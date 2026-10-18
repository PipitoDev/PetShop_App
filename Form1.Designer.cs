namespace PetShop_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            plLadoEsquerdo = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tlpCaixaEsquerda = new TableLayoutPanel();
            lblTxtSupEsquerdo = new Label();
            lblTxtMedEsquerdo = new Label();
            flpCaixaLogoNome = new FlowLayoutPanel();
            pcbLogo = new PictureBox();
            lblNome = new Label();
            lblTxtInfEsquerdo = new Label();
            plLadoDireito = new Panel();
            tlpCaixaDireita = new TableLayoutPanel();
            lblBoasVindas = new Label();
            lblTxtSupDireito = new Label();
            tblCaixaEmailSenha = new TableLayoutPanel();
            lblEmail = new Label();
            lblSenha = new Label();
            txtSenha = new TextBox();
            txtEmail = new TextBox();
            lblTxtSupInferior = new Label();
            plLadoEsquerdo.SuspendLayout();
            tlpCaixaEsquerda.SuspendLayout();
            flpCaixaLogoNome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            plLadoDireito.SuspendLayout();
            tlpCaixaDireita.SuspendLayout();
            tblCaixaEmailSenha.SuspendLayout();
            SuspendLayout();
            // 
            // plLadoEsquerdo
            // 
            plLadoEsquerdo.BackColor = Color.FromArgb(20, 83, 45);
            plLadoEsquerdo.Controls.Add(tableLayoutPanel1);
            plLadoEsquerdo.Controls.Add(tlpCaixaEsquerda);
            plLadoEsquerdo.Dock = DockStyle.Left;
            plLadoEsquerdo.Location = new Point(0, 0);
            plLadoEsquerdo.Margin = new Padding(4, 3, 4, 3);
            plLadoEsquerdo.Name = "plLadoEsquerdo";
            plLadoEsquerdo.Size = new Size(416, 561);
            plLadoEsquerdo.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 84F));
            tableLayoutPanel1.Location = new Point(416, 155);
            tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(50, 50);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tlpCaixaEsquerda
            // 
            tlpCaixaEsquerda.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpCaixaEsquerda.ColumnCount = 1;
            tlpCaixaEsquerda.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCaixaEsquerda.Controls.Add(lblTxtSupEsquerdo, 0, 2);
            tlpCaixaEsquerda.Controls.Add(lblTxtMedEsquerdo, 0, 3);
            tlpCaixaEsquerda.Controls.Add(flpCaixaLogoNome, 0, 1);
            tlpCaixaEsquerda.Controls.Add(lblTxtInfEsquerdo, 0, 4);
            tlpCaixaEsquerda.Location = new Point(12, 0);
            tlpCaixaEsquerda.Margin = new Padding(4, 3, 4, 3);
            tlpCaixaEsquerda.Name = "tlpCaixaEsquerda";
            tlpCaixaEsquerda.RowCount = 6;
            tlpCaixaEsquerda.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpCaixaEsquerda.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tlpCaixaEsquerda.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tlpCaixaEsquerda.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tlpCaixaEsquerda.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tlpCaixaEsquerda.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tlpCaixaEsquerda.Size = new Size(390, 561);
            tlpCaixaEsquerda.TabIndex = 0;
            // 
            // lblTxtSupEsquerdo
            // 
            lblTxtSupEsquerdo.AutoSize = true;
            lblTxtSupEsquerdo.Dock = DockStyle.Fill;
            lblTxtSupEsquerdo.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTxtSupEsquerdo.ForeColor = Color.White;
            lblTxtSupEsquerdo.Location = new Point(4, 130);
            lblTxtSupEsquerdo.Margin = new Padding(4, 0, 4, 0);
            lblTxtSupEsquerdo.Name = "lblTxtSupEsquerdo";
            lblTxtSupEsquerdo.RightToLeft = RightToLeft.No;
            lblTxtSupEsquerdo.Size = new Size(382, 75);
            lblTxtSupEsquerdo.TabIndex = 0;
            lblTxtSupEsquerdo.Text = "Mais cuidado para os pets. Mais controle para você.\r\n\r\n";
            lblTxtSupEsquerdo.TextAlign = ContentAlignment.MiddleLeft;
            lblTxtSupEsquerdo.Click += lblTextoSuperiorEsquerdo_Click;
            // 
            // lblTxtMedEsquerdo
            // 
            lblTxtMedEsquerdo.AutoSize = true;
            lblTxtMedEsquerdo.Dock = DockStyle.Fill;
            lblTxtMedEsquerdo.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTxtMedEsquerdo.ForeColor = Color.FromArgb(224, 224, 224);
            lblTxtMedEsquerdo.Location = new Point(4, 205);
            lblTxtMedEsquerdo.Margin = new Padding(4, 0, 4, 0);
            lblTxtMedEsquerdo.Name = "lblTxtMedEsquerdo";
            lblTxtMedEsquerdo.RightToLeft = RightToLeft.No;
            lblTxtMedEsquerdo.Size = new Size(382, 75);
            lblTxtMedEsquerdo.TabIndex = 1;
            lblTxtMedEsquerdo.Text = " Mais cuidado para os pets. Mais controle para você.";
            lblTxtMedEsquerdo.TextAlign = ContentAlignment.MiddleLeft;
            lblTxtMedEsquerdo.Click += lblTextoMedioEsquerdo_Click;
            // 
            // flpCaixaLogoNome
            // 
            flpCaixaLogoNome.Controls.Add(pcbLogo);
            flpCaixaLogoNome.Controls.Add(lblNome);
            flpCaixaLogoNome.Dock = DockStyle.Fill;
            flpCaixaLogoNome.Location = new Point(4, 33);
            flpCaixaLogoNome.Margin = new Padding(4, 3, 4, 3);
            flpCaixaLogoNome.Name = "flpCaixaLogoNome";
            flpCaixaLogoNome.Size = new Size(382, 94);
            flpCaixaLogoNome.TabIndex = 3;
            // 
            // pcbLogo
            // 
            pcbLogo.Anchor = AnchorStyles.Left;
            pcbLogo.BackColor = Color.Cornsilk;
            pcbLogo.Location = new Point(4, 3);
            pcbLogo.Margin = new Padding(4, 3, 4, 3);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(75, 75);
            pcbLogo.TabIndex = 0;
            pcbLogo.TabStop = false;
            // 
            // lblNome
            // 
            lblNome.Anchor = AnchorStyles.Left;
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.ForeColor = Color.White;
            lblNome.Location = new Point(87, 26);
            lblNome.Margin = new Padding(4, 0, 4, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(193, 29);
            lblNome.TabIndex = 1;
            lblNome.Text = "PET-ISTA SHOP\r\n";
            lblNome.Click += lblNome_Click;
            // 
            // lblTxtInfEsquerdo
            // 
            lblTxtInfEsquerdo.AutoSize = true;
            lblTxtInfEsquerdo.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTxtInfEsquerdo.ForeColor = Color.Silver;
            lblTxtInfEsquerdo.Location = new Point(4, 280);
            lblTxtInfEsquerdo.Margin = new Padding(4, 0, 4, 0);
            lblTxtInfEsquerdo.Name = "lblTxtInfEsquerdo";
            lblTxtInfEsquerdo.Size = new Size(292, 16);
            lblTxtInfEsquerdo.TabIndex = 4;
            lblTxtInfEsquerdo.Text = " PetShop Central · Gestão feita para quem cuida.";
            // 
            // plLadoDireito
            // 
            plLadoDireito.Controls.Add(tlpCaixaDireita);
            plLadoDireito.Dock = DockStyle.Fill;
            plLadoDireito.Location = new Point(416, 0);
            plLadoDireito.Margin = new Padding(4, 3, 4, 3);
            plLadoDireito.Name = "plLadoDireito";
            plLadoDireito.Size = new Size(468, 561);
            plLadoDireito.TabIndex = 1;
            // 
            // tlpCaixaDireita
            // 
            tlpCaixaDireita.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tlpCaixaDireita.ColumnCount = 1;
            tlpCaixaDireita.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCaixaDireita.Controls.Add(lblBoasVindas, 0, 2);
            tlpCaixaDireita.Controls.Add(lblTxtSupDireito, 0, 3);
            tlpCaixaDireita.Controls.Add(tblCaixaEmailSenha, 0, 5);
            tlpCaixaDireita.Controls.Add(lblTxtSupInferior, 0, 4);
            tlpCaixaDireita.Location = new Point(56, 0);
            tlpCaixaDireita.Margin = new Padding(4, 3, 4, 3);
            tlpCaixaDireita.Name = "tlpCaixaDireita";
            tlpCaixaDireita.RowCount = 7;
            tlpCaixaDireita.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpCaixaDireita.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpCaixaDireita.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpCaixaDireita.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tlpCaixaDireita.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tlpCaixaDireita.RowStyles.Add(new RowStyle(SizeType.Absolute, 328F));
            tlpCaixaDireita.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpCaixaDireita.Size = new Size(360, 561);
            tlpCaixaDireita.TabIndex = 0;
            tlpCaixaDireita.Paint += tlpCaixaDireita_Paint;
            // 
            // lblBoasVindas
            // 
            lblBoasVindas.AutoSize = true;
            lblBoasVindas.BackColor = Color.Transparent;
            lblBoasVindas.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBoasVindas.ForeColor = Color.FromArgb(20, 83, 45);
            lblBoasVindas.Location = new Point(4, 90);
            lblBoasVindas.Margin = new Padding(4, 0, 4, 0);
            lblBoasVindas.Name = "lblBoasVindas";
            lblBoasVindas.Size = new Size(255, 19);
            lblBoasVindas.TabIndex = 0;
            lblBoasVindas.Text = " BEM-VINDO AO PET-ISTA SHOP";
            lblBoasVindas.Click += label1_Click_3;
            // 
            // lblTxtSupDireito
            // 
            lblTxtSupDireito.AutoSize = true;
            lblTxtSupDireito.BackColor = Color.Transparent;
            lblTxtSupDireito.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTxtSupDireito.ForeColor = Color.Black;
            lblTxtSupDireito.Location = new Point(4, 140);
            lblTxtSupDireito.Margin = new Padding(4, 0, 4, 0);
            lblTxtSupDireito.Name = "lblTxtSupDireito";
            lblTxtSupDireito.Size = new Size(228, 29);
            lblTxtSupDireito.TabIndex = 8;
            lblTxtSupDireito.Text = "Entre na sua conta";
            lblTxtSupDireito.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tblCaixaEmailSenha
            // 
            tblCaixaEmailSenha.AutoSize = true;
            tblCaixaEmailSenha.ColumnCount = 1;
            tblCaixaEmailSenha.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblCaixaEmailSenha.Controls.Add(lblEmail, 0, 0);
            tblCaixaEmailSenha.Controls.Add(lblSenha, 0, 2);
            tblCaixaEmailSenha.Controls.Add(txtSenha, 0, 3);
            tblCaixaEmailSenha.Controls.Add(txtEmail, 0, 1);
            tblCaixaEmailSenha.Location = new Point(3, 217);
            tblCaixaEmailSenha.Name = "tblCaixaEmailSenha";
            tblCaixaEmailSenha.RowCount = 4;
            tblCaixaEmailSenha.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblCaixaEmailSenha.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tblCaixaEmailSenha.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblCaixaEmailSenha.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tblCaixaEmailSenha.Size = new Size(354, 130);
            tblCaixaEmailSenha.TabIndex = 9;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(3, 24);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(182, 16);
            lblEmail.TabIndex = 4;
            lblEmail.Text = " E-mail ou nome de usuário";
            lblEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSenha
            // 
            lblSenha.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(3, 89);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(52, 16);
            lblSenha.TabIndex = 5;
            lblSenha.Text = " Senha";
            lblSenha.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(3, 108);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Digite aqui";
            txtSenha.Size = new Size(348, 22);
            txtSenha.TabIndex = 3;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(3, 43);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Digite aqui";
            txtEmail.Size = new Size(348, 22);
            txtEmail.TabIndex = 2;
            // 
            // lblTxtSupInferior
            // 
            lblTxtSupInferior.AutoSize = true;
            lblTxtSupInferior.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTxtSupInferior.ForeColor = Color.Gray;
            lblTxtSupInferior.Location = new Point(4, 189);
            lblTxtSupInferior.Margin = new Padding(4, 0, 4, 0);
            lblTxtSupInferior.Name = "lblTxtSupInferior";
            lblTxtSupInferior.Size = new Size(315, 17);
            lblTxtSupInferior.TabIndex = 7;
            lblTxtSupInferior.Text = " Acesse sua unidade e continue de onde parou.";
            lblTxtSupInferior.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(plLadoDireito);
            Controls.Add(plLadoEsquerdo);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(900, 600);
            Name = "Form1";
            Text = "PetShop";
            Load += Form1_Load;
            plLadoEsquerdo.ResumeLayout(false);
            tlpCaixaEsquerda.ResumeLayout(false);
            tlpCaixaEsquerda.PerformLayout();
            flpCaixaLogoNome.ResumeLayout(false);
            flpCaixaLogoNome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            plLadoDireito.ResumeLayout(false);
            tlpCaixaDireita.ResumeLayout(false);
            tlpCaixaDireita.PerformLayout();
            tblCaixaEmailSenha.ResumeLayout(false);
            tblCaixaEmailSenha.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel plLadoEsquerdo;
        private Panel plLadoDireito;
        private TableLayoutPanel tlpCaixaEsquerda;
        private Label lblTxtSupEsquerdo;
        private Label lblTxtMedEsquerdo;
        private FlowLayoutPanel flpCaixaLogoNome;
        private PictureBox pcbLogo;
        private Label lblNome;
        private Label lblTxtInfEsquerdo;
        private TableLayoutPanel tlpCaixaDireita;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblBoasVindas;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblTxtSupInferior;
        private Label lblTxtSupDireito;
        private TableLayoutPanel tblCaixaEmailSenha;
        private Label lblEmail;
        private Label lblSenha;
        private TextBox txtSenha;
        private TextBox txtEmail;
    }
}
