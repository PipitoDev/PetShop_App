#nullable disable
namespace PetShop_App.Telas.Agendamentos;

partial class FormularioAtendimento
{
    private System.ComponentModel.IContainer components;
    private TableLayoutPanel campos; private FlowLayoutPanel botoes; private Button btnSalvar; private Button btnCancelar;
    private Label lblPet;
    private ComboBox cmbPet;
    private Label lblServico;
    private ComboBox cmbServico;
    private Label lblDataHora;
    private DateTimePicker dtpDataHora;
    private Label lblStatus;
    private ComboBox cmbStatus;
    private Label lblObservacoes;
    private TextBox txtObservacoes;

    protected override void Dispose(bool disposing) { if (disposing) components?.Dispose(); base.Dispose(disposing); }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        campos = new TableLayoutPanel(); botoes = new FlowLayoutPanel(); btnSalvar = new Button(); btnCancelar = new Button();
        lblPet = new Label(); cmbPet = new ComboBox();
        lblServico = new Label(); cmbServico = new ComboBox();
        lblDataHora = new Label(); dtpDataHora = new DateTimePicker();
        lblStatus = new Label(); cmbStatus = new ComboBox();
        lblObservacoes = new Label(); txtObservacoes = new TextBox();
        campos.SuspendLayout(); botoes.SuspendLayout(); SuspendLayout(); ConfigurarEstrutura();
        ConfigurarLabel(lblPet, "Pet *"); ConfigurarCombo(cmbPet);
        ConfigurarLabel(lblServico, "Serviço *"); ConfigurarCombo(cmbServico);
        ConfigurarLabel(lblDataHora, "Data e horário *");
        dtpDataHora.Dock = DockStyle.Top; dtpDataHora.Font = new Font("Segoe UI", 10F); dtpDataHora.Format = DateTimePickerFormat.Custom; dtpDataHora.CustomFormat = "dd/MM/yyyy HH:mm";
        ConfigurarLabel(lblStatus, "Status"); ConfigurarCombo(cmbStatus);
        cmbStatus.Items.AddRange(new object[] { "Agendado", "Confirmado", "Em atendimento", "Concluído", "Cancelado" });
        ConfigurarLabel(lblObservacoes, "Observações");
        txtObservacoes.Dock = DockStyle.Top; txtObservacoes.Font = new Font("Segoe UI", 10F); txtObservacoes.Multiline = true; txtObservacoes.Height = 70;
        campos.Controls.Add(lblPet); campos.Controls.Add(cmbPet);
        campos.Controls.Add(lblServico); campos.Controls.Add(cmbServico);
        campos.Controls.Add(lblDataHora); campos.Controls.Add(dtpDataHora);
        campos.Controls.Add(lblStatus); campos.Controls.Add(cmbStatus);
        campos.Controls.Add(lblObservacoes); campos.Controls.Add(txtObservacoes);
        ClientSize = new Size(576, 550); Controls.Add(campos); Controls.Add(botoes); Name = "FormularioAtendimento"; Text = "Agendar atendimento";
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
    private static void ConfigurarCombo(ComboBox combo) { combo.Dock = DockStyle.Top; combo.DropDownStyle = ComboBoxStyle.DropDownList; combo.Font = new Font("Segoe UI", 10F); }
}
