using FontAwesome.Sharp;

namespace PetShop_App.Componentes;

/// <summary>
/// Menu de navegação da janela principal. Ele não cria páginas diretamente;
/// publica eventos que a classe Principal converte em trocas de conteúdo.
/// </summary>
public partial class MenuLateral : UserControl
{
    public MenuLateral()
    {
        InitializeComponent();
        // Cada botão atualiza o destaque visual e publica o evento correspondente.
        btnPainel.Click += (_, _) => Selecionar(btnPainel, PainelSelecionado);
        btnClientes.Click += (_, _) => Selecionar(btnClientes, ClientesSelecionado);
        btnPets.Click += (_, _) => Selecionar(btnPets, PetsSelecionado);
        btnServicos.Click += (_, _) => Selecionar(btnServicos, ServicosSelecionado);
        btnAgendamentos.Click += (_, _) => Selecionar(btnAgendamentos, AgendamentosSelecionado);
        btnAtendimentos.Click += (_, _) => Selecionar(btnAtendimentos, AtendimentosSelecionado);
        btnPDV.Click += (_, _) => Selecionar(btnPDV, PdvSelecionado);
        btnPedidos.Click += (_, _) => Selecionar(btnPedidos, PedidosSelecionado);
        btnEstoque.Click += (_, _) => Selecionar(btnEstoque, EstoqueSelecionado);
    }

    // Principal assina estes eventos para decidir qual UserControl deve ser aberto.
    public event EventHandler? PainelSelecionado;
    public event EventHandler? ClientesSelecionado;
    public event EventHandler? PetsSelecionado;
    public event EventHandler? ServicosSelecionado;
    public event EventHandler? AgendamentosSelecionado;
    public event EventHandler? AtendimentosSelecionado;
    public event EventHandler? PdvSelecionado;
    public event EventHandler? PedidosSelecionado;
    public event EventHandler? EstoqueSelecionado;

    /// <summary>Exibe no rodapé do menu o usuário autenticado e seu perfil.</summary>
    public void ConfigurarUsuario(string nome, string cargo = "Atendente")
    {
        lblNomeUsuario.Text = nome;
        lblCargo.Text = cargo;
    }

    /// <summary>Sincroniza texto, cor e ícone com o estado real do caixa.</summary>
    public void AtualizarStatusCaixa(bool aberto)
    {
        var cor = aberto ? Color.FromArgb(22, 163, 74) : Color.FromArgb(220, 38, 38);
        iconPictureBox1.IconChar = aberto ? IconChar.CheckCircle : IconChar.TimesCircle;
        iconPictureBox1.IconColor = cor;
        iconPictureBox1.ForeColor = cor;
        lblCaixa.Text = aberto ? "Caixa aberto" : "Caixa fechado";
        lblCaixa.ForeColor = cor;
        lblStatusCaixa.Visible = false;
    }

    /// <summary>Simula o clique inicial para abrir o painel após o login.</summary>
    public void AbrirPainel() => btnPainel.PerformClick();

    /// <summary>Remove o destaque anterior, destaca o item atual e dispara sua ação.</summary>
    private void Selecionar(IconButton selecionado, EventHandler? evento)
    {
        foreach (var botao in flpBotoesMenu.Controls.OfType<IconButton>())
        {
            botao.BackColor = Color.White;
            botao.ForeColor = Color.FromArgb(100, 116, 139);
            botao.IconColor = Color.FromArgb(100, 116, 139);
        }
        selecionado.BackColor = Color.FromArgb(255, 240, 226);
        selecionado.ForeColor = Color.FromArgb(255, 128, 0);
        selecionado.IconColor = Color.FromArgb(255, 128, 0);
        evento?.Invoke(this, EventArgs.Empty);
    }

}
