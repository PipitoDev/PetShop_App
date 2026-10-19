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
            lblTxtSupInferior = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            plLadoEsquerdo.SuspendLayout();
            tlpCaixaEsquerda.SuspendLayout();
            flpCaixaLogoNome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            plLadoDireito.SuspendLayout();
            tlpCaixaDireita.SuspendLayout();
            SuspendLayout();
            // 
            // plLadoEsquerdo
            // 
            plLadoEsquerdo.BackColor = Color.FromArgb(20, 83, 45);
            plLadoEsquerdo.Controls.Add(tableLayoutPanel1);
            plLadoEsquerdo.Controls.Add(tlpCaixaEsquerda);
            plLadoEsquerdo.Dock = DockStyle.Left;
            plLadoEsquerdo.Location = new Point(0, 0);
            plLadoEsquerdo.Margin = new Padding(6, 5, 6, 5);
            plLadoEsquerdo.Name = "plLadoEsquerdo";
            plLadoEsquerdo.Size = new Size(594, 935);
            plLadoEsquerdo.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 84F));
            tableLayoutPanel1.Location = new Point(594, 258);
            tableLayoutPanel1.Margin = new Padding(6, 5, 6, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(71, 83);
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
            tlpCaixaEsquerda.Location = new Point(17, 0);
            tlpCaixaEsquerda.Margin = new Padding(6, 5, 6, 5);
            tlpCaixaEsquerda.Name = "tlpCaixaEsquerda";
            tlpCaixaEsquerda.RowCount = 6;
            tlpCaixaEsquerda.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpCaixaEsquerda.RowStyles.Add(new RowStyle(SizeType.Absolute, 167F));
            tlpCaixaEsquerda.RowStyles.Add(new RowStyle(SizeType.Absolute, 125F));
            tlpCaixaEsquerda.RowStyles.Add(new RowStyle(SizeType.Absolute, 125F));
            tlpCaixaEsquerda.RowStyles.Add(new RowStyle(SizeType.Absolute, 125F));
            tlpCaixaEsquerda.RowStyles.Add(new RowStyle(SizeType.Absolute, 125F));
            tlpCaixaEsquerda.Size = new Size(557, 935);
            tlpCaixaEsquerda.TabIndex = 0;
            // 
            // lblTxtSupEsquerdo
            // 
            lblTxtSupEsquerdo.AutoSize = true;
            lblTxtSupEsquerdo.Dock = DockStyle.Fill;
            lblTxtSupEsquerdo.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTxtSupEsquerdo.ForeColor = Color.White;
            lblTxtSupEsquerdo.Location = new Point(6, 217);
            lblTxtSupEsquerdo.Margin = new Padding(6, 0, 6, 0);
            lblTxtSupEsquerdo.Name = "lblTxtSupEsquerdo";
            lblTxtSupEsquerdo.RightToLeft = RightToLeft.No;
            lblTxtSupEsquerdo.Size = new Size(545, 125);
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
            lblTxtMedEsquerdo.Location = new Point(6, 342);
            lblTxtMedEsquerdo.Margin = new Padding(6, 0, 6, 0);
            lblTxtMedEsquerdo.Name = "lblTxtMedEsquerdo";
            lblTxtMedEsquerdo.RightToLeft = RightToLeft.No;
            lblTxtMedEsquerdo.Size = new Size(545, 125);
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
            flpCaixaLogoNome.Location = new Point(6, 55);
            flpCaixaLogoNome.Margin = new Padding(6, 5, 6, 5);
            flpCaixaLogoNome.Name = "flpCaixaLogoNome";
            flpCaixaLogoNome.Size = new Size(545, 157);
            flpCaixaLogoNome.TabIndex = 3;
            // 
            // pcbLogo
            // 
            pcbLogo.Anchor = AnchorStyles.Left;
            pcbLogo.BackColor = Color.Cornsilk;
            pcbLogo.Location = new Point(6, 5);
            pcbLogo.Margin = new Padding(6, 5, 6, 5);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(107, 125);
            pcbLogo.TabIndex = 0;
            pcbLogo.TabStop = false;
            // 
            // lblNome
            // 
            lblNome.Anchor = AnchorStyles.Left;
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.ForeColor = Color.White;
            lblNome.Location = new Point(125, 46);
            lblNome.Margin = new Padding(6, 0, 6, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(289, 43);
            lblNome.TabIndex = 1;
            lblNome.Text = "PET-ISTA SHOP\r\n";
            lblNome.Click += lblNome_Click;
            // 
            // lblTxtInfEsquerdo
            // 
            lblTxtInfEsquerdo.AutoSize = true;
            lblTxtInfEsquerdo.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTxtInfEsquerdo.ForeColor = Color.Silver;
            lblTxtInfEsquerdo.Location = new Point(6, 467);
            lblTxtInfEsquerdo.Margin = new Padding(6, 0, 6, 0);
            lblTxtInfEsquerdo.Name = "lblTxtInfEsquerdo";
            lblTxtInfEsquerdo.Size = new Size(446, 23);
            lblTxtInfEsquerdo.TabIndex = 4;
            lblTxtInfEsquerdo.Text = " PetShop Central · Gestão feita para quem cuida.";
            // 
            // plLadoDireito
            // 
            plLadoDireito.Controls.Add(tlpCaixaDireita);
            plLadoDireito.Dock = DockStyle.Fill;
            plLadoDireito.Location = new Point(594, 0);
            plLadoDireito.Margin = new Padding(6, 5, 6, 5);
            plLadoDireito.Name = "plLadoDireito";
            plLadoDireito.Size = new Size(669, 935);
            plLadoDireito.TabIndex = 1;
            // 
            // tlpCaixaDireita
            // 
            tlpCaixaDireita.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tlpCaixaDireita.ColumnCount = 1;
            tlpCaixaDireita.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCaixaDireita.Controls.Add(lblBoasVindas, 0, 2);
            tlpCaixaDireita.Controls.Add(lblTxtSupDireito, 0, 3);
            tlpCaixaDireita.Controls.Add(lblTxtSupInferior, 0, 4);
            tlpCaixaDireita.Controls.Add(lblEmail, 0, 5);
            tlpCaixaDireita.Controls.Add(txtEmail, 0, 6);
            tlpCaixaDireita.Controls.Add(label1, 0, 7);
            tlpCaixaDireita.Controls.Add(textBox1, 0, 8);
            tlpCaixaDireita.Location = new Point(80, 0);
            tlpCaixaDireita.Margin = new Padding(6, 5, 6, 5);
            tlpCaixaDireita.Name = "tlpCaixaDireita";
            tlpCaixaDireita.RowCount = 10;
            tlpCaixaDireita.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
            tlpCaixaDireita.RowStyles.Add(new RowStyle(SizeType.Absolute, 83F));
            tlpCaixaDireita.RowStyles.Add(new RowStyle(SizeType.Absolute, 83F));
            tlpCaixaDireita.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tlpCaixaDireita.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tlpCaixaDireita.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tlpCaixaDireita.RowStyles.Add(new RowStyle(SizeType.Absolute, 83F));
            tlpCaixaDireita.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tlpCaixaDireita.RowStyles.Add(new RowStyle(SizeType.Absolute, 83F));
            tlpCaixaDireita.RowStyles.Add(new RowStyle(SizeType.Absolute, 83F));
            tlpCaixaDireita.Size = new Size(514, 935);
            tlpCaixaDireita.TabIndex = 0;
            tlpCaixaDireita.Paint += tlpCaixaDireita_Paint;
            // 
            // lblBoasVindas
            // 
            lblBoasVindas.AutoSize = true;
            lblBoasVindas.BackColor = Color.Transparent;
            lblBoasVindas.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBoasVindas.ForeColor = Color.FromArgb(20, 83, 45);
            lblBoasVindas.Location = new Point(6, 150);
            lblBoasVindas.Margin = new Padding(6, 0, 6, 0);
            lblBoasVindas.Name = "lblBoasVindas";
            lblBoasVindas.Size = new Size(385, 29);
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
            lblTxtSupDireito.Location = new Point(6, 233);
            lblTxtSupDireito.Margin = new Padding(6, 0, 6, 0);
            lblTxtSupDireito.Name = "lblTxtSupDireito";
            lblTxtSupDireito.Size = new Size(339, 43);
            lblTxtSupDireito.TabIndex = 8;
            lblTxtSupDireito.Text = "Entre na sua conta";
            lblTxtSupDireito.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTxtSupInferior
            // 
            lblTxtSupInferior.AutoSize = true;
            lblTxtSupInferior.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTxtSupInferior.ForeColor = Color.Gray;
            lblTxtSupInferior.Location = new Point(6, 315);
            lblTxtSupInferior.Margin = new Padding(6, 0, 6, 0);
            lblTxtSupInferior.Name = "lblTxtSupInferior";
            lblTxtSupInferior.Size = new Size(489, 26);
            lblTxtSupInferior.TabIndex = 7;
            lblTxtSupInferior.Text = " Acesse sua unidade e continue de onde parou.";
            lblTxtSupInferior.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Dock = DockStyle.Bottom;
            lblEmail.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(4, 407);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(506, 24);
            lblEmail.TabIndex = 9;
            lblEmail.Text = " Insira seu E-mail";
            // 
            // txtEmail
            // 
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(4, 436);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(506, 30);
            txtEmail.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(4, 548);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(506, 24);
            label1.TabIndex = 11;
            label1.Text = " Insira sua senha";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(4, 577);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(506, 30);
            textBox1.TabIndex = 12;
            textBox1.UseSystemPasswordChar = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1263, 935);
            Controls.Add(plLadoDireito);
            Controls.Add(plLadoEsquerdo);
            Margin = new Padding(6, 5, 6, 5);
            MinimumSize = new Size(1276, 963);
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
        private Label lblTxtSupDireito;
        private Label lblTxtSupInferior;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label label1;
        private TextBox textBox1;
    }
}
