#nullable disable
namespace PetShop_App.Telas.Vendas
{
    partial class PaginaEstoque
    {
        private Button btnEditarRegistro;

        private Button btnExcluirRegistro;

        private DataGridViewTextBoxColumn gradeEstoqueColId;

private DataGridViewTextBoxColumn gradeEstoqueColCodigo;

private DataGridViewTextBoxColumn gradeEstoqueColNome;

private DataGridViewTextBoxColumn gradeEstoqueColCategoria;

private DataGridViewTextBoxColumn gradeEstoqueColPreco;

private DataGridViewTextBoxColumn gradeEstoqueColEstoque;

private DataGridViewTextBoxColumn gradeEstoqueColMinimo;

private DataGridViewTextBoxColumn gradeEstoqueColSituacao;

private System.ComponentModel.IContainer components;

protected override void Dispose(bool disposing)
{
    if (disposing && components != null) components.Dispose();

    base.Dispose(disposing);

}
private void InitializeComponent()
        {
components = new System.ComponentModel.Container();

            lblTitulo = new Label();

lblTitulo.Name = "lblTitulo";

            lblResumo = new Label();

lblResumo.Name = "lblResumo";

            txtPesquisa = new TextBox();

txtPesquisa.Name = "txtPesquisa";

            btnNovoProduto = new Button();

            gradeEstoque = new DataGridView();

gradeEstoque.Name = "gradeEstoque";

gradeEstoqueColId = new DataGridViewTextBoxColumn();

gradeEstoqueColId.Name = "Id";

gradeEstoqueColId.DataPropertyName = "Id";

gradeEstoqueColId.HeaderText = "Id";

gradeEstoqueColId.Visible = false;

gradeEstoqueColCodigo = new DataGridViewTextBoxColumn();

gradeEstoqueColCodigo.Name = "Codigo";

gradeEstoqueColCodigo.DataPropertyName = "Codigo";

gradeEstoqueColCodigo.HeaderText = "Codigo";

gradeEstoqueColNome = new DataGridViewTextBoxColumn();

gradeEstoqueColNome.Name = "Nome";

gradeEstoqueColNome.DataPropertyName = "Nome";

gradeEstoqueColNome.HeaderText = "Nome";

gradeEstoqueColCategoria = new DataGridViewTextBoxColumn();

gradeEstoqueColCategoria.Name = "Categoria";

gradeEstoqueColCategoria.DataPropertyName = "Categoria";

gradeEstoqueColCategoria.HeaderText = "Categoria";

gradeEstoqueColPreco = new DataGridViewTextBoxColumn();

gradeEstoqueColPreco.Name = "Preço";

gradeEstoqueColPreco.DataPropertyName = "Preço";

gradeEstoqueColPreco.HeaderText = "Preço";

gradeEstoqueColEstoque = new DataGridViewTextBoxColumn();

gradeEstoqueColEstoque.Name = "Estoque";

gradeEstoqueColEstoque.DataPropertyName = "Estoque";

gradeEstoqueColEstoque.HeaderText = "Estoque";

gradeEstoqueColMinimo = new DataGridViewTextBoxColumn();

gradeEstoqueColMinimo.Name = "Mínimo";

gradeEstoqueColMinimo.DataPropertyName = "Mínimo";

gradeEstoqueColMinimo.HeaderText = "Mínimo";

gradeEstoqueColSituacao = new DataGridViewTextBoxColumn();

gradeEstoqueColSituacao.Name = "Situação";

gradeEstoqueColSituacao.DataPropertyName = "Situação";

gradeEstoqueColSituacao.HeaderText = "Situação";

gradeEstoque.AutoGenerateColumns = false;

gradeEstoque.Columns.AddRange(new DataGridViewColumn[] { gradeEstoqueColId, gradeEstoqueColCodigo, gradeEstoqueColNome, gradeEstoqueColCategoria, gradeEstoqueColPreco, gradeEstoqueColEstoque, gradeEstoqueColMinimo, gradeEstoqueColSituacao });

            btnEditarRegistro = new Button();
 btnEditarRegistro.Name = "btnEditarRegistro";
 btnEditarRegistro.Text = "Editar";
 btnEditarRegistro.Size = new Size(90, 40);
 btnEditarRegistro.Location = new Point(599, 8);
 btnEditarRegistro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
 btnEditarRegistro.BackColor = Color.White;
 btnEditarRegistro.ForeColor = Color.FromArgb(255, 128, 0);
 btnEditarRegistro.FlatStyle = FlatStyle.Flat;
 this.Controls.Add(btnEditarRegistro);

            btnExcluirRegistro = new Button();
 btnExcluirRegistro.Name = "btnExcluirRegistro";
 btnExcluirRegistro.Text = "Remover";
 btnExcluirRegistro.Size = new Size(105, 40);
 btnExcluirRegistro.Location = new Point(697, 8);
 btnExcluirRegistro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
 btnExcluirRegistro.BackColor = Color.White;
 btnExcluirRegistro.ForeColor = Color.FromArgb(255, 128, 0);
 btnExcluirRegistro.FlatStyle = FlatStyle.Flat;
 this.Controls.Add(btnExcluirRegistro);

            ((System.ComponentModel.ISupportInitialize)gradeEstoque).BeginInit();

            SuspendLayout();


            lblTitulo.AutoSize = true;

            lblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);

            lblTitulo.Location = new Point(0, 4);

            lblTitulo.Text = "Estoque";


            lblResumo.AutoSize = true;

            lblResumo.ForeColor = Color.FromArgb(100, 116, 139);

            lblResumo.Location = new Point(0, 48);

            lblResumo.Text = "Produtos e alertas de reposição";


            txtPesquisa.Location = new Point(0, 82);

            txtPesquisa.PlaceholderText = "Código ou nome do produto";

            txtPesquisa.Size = new Size(420, 23);


            btnNovoProduto.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            btnNovoProduto.BackColor = Color.FromArgb(255, 128, 0);

            btnNovoProduto.Cursor = Cursors.Hand;

            btnNovoProduto.FlatAppearance.BorderSize = 0;

            btnNovoProduto.FlatStyle = FlatStyle.Flat;

            btnNovoProduto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            btnNovoProduto.ForeColor = Color.White;

            btnNovoProduto.Location = new Point(810, 8);

            btnNovoProduto.Name = "btnNovoProduto";

            btnNovoProduto.Size = new Size(170, 40);

            btnNovoProduto.Text = "+ Cadastrar produto";

            btnNovoProduto.UseVisualStyleBackColor = false;


            gradeEstoque.AllowUserToAddRows = false;

            gradeEstoque.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            gradeEstoque.BackgroundColor = Color.White;

            gradeEstoque.BorderStyle = BorderStyle.None;

            gradeEstoque.Location = new Point(0, 125);

            gradeEstoque.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            gradeEstoque.Size = new Size(1000, 575);

            gradeEstoque.ReadOnly = true;

            gradeEstoque.RowHeadersVisible = false;


            BackColor = Color.FromArgb(241, 245, 249);

            Controls.AddRange(new Control[] { lblTitulo, lblResumo, txtPesquisa, btnNovoProduto, gradeEstoque });

            Name = "PaginaEstoque";

            Size = new Size(1000, 700);

            ((System.ComponentModel.ISupportInitialize)gradeEstoque).EndInit();

            ResumeLayout(false);

            PerformLayout();

        }
        private Label lblTitulo, lblResumo;

        private TextBox txtPesquisa;

        private Button btnNovoProduto;

        private DataGridView gradeEstoque;


    }

}
