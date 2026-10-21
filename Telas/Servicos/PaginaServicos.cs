using PetShop_App.Componentes;
using PetShop_App.Dados;
using PetShop_App.Modelos;
namespace PetShop_App.Telas.Servicos
{

public partial class PaginaServicos : UserControl
{
    public PaginaServicos() { InitializeComponent(); if (PetShop_App.Componentes.AmbienteDesign.EstaAtivo(this)) return; Load += async (_, _) => await CarregarAsync(); btnNovo.Click += async (_, _) => await NovoAsync(); btnEditarRegistro.Click += async (_, _) => await EditarAsync(); btnExcluirRegistro.Click += async (_, _) => await ExcluirAsync(); }
    private async Task CarregarAsync() { if (PetShop_App.Componentes.AmbienteDesign.EstaAtivo(this)) return; try { gradeServicos.DataSource = (await new RepositorioPetShop().ListarServicosAsync()).Select(x => new { x.Id, x.Nome, x.Descricao, Valor = x.Valor.ToString("C"), Duração = x.DuracaoMinutos + " min", Status = x.Ativo ? "Ativo" : "Inativo" }).ToList(); if (gradeServicos.Columns["Id"] is not null) gradeServicos.Columns["Id"].Visible = false; } catch (Exception ex) { MessageBox.Show(ex.Message, "Não foi possível carregar os serviços"); } }
    private async Task NovoAsync() { using var f = new FormularioCadastro("Cadastrar serviço", 520); var nome = f.Texto("Nome do serviço *"); var desc = f.Texto("Descrição"); var valor = f.Numero("Valor (R$) *", 99999, 2); var duracao = f.Numero("Duração (minutos) *", 1440); duracao.Value = 60; if (f.ShowDialog(this) != DialogResult.OK) return; if (string.IsNullOrWhiteSpace(nome.Text) || valor.Value <= 0) { MessageBox.Show("Informe nome e valor do serviço."); return; } await new RepositorioPetShop().SalvarServicoAsync(new Servico { Nome = nome.Text.Trim(), Descricao = desc.Text.Trim(), Valor = valor.Value, DuracaoMinutos = (int)duracao.Value }); await CarregarAsync(); }
    private async Task EditarAsync() { if (gradeServicos.CurrentRow?.Cells["Id"].Value is not int id) return; var repo = new RepositorioPetShop(); var s = (await repo.ListarServicosAsync()).First(x => x.Id == id); using var f = new FormularioCadastro("Editar serviço", 520); var nome = f.Texto("Nome"); nome.Text = s.Nome; var desc = f.Texto("Descrição"); desc.Text = s.Descricao; var valor = f.Numero("Valor", 99999, 2); valor.Value = s.Valor; var duracao = f.Numero("Duração", 1440); duracao.Value = s.DuracaoMinutos; if (f.ShowDialog(this) != DialogResult.OK) return; s.Nome = nome.Text; s.Descricao = desc.Text; s.Valor = valor.Value; s.DuracaoMinutos = (int)duracao.Value; await repo.AtualizarServicoAsync(s); await CarregarAsync(); }
    private async Task ExcluirAsync() { if (gradeServicos.CurrentRow?.Cells["Id"].Value is not int id || !BotoesCrud.Confirmar("o serviço selecionado")) return; try { await new RepositorioPetShop().ExcluirServicoAsync(id); await CarregarAsync(); } catch (MySqlConnector.MySqlException) { MessageBox.Show("O serviço possui atendimentos vinculados e não pode ser removido."); } }
}

}
