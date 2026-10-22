#nullable disable
namespace PetShop_App.Telas.Pets;

partial class FormularioPet
{
    private System.ComponentModel.IContainer components = null;
    private TableLayoutPanel campos;
    private FlowLayoutPanel botoes;
    private Button btnSalvar;
    private Button btnCancelar;
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
        campos = new TableLayoutPanel();
        lblTutor = new Label();
        cmbTutor = new ComboBox();
        lblNome = new Label();
        txtNome = new TextBox();
        lblEspecie = new Label();
        cmbEspecie = new ComboBox();
        lblRaca = new Label();
        txtRaca = new TextBox();
        lblPorte = new Label();
        cmbPorte = new ComboBox();
        lblNascimento = new Label();
        dtpNascimento = new DateTimePicker();
        lblPeso = new Label();
        numPeso = new NumericUpDown();
        botoes = new FlowLayoutPanel();
        btnSalvar = new Button();
        btnCancelar = new Button();
        campos.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numPeso).BeginInit();
        botoes.SuspendLayout();
        SuspendLayout();
        // 
        // campos
        // 
        campos.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        campos.Controls.Add(lblTutor);
        campos.Controls.Add(cmbTutor);
        campos.Controls.Add(lblNome);
        campos.Controls.Add(txtNome);
        campos.Controls.Add(lblEspecie);
        campos.Controls.Add(cmbEspecie);
        campos.Controls.Add(lblRaca);
        campos.Controls.Add(txtRaca);
        campos.Controls.Add(lblPorte);
        campos.Controls.Add(cmbPorte);
        campos.Controls.Add(lblNascimento);
        campos.Controls.Add(dtpNascimento);
        campos.Controls.Add(lblPeso);
        campos.Controls.Add(numPeso);
        campos.Location = new Point(0, 12);
        campos.Name = "campos";
        campos.RowCount = 3;
        campos.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
        campos.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        campos.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
        campos.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
        campos.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
        campos.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
        campos.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
        campos.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
        campos.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
        campos.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
        campos.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
        campos.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
        campos.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
        campos.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        campos.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
        campos.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
        campos.Size = new Size(504, 538);
        campos.TabIndex = 0;
        // 
        // lblTutor
        // 
        lblTutor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblTutor.Location = new Point(3, 0);
        lblTutor.Name = "lblTutor";
        lblTutor.Size = new Size(100, 20);
        lblTutor.TabIndex = 0;
        lblTutor.Text = "Tutor *";
        // 
        // cmbTutor
        // 
        cmbTutor.Dock = DockStyle.Top;
        cmbTutor.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbTutor.Location = new Point(3, 31);
        cmbTutor.Name = "cmbTutor";
        cmbTutor.Size = new Size(498, 28);
        cmbTutor.TabIndex = 1;
        // 
        // lblNome
        // 
        lblNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblNome.Location = new Point(3, 68);
        lblNome.Name = "lblNome";
        lblNome.Size = new Size(124, 20);
        lblNome.TabIndex = 2;
        lblNome.Text = "Nome do pet *";
        // 
        // txtNome
        // 
        txtNome.Dock = DockStyle.Top;
        txtNome.Location = new Point(3, 96);
        txtNome.Name = "txtNome";
        txtNome.PlaceholderText = "Ex.: Luna";
        txtNome.Size = new Size(498, 27);
        txtNome.TabIndex = 3;
        // 
        // lblEspecie
        // 
        lblEspecie.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblEspecie.Location = new Point(3, 132);
        lblEspecie.Name = "lblEspecie";
        lblEspecie.Size = new Size(100, 23);
        lblEspecie.TabIndex = 4;
        lblEspecie.Text = "Espécie *";
        // 
        // cmbEspecie
        // 
        cmbEspecie.Dock = DockStyle.Top;
        cmbEspecie.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbEspecie.Items.AddRange(new object[] { "Cão", "Gato", "Ave", "Outro" });
        cmbEspecie.Location = new Point(3, 161);
        cmbEspecie.Name = "cmbEspecie";
        cmbEspecie.Size = new Size(498, 28);
        cmbEspecie.TabIndex = 5;
        // 
        // lblRaca
        // 
        lblRaca.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblRaca.Location = new Point(3, 193);
        lblRaca.Name = "lblRaca";
        lblRaca.Size = new Size(100, 20);
        lblRaca.TabIndex = 6;
        lblRaca.Text = "Raça";
        // 
        // txtRaca
        // 
        txtRaca.Dock = DockStyle.Top;
        txtRaca.Location = new Point(3, 223);
        txtRaca.Name = "txtRaca";
        txtRaca.PlaceholderText = "Ex.: Golden Retriever";
        txtRaca.Size = new Size(498, 27);
        txtRaca.TabIndex = 7;
        // 
        // lblPorte
        // 
        lblPorte.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblPorte.Location = new Point(3, 261);
        lblPorte.Name = "lblPorte";
        lblPorte.Size = new Size(100, 20);
        lblPorte.TabIndex = 8;
        lblPorte.Text = "Porte";
        // 
        // cmbPorte
        // 
        cmbPorte.Dock = DockStyle.Top;
        cmbPorte.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbPorte.Items.AddRange(new object[] { "Pequeno", "Médio", "Grande" });
        cmbPorte.Location = new Point(3, 287);
        cmbPorte.Name = "cmbPorte";
        cmbPorte.Size = new Size(498, 28);
        cmbPorte.TabIndex = 9;
        // 
        // lblNascimento
        // 
        lblNascimento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblNascimento.Location = new Point(3, 329);
        lblNascimento.Name = "lblNascimento";
        lblNascimento.Size = new Size(100, 24);
        lblNascimento.TabIndex = 10;
        lblNascimento.Text = "Nascimento";
        // 
        // dtpNascimento
        // 
        dtpNascimento.Dock = DockStyle.Top;
        dtpNascimento.Font = new Font("Segoe UI", 10F);
        dtpNascimento.Format = DateTimePickerFormat.Short;
        dtpNascimento.Location = new Point(3, 361);
        dtpNascimento.Name = "dtpNascimento";
        dtpNascimento.Size = new Size(498, 30);
        dtpNascimento.TabIndex = 11;
        // 
        // lblPeso
        // 
        lblPeso.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblPeso.Location = new Point(3, 405);
        lblPeso.Name = "lblPeso";
        lblPeso.Size = new Size(100, 20);
        lblPeso.TabIndex = 12;
        lblPeso.Text = "Peso (kg)";
        // 
        // numPeso
        // 
        numPeso.DecimalPlaces = 2;
        numPeso.Dock = DockStyle.Top;
        numPeso.Font = new Font("Segoe UI", 10F);
        numPeso.Location = new Point(3, 441);
        numPeso.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
        numPeso.Name = "numPeso";
        numPeso.Size = new Size(498, 30);
        numPeso.TabIndex = 13;
        // 
        // botoes
        // 
        botoes.Controls.Add(btnSalvar);
        botoes.Controls.Add(btnCancelar);
        botoes.Dock = DockStyle.Bottom;
        botoes.FlowDirection = FlowDirection.RightToLeft;
        botoes.Location = new Point(0, 538);
        botoes.Name = "botoes";
        botoes.Padding = new Padding(12);
        botoes.Size = new Size(504, 72);
        botoes.TabIndex = 1;
        // 
        // btnSalvar
        // 
        btnSalvar.DialogResult = DialogResult.OK;
        btnSalvar.Location = new Point(357, 15);
        btnSalvar.Name = "btnSalvar";
        btnSalvar.Size = new Size(120, 40);
        btnSalvar.TabIndex = 0;
        btnSalvar.Text = "Salvar pet";
        // 
        // btnCancelar
        // 
        btnCancelar.DialogResult = DialogResult.Cancel;
        btnCancelar.Location = new Point(259, 15);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(92, 40);
        btnCancelar.TabIndex = 1;
        btnCancelar.Text = "Cancelar";
        // 
        // FormularioPet
        // 
        AcceptButton = btnSalvar;
        CancelButton = btnCancelar;
        ClientSize = new Size(504, 610);
        Controls.Add(campos);
        Controls.Add(botoes);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "FormularioPet";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Cadastrar pet";
        campos.ResumeLayout(false);
        campos.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numPeso).EndInit();
        botoes.ResumeLayout(false);
        ResumeLayout(false);
    }
}
