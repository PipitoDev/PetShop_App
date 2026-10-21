using PetShop_App.Telas.Agendamentos;
using PetShop_App.Telas.Clientes;
using PetShop_App.Telas.Pets;
using PetShop_App.Telas.Servicos;
using PetShop_App.Telas.Vendas;
using PetShop_App.Dados;

namespace PetShop_App.Telas.Principal;

public partial class Principal : Form
{
    public Principal() : this("Funcionário", "Atendente") { }

    public Principal(string nomeFuncionario, string cargo)
    {
        InitializeComponent();
        menuLateral.ConfigurarUsuario(nomeFuncionario, cargo);
        lblSaudacao.Text = $"Bom dia, {nomeFuncionario}";
        lblData.Text = DateTime.Today.ToString("dddd, dd/MM/yyyy");
        menuLateral.PainelSelecionado += (_, _) => AbrirPagina(new PainelDiario());
        menuLateral.ClientesSelecionado += (_, _) => AbrirPagina(new PaginaClientes());
        menuLateral.PetsSelecionado += (_, _) => AbrirPagina(new PaginaPets());
        menuLateral.ServicosSelecionado += (_, _) => AbrirPagina(new PaginaServicos());
        menuLateral.AgendamentosSelecionado += (_, _) => AbrirPagina(new PaginaAtendimentos("Agendamentos"));
        menuLateral.AtendimentosSelecionado += (_, _) => AbrirPagina(new PaginaAtendimentos("Atendimentos"));
        menuLateral.PdvSelecionado += (_, _) => AbrirPdv();
        menuLateral.PedidosSelecionado += (_, _) => AbrirPagina(new PaginaPedidos());
        menuLateral.EstoqueSelecionado += (_, _) => AbrirPagina(new PaginaEstoque());
        Shown += async (_, _) =>
        {
            menuLateral.AbrirPainel();
            await AtualizarStatusCaixaAsync();
        };
    }

    private void AbrirPdv()
    {
        var pagina = new PaginaPDV();
        pagina.StatusCaixaAlterado += aberto => menuLateral.AtualizarStatusCaixa(aberto);
        AbrirPagina(pagina);
    }

    private async Task AtualizarStatusCaixaAsync()
    {
        menuLateral.AtualizarStatusCaixa(await new RepositorioPetShop().CaixaEstaAbertoAsync());
    }

    private void AbrirPagina(Control pagina)
    {
        pnlConteudo.Controls.Clear();
        pagina.Dock = DockStyle.Fill;
        pnlConteudo.Controls.Add(pagina);
    }
}
