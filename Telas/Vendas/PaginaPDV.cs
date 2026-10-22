using PetShop_App.Dados;
using PetShop_App.Modelos;
using PetShop_App.Componentes;

namespace PetShop_App.Telas.Vendas
{

/// <summary>
/// Coordena o ponto de venda: consulta o catálogo, mantém o carrinho da venda
/// atual e solicita ao repositório a gravação transacional do pedido e do estoque.
/// </summary>
public partial class PaginaPDV : UserControl
{
    // Cópia do catálogo usada para filtrar a grade sem consultar o banco a cada tecla.
    private List<Produto> produtos = [];
    // Estado temporário da venda. Ele só é persistido quando FinalizarAsync é concluído.
    private readonly List<(Produto Produto, int Quantidade)> carrinho = [];
    private bool caixaAberto;

    /// <summary>
    /// Notifica a janela principal para que o indicador global de caixa acompanhe o PDV.
    /// </summary>
    public event Action<bool>? StatusCaixaAlterado;

    /// <summary>Inicializa os controles e conecta os eventos às ações da tela.</summary>
    public PaginaPDV()
    {
        InitializeComponent();
        if (AmbienteDesign.EstaAtivo(this)) return;

        // A tela mantém o carrinho em memória; o repositório persiste somente na finalização.
        Load += async (_, _) => await CarregarAsync();
        txtBusca.TextChanged += (_, _) => FiltrarProdutos();
        btnAdicionar.Click += (_, _) => Adicionar();
        btnRemover.Click += (_, _) => Remover();
        btnLimpar.Click += (_, _) => LimparVenda();
        numDesconto.ValueChanged += (_, _) => AtualizarCarrinho();
        btnFinalizar.Click += async (_, _) => await FinalizarAsync();
        btnAbrirCaixa.Click += async (_, _) => await AbrirCaixaAsync();
        btnFecharCaixa.Click += async (_, _) => await FecharCaixaAsync();
    }

    /// <summary>Carrega catálogo, clientes, carrinho e situação atual do caixa.</summary>
    private async Task CarregarAsync()
    {
        if (AmbienteDesign.EstaAtivo(this)) return;
        var repo = new RepositorioPetShop();
        produtos = await repo.ListarProdutosAsync();
        var clientes = await repo.ListarClientesAsync();
        clientes.Insert(0, new Cliente { Id = 0, Nome = "Consumidor final" });
        cmbCliente.DataSource = clientes;
        cmbCliente.DisplayMember = "Nome";
        cmbCliente.ValueMember = "Id";
        FiltrarProdutos();
        AtualizarCarrinho();
        await AtualizarEstadoCaixaAsync();
    }

    /// <summary>
    /// Sincroniza botões e indicador visual com o turno de caixa persistido no banco.
    /// </summary>
    private async Task AtualizarEstadoCaixaAsync()
    {
        caixaAberto = await new RepositorioPetShop().CaixaEstaAbertoAsync();
        lblStatusCaixa.Text = caixaAberto ? "● Caixa aberto" : "● Caixa fechado";
        lblStatusCaixa.ForeColor = caixaAberto ? Color.FromArgb(22, 163, 74) : Color.FromArgb(220, 38, 38);
        btnAbrirCaixa.Enabled = !caixaAberto;
        btnFecharCaixa.Enabled = caixaAberto;
        btnFinalizar.Enabled = caixaAberto;
        StatusCaixaAlterado?.Invoke(caixaAberto);
    }

    /// <summary>Solicita o saldo inicial e abre um novo turno de caixa.</summary>
    private async Task AbrirCaixaAsync()
    {
        using var formulario = new FormularioCaixa(true);
        if (formulario.ShowDialog(FindForm()) != DialogResult.OK) return;
        await new RepositorioPetShop().AbrirCaixaAsync(formulario.Saldo);
        await AtualizarEstadoCaixaAsync();
    }

    /// <summary>Solicita o saldo final, fecha o turno ativo e descarta a venda corrente.</summary>
    private async Task FecharCaixaAsync()
    {
        using var formulario = new FormularioCaixa(false);
        if (formulario.ShowDialog(FindForm()) != DialogResult.OK) return;
        await new RepositorioPetShop().FecharCaixaAsync(formulario.Saldo);
        LimparVenda();
        await AtualizarEstadoCaixaAsync();
    }

    /// <summary>Projeta no grid apenas os produtos compatíveis com nome ou código.</summary>
    private void FiltrarProdutos()
    {
        var busca = txtBusca.Text.Trim();
        gradeProdutos.DataSource = produtos.Where(x => x.Nome.Contains(busca, StringComparison.OrdinalIgnoreCase) || x.Codigo.Contains(busca, StringComparison.OrdinalIgnoreCase))
            .Select(x => new { x.Codigo, x.Nome, Preço = x.Preco.ToString("C"), x.Estoque }).ToList();
    }

    /// <summary>Adiciona a quantidade escolhida respeitando o estoque disponível.</summary>
    private void Adicionar()
    {
        if (gradeProdutos.CurrentRow is null) return;
        var codigo = gradeProdutos.CurrentRow.Cells["Codigo"].Value?.ToString();
        var produto = produtos.First(x => x.Codigo == codigo);
        var quantidade = (int)numQuantidade.Value;
        var indice = carrinho.FindIndex(x => x.Produto.Id == produto.Id);
        var atual = indice >= 0 ? carrinho[indice].Quantidade : 0;
        if (atual + quantidade > produto.Estoque)
        {
            MessageBox.Show($"Disponível em estoque: {produto.Estoque}.", "Estoque insuficiente");
            return;
        }
        if (indice >= 0) carrinho[indice] = (produto, atual + quantidade);
        else carrinho.Add((produto, quantidade));
        numQuantidade.Value = 1;
        AtualizarCarrinho();
    }

    /// <summary>Remove integralmente do carrinho o produto selecionado.</summary>
    private void Remover()
    {
        if (gradeCarrinho.CurrentRow?.Cells["Codigo"].Value?.ToString() is not string codigo) return;
        carrinho.RemoveAll(x => x.Produto.Codigo == codigo);
        AtualizarCarrinho();
    }

    /// <summary>Restaura os campos e o carrinho para o estado inicial de uma venda.</summary>
    private void LimparVenda()
    {
        carrinho.Clear();
        numDesconto.Value = 0;
        if (cmbCliente.Items.Count > 0) cmbCliente.SelectedIndex = 0;
        AtualizarCarrinho();
    }

    /// <summary>Recalcula a grade, quantidades, desconto, subtotal e total exibidos.</summary>
    private void AtualizarCarrinho()
    {
        gradeCarrinho.DataSource = carrinho.Select(x => new { x.Produto.Codigo, x.Produto.Nome, x.Quantidade, Unitário = x.Produto.Preco.ToString("C"), Subtotal = (x.Produto.Preco * x.Quantidade).ToString("C") }).ToList();
        var subtotal = carrinho.Sum(x => x.Produto.Preco * x.Quantidade);
        var total = subtotal - (subtotal * numDesconto.Value / 100);
        lblSubtotal.Text = $"Subtotal: {subtotal:C}";
        lblTotal.Text = $"Total: {total:C}";
        lblItens.Text = $"{carrinho.Sum(x => x.Quantidade)} item(ns)";
    }

    /// <summary>
    /// Valida os pré-requisitos do PDV e delega ao repositório a gravação atômica da venda.
    /// </summary>
    private async Task FinalizarAsync()
    {
        if (!caixaAberto)
        {
            MessageBox.Show("Abra o caixa antes de finalizar uma venda.", "Caixa fechado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        if (carrinho.Count == 0)
        {
            MessageBox.Show("Adicione produtos ao carrinho.");
            return;
        }
        if (cmbPagamento.SelectedIndex < 0)
        {
            MessageBox.Show("Selecione a forma de pagamento.");
            return;
        }
        var clienteId = cmbCliente.SelectedValue is int id && id > 0 ? id : (int?)null;
        await new RepositorioPetShop().RegistrarVendaAsync(clienteId, carrinho, cmbPagamento.Text, numDesconto.Value);
        MessageBox.Show($"Venda finalizada!\n{lblTotal.Text}\nPagamento: {cmbPagamento.Text}", "PDV", MessageBoxButtons.OK, MessageBoxIcon.Information);
        LimparVenda();
        await CarregarAsync();
    }
}

}
