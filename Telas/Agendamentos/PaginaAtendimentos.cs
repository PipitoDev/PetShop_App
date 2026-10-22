using PetShop_App.Componentes;
using PetShop_App.Dados;
using PetShop_App.Modelos;
namespace PetShop_App.Telas.Agendamentos
{

public partial class PaginaAtendimentos : UserControl
{
    public PaginaAtendimentos() : this("Atendimentos") { }
    public PaginaAtendimentos(string titulo) { InitializeComponent(); if (PetShop_App.Componentes.AmbienteDesign.EstaAtivo(this)) return; lblTitulo.Text = titulo; Load += async (_, _) => await CarregarAsync(); btnNovo.Click += async (_, _) => await NovoAsync(); btnEditarRegistro.Click += async (_, _) => await EditarAsync(); btnExcluirRegistro.Click += async (_, _) => await ExcluirAsync(); }
    private async Task CarregarAsync() { if (PetShop_App.Componentes.AmbienteDesign.EstaAtivo(this)) return; try { gradeAtendimentos.DataSource = (await new RepositorioPetShop().ListarAtendimentosAsync()).Select(x => new { x.Id, Data = x.DataHora.ToString("dd/MM/yyyy HH:mm"), x.Pet, x.Tutor, x.Servico, Valor = x.Valor.ToString("C"), x.Status }).ToList(); if (gradeAtendimentos.Columns["Id"] is not null) gradeAtendimentos.Columns["Id"].Visible = false; } catch (Exception ex) { MessageBox.Show(ex.Message, "Não foi possível carregar os atendimentos"); } }
    private async Task NovoAsync() { var repo = new RepositorioPetShop(); var pets = await repo.ListarPetsAsync(); var servicos = (await repo.ListarServicosAsync()).Where(x => x.Ativo).ToList(); if (pets.Count == 0 || servicos.Count == 0) { MessageBox.Show("Cadastre ao menos um pet e um serviço antes de agendar."); return; } using var f = new FormularioAtendimento(pets, servicos); if (f.ShowDialog(this) != DialogResult.OK) return; await repo.SalvarAtendimentoAsync(f.Atendimento); await CarregarAsync(); }
    private async Task EditarAsync() { if (gradeAtendimentos.CurrentRow?.Cells["Id"].Value is not int id) return; var repo = new RepositorioPetShop(); var atendimento = (await repo.ListarAtendimentosAsync()).First(x => x.Id == id); var pets = await repo.ListarPetsAsync(); var servicos = await repo.ListarServicosAsync(); using var f = new FormularioAtendimento(pets, servicos, atendimento); if (f.ShowDialog(this) != DialogResult.OK) return; await repo.AtualizarAtendimentoAsync(f.Atendimento); await CarregarAsync(); }
    private async Task ExcluirAsync() { if (gradeAtendimentos.CurrentRow?.Cells["Id"].Value is not int id || !BotoesCrud.Confirmar("o agendamento/atendimento selecionado")) return; await new RepositorioPetShop().ExcluirAtendimentoAsync(id); await CarregarAsync(); }
}

}
