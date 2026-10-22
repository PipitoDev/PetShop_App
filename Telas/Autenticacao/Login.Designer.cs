namespace PetShop_App
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel plLadoDireito;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            plLadoDireito = new Panel();
            tlpPrincipal = new TableLayoutPanel();
            pnlLaranja = new Panel();
            tlpLadoEsquerdo = new TableLayoutPanel();
            picLogoLogin = new PictureBox();
            lblFraseEfeito = new Label();
            pictureBox1 = new PictureBox();
            tlpCentralizar = new TableLayoutPanel();
            pnlCardLogin = new Panel();
            tlpLogin = new TableLayoutPanel();
            lblBoasVindas = new Label();
            lblTitulo = new Label();
            lblDesc = new Label();
            lblUsuario = new Label();
            pnlUsuario = new PetShop_App.Componentes.PainelArredondado();
            txtUsuario = new TextBox();
            lblSenha = new Label();
            pnlSenha = new PetShop_App.Componentes.PainelArredondado();
            txtSenha = new TextBox();
            chkLembrarSenha = new CheckBox();
            btnEntrar = new Button();
            plLadoDireito.SuspendLayout();
            tlpPrincipal.SuspendLayout();
            pnlLaranja.SuspendLayout();
            tlpLadoEsquerdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tlpCentralizar.SuspendLayout();
            pnlCardLogin.SuspendLayout();
            tlpLogin.SuspendLayout();
            pnlUsuario.SuspendLayout();
            pnlSenha.SuspendLayout();
            SuspendLayout();
            // 
            // plLadoDireito
            // 
            plLadoDireito.Controls.Add(tlpPrincipal);
            plLadoDireito.Dock = DockStyle.Fill;
            plLadoDireito.Location = new Point(0, 0);
            plLadoDireito.Margin = new Padding(4, 3, 4, 3);
            plLadoDireito.Name = "plLadoDireito";
            plLadoDireito.Size = new Size(884, 561);
            plLadoDireito.TabIndex = 1;
            // 
            // tlpPrincipal
            // 
            tlpPrincipal.ColumnCount = 2;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tlpPrincipal.Controls.Add(pnlLaranja, 0, 0);
            tlpPrincipal.Controls.Add(tlpCentralizar, 1, 0);
            tlpPrincipal.Dock = DockStyle.Fill;
            tlpPrincipal.Location = new Point(0, 0);
            tlpPrincipal.Margin = new Padding(0);
            tlpPrincipal.Name = "tlpPrincipal";
            tlpPrincipal.RowCount = 1;
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpPrincipal.Size = new Size(884, 561);
            tlpPrincipal.TabIndex = 0;
            // 
            // pnlLaranja
            // 
            pnlLaranja.BackColor = Color.FromArgb(255, 128, 0);
            pnlLaranja.Controls.Add(tlpLadoEsquerdo);
            pnlLaranja.Dock = DockStyle.Fill;
            pnlLaranja.Location = new Point(0, 0);
            pnlLaranja.Margin = new Padding(0);
            pnlLaranja.Name = "pnlLaranja";
            pnlLaranja.Size = new Size(397, 561);
            pnlLaranja.TabIndex = 0;
            // 
            // tlpLadoEsquerdo
            // 
            tlpLadoEsquerdo.BackColor = Color.Transparent;
            tlpLadoEsquerdo.ColumnCount = 1;
            tlpLadoEsquerdo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpLadoEsquerdo.Controls.Add(picLogoLogin, 0, 0);
            tlpLadoEsquerdo.Controls.Add(lblFraseEfeito, 0, 2);
            tlpLadoEsquerdo.Controls.Add(pictureBox1, 0, 3);
            tlpLadoEsquerdo.Dock = DockStyle.Fill;
            tlpLadoEsquerdo.Font = new Font("Segoe UI", 10F);
            tlpLadoEsquerdo.Location = new Point(0, 0);
            tlpLadoEsquerdo.Margin = new Padding(0);
            tlpLadoEsquerdo.Name = "tlpLadoEsquerdo";
            tlpLadoEsquerdo.RowCount = 4;
            tlpLadoEsquerdo.RowStyles.Add(new RowStyle(SizeType.Percent, 24F));
            tlpLadoEsquerdo.RowStyles.Add(new RowStyle(SizeType.Percent, 3F));
            tlpLadoEsquerdo.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tlpLadoEsquerdo.RowStyles.Add(new RowStyle(SizeType.Percent, 61F));
            tlpLadoEsquerdo.Size = new Size(397, 561);
            tlpLadoEsquerdo.TabIndex = 0;
            // 
            // picLogoLogin
            // 
            picLogoLogin.Dock = DockStyle.Fill;
            picLogoLogin.Image = (Image)resources.GetObject("picLogoLogin.Image");
            picLogoLogin.Location = new Point(10, 5);
            picLogoLogin.Margin = new Padding(10, 5, 10, 5);
            picLogoLogin.Name = "picLogoLogin";
            picLogoLogin.Size = new Size(377, 124);
            picLogoLogin.SizeMode = PictureBoxSizeMode.Zoom;
            picLogoLogin.TabIndex = 0;
            picLogoLogin.TabStop = false;
            // 
            // lblFraseEfeito
            // 
            lblFraseEfeito.Dock = DockStyle.Fill;
            lblFraseEfeito.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFraseEfeito.ForeColor = Color.White;
            lblFraseEfeito.Location = new Point(15, 150);
            lblFraseEfeito.Margin = new Padding(15, 0, 15, 0);
            lblFraseEfeito.Name = "lblFraseEfeito";
            lblFraseEfeito.Size = new Size(367, 67);
            lblFraseEfeito.TabIndex = 1;
            lblFraseEfeito.Text = "Tecnologia que conecta cuidado e carinho.";
            lblFraseEfeito.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 217);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(397, 344);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // tlpCentralizar
            // 
            tlpCentralizar.BackgroundImage = (Image)resources.GetObject("tlpCentralizar.BackgroundImage");
            tlpCentralizar.ColumnCount = 3;
            tlpCentralizar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpCentralizar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 400F));
            tlpCentralizar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpCentralizar.Controls.Add(pnlCardLogin, 1, 1);
            tlpCentralizar.Dock = DockStyle.Fill;
            tlpCentralizar.Location = new Point(397, 0);
            tlpCentralizar.Margin = new Padding(0);
            tlpCentralizar.Name = "tlpCentralizar";
            tlpCentralizar.RowCount = 3;
            tlpCentralizar.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpCentralizar.RowStyles.Add(new RowStyle(SizeType.Absolute, 420F));
            tlpCentralizar.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpCentralizar.Size = new Size(487, 561);
            tlpCentralizar.TabIndex = 1;
            // 
            // pnlCardLogin
            // 
            pnlCardLogin.BackColor = Color.White;
            pnlCardLogin.Controls.Add(tlpLogin);
            pnlCardLogin.Dock = DockStyle.Fill;
            pnlCardLogin.Location = new Point(43, 70);
            pnlCardLogin.Margin = new Padding(0);
            pnlCardLogin.Name = "pnlCardLogin";
            pnlCardLogin.Padding = new Padding(10);
            pnlCardLogin.Size = new Size(400, 420);
            pnlCardLogin.TabIndex = 0;
            // 
            // tlpLogin
            // 
            tlpLogin.ColumnCount = 1;
            tlpLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpLogin.Controls.Add(lblBoasVindas, 0, 0);
            tlpLogin.Controls.Add(lblTitulo, 0, 1);
            tlpLogin.Controls.Add(lblDesc, 0, 2);
            tlpLogin.Controls.Add(lblUsuario, 0, 3);
            tlpLogin.Controls.Add(pnlUsuario, 0, 4);
            tlpLogin.Controls.Add(lblSenha, 0, 5);
            tlpLogin.Controls.Add(pnlSenha, 0, 6);
            tlpLogin.Controls.Add(chkLembrarSenha, 0, 7);
            tlpLogin.Controls.Add(btnEntrar, 0, 8);
            tlpLogin.Dock = DockStyle.Fill;
            tlpLogin.Location = new Point(10, 10);
            tlpLogin.Margin = new Padding(0);
            tlpLogin.Name = "tlpLogin";
            tlpLogin.Padding = new Padding(10);
            tlpLogin.RowCount = 11;
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Absolute, 13F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tlpLogin.Size = new Size(380, 400);
            tlpLogin.TabIndex = 1;
            // 
            // lblBoasVindas
            // 
            lblBoasVindas.Dock = DockStyle.Fill;
            lblBoasVindas.Font = new Font("Segoe UI", 10.75F, FontStyle.Bold);
            lblBoasVindas.ForeColor = Color.FromArgb(255, 128, 0);
            lblBoasVindas.Location = new Point(13, 10);
            lblBoasVindas.Name = "lblBoasVindas";
            lblBoasVindas.Size = new Size(354, 35);
            lblBoasVindas.TabIndex = 0;
            lblBoasVindas.Text = "BEM VINDO AO PATAHUB!";
            lblBoasVindas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(13, 45);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(354, 67);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Entre na sua conta";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDesc
            // 
            lblDesc.Dock = DockStyle.Fill;
            lblDesc.Font = new Font("Segoe UI", 10F);
            lblDesc.ForeColor = Color.Gray;
            lblDesc.Location = new Point(13, 112);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(354, 38);
            lblDesc.TabIndex = 2;
            lblDesc.Text = "Continue de você onde parou.";
            lblDesc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.Left;
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(13, 156);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(67, 20);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuário:";
            lblUsuario.TextAlign = ContentAlignment.BottomLeft;
            // 
            // pnlUsuario
            // 
            pnlUsuario.BackColor = Color.White;
            pnlUsuario.Controls.Add(txtUsuario);
            pnlUsuario.CorBorda = Color.FromArgb(195, 205, 215);
            pnlUsuario.Dock = DockStyle.Fill;
            pnlUsuario.EspessuraBorda = 1;
            pnlUsuario.Location = new Point(10, 185);
            pnlUsuario.Margin = new Padding(0, 3, 0, 5);
            pnlUsuario.Name = "pnlUsuario";
            pnlUsuario.Padding = new Padding(12, 5, 12, 5);
            pnlUsuario.Raio = 10;
            pnlUsuario.Size = new Size(360, 34);
            pnlUsuario.TabIndex = 5;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.White;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Location = new Point(9, 9);
            txtUsuario.Margin = new Padding(0);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Digite o seu ID de usuário.";
            txtUsuario.Size = new Size(336, 16);
            txtUsuario.TabIndex = 4;
            // 
            // lblSenha
            // 
            lblSenha.Anchor = AnchorStyles.Left;
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblSenha.Location = new Point(13, 229);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(55, 20);
            lblSenha.TabIndex = 5;
            lblSenha.Text = "Senha:";
            lblSenha.TextAlign = ContentAlignment.BottomLeft;
            lblSenha.Click += lblSenha_Click;
            // 
            // pnlSenha
            // 
            pnlSenha.BackColor = Color.White;
            pnlSenha.Controls.Add(txtSenha);
            pnlSenha.CorBorda = Color.FromArgb(195, 205, 215);
            pnlSenha.Dock = DockStyle.Fill;
            pnlSenha.EspessuraBorda = 1;
            pnlSenha.Location = new Point(10, 258);
            pnlSenha.Margin = new Padding(0, 3, 0, 5);
            pnlSenha.Name = "pnlSenha";
            pnlSenha.Padding = new Padding(12, 5, 12, 5);
            pnlSenha.Raio = 10;
            pnlSenha.Size = new Size(360, 33);
            pnlSenha.TabIndex = 7;
            // 
            // txtSenha
            // 
            txtSenha.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSenha.BackColor = Color.White;
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Location = new Point(9, 9);
            txtSenha.Margin = new Padding(0);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Digite sua senha.";
            txtSenha.Size = new Size(336, 16);
            txtSenha.TabIndex = 6;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // chkLembrarSenha
            // 
            chkLembrarSenha.AutoSize = true;
            chkLembrarSenha.Location = new Point(13, 299);
            chkLembrarSenha.Name = "chkLembrarSenha";
            chkLembrarSenha.Size = new Size(105, 19);
            chkLembrarSenha.TabIndex = 8;
            chkLembrarSenha.Text = "Lembrar Senha";
            chkLembrarSenha.UseVisualStyleBackColor = true;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(255, 128, 0);
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.Dock = DockStyle.Fill;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(13, 336);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(354, 30);
            btnEntrar.TabIndex = 7;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(plLadoDireito);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(898, 593);
            Name = "Login";
            Text = "PetShop";
            Load += Form1_Load;
            plLadoDireito.ResumeLayout(false);
            tlpPrincipal.ResumeLayout(false);
            pnlLaranja.ResumeLayout(false);
            tlpLadoEsquerdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogoLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tlpCentralizar.ResumeLayout(false);
            pnlCardLogin.ResumeLayout(false);
            tlpLogin.ResumeLayout(false);
            tlpLogin.PerformLayout();
            pnlUsuario.ResumeLayout(false);
            pnlUsuario.PerformLayout();
            pnlSenha.ResumeLayout(false);
            pnlSenha.PerformLayout();
            ResumeLayout(false);
        }

        #endregion


        private TableLayoutPanel tlpPrincipal;
        private Panel pnlLaranja;
        private TableLayoutPanel tlpCentralizar;
        private TableLayoutPanel tlpLadoEsquerdo;
        private PictureBox picLogoLogin;
        private Label lblFraseEfeito;
        private PictureBox pictureBox1;
        private Panel pnlCardLogin;
        private TableLayoutPanel tlpLogin;
        private Label lblTitulo;
        private Label lblDesc;
        private Label lblUsuario;
        private Button btnEntrar;
        private Label lblBoasVindas;
        private Label lblSenha;
        private CheckBox chkLembrarSenha;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Componentes.PainelArredondado pnlUsuario;
        private Componentes.PainelArredondado pnlSenha;
    }
}
