using PetShop_App.Componentes;
using PetShop_App.Dados;
using PetShop_App.Modelos;
namespace PetShop_App.Telas.Pets
{

public partial class PaginaPets : UserControl
{
    public PaginaPets() { InitializeComponent(); if (PetShop_App.Componentes.AmbienteDesign.EstaAtivo(this)) return; Load += async (_, _) => await CarregarAsync(); txtPesquisa.TextChanged += async (_, _) => await CarregarAsync(); btnNovo.Click += async (_, _) => await NovoAsync(); btnEditarRegistro.Click += async (_, _) => await EditarAsync(); btnExcluirRegistro.Click += async (_, _) => await ExcluirAsync(); }
    private async Task CarregarAsync() { if (PetShop_App.Componentes.AmbienteDesign.EstaAtivo(this)) return; try { gradePets.DataSource = (await new RepositorioPetShop().ListarPetsAsync(txtPesquisa.Text)).Select(x => new { x.Id, x.Nome, x.Tutor, x.Especie, x.Raca, x.Porte, Peso = x.Peso + " kg" }).ToList(); if (gradePets.Columns["Id"] is not null) gradePets.Columns["Id"].Visible = false; } catch (Exception ex) { MessageBox.Show(ex.Message, "Não foi possível carregar os pets"); } }
    private async Task NovoAsync() { var repo = new RepositorioPetShop(); var clientes = await repo.ListarClientesAsync(); if (clientes.Count == 0) { MessageBox.Show("Cadastre um cliente antes de cadastrar o pet.", "Vínculo obrigatório"); return; } using var f = new FormularioPet(clientes); if (f.ShowDialog(this) != DialogResult.OK) return; await repo.SalvarPetAsync(f.Pet); await CarregarAsync(); }
    private async Task EditarAsync() { if (gradePets.CurrentRow?.Cells["Id"].Value is not int id) return; var repo = new RepositorioPetShop(); var pet = (await repo.ListarPetsAsync()).First(x => x.Id == id); var clientes = await repo.ListarClientesAsync(); using var f = new FormularioPet(clientes, pet); if (f.ShowDialog(this) != DialogResult.OK) return; await repo.AtualizarPetAsync(f.Pet); await CarregarAsync(); }
    private async Task ExcluirAsync() { if (gradePets.CurrentRow?.Cells["Id"].Value is not int id || !BotoesCrud.Confirmar("o pet selecionado")) return; try { await new RepositorioPetShop().ExcluirPetAsync(id); await CarregarAsync(); } catch (MySqlConnector.MySqlException) { MessageBox.Show("O pet possui atendimentos vinculados. Remova-os antes."); } }
}

}
