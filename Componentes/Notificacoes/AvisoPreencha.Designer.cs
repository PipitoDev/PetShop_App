namespace PetShop_App
{
    partial class DialogoAviso
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Button btnOk;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblMensagem = new Label();
            btnOk = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(55, 55, 55);
            lblTitulo.Location = new Point(83, 27);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(300, 35);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Preencha os campos";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMensagem
            // 
            lblMensagem.Font = new Font("Segoe UI", 10F);
            lblMensagem.ForeColor = Color.FromArgb(80, 80, 80);
            lblMensagem.Location = new Point(23, 82);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(360, 48);
            lblMensagem.TabIndex = 2;
            lblMensagem.Text = "Informe seu usuário ou e-mail e sua senha para continuar.";
            lblMensagem.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.FromArgb(255, 128, 0);
            btnOk.DialogResult = DialogResult.OK;
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnOk.ForeColor = Color.White;
            btnOk.Location = new Point(145, 148);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(120, 36);
            btnOk.TabIndex = 3;
            btnOk.Text = "Entendi";
            btnOk.UseVisualStyleBackColor = false;
            // 
            // DialogoAviso
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(408, 205);
            Controls.Add(btnOk);
            Controls.Add(lblMensagem);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DialogoAviso";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Aviso";
            ResumeLayout(false);
        }
    }
}
