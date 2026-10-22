namespace PetShop_App.Modelos;

/// <summary>Dados resumidos de uma venda usados na listagem de pedidos.</summary>
public sealed class PedidoResumo
{
    public int Id { get; set; }
    public string Numero { get; set; } = "";
    public string Cliente { get; set; } = "";
    public DateTime Data { get; set; }
    public decimal Total { get; set; }
    public string Status { get; set; } = "";
    public string Pagamento { get; set; } = "";
}
