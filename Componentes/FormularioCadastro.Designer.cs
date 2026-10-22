#nullable disable
namespace PetShop_App.Componentes
{
    partial class FormularioCadastro
    {
        private System.ComponentModel.IContainer components;
        protected TableLayoutPanel campos;
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
            botoes.SuspendLayout();
            SuspendLayout();
            // 
            // campos
            // 
            campos.AutoScroll = true;
            campos.ColumnCount = 1;
            campos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            campos.Dock = DockStyle.Fill;
            campos.Location = new Point(0, 0);
            campos.Margin = new Padding(3, 4, 3, 4);
            campos.Name = "campos";
            campos.Padding = new Padding(25, 29, 25, 29);
            campos.Size = new Size(576, 648);
            campos.TabIndex = 0;
            // 
            // botoes
            // 
            botoes.Controls.Add(btnSalvar);
            botoes.Controls.Add(btnCancelar);
            botoes.Dock = DockStyle.Bottom;
            botoes.FlowDirection = FlowDirection.RightToLeft;
            botoes.Location = new Point(0, 648);
            botoes.Margin = new Padding(3, 4, 3, 4);
            botoes.Name = "botoes";
            botoes.Padding = new Padding(11, 13, 11, 13);
            botoes.Size = new Size(576, 87);
            botoes.TabIndex = 1;
            // 
            // btnSalvar
            // 
            btnSalvar.AutoSize = true;
            btnSalvar.BackColor = Color.FromArgb(255, 128, 0);
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(437, 17);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Padding = new Padding(16, 0, 16, 0);
            btnSalvar.Size = new Size(114, 53);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = true;
            btnCancelar.BackColor = Color.White;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.FromArgb(255, 128, 0);
            btnCancelar.Location = new Point(296, 17);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Padding = new Padding(16, 0, 16, 0);
            btnCancelar.Size = new Size(135, 53);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // FormularioCadastro
            // 
            AcceptButton = btnSalvar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnCancelar;
            ClientSize = new Size(576, 735);
            Controls.Add(campos);
            Controls.Add(botoes);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormularioCadastro";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro";
            botoes.ResumeLayout(false);
            botoes.PerformLayout();
            ResumeLayout(false);
        }
    }
}
