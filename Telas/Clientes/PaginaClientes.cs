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
        using var formulario = new FormularioCadastro(existente is null ? "Cadastrar cliente" : "Editar cliente", 480);
        var nome = formulario.Texto("Nome completo *");
        var cpf = formulario.Texto("CPF");
        var telefone = formulario.Texto("Telefone");
        var email = formulario.Texto("E-mail");
        nome.MaxLength = 150;
        cpf.MaxLength = 14;
        telefone.MaxLength = 20;
        email.MaxLength = 150;
        nome.Text = existente?.Nome ?? "";
        cpf.Text = existente?.Cpf ?? "";
        telefone.Text = existente?.Telefone ?? "";
        email.Text = existente?.Email ?? "";
        // Valida antes de fechar para preservar os campos preenchidos.
        formulario.FormClosing += (_, evento) =>
        {
            if (formulario.DialogResult != DialogResult.OK || !string.IsNullOrWhiteSpace(nome.Text)) return;
            evento.Cancel = true;
            MessageBox.Show(formulario, "Informe o nome do cliente.", "Campo obrigatório");
            nome.Focus();
        };
        if (formulario.ShowDialog(this) != DialogResult.OK) return;
        var cliente = new Cliente
        {
            Id = existente?.Id ?? 0,
            Nome = nome.Text.Trim(),
            Cpf = cpf.Text.Trim(),
            Telefone = telefone.Text.Trim(),
            Email = email.Text.Trim()
        };
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
