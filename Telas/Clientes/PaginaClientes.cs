using MySqlConnector;
using PetShop_App.Componentes;
using PetShop_App.Dados;
using PetShop_App.Modelos;

namespace PetShop_App.Telas.Clientes
{

/// <summary>
/// Tela de consulta e manutenção de clientes. Conecta a grade, a pesquisa e os
/// formulários de cadastro às operações correspondentes do repositório.
/// </summary>
public partial class PaginaClientes : UserControl
{
    // Uma única instância atende todas as ações enquanto esta página estiver aberta.
    private readonly RepositorioPetShop repositorio = new();
    // Impede que uma pesquisa antiga e mais lenta substitua o resultado mais recente.
    private int versaoPesquisa;
    // Bloqueia cliques repetidos enquanto uma operação de escrita está em andamento.
    private bool operacaoEmAndamento;

    public PaginaClientes()
    {
        InitializeComponent();
        if (AmbienteDesign.EstaAtivo(this)) return;

        gradeClientes.MultiSelect = false;
        Load += async (_, _) => await CarregarAsync();
        txtPesquisa.TextChanged += async (_, _) => await CarregarAsync();
        btnNovo.Click += async (_, _) => await ExecutarAcaoAsync(() => SalvarAsync(null));
        btnEditarRegistro.Click += async (_, _) => await ExecutarAcaoAsync(EditarAsync);
        btnExcluirRegistro.Click += async (_, _) => await ExecutarAcaoAsync(ExcluirAsync);
    }

    /// <summary>Consulta clientes e vincula o resultado diretamente à grade.</summary>
    private async Task CarregarAsync()
    {
        if (AmbienteDesign.EstaAtivo(this)) return;
        var versao = ++versaoPesquisa;
        try
        {
            var clientes = await repositorio.ListarClientesAsync(txtPesquisa.Text);
            // Uma busca antiga não deve substituir a pesquisa mais recente.
            if (IsDisposed || versao != versaoPesquisa) return;
            gradeClientes.DataSource = clientes;
            if (gradeClientes.Columns["Id"] is { } coluna) coluna.Visible = false;
        }
        catch (Exception erro)
        {
            if (!IsDisposed && versao == versaoPesquisa)
                MessageBox.Show(this, "Não foi possível carregar os clientes.\n\n" + erro.Message, "Clientes");
        }
    }

    /// <summary>Executa ações CRUD com bloqueio visual e tratamento central de erros.</summary>
    private async Task ExecutarAcaoAsync(Func<Task> acao)
    {
        if (operacaoEmAndamento) return;
        operacaoEmAndamento = true;
        pnlCabecalho.Enabled = false;
        try
        {
            await acao();
        }
        catch (MySqlException erro) when (erro.Number == 1451)
        {
            MessageBox.Show(this, "Este cliente possui pets ou pedidos vinculados e não pode ser removido.", "Cliente vinculado");
        }
        catch (Exception erro)
        {
            MessageBox.Show(this, "Não foi possível concluir a operação.\n\n" + erro.Message, "Clientes");
        }
        finally
        {
            operacaoEmAndamento = false;
            if (!IsDisposed) pnlCabecalho.Enabled = true;
        }
    }

    /// <summary>Retorna o modelo associado à linha atual da grade.</summary>
    private Cliente? Selecionado()
    {
        var cliente = gradeClientes.CurrentRow?.DataBoundItem as Cliente;
        if (cliente is null)
            MessageBox.Show(this, "Selecione um cliente na lista.", "Clientes");
        return cliente;
    }

    /// <summary>Abre o mesmo formulário em modo de edição.</summary>
    private async Task EditarAsync()
    {
        if (Selecionado() is { } cliente) await SalvarAsync(cliente);
    }

    /// <summary>Abre o formulário e decide entre INSERT e UPDATE pela existência do modelo.</summary>
    private async Task SalvarAsync(Cliente? existente)
    {
        using var formulario = new FormularioCliente(existente);
        if (formulario.ShowDialog(this) != DialogResult.OK) return;
        var cliente = formulario.Cliente;
        if (existente is null) await repositorio.SalvarClienteAsync(cliente);
        else await repositorio.AtualizarClienteAsync(cliente);
        await CarregarAsync();
    }

    /// <summary>Confirma e remove o cliente selecionado.</summary>
    private async Task ExcluirAsync()
    {
        var cliente = Selecionado();
        if (cliente is null || !BotoesCrud.Confirmar($"o cliente {cliente.Nome}")) return;
        await repositorio.ExcluirClienteAsync(cliente.Id);
        await CarregarAsync();
    }
}

}
