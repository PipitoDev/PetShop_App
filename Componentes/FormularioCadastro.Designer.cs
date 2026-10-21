#nullable disable
namespace PetShop_App.Componentes
{
    partial class FormularioCadastro
    {
        private System.ComponentModel.IContainer components;
        private TableLayoutPanel campos;
        private FlowLayoutPanel botoes;
        private Button btnSalvar;
        private Button btnCancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            campos = new TableLayoutPanel();
            botoes = new FlowLayoutPanel();
            btnSalvar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            botoes.SuspendLayout();
            campos.Name = "campos";
            campos.Dock = DockStyle.Fill;
            campos.ColumnCount = 1;
            campos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            campos.AutoScroll = true;
            campos.Padding = new Padding(22);
            campos.TabIndex = 0;
            botoes.Name = "botoes";
            botoes.Dock = DockStyle.Bottom;
            botoes.Height = 65;
            botoes.FlowDirection = FlowDirection.RightToLeft;
            botoes.Padding = new Padding(10);
            botoes.Controls.Add(btnSalvar);
            botoes.Controls.Add(btnCancelar);
            botoes.TabIndex = 1;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Text = "Salvar";
            btnSalvar.AutoSize = true;
            btnSalvar.Size = new Size(100, 40);
            btnSalvar.Padding = new Padding(14, 0, 14, 0);
            btnSalvar.BackColor = Color.FromArgb(255, 128, 0);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalvar.DialogResult = DialogResult.OK;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Text = "Cancelar";
            btnCancelar.AutoSize = true;
            btnCancelar.Size = new Size(110, 40);
            btnCancelar.Padding = new Padding(14, 0, 14, 0);
            btnCancelar.BackColor = Color.White;
            btnCancelar.ForeColor = Color.FromArgb(255, 128, 0);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancelar.DialogResult = DialogResult.Cancel;
            AcceptButton = btnSalvar;
            CancelButton = btnCancelar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(504, 551);
            Controls.Add(campos);
            Controls.Add(botoes);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            Name = "FormularioCadastro";
            Text = "Cadastro";
            botoes.ResumeLayout(false);
            botoes.PerformLayout();
            ResumeLayout(false);
        }
    }
}
