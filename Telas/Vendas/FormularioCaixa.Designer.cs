#nullable disable
namespace PetShop_App.Telas.Vendas;

partial class FormularioCaixa
{
    private System.ComponentModel.IContainer components;
    private TableLayoutPanel campos; private FlowLayoutPanel botoes; private Button btnSalvar; private Button btnCancelar;
    private Label lblSaldo;
    private NumericUpDown numSaldo;

    protected override void Dispose(bool disposing) { if (disposing) components?.Dispose(); base.Dispose(disposing); }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        campos = new TableLayoutPanel(); botoes = new FlowLayoutPanel(); btnSalvar = new Button(); btnCancelar = new Button();
        lblSaldo = new Label(); numSaldo = new NumericUpDown();
        ((System.ComponentModel.ISupportInitialize)numSaldo).BeginInit(); campos.SuspendLayout(); botoes.SuspendLayout(); SuspendLayout();
        campos.AutoScroll = true; campos.ColumnCount = 1; campos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F)); campos.Dock = DockStyle.Fill; campos.Padding = new Padding(22);
        botoes.Controls.Add(btnSalvar); botoes.Controls.Add(btnCancelar); botoes.Dock = DockStyle.Bottom; botoes.FlowDirection = FlowDirection.RightToLeft; botoes.Height = 65; botoes.Padding = new Padding(10);
        btnSalvar.Text = "Salvar"; btnSalvar.Size = new Size(110, 40); btnSalvar.BackColor = Color.FromArgb(255, 128, 0); btnSalvar.ForeColor = Color.White; btnSalvar.FlatStyle = FlatStyle.Flat; btnSalvar.Font = new Font("Segoe UI", 10F, FontStyle.Bold); btnSalvar.DialogResult = DialogResult.OK;
        btnCancelar.Text = "Cancelar"; btnCancelar.Size = new Size(120, 40); btnCancelar.BackColor = Color.White; btnCancelar.ForeColor = Color.FromArgb(255, 128, 0); btnCancelar.FlatStyle = FlatStyle.Flat; btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold); btnCancelar.DialogResult = DialogResult.Cancel;
        lblSaldo.AutoSize = true; lblSaldo.Font = new Font("Segoe UI", 9F, FontStyle.Bold); lblSaldo.Text = "Saldo inicial (R$)";
        numSaldo.Dock = DockStyle.Top; numSaldo.DecimalPlaces = 2; numSaldo.Maximum = 999999; numSaldo.Font = new Font("Segoe UI", 10F);
        campos.Controls.Add(lblSaldo); campos.Controls.Add(numSaldo);
        AcceptButton = btnSalvar; CancelButton = btnCancelar; AutoScaleMode = AutoScaleMode.Font; BackColor = Color.White;
        ClientSize = new Size(504, 250); Controls.Add(campos); Controls.Add(botoes); FormBorderStyle = FormBorderStyle.FixedDialog; MaximizeBox = false; MinimizeBox = false; Name = "FormularioCaixa"; StartPosition = FormStartPosition.CenterParent; Text = "Abrir caixa";
        ((System.ComponentModel.ISupportInitialize)numSaldo).EndInit(); campos.ResumeLayout(false); campos.PerformLayout(); botoes.ResumeLayout(false); ResumeLayout(false);
    }
}
