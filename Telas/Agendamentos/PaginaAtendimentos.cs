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
    private async Task NovoAsync() { var repo = new RepositorioPetShop(); var pets = await repo.ListarPetsAsync(); var servicos = (await repo.ListarServicosAsync()).Where(x => x.Ativo).ToList(); if (pets.Count == 0 || servicos.Count == 0) { MessageBox.Show("Cadastre ao menos um pet e um serviço antes de agendar."); return; } using var f = new FormularioCadastro("Agendar atendimento", 560); var pet = f.Combo("Pet *"); pet.DataSource = pets; pet.DisplayMember = "Nome"; pet.ValueMember = "Id"; var servico = f.Combo("Serviço *"); servico.DataSource = servicos; servico.DisplayMember = "Nome"; servico.ValueMember = "Id"; var data = f.Data("Data e horário *", true); data.Value = DateTime.Now.AddHours(1); var obs = f.Texto("Observações"); if (f.ShowDialog(this) != DialogResult.OK || pet.SelectedValue is not int petId || servico.SelectedItem is not Servico selecionado) return; await repo.SalvarAtendimentoAsync(new Atendimento { PetId = petId, ServicoId = selecionado.Id, DataHora = data.Value, Valor = selecionado.Valor, Status = "Agendado", Observacoes = obs.Text.Trim() }); await CarregarAsync(); }
    private async Task EditarAsync() { if (gradeAtendimentos.CurrentRow?.Cells["Id"].Value is not int id) return; var repo = new RepositorioPetShop(); var a = (await repo.ListarAtendimentosAsync()).First(x => x.Id == id); using var f = new FormularioCadastro("Atualizar atendimento", 520); var data = f.Data("Data e horário", true); data.Value = a.DataHora; var status = f.Combo("Status"); status.Items.AddRange(["Agendado", "Confirmado", "Em atendimento", "Concluído", "Cancelado"]); status.Text = a.Status; var obs = f.Texto("Observações"); obs.Text = a.Observacoes; if (f.ShowDialog(this) != DialogResult.OK) return; a.DataHora = data.Value; a.Status = status.Text; a.Observacoes = obs.Text; await repo.AtualizarAtendimentoAsync(a); await CarregarAsync(); }
    private async Task ExcluirAsync() { if (gradeAtendimentos.CurrentRow?.Cells["Id"].Value is not int id || !BotoesCrud.Confirmar("o agendamento/atendimento selecionado")) return; await new RepositorioPetShop().ExcluirAtendimentoAsync(id); await CarregarAsync(); }
}

}
