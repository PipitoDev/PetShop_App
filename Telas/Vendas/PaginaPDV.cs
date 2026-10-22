using PetShop_App.Dados;
using PetShop_App.Modelos;
using PetShop_App.Componentes;

namespace PetShop_App.Telas.Vendas
{

public partial class PaginaPDV : UserControl
{
    private List<Produto> produtos = [];
    private readonly List<(Produto Produto, int Quantidade)> carrinho = [];
    private bool caixaAberto;

    public event Action<bool>? StatusCaixaAlterado;

    public PaginaPDV()
    {
        InitializeComponent(); if (PetShop_App.Componentes.AmbienteDesign.EstaAtivo(this)) return;
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

    private async Task CarregarAsync()
    {
        if (PetShop_App.Componentes.AmbienteDesign.EstaAtivo(this)) return;
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

    private async Task AbrirCaixaAsync()
    {
        using var formulario = new FormularioCaixa(true);
        if (formulario.ShowDialog(FindForm()) != DialogResult.OK) return;
        await new RepositorioPetShop().AbrirCaixaAsync(formulario.Saldo);
        await AtualizarEstadoCaixaAsync();
    }

    private async Task FecharCaixaAsync()
    {
        using var formulario = new FormularioCaixa(false);
        if (formulario.ShowDialog(FindForm()) != DialogResult.OK) return;
        await new RepositorioPetShop().FecharCaixaAsync(formulario.Saldo);
        LimparVenda();
        await AtualizarEstadoCaixaAsync();
    }

    private void FiltrarProdutos()
    {
        var busca = txtBusca.Text.Trim();
        gradeProdutos.DataSource = produtos.Where(x => x.Nome.Contains(busca, StringComparison.OrdinalIgnoreCase) || x.Codigo.Contains(busca, StringComparison.OrdinalIgnoreCase))
            .Select(x => new { x.Codigo, x.Nome, Preço = x.Preco.ToString("C"), x.Estoque }).ToList();
    }

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

    private void Remover()
    {
        if (gradeCarrinho.CurrentRow?.Cells["Codigo"].Value?.ToString() is not string codigo) return;
        carrinho.RemoveAll(x => x.Produto.Codigo == codigo);
        AtualizarCarrinho();
    }

    private void LimparVenda()
    {
        carrinho.Clear();
        numDesconto.Value = 0;
        if (cmbCliente.Items.Count > 0) cmbCliente.SelectedIndex = 0;
        AtualizarCarrinho();
    }

    private void AtualizarCarrinho()
    {
        gradeCarrinho.DataSource = carrinho.Select(x => new { x.Produto.Codigo, x.Produto.Nome, x.Quantidade, Unitário = x.Produto.Preco.ToString("C"), Subtotal = (x.Produto.Preco * x.Quantidade).ToString("C") }).ToList();
        var subtotal = carrinho.Sum(x => x.Produto.Preco * x.Quantidade);
        var total = subtotal - (subtotal * numDesconto.Value / 100);
        lblSubtotal.Text = $"Subtotal: {subtotal:C}";
        lblTotal.Text = $"Total: {total:C}";
        lblItens.Text = $"{carrinho.Sum(x => x.Quantidade)} item(ns)";
    }

    private async Task FinalizarAsync()
    {
        if (!caixaAberto) { MessageBox.Show("Abra o caixa antes de finalizar uma venda.", "Caixa fechado", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
        if (carrinho.Count == 0) { MessageBox.Show("Adicione produtos ao carrinho."); return; }
        if (cmbPagamento.SelectedIndex < 0) { MessageBox.Show("Selecione a forma de pagamento."); return; }
        var clienteId = cmbCliente.SelectedValue is int id && id > 0 ? id : (int?)null;
        await new RepositorioPetShop().RegistrarVendaAsync(clienteId, carrinho, cmbPagamento.Text, numDesconto.Value);
        MessageBox.Show($"Venda finalizada!\n{lblTotal.Text}\nPagamento: {cmbPagamento.Text}", "PDV", MessageBoxButtons.OK, MessageBoxIcon.Information);
        LimparVenda();
        await CarregarAsync();
    }
}

}
