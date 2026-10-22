#nullable disable
namespace PetShop_App.Telas.Servicos;

partial class FormularioServico
{
    private System.ComponentModel.IContainer components = null;
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
        campos = new TableLayoutPanel();
        lblNome = new Label();
        txtNome = new TextBox();
        lblDescricao = new Label();
        txtDescricao = new TextBox();
        lblValor = new Label();
        numValor = new NumericUpDown();
        lblDuracao = new Label();
        numDuracao = new NumericUpDown();
        chkAtivo = new CheckBox();
        botoes = new FlowLayoutPanel();
        btnSalvar = new Button();
        btnCancelar = new Button();
        campos.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numValor).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numDuracao).BeginInit();
        botoes.SuspendLayout();
        SuspendLayout();
        // 
        // campos
        // 
        campos.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        campos.Controls.Add(lblNome, 0, 1);
        campos.Controls.Add(txtNome, 0, 2);
        campos.Controls.Add(lblDescricao, 0, 3);
        campos.Controls.Add(txtDescricao, 0, 4);
        campos.Controls.Add(lblValor, 0, 5);
        campos.Controls.Add(numValor, 0, 6);
        campos.Controls.Add(lblDuracao, 0, 7);
        campos.Controls.Add(numDuracao, 0, 8);
        campos.Controls.Add(chkAtivo, 0, 9);
        campos.Dock = DockStyle.Fill;
        campos.Location = new Point(0, 0);
        campos.Name = "campos";
        campos.RowCount = 1;
        campos.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
        campos.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
        campos.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
        campos.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
        campos.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
        campos.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
        campos.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
        campos.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
        campos.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        campos.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
        campos.Size = new Size(504, 416);
        campos.TabIndex = 0;
        // 
        // lblNome
        // 
        lblNome.AutoSize = true;
        lblNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblNome.Location = new Point(3, 36);
        lblNome.Name = "lblNome";
        lblNome.Size = new Size(139, 20);
        lblNome.TabIndex = 0;
        lblNome.Text = "Nome do serviço *";
        // 
        // txtNome
        // 
        txtNome.Dock = DockStyle.Top;
        txtNome.Font = new Font("Segoe UI", 10F);
        txtNome.Location = new Point(3, 67);
        txtNome.Name = "txtNome";
        txtNome.PlaceholderText = "Ex.: Banho e tosa";
        txtNome.Size = new Size(498, 30);
        txtNome.TabIndex = 1;
        // 
        // lblDescricao
        // 
        lblDescricao.AutoSize = true;
        lblDescricao.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblDescricao.Location = new Point(3, 108);
        lblDescricao.Name = "lblDescricao";
        lblDescricao.Size = new Size(76, 20);
        lblDescricao.TabIndex = 2;
        lblDescricao.Text = "Descrição";
        // 
        // txtDescricao
        // 
        txtDescricao.Dock = DockStyle.Top;
        txtDescricao.Font = new Font("Segoe UI", 10F);
        txtDescricao.Location = new Point(3, 144);
        txtDescricao.Name = "txtDescricao";
        txtDescricao.PlaceholderText = "Descreva o serviço";
        txtDescricao.Size = new Size(498, 30);
        txtDescricao.TabIndex = 3;
        // 
        // lblValor
        // 
        lblValor.AutoSize = true;
        lblValor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblValor.Location = new Point(3, 182);
        lblValor.Name = "lblValor";
        lblValor.Size = new Size(91, 20);
        lblValor.TabIndex = 4;
        lblValor.Text = "Valor (R$) *";
        // 
        // numValor
        // 
        numValor.DecimalPlaces = 2;
        numValor.Dock = DockStyle.Top;
        numValor.Font = new Font("Segoe UI", 10F);
        numValor.Location = new Point(3, 210);
        numValor.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
        numValor.Name = "numValor";
        numValor.Size = new Size(498, 30);
        numValor.TabIndex = 5;
        // 
        // lblDuracao
        // 
        lblDuracao.AutoSize = true;
        lblDuracao.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblDuracao.Location = new Point(3, 245);
        lblDuracao.Name = "lblDuracao";
        lblDuracao.Size = new Size(152, 20);
        lblDuracao.TabIndex = 6;
        lblDuracao.Text = "Duração (minutos) *";
        // 
        // numDuracao
        // 
        numDuracao.Dock = DockStyle.Top;
        numDuracao.Font = new Font("Segoe UI", 10F);
        numDuracao.Location = new Point(3, 273);
        numDuracao.Maximum = new decimal(new int[] { 1440, 0, 0, 0 });
        numDuracao.Name = "numDuracao";
        numDuracao.Size = new Size(498, 30);
        numDuracao.TabIndex = 7;
        // 
        // chkAtivo
        // 
        chkAtivo.AutoSize = true;
        chkAtivo.Font = new Font("Segoe UI", 9F);
        chkAtivo.Location = new Point(0, 322);
        chkAtivo.Margin = new Padding(0, 12, 0, 0);
        chkAtivo.Name = "chkAtivo";
        chkAtivo.Size = new Size(116, 24);
        chkAtivo.TabIndex = 8;
        chkAtivo.Text = "Serviço ativo";
        // 
        // botoes
        // 
        botoes.Controls.Add(btnSalvar);
        botoes.Controls.Add(btnCancelar);
        botoes.Dock = DockStyle.Bottom;
        botoes.FlowDirection = FlowDirection.RightToLeft;
        botoes.Location = new Point(0, 416);
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
        btnSalvar.Location = new Point(351, 13);
        btnSalvar.Name = "btnSalvar";
        btnSalvar.Size = new Size(130, 40);
        btnSalvar.TabIndex = 0;
        btnSalvar.Text = "Salvar serviço";
        btnSalvar.UseVisualStyleBackColor = false;
        // 
        // btnCancelar
        // 
        btnCancelar.BackColor = Color.White;
        btnCancelar.DialogResult = DialogResult.Cancel;
        btnCancelar.FlatStyle = FlatStyle.Flat;
        btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnCancelar.ForeColor = Color.FromArgb(255, 128, 0);
        btnCancelar.Location = new Point(225, 13);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(120, 40);
        btnCancelar.TabIndex = 1;
        btnCancelar.Text = "Cancelar";
        btnCancelar.UseVisualStyleBackColor = false;
        // 
        // FormularioServico
        // 
        AcceptButton = btnSalvar;
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        CancelButton = btnCancelar;
        ClientSize = new Size(504, 481);
        Controls.Add(campos);
        Controls.Add(botoes);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "FormularioServico";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Cadastrar serviço";
        campos.ResumeLayout(false);
        campos.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numValor).EndInit();
        ((System.ComponentModel.ISupportInitialize)numDuracao).EndInit();
        botoes.ResumeLayout(false);
        ResumeLayout(false);
    }

    private void ConfigurarEstrutura()
    {
        campos.AutoScroll = true;
        campos.ColumnCount = 1;
        campos.ColumnStyles.Clear();
        campos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        campos.RowCount = 9;
        campos.RowStyles.Clear();
        for (var indice = 0; indice < campos.RowCount; indice++)
            campos.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        campos.Dock = DockStyle.Fill;
        campos.Padding = new Padding(22);
    }
}
