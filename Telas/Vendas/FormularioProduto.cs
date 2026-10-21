using PetShop_App.Modelos;

namespace PetShop_App.Telas.Vendas;

public partial class FormularioProduto : Form
{
    private readonly int produtoId;

    public FormularioProduto()
    {
        InitializeComponent();
        cmbCategoria.SelectedIndex = 0;
        numEstoqueMinimo.Value = 5;
    }

    public FormularioProduto(Produto? produto) : this()
    {
        produtoId = produto?.Id ?? 0;
        Text = produto is null ? "Cadastrar produto" : "Editar produto";
        if (produto is null) return;
        txtCodigo.Text = produto.Codigo;
        txtNome.Text = produto.Nome;
        if (cmbCategoria.Items.Contains(produto.Categoria)) cmbCategoria.Text = produto.Categoria;
        else cmbCategoria.Items.Add(produto.Categoria);
        cmbCategoria.Text = produto.Categoria;
        numPreco.Value = Math.Clamp(produto.Preco, numPreco.Minimum, numPreco.Maximum);
        numEstoque.Value = Math.Clamp(produto.Estoque, (int)numEstoque.Minimum, (int)numEstoque.Maximum);
        numEstoqueMinimo.Value = Math.Clamp(produto.EstoqueMinimo, (int)numEstoqueMinimo.Minimum, (int)numEstoqueMinimo.Maximum);
    }

    public Produto Produto => new()
    {
        Id = produtoId,
        Codigo = txtCodigo.Text.Trim().ToUpperInvariant(),
        Nome = txtNome.Text.Trim(),
        Categoria = cmbCategoria.Text,
        Preco = numPreco.Value,
        Estoque = (int)numEstoque.Value,
        EstoqueMinimo = (int)numEstoqueMinimo.Value
    };

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        if (DialogResult == DialogResult.OK &&
            (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
             string.IsNullOrWhiteSpace(txtNome.Text) || numPreco.Value <= 0))
        {
            e.Cancel = true;
            MessageBox.Show(this, "Informe código, nome e preço do produto.", "Campos obrigatórios");
        }
        base.OnFormClosing(e);
    }
}
