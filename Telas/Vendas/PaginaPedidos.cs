using PetShop_App.Dados;
namespace PetShop_App.Telas.Vendas
{

public partial class PaginaPedidos : UserControl
{
    public PaginaPedidos() { InitializeComponent(); if (PetShop_App.Componentes.AmbienteDesign.EstaAtivo(this)) return; Load += async (_, _) => await CarregarAsync(); btnAtualizar.Click += async (_, _) => await CarregarAsync(); }
    private async Task CarregarAsync() { if (PetShop_App.Componentes.AmbienteDesign.EstaAtivo(this)) return; try { var itens = await new RepositorioPetShop().ListarPedidosAsync(); gradePedidos.DataSource = itens.Select(x => new { x.Numero, x.Cliente, Data = x.Data.ToString("dd/MM/yyyy HH:mm"), Total = x.Total.ToString("C"), x.Status, x.Pagamento }).ToList(); lblResumo.Text = $"{itens.Count} pedidos · Faturamento: {itens.Where(x => x.Status == "Concluído").Sum(x => x.Total):C}"; } catch (Exception ex) { MessageBox.Show(ex.Message, "Pedidos"); } }
}

}
