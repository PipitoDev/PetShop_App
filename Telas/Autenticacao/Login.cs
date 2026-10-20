using System.Drawing.Drawing2D;



namespace PetShop_App
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            // Conecta o botão ao evento de validação do formulário.
            btnEntrar.Click += btnEntrar_Click;

            this.Shown += (s, e) =>
                AjustarResponsividade();

            pnlLaranja.Resize += (s, e) =>
                AjustarResponsividade();

            pnlCardLogin.Resize += (s, e) =>
            {
                ArredondarPainel(pnlCardLogin, 18);
            };

            ArredondarPainel(pnlCardLogin, 18);

           
        }


        private void ArredondarPainel(Panel painel, int raio)
        {
            if (painel.Width <= 0 || painel.Height <= 0)
                return;

            using GraphicsPath caminho = new GraphicsPath();

            int diametro = raio * 2;
            Rectangle area = new Rectangle(
                0, 0, painel.Width, painel.Height
            );

            caminho.AddArc(area.Left, area.Top,
                diametro, diametro, 180, 90);

            caminho.AddArc(area.Right - diametro, area.Top,
                diametro, diametro, 270, 90);

            caminho.AddArc(area.Right - diametro,
                area.Bottom - diametro,
                diametro, diametro, 0, 90);

            caminho.AddArc(area.Left,
                area.Bottom - diametro,
                diametro, diametro, 90, 90);

            caminho.CloseFigure();

            var regiaoAnterior = painel.Region;
            painel.Region = new Region(caminho);
            regiaoAnterior?.Dispose();
        }



        private void AjustarResponsividade()
        {
            int largura = pnlLaranja.ClientSize.Width;
            int altura = pnlLaranja.ClientSize.Height;

            if (largura <= 0 || altura <= 0)
                return;

            // Escala relativa à largura inicial de referência.
            float escala = Math.Min(
                largura / 400f,
                altura / 600f
            );

            float tamanhoFrase = Math.Clamp(
                12f * escala,
                10f,
                22f
            );

            lblFraseEfeito.Font = new Font(
                "Segoe UI",
                tamanhoFrase,
                FontStyle.Bold
            );
        }



        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text;

            if (string.IsNullOrWhiteSpace(usuario) && string.IsNullOrWhiteSpace(senha))
            {
                using var aviso = new DialogoAviso(
                    "Preencha os campos",
                    "Informe seu usuário ou e-mail e sua senha para continuar.");
                aviso.ShowDialog(this);
                txtUsuario.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(usuario))
            {
                using var aviso = new DialogoAviso(
                    "Nome não informado",
                    "Digite seu usuário ou e-mail antes de continuar.");
                aviso.ShowDialog(this);
                txtUsuario.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(senha))
            {
                using var aviso = new DialogoAviso(
                    "Senha não informada",
                    "Digite sua senha antes de continuar.");
                aviso.ShowDialog(this);
                txtSenha.Focus();
                return;
            }

            // A validação de credenciais precisa ser conectada ao banco/sistema de usuários.
            using var avisoLogin = new DialogoAviso(
                "Não foi possível entrar",
                "Os campos foram preenchidos, mas a autenticação ainda não está conectada ao sistema.");
            avisoLogin.ShowDialog(this);
        }

        private void LimparCampos()
        {
            txtUsuario.Clear();
            txtSenha.Clear();
            txtUsuario.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void lblTextoSuperiorEsquerdo_Click(object sender, EventArgs e)
        {

        }

        private void lblTextoMedioEsquerdo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void tlpCaixaDireita_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void tblCaixaEmailSenha_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click_1(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pnlUsuario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

        }
    }
}
