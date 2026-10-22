using PetShop_App.Componentes;
using PetShop_App.Dados;
using PetShop_App.Modelos;
namespace PetShop_App.Telas.Servicos
{

public partial class PaginaServicos : UserControl
{
    public PaginaServicos() { InitializeComponent(); if (PetShop_App.Componentes.AmbienteDesign.EstaAtivo(this)) return; Load += async (_, _) => await CarregarAsync(); btnNovo.Click += async (_, _) => await NovoAsync(); btnEditarRegistro.Click += async (_, _) => await EditarAsync(); btnExcluirRegistro.Click += async (_, _) => await ExcluirAsync(); }
    private async Task CarregarAsync() { if (PetShop_App.Componentes.AmbienteDesign.EstaAtivo(this)) return; try { gradeServicos.DataSource = (await new RepositorioPetShop().ListarServicosAsync()).Select(x => new { x.Id, x.Nome, x.Descricao, Valor = x.Valor.ToString("C"), Duração = x.DuracaoMinutos + " min", Status = x.Ativo ? "Ativo" : "Inativo" }).ToList(); if (gradeServicos.Columns["Id"] is not null) gradeServicos.Columns["Id"].Visible = false; } catch (Exception ex) { MessageBox.Show(ex.Message, "Não foi possível carregar os serviços"); } }
    private async Task NovoAsync() { using var f = new FormularioServico(null); if (f.ShowDialog(this) != DialogResult.OK) return; await new RepositorioPetShop().SalvarServicoAsync(f.Servico); await CarregarAsync(); }
    private async Task EditarAsync() { if (gradeServicos.CurrentRow?.Cells["Id"].Value is not int id) return; var repo = new RepositorioPetShop(); var servico = (await repo.ListarServicosAsync()).First(x => x.Id == id); using var f = new FormularioServico(servico); if (f.ShowDialog(this) != DialogResult.OK) return; await repo.AtualizarServicoAsync(f.Servico); await CarregarAsync(); }
    private async Task ExcluirAsync() { if (gradeServicos.CurrentRow?.Cells["Id"].Value is not int id || !BotoesCrud.Confirmar("o serviço selecionado")) return; try { await new RepositorioPetShop().ExcluirServicoAsync(id); await CarregarAsync(); } catch (MySqlConnector.MySqlException) { MessageBox.Show("O serviço possui atendimentos vinculados e não pode ser removido."); } }
}

}
