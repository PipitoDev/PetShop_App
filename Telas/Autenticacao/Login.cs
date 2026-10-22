using PetShop_App.Componentes;
using PetShop_App.Dados;
using PetShop_App.Telas.Principal;

namespace PetShop_App;

/// <summary>
/// Primeira janela da aplicação. Valida os campos, prepara o banco, autentica
/// o funcionário e transfere nome/perfil para a janela Principal.
/// </summary>
public partial class Login : Form
{
    public Login()
    {
        InitializeComponent();

        WindowState = FormWindowState.Maximized;

        if (AmbienteDesign.EstaAtivo(this)) return;

        btnEntrar.Click += btnEntrar_Click;
        Shown += (_, _) => AjustarResponsividade();
        pnlLaranja.Resize += (_, _) => AjustarResponsividade();
        pnlCardLogin.Resize += (_, _) => Tema.Arredondar(pnlCardLogin, 18);
        Tema.Arredondar(pnlCardLogin, 18);
    }

    /// <summary>Adapta a frase lateral ao espaço disponível sem perder legibilidade.</summary>
    private void AjustarResponsividade()
    {
        var largura = pnlLaranja.ClientSize.Width;
        var altura = pnlLaranja.ClientSize.Height;
        if (largura <= 0 || altura <= 0) return;

        // Mantém a frase proporcional ao painel sem ultrapassar limites legíveis.
        var escala = Math.Min(largura / 400f, altura / 600f);
        var tamanhoFonte = Math.Clamp(12f * escala, 10f, 22f);
        lblFraseEfeito.Font = new Font("Segoe UI", tamanhoFonte, FontStyle.Bold);
    }

    /// <summary>Fluxo acionado pelo botão Entrar definido no Designer.</summary>
    private async void btnEntrar_Click(object? sender, EventArgs e)
    {
        var usuario = txtUsuario.Text.Trim();
        var senha = txtSenha.Text;

        if (!ValidarCredenciaisInformadas(usuario, senha)) return;

        DefinirEstadoDeCarregamento(true);
        try
        {
            // Garante a estrutura do banco antes de consultar o funcionário.
            await InicializadorBanco.InicializarAsync();
            var autenticacao = await new RepositorioPetShop().AutenticarAsync(usuario, senha);
            if (!autenticacao.Valido)
            {
                ExibirAviso("Credenciais inválidas", "Confira o usuário e a senha informados.");
                return;
            }

            Hide();
            using var principal = new Principal(autenticacao.Nome, autenticacao.Perfil);
            principal.ShowDialog();
            Close();
        }
        catch (Exception erro)
        {
            ExibirAviso(
                "Não foi possível conectar ao MySQL",
                "Confira as variáveis PETSHOP_DB_SERVIDOR, PETSHOP_DB_PORTA, " +
                "PETSHOP_DB_NOME, PETSHOP_DB_USUARIO e PETSHOP_DB_SENHA.\n\n" + erro.Message);
        }
        finally
        {
            if (!IsDisposed) DefinirEstadoDeCarregamento(false);
        }
    }

    /// <summary>Valida somente presença; a validade da credencial pertence ao banco.</summary>
    private bool ValidarCredenciaisInformadas(string usuario, string senha)
    {
        if (string.IsNullOrWhiteSpace(usuario))
        {
            ExibirAviso("Usuário não informado", "Digite seu usuário ou e-mail antes de continuar.");
            txtUsuario.Focus();
            return false;
        }

        if (string.IsNullOrWhiteSpace(senha))
        {
            ExibirAviso("Senha não informada", "Digite sua senha antes de continuar.");
            txtSenha.Focus();
            return false;
        }

        return true;
    }

    /// <summary>Evita cliques duplicados e informa visualmente a autenticação em curso.</summary>
    private void DefinirEstadoDeCarregamento(bool carregando)
    {
        btnEntrar.Enabled = !carregando;
        btnEntrar.Text = carregando ? "Entrando..." : "ENTRAR";
    }

    /// <summary>Abre a janela de aviso padronizada como filha do login.</summary>
    private void ExibirAviso(string titulo, string mensagem)
    {
        using var aviso = new DialogoAviso(titulo, mensagem);
        aviso.ShowDialog(this);
    }
}
