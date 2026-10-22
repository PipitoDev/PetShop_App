using PetShop_App.Componentes;
using PetShop_App.Modelos;

namespace PetShop_App.Telas.Vendas;

/// <summary>Janela modal de inclusão e edição de produtos do estoque.</summary>
public partial class FormularioProduto : Form
{
    private readonly int produtoId;

    /// <summary>Inicializa categoria e estoque mínimo sugeridos para novos produtos.</summary>
    public FormularioProduto()
    {
        InitializeComponent();
        Tema.ArredondarCamposFormulario(this);
        cmbCategoria.SelectedIndex = 0;
        numEstoqueMinimo.Value = 5;
    }

    /// <summary>Preenche os controles quando o produto recebido será editado.</summary>
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

    /// <summary>Normaliza o código e cria o modelo enviado ao repositório.</summary>
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

    /// <summary>Valida os dados comerciais mínimos antes de salvar.</summary>
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
