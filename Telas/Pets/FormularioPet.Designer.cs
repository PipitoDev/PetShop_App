#nullable disable
namespace PetShop_App.Telas.Pets;

partial class FormularioPet
{
    private System.ComponentModel.IContainer components;
    private TableLayoutPanel campos; private FlowLayoutPanel botoes; private Button btnSalvar; private Button btnCancelar;
    private Label lblTutor;
    private ComboBox cmbTutor;
    private Label lblNome;
    private TextBox txtNome;
    private Label lblEspecie;
    private ComboBox cmbEspecie;
    private Label lblRaca;
    private TextBox txtRaca;
    private Label lblPorte;
    private ComboBox cmbPorte;
    private Label lblNascimento;
    private DateTimePicker dtpNascimento;
    private Label lblPeso;
    private NumericUpDown numPeso;

    protected override void Dispose(bool disposing)
    {
        if (disposing) components?.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        campos = new TableLayoutPanel(); botoes = new FlowLayoutPanel(); btnSalvar = new Button(); btnCancelar = new Button();
        lblTutor = new Label(); cmbTutor = new ComboBox();
        lblNome = new Label(); txtNome = new TextBox();
        lblEspecie = new Label(); cmbEspecie = new ComboBox();
        lblRaca = new Label(); txtRaca = new TextBox();
        lblPorte = new Label(); cmbPorte = new ComboBox();
        lblNascimento = new Label(); dtpNascimento = new DateTimePicker();
        lblPeso = new Label(); numPeso = new NumericUpDown();
        ((System.ComponentModel.ISupportInitialize)numPeso).BeginInit();
        campos.SuspendLayout(); botoes.SuspendLayout(); SuspendLayout();
        ConfigurarEstrutura();
        ConfigurarLabel(lblTutor, "Tutor *"); ConfigurarCombo(cmbTutor);
        ConfigurarLabel(lblNome, "Nome do pet *"); ConfigurarTexto(txtNome);
        ConfigurarLabel(lblEspecie, "Espécie *"); ConfigurarCombo(cmbEspecie); cmbEspecie.Items.AddRange(new object[] { "Cão", "Gato", "Ave", "Outro" });
        ConfigurarLabel(lblRaca, "Raça"); ConfigurarTexto(txtRaca);
        ConfigurarLabel(lblPorte, "Porte"); ConfigurarCombo(cmbPorte); cmbPorte.Items.AddRange(new object[] { "Pequeno", "Médio", "Grande" });
        ConfigurarLabel(lblNascimento, "Nascimento"); dtpNascimento.Dock = DockStyle.Top; dtpNascimento.Format = DateTimePickerFormat.Short; dtpNascimento.Font = new Font("Segoe UI", 10F);
        ConfigurarLabel(lblPeso, "Peso (kg)"); numPeso.Dock = DockStyle.Top; numPeso.DecimalPlaces = 2; numPeso.Maximum = 200; numPeso.Font = new Font("Segoe UI", 10F);
        campos.Controls.Add(lblTutor); campos.Controls.Add(cmbTutor);
        campos.Controls.Add(lblNome); campos.Controls.Add(txtNome);
        campos.Controls.Add(lblEspecie); campos.Controls.Add(cmbEspecie);
        campos.Controls.Add(lblRaca); campos.Controls.Add(txtRaca);
        campos.Controls.Add(lblPorte); campos.Controls.Add(cmbPorte);
        campos.Controls.Add(lblNascimento); campos.Controls.Add(dtpNascimento);
        campos.Controls.Add(lblPeso); campos.Controls.Add(numPeso);
        ClientSize = new Size(504, 610); Name = "FormularioPet"; Text = "Cadastrar pet";
        Controls.Add(campos); Controls.Add(botoes);
        ((System.ComponentModel.ISupportInitialize)numPeso).EndInit();
        campos.ResumeLayout(false); campos.PerformLayout(); botoes.ResumeLayout(false); ResumeLayout(false);
    }

    private void ConfigurarEstrutura()
    {
        campos.AutoScroll = true; campos.ColumnCount = 1; campos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F)); campos.Dock = DockStyle.Fill; campos.Padding = new Padding(22);
        botoes.Controls.Add(btnSalvar); botoes.Controls.Add(btnCancelar); botoes.Dock = DockStyle.Bottom; botoes.FlowDirection = FlowDirection.RightToLeft; botoes.Height = 65; botoes.Padding = new Padding(10);
        btnSalvar.Text = "Salvar"; btnSalvar.Size = new Size(110, 40); btnSalvar.BackColor = Color.FromArgb(255, 128, 0); btnSalvar.ForeColor = Color.White; btnSalvar.FlatStyle = FlatStyle.Flat; btnSalvar.Font = new Font("Segoe UI", 10F, FontStyle.Bold); btnSalvar.DialogResult = DialogResult.OK;
        btnCancelar.Text = "Cancelar"; btnCancelar.Size = new Size(120, 40); btnCancelar.BackColor = Color.White; btnCancelar.ForeColor = Color.FromArgb(255, 128, 0); btnCancelar.FlatStyle = FlatStyle.Flat; btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold); btnCancelar.DialogResult = DialogResult.Cancel;
        AcceptButton = btnSalvar; CancelButton = btnCancelar; AutoScaleMode = AutoScaleMode.Font; BackColor = Color.White; FormBorderStyle = FormBorderStyle.FixedDialog; MaximizeBox = false; MinimizeBox = false; StartPosition = FormStartPosition.CenterParent;
    }

    private static void ConfigurarLabel(Label label, string texto) { label.AutoSize = true; label.Font = new Font("Segoe UI", 9F, FontStyle.Bold); label.Text = texto; }
    private static void ConfigurarTexto(TextBox texto) { texto.Dock = DockStyle.Top; texto.Font = new Font("Segoe UI", 10F); }
    private static void ConfigurarCombo(ComboBox combo) { combo.Dock = DockStyle.Top; combo.DropDownStyle = ComboBoxStyle.DropDownList; combo.Font = new Font("Segoe UI", 10F); }
}
