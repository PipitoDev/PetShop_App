#nullable disable
namespace PetShop_App.Telas.Servicos;

partial class FormularioServico
{
    private System.ComponentModel.IContainer components;
    private TableLayoutPanel campos; private FlowLayoutPanel botoes; private Button btnSalvar; private Button btnCancelar;
    private Label lblNome;
    private TextBox txtNome;
    private Label lblDescricao;
    private TextBox txtDescricao;
    private Label lblValor;
    private NumericUpDown numValor;
    private Label lblDuracao;
    private NumericUpDown numDuracao;
    private CheckBox chkAtivo;

    protected override void Dispose(bool disposing) { if (disposing) components?.Dispose(); base.Dispose(disposing); }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        campos = new TableLayoutPanel(); botoes = new FlowLayoutPanel(); btnSalvar = new Button(); btnCancelar = new Button();
        lblNome = new Label(); txtNome = new TextBox();
        lblDescricao = new Label(); txtDescricao = new TextBox();
        lblValor = new Label(); numValor = new NumericUpDown();
        lblDuracao = new Label(); numDuracao = new NumericUpDown(); chkAtivo = new CheckBox();
        ((System.ComponentModel.ISupportInitialize)numValor).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numDuracao).BeginInit();
        campos.SuspendLayout(); botoes.SuspendLayout(); SuspendLayout(); ConfigurarEstrutura();
        lblNome.AutoSize = true; lblNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold); lblNome.Text = "Nome do serviço *";
        txtNome.Dock = DockStyle.Top; txtNome.Font = new Font("Segoe UI", 10F);
        lblDescricao.AutoSize = true; lblDescricao.Font = new Font("Segoe UI", 9F, FontStyle.Bold); lblDescricao.Text = "Descrição";
        txtDescricao.Dock = DockStyle.Top; txtDescricao.Font = new Font("Segoe UI", 10F);
        lblValor.AutoSize = true; lblValor.Font = new Font("Segoe UI", 9F, FontStyle.Bold); lblValor.Text = "Valor (R$) *";
        numValor.Dock = DockStyle.Top; numValor.DecimalPlaces = 2; numValor.Maximum = 99999; numValor.Font = new Font("Segoe UI", 10F);
        lblDuracao.AutoSize = true; lblDuracao.Font = new Font("Segoe UI", 9F, FontStyle.Bold); lblDuracao.Text = "Duração (minutos) *";
        numDuracao.Dock = DockStyle.Top; numDuracao.Maximum = 1440; numDuracao.Font = new Font("Segoe UI", 10F);
        chkAtivo.AutoSize = true; chkAtivo.Text = "Serviço ativo"; chkAtivo.Font = new Font("Segoe UI", 9F); chkAtivo.Margin = new Padding(0, 12, 0, 0);
        campos.Controls.Add(lblNome); campos.Controls.Add(txtNome);
        campos.Controls.Add(lblDescricao); campos.Controls.Add(txtDescricao);
        campos.Controls.Add(lblValor); campos.Controls.Add(numValor);
        campos.Controls.Add(lblDuracao); campos.Controls.Add(numDuracao);
        campos.Controls.Add(chkAtivo);
        ClientSize = new Size(504, 481); Controls.Add(campos); Controls.Add(botoes); Name = "FormularioServico"; Text = "Cadastrar serviço";
        ((System.ComponentModel.ISupportInitialize)numValor).EndInit();
        ((System.ComponentModel.ISupportInitialize)numDuracao).EndInit();
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
}
