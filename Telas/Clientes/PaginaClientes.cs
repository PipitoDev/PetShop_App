using MySqlConnector;
using PetShop_App.Componentes;
using PetShop_App.Dados;
using PetShop_App.Modelos;

namespace PetShop_App.Telas.Clientes
{

public partial class PaginaClientes : UserControl
{
    private readonly RepositorioPetShop repositorio = new();
    private int versaoPesquisa;
    private bool operacaoEmAndamento;

    public PaginaClientes()
    {
        InitializeComponent(); if (PetShop_App.Componentes.AmbienteDesign.EstaAtivo(this)) return;
        gradeClientes.MultiSelect = false;
        Load += async (_, _) => await CarregarAsync();
        txtPesquisa.TextChanged += async (_, _) => await CarregarAsync();
        btnNovo.Click += async (_, _) => await ExecutarAcaoAsync(() => SalvarAsync(null));
        btnEditarRegistro.Click += async (_, _) => await ExecutarAcaoAsync(EditarAsync); btnExcluirRegistro.Click += async (_, _) => await ExecutarAcaoAsync(ExcluirAsync);
    }

    private async Task CarregarAsync()
    {
        if (PetShop_App.Componentes.AmbienteDesign.EstaAtivo(this)) return;
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

    private async Task ExecutarAcaoAsync(Func<Task> acao)
    {
        if (operacaoEmAndamento) return;
        operacaoEmAndamento = true;
        pnlCabecalho.Enabled = false;
        try { await acao(); }
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

    private Cliente? Selecionado()
    {
        var cliente = gradeClientes.CurrentRow?.DataBoundItem as Cliente;
        if (cliente is null) MessageBox.Show(this, "Selecione um cliente na lista.", "Clientes");
        return cliente;
    }

    private async Task EditarAsync()
    {
        if (Selecionado() is { } cliente) await SalvarAsync(cliente);
    }

    private async Task SalvarAsync(Cliente? existente)
    {
        using var formulario = new FormularioCliente(existente);
        if (formulario.ShowDialog(this) != DialogResult.OK) return;
        var cliente = formulario.Cliente;
        if (existente is null) await repositorio.SalvarClienteAsync(cliente);
        else await repositorio.AtualizarClienteAsync(cliente);
        await CarregarAsync();
    }

    private async Task ExcluirAsync()
    {
        var cliente = Selecionado();
        if (cliente is null || !BotoesCrud.Confirmar($"o cliente {cliente.Nome}")) return;
        await repositorio.ExcluirClienteAsync(cliente.Id);
        await CarregarAsync();
    }
}

}
