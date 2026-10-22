using PetShop_App.Componentes;
using PetShop_App.Dados;
using PetShop_App.Telas.Agendamentos;
using PetShop_App.Telas.Clientes;
using PetShop_App.Telas.Pets;
using PetShop_App.Telas.Servicos;
using PetShop_App.Telas.Vendas;

namespace PetShop_App.Telas.Principal;

/// <summary>
/// Janela principal autenticada. Mantém menu e cabeçalho fixos enquanto troca
/// UserControls dentro de pnlConteudo conforme os eventos do MenuLateral.
/// </summary>
public partial class Principal : Form
{
    private readonly RepositorioPetShop repositorio = new();

    public Principal() : this("Funcionário", "Atendente")
    {
    }

    public Principal(string nomeFuncionario, string cargo)
    {
        InitializeComponent();
        if (AmbienteDesign.EstaAtivo(this)) return;

        ConfigurarCabecalho(nomeFuncionario, cargo);
        ConectarMenuLateral();
        Shown += Principal_Shown;
    }

    /// <summary>Apresenta identidade da sessão no cabeçalho e no menu.</summary>
    private void ConfigurarCabecalho(string nomeFuncionario, string cargo)
    {
        menuLateral.ConfigurarUsuario(nomeFuncionario, cargo);
        lblSaudacao.Text = $"Bom dia, {nomeFuncionario}";
        lblData.Text = DateTime.Today.ToString("dddd, dd/MM/yyyy");
    }

    /// <summary>Associa os eventos publicados pelo menu às páginas correspondentes.</summary>
    private void ConectarMenuLateral()
    {
        // Cada evento substitui somente o conteúdo central; cabeçalho e menu permanecem.
        menuLateral.PainelSelecionado += (_, _) => AbrirPagina(new PainelDiario());
        menuLateral.ClientesSelecionado += (_, _) => AbrirPagina(new PaginaClientes());
        menuLateral.PetsSelecionado += (_, _) => AbrirPagina(new PaginaPets());
        menuLateral.ServicosSelecionado += (_, _) => AbrirPagina(new PaginaServicos());
        menuLateral.AgendamentosSelecionado += (_, _) => AbrirPagina(new PaginaAtendimentos("Agendamentos"));
        menuLateral.AtendimentosSelecionado += (_, _) => AbrirPagina(new PaginaAtendimentos("Atendimentos"));
        menuLateral.PdvSelecionado += (_, _) => AbrirPdv();
        menuLateral.PedidosSelecionado += (_, _) => AbrirPagina(new PaginaPedidos());
        menuLateral.EstoqueSelecionado += (_, _) => AbrirPagina(new PaginaEstoque());
    }

    /// <summary>Abre o painel inicial e sincroniza o indicador de caixa.</summary>
    private async void Principal_Shown(object? sender, EventArgs e)
    {
        menuLateral.AbrirPainel();
        try
        {
            await AtualizarStatusCaixaAsync();
        }
        catch (Exception erro)
        {
            MessageBox.Show(this, $"Não foi possível consultar o caixa.\n\n{erro.Message}", "Caixa");
        }
    }

    /// <summary>Abre o PDV e conecta suas mudanças de caixa ao menu lateral.</summary>
    private void AbrirPdv()
    {
        var pagina = new PaginaPDV();
        pagina.StatusCaixaAlterado += menuLateral.AtualizarStatusCaixa;
        AbrirPagina(pagina);
    }

    /// <summary>Consulta o banco e reflete o estado do caixa no menu.</summary>
    private async Task AtualizarStatusCaixaAsync()
    {
        var caixaAberto = await repositorio.CaixaEstaAbertoAsync();
        menuLateral.AtualizarStatusCaixa(caixaAberto);
    }

    /// <summary>Descarta a página anterior e ocupa o painel central com a nova.</summary>
    private void AbrirPagina(Control pagina)
    {
        // Dispose libera recursos e handlers da página substituída.
        while (pnlConteudo.Controls.Count > 0)
        {
            var controle = pnlConteudo.Controls[0];
            pnlConteudo.Controls.RemoveAt(0);
            controle.Dispose();
        }

        pagina.Dock = DockStyle.Fill;
        pnlConteudo.Controls.Add(pagina);
    }
}
