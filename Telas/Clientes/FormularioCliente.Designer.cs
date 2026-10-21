#nullable disable
namespace PetShop_App.Telas.Clientes;

partial class FormularioCliente
{
    private System.ComponentModel.IContainer components;
    private TableLayoutPanel campos;
    private FlowLayoutPanel botoes;
    private Button btnSalvar;
    private Button btnCancelar;
    private Label lblNome;
    private TextBox txtNome;
    private Label lblCpf;
    private TextBox txtCpf;
    private Label lblTelefone;
    private TextBox txtTelefone;
    private Label lblEmail;
    private TextBox txtEmail;

    protected override void Dispose(bool disposing)
    {
        if (disposing) components?.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        campos = new TableLayoutPanel();
        lblNome = new Label();
        txtNome = new TextBox();
        lblCpf = new Label();
        txtCpf = new TextBox();
        lblTelefone = new Label();
        txtTelefone = new TextBox();
        lblEmail = new Label();
        txtEmail = new TextBox();
        botoes = new FlowLayoutPanel();
        btnSalvar = new Button();
        btnCancelar = new Button();
        campos.SuspendLayout();
        botoes.SuspendLayout();
        SuspendLayout();
        // 
        // campos
        // 
        campos.AutoScroll = true;
        campos.ColumnCount = 1;
        campos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        campos.Controls.Add(lblNome);
        campos.Controls.Add(txtNome);
        campos.Controls.Add(lblCpf);
        campos.Controls.Add(txtCpf);
        campos.Controls.Add(lblTelefone);
        campos.Controls.Add(txtTelefone);
        campos.Controls.Add(lblEmail);
        campos.Controls.Add(txtEmail);
        campos.Dock = DockStyle.Fill;
        campos.Location = new Point(0, 0);
        campos.Name = "campos";
        campos.Padding = new Padding(22);
        campos.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        campos.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        campos.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
        campos.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
        campos.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
        campos.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
        campos.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
        campos.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
        campos.Size = new Size(504, 376);
        campos.TabIndex = 0;
        // 
        // lblNome
        // 
        lblNome.AutoSize = true;
        lblNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblNome.Location = new Point(25, 22);
        lblNome.Name = "lblNome";
        lblNome.Size = new Size(133, 20);
        lblNome.TabIndex = 0;
        lblNome.Text = "Nome completo *";
        // 
        // txtNome
        // 
        txtNome.Dock = DockStyle.Top;
        txtNome.Font = new Font("Segoe UI", 10F);
        txtNome.Location = new Point(25, 45);
        txtNome.MaxLength = 150;
        txtNome.Name = "txtNome";
        txtNome.Size = new Size(454, 30);
        txtNome.TabIndex = 1;
        // 
        // lblCpf
        // 
        lblCpf.AutoSize = true;
        lblCpf.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblCpf.Location = new Point(25, 82);
        lblCpf.Name = "lblCpf";
        lblCpf.Size = new Size(35, 20);
        lblCpf.TabIndex = 2;
        lblCpf.Text = "CPF";
        // 
        // txtCpf
        // 
        txtCpf.Dock = DockStyle.Top;
        txtCpf.Font = new Font("Segoe UI", 10F);
        txtCpf.Location = new Point(25, 106);
        txtCpf.MaxLength = 14;
        txtCpf.Name = "txtCpf";
        txtCpf.Size = new Size(454, 30);
        txtCpf.TabIndex = 3;
        // 
        // lblTelefone
        // 
        lblTelefone.AutoSize = true;
        lblTelefone.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblTelefone.Location = new Point(25, 140);
        lblTelefone.Name = "lblTelefone";
        lblTelefone.Size = new Size(69, 20);
        lblTelefone.TabIndex = 4;
        lblTelefone.Text = "Telefone";
        // 
        // txtTelefone
        // 
        txtTelefone.Dock = DockStyle.Top;
        txtTelefone.Font = new Font("Segoe UI", 10F);
        txtTelefone.Location = new Point(25, 166);
        txtTelefone.MaxLength = 20;
        txtTelefone.Name = "txtTelefone";
        txtTelefone.Size = new Size(454, 30);
        txtTelefone.TabIndex = 5;
        // 
        // lblEmail
        // 
        lblEmail.AutoSize = true;
        lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblEmail.Location = new Point(25, 205);
        lblEmail.Name = "lblEmail";
        lblEmail.Size = new Size(53, 20);
        lblEmail.TabIndex = 6;
        lblEmail.Text = "E-mail";
        // 
        // txtEmail
        // 
        txtEmail.Dock = DockStyle.Top;
        txtEmail.Font = new Font("Segoe UI", 10F);
        txtEmail.Location = new Point(25, 234);
        txtEmail.MaxLength = 150;
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(454, 30);
        txtEmail.TabIndex = 7;
        // 
        // botoes
        // 
        botoes.Controls.Add(btnSalvar);
        botoes.Controls.Add(btnCancelar);
        botoes.Dock = DockStyle.Bottom;
        botoes.FlowDirection = FlowDirection.RightToLeft;
        botoes.Location = new Point(0, 376);
        botoes.Name = "botoes";
        botoes.Padding = new Padding(10);
        botoes.Size = new Size(504, 65);
        botoes.TabIndex = 1;
        // 
        // btnSalvar
        // 
        btnSalvar.BackColor = Color.FromArgb(255, 128, 0);
        btnSalvar.DialogResult = DialogResult.OK;
        btnSalvar.FlatStyle = FlatStyle.Flat;
        btnSalvar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnSalvar.ForeColor = Color.White;
        btnSalvar.Location = new Point(371, 13);
        btnSalvar.Name = "btnSalvar";
        btnSalvar.Size = new Size(110, 40);
        btnSalvar.TabIndex = 0;
        btnSalvar.Text = "Salvar";
        btnSalvar.UseVisualStyleBackColor = false;
        // 
        // btnCancelar
        // 
        btnCancelar.BackColor = Color.White;
        btnCancelar.DialogResult = DialogResult.Cancel;
        btnCancelar.FlatStyle = FlatStyle.Flat;
        btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnCancelar.ForeColor = Color.FromArgb(255, 128, 0);
        btnCancelar.Location = new Point(245, 13);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(120, 40);
        btnCancelar.TabIndex = 1;
        btnCancelar.Text = "Cancelar";
        btnCancelar.UseVisualStyleBackColor = false;
        // 
        // FormularioCliente
        // 
        AcceptButton = btnSalvar;
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        CancelButton = btnCancelar;
        ClientSize = new Size(504, 441);
        Controls.Add(campos);
        Controls.Add(botoes);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "FormularioCliente";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Cadastrar cliente";
        campos.ResumeLayout(false);
        campos.PerformLayout();
        botoes.ResumeLayout(false);
        ResumeLayout(false);
    }
}
