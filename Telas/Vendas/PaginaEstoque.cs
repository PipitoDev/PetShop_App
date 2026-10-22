using MySqlConnector;
using PetShop_App.Componentes;
using PetShop_App.Dados;

namespace PetShop_App.Telas.Vendas;

/// <summary>Página CRUD de produtos e acompanhamento de estoque mínimo.</summary>
public partial class PaginaEstoque : UserControl
{
    private readonly RepositorioPetShop repositorio = new();

    public PaginaEstoque()
    {
        InitializeComponent();
        if (AmbienteDesign.EstaAtivo(this)) return;

        Load += async (_, _) => await CarregarAsync();
        txtPesquisa.TextChanged += async (_, _) => await CarregarAsync();
        btnNovoProduto.Click += async (_, _) => await CadastrarAsync();
        btnEditarRegistro.Click += async (_, _) => await EditarAsync();
        btnExcluirRegistro.Click += async (_, _) => await ExcluirAsync();
    }

    /// <summary>Consulta produtos, atualiza a grade e recalcula o resumo de estoque.</summary>
    private async Task CarregarAsync()
    {
        try
        {
            var produtos = await repositorio.ListarProdutosAsync(txtPesquisa.Text);
            gradeEstoque.DataSource = produtos.Select(produto => new
            {
                produto.Id,
                produto.Codigo,
                produto.Nome,
                produto.Categoria,
                Preço = produto.Preco.ToString("C"),
                produto.Estoque,
                Mínimo = produto.EstoqueMinimo,
                Situação = produto.Estoque <= produto.EstoqueMinimo ? "Estoque baixo" : "Normal"
            }).ToList();

            if (gradeEstoque.Columns["Id"] is { } colunaId)
                colunaId.Visible = false;

            var quantidadeBaixa = produtos.Count(produto => produto.Estoque <= produto.EstoqueMinimo);
            lblResumo.Text = $"{produtos.Count} produtos · {quantidadeBaixa} com estoque baixo";
        }
        catch (Exception erro)
        {
            MessageBox.Show(this, $"Não foi possível carregar o estoque.\n\n{erro.Message}", "Estoque");
        }
    }

    /// <summary>Abre o formulário e trata especificamente códigos duplicados.</summary>
    private async Task CadastrarAsync()
    {
        using var formulario = new FormularioProduto(null);
        if (formulario.ShowDialog(this) != DialogResult.OK) return;

        try
        {
            await repositorio.SalvarProdutoAsync(formulario.Produto);
            txtPesquisa.Clear();
            await CarregarAsync();
        }
        catch (MySqlException erro) when (erro.Number == 1062)
        {
            MessageBox.Show(this, "Já existe um produto com esse código.", "Código duplicado");
        }
    }

    /// <summary>Carrega e atualiza o produto selecionado.</summary>
    private async Task EditarAsync()
    {
        var produtoId = ObterIdSelecionado();
        if (produtoId is null) return;

        var produto = (await repositorio.ListarProdutosAsync()).First(item => item.Id == produtoId);
        using var formulario = new FormularioProduto(produto);
        if (formulario.ShowDialog(this) != DialogResult.OK) return;

        await repositorio.AtualizarProdutoAsync(formulario.Produto);
        await CarregarAsync();
    }

    /// <summary>Remove o produto se ele ainda não estiver vinculado a vendas.</summary>
    private async Task ExcluirAsync()
    {
        var produtoId = ObterIdSelecionado();
        if (produtoId is null || !BotoesCrud.Confirmar("o produto selecionado")) return;

        try
        {
            await repositorio.ExcluirProdutoAsync(produtoId.Value);
            await CarregarAsync();
        }
        catch (MySqlException erro) when (erro.Number == 1451)
        {
            MessageBox.Show(this, "Este produto possui vendas vinculadas e não pode ser removido.", "Produto vinculado");
        }
    }

    /// <summary>Obtém o ID oculto da linha atual.</summary>
    private int? ObterIdSelecionado()
    {
        if (gradeEstoque.CurrentRow?.Cells["Id"].Value is int id) return id;
        MessageBox.Show(this, "Selecione um produto na lista.", "Estoque");
        return null;
    }
}
