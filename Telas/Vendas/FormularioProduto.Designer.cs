#nullable disable
namespace PetShop_App.Telas.Vendas;

partial class FormularioProduto
{
    private System.ComponentModel.IContainer components;
    private TableLayoutPanel campos; private FlowLayoutPanel botoes; private Button btnSalvar; private Button btnCancelar;
    private Label lblCodigo; private TextBox txtCodigo;
    private Label lblNome; private TextBox txtNome;
    private Label lblCategoria; private ComboBox cmbCategoria;
    private Label lblPreco; private NumericUpDown numPreco;
    private Label lblEstoque; private NumericUpDown numEstoque;
    private Label lblEstoqueMinimo; private NumericUpDown numEstoqueMinimo;

    protected override void Dispose(bool disposing) { if (disposing) components?.Dispose(); base.Dispose(disposing); }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        campos = new TableLayoutPanel(); botoes = new FlowLayoutPanel(); btnSalvar = new Button(); btnCancelar = new Button();
        lblCodigo = new Label(); txtCodigo = new TextBox(); lblNome = new Label(); txtNome = new TextBox();
        lblCategoria = new Label(); cmbCategoria = new ComboBox(); lblPreco = new Label(); numPreco = new NumericUpDown();
        lblEstoque = new Label(); numEstoque = new NumericUpDown(); lblEstoqueMinimo = new Label(); numEstoqueMinimo = new NumericUpDown();
        ((System.ComponentModel.ISupportInitialize)numPreco).BeginInit(); ((System.ComponentModel.ISupportInitialize)numEstoque).BeginInit(); ((System.ComponentModel.ISupportInitialize)numEstoqueMinimo).BeginInit();
        campos.SuspendLayout(); botoes.SuspendLayout(); SuspendLayout(); ConfigurarEstrutura();
        ConfigurarLabel(lblCodigo, "Código/SKU *"); ConfigurarTexto(txtCodigo); txtCodigo.PlaceholderText = "Ex.: RAC-007";
        ConfigurarLabel(lblNome, "Nome do produto *"); ConfigurarTexto(txtNome); txtNome.PlaceholderText = "Ex.: Ração Premium 10 kg";
        ConfigurarLabel(lblCategoria, "Categoria *"); cmbCategoria.Dock = DockStyle.Top; cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList; cmbCategoria.Font = new Font("Segoe UI", 10F);
        cmbCategoria.Items.AddRange(new object[] { "Rações", "Petiscos", "Higiene", "Brinquedos", "Acessórios", "Medicamentos", "Outros" });
        ConfigurarLabel(lblPreco, "Preço de venda (R$) *"); ConfigurarNumero(numPreco, 999999, 2);
        ConfigurarLabel(lblEstoque, "Quantidade em estoque"); ConfigurarNumero(numEstoque, 99999, 0);
        ConfigurarLabel(lblEstoqueMinimo, "Estoque mínimo"); ConfigurarNumero(numEstoqueMinimo, 99999, 0);
        campos.Controls.Add(lblCodigo); campos.Controls.Add(txtCodigo); campos.Controls.Add(lblNome); campos.Controls.Add(txtNome);
        campos.Controls.Add(lblCategoria); campos.Controls.Add(cmbCategoria); campos.Controls.Add(lblPreco); campos.Controls.Add(numPreco);
        campos.Controls.Add(lblEstoque); campos.Controls.Add(numEstoque); campos.Controls.Add(lblEstoqueMinimo); campos.Controls.Add(numEstoqueMinimo);
        ClientSize = new Size(504, 585); Controls.Add(campos); Controls.Add(botoes); Name = "FormularioProduto"; Text = "Cadastrar produto";
        ((System.ComponentModel.ISupportInitialize)numPreco).EndInit(); ((System.ComponentModel.ISupportInitialize)numEstoque).EndInit(); ((System.ComponentModel.ISupportInitialize)numEstoqueMinimo).EndInit();
        campos.ResumeLayout(false); campos.PerformLayout(); botoes.ResumeLayout(false); ResumeLayout(false);
    }
    private void ConfigurarEstrutura()
    {
        campos.AutoScroll = true; campos.ColumnCount = 1; campos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F)); campos.Dock = DockStyle.Fill; campos.Padding = new Padding(22);
        botoes.Controls.Add(btnSalvar); botoes.Controls.Add(btnCancelar); botoes.Dock = DockStyle.Bottom; botoes.FlowDirection = FlowDirection.RightToLeft; botoes.Height = 65; botoes.Padding = new Padding(10);
        btnSalvar.Text = "Salvar produto"; btnSalvar.Size = new Size(135, 40); btnSalvar.BackColor = Color.FromArgb(255, 128, 0); btnSalvar.ForeColor = Color.White; btnSalvar.FlatStyle = FlatStyle.Flat; btnSalvar.Font = new Font("Segoe UI", 10F, FontStyle.Bold); btnSalvar.DialogResult = DialogResult.OK;
        btnCancelar.Text = "Cancelar"; btnCancelar.Size = new Size(120, 40); btnCancelar.BackColor = Color.White; btnCancelar.ForeColor = Color.FromArgb(255, 128, 0); btnCancelar.FlatStyle = FlatStyle.Flat; btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold); btnCancelar.DialogResult = DialogResult.Cancel;
        AcceptButton = btnSalvar; CancelButton = btnCancelar; AutoScaleMode = AutoScaleMode.Font; BackColor = Color.White; FormBorderStyle = FormBorderStyle.FixedDialog; MaximizeBox = false; MinimizeBox = false; StartPosition = FormStartPosition.CenterParent;
    }
    private static void ConfigurarLabel(Label label, string texto) { label.AutoSize = true; label.Font = new Font("Segoe UI", 9F, FontStyle.Bold); label.Text = texto; }
    private static void ConfigurarTexto(TextBox texto) { texto.Dock = DockStyle.Top; texto.Font = new Font("Segoe UI", 10F); }
    private static void ConfigurarNumero(NumericUpDown numero, decimal maximo, int casas) { numero.Dock = DockStyle.Top; numero.Maximum = maximo; numero.DecimalPlaces = casas; numero.Font = new Font("Segoe UI", 10F); }
}
