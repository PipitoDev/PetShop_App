using PetShop_App.Dados;
namespace PetShop_App.Telas.Principal
{

public partial class PainelDiario : UserControl
{
    public PainelDiario() { InitializeComponent(); if (PetShop_App.Componentes.AmbienteDesign.EstaAtivo(this)) return; Load += async (_, _) => await CarregarAsync(); }
    private async Task CarregarAsync() { if (PetShop_App.Componentes.AmbienteDesign.EstaAtivo(this)) return; try { lblDetalheAtendimentos.Text = "Carregando..."; var repo = new RepositorioPetShop(); var itens = await repo.ListarAtendimentosAsync(); var pets = await repo.ListarPetsAsync(); var pedidos = await repo.ListarPedidosAsync(); gradeAgenda.DataSource = itens.Select(x => new { Horário = x.DataHora.ToString("dd/MM HH:mm"), x.Pet, x.Tutor, Serviço = x.Servico, Valor = x.Valor.ToString("C"), x.Status }).ToList(); lblValorAtendimentos.Text = itens.Count(x => x.DataHora.Date == DateTime.Today).ToString(); lblDetalheAtendimentos.Text = $"{itens.Count(x => x.DataHora.Date == DateTime.Today && x.Status == "Em atendimento")} em andamento"; lblValorAgendamentos.Text = itens.Count(x => x.Status == "Agendado").ToString(); lblValorPets.Text = pets.Count.ToString(); lblValorFaturamento.Text = (itens.Where(x => x.DataHora.Date == DateTime.Today).Sum(x => x.Valor) + pedidos.Where(x => x.Data.Date == DateTime.Today && x.Status == "Concluído").Sum(x => x.Total)).ToString("C"); } catch (Exception ex) { lblDetalheAtendimentos.Text = "Indisponível"; gradeAgenda.DataSource = new[] { new { Aviso = "Configure o MySQL: " + ex.Message } }; } }

    private void lblValorAtendimentos_Click(object sender, EventArgs e)
    {

    }
}

}
