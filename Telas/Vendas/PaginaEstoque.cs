using PetShop_App.Dados;
namespace PetShop_App.Telas.Vendas
{

public partial class PaginaEstoque : UserControl
{
    public PaginaEstoque() { InitializeComponent(); if (PetShop_App.Componentes.AmbienteDesign.EstaAtivo(this)) return; Load += async (_, _) => await CarregarAsync(); txtPesquisa.TextChanged += async (_, _) => await CarregarAsync(); btnNovoProduto.Click += async (_, _) => await NovoProdutoAsync(); btnEditarRegistro.Click += async (_, _) => await EditarAsync(); btnExcluirRegistro.Click += async (_, _) => await ExcluirAsync(); }
    private async Task CarregarAsync() { if (PetShop_App.Componentes.AmbienteDesign.EstaAtivo(this)) return; try { var itens = await new RepositorioPetShop().ListarProdutosAsync(txtPesquisa.Text); gradeEstoque.DataSource = itens.Select(x => new { x.Id, x.Codigo, x.Nome, x.Categoria, Preço = x.Preco.ToString("C"), x.Estoque, Mínimo = x.EstoqueMinimo, Situação = x.Estoque <= x.EstoqueMinimo ? "Estoque baixo" : "Normal" }).ToList(); if (gradeEstoque.Columns["Id"] is not null) gradeEstoque.Columns["Id"].Visible = false; lblResumo.Text = $"{itens.Count} produtos · {itens.Count(x => x.Estoque <= x.EstoqueMinimo)} com estoque baixo"; } catch (Exception ex) { MessageBox.Show(ex.Message, "Estoque"); } }
    private async Task NovoProdutoAsync() { using var f = new FormularioProduto(null); if (f.ShowDialog(this) != DialogResult.OK) return; try { await new RepositorioPetShop().SalvarProdutoAsync(f.Produto); txtPesquisa.Clear(); await CarregarAsync(); MessageBox.Show("Produto cadastrado com sucesso!", "Estoque"); } catch (MySqlConnector.MySqlException ex) when (ex.Number == 1062) { MessageBox.Show("Já existe um produto com esse código.", "Código duplicado"); } }
    private async Task EditarAsync() { if (gradeEstoque.CurrentRow?.Cells["Id"].Value is not int id) return; var produto = (await new RepositorioPetShop().ListarProdutosAsync()).First(x => x.Id == id); using var f = new FormularioProduto(produto); if (f.ShowDialog(this) != DialogResult.OK) return; await new RepositorioPetShop().AtualizarProdutoAsync(f.Produto); await CarregarAsync(); }
    private async Task ExcluirAsync() { if (gradeEstoque.CurrentRow?.Cells["Id"].Value is not int id || !PetShop_App.Componentes.BotoesCrud.Confirmar("o produto selecionado")) return; try { await new RepositorioPetShop().ExcluirProdutoAsync(id); await CarregarAsync(); } catch (MySqlConnector.MySqlException) { MessageBox.Show("Este produto possui vendas vinculadas e não pode ser removido."); } }
}

}
