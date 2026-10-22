using PetShop_App.Componentes;
using PetShop_App.Dados;

namespace PetShop_App.Telas.Vendas;

/// <summary>Consulta pedidos registrados pelo PDV e apresenta o faturamento concluído.</summary>
public partial class PaginaPedidos : UserControl
{
    private readonly RepositorioPetShop repositorio = new();

    public PaginaPedidos()
    {
        InitializeComponent();
        if (AmbienteDesign.EstaAtivo(this)) return;

        Load += async (_, _) => await CarregarAsync();
        btnAtualizar.Click += async (_, _) => await CarregarAsync();
    }

    /// <summary>Atualiza a grade e soma somente pedidos com status Concluído.</summary>
    private async Task CarregarAsync()
    {
        try
        {
            var pedidos = await repositorio.ListarPedidosAsync();
            gradePedidos.DataSource = pedidos.Select(pedido => new
            {
                pedido.Numero,
                pedido.Cliente,
                Data = pedido.Data.ToString("dd/MM/yyyy HH:mm"),
                Total = pedido.Total.ToString("C"),
                pedido.Status,
                pedido.Pagamento
            }).ToList();

            var faturamento = pedidos
                .Where(pedido => string.Equals(pedido.Status, "Concluído", StringComparison.OrdinalIgnoreCase))
                .Sum(pedido => pedido.Total);
            lblResumo.Text = $"{pedidos.Count} pedidos · Faturamento: {faturamento:C}";
        }
        catch (Exception erro)
        {
            MessageBox.Show(this, $"Não foi possível carregar os pedidos.\n\n{erro.Message}", "Pedidos");
        }
    }
}
