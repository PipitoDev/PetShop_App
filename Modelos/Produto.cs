namespace PetShop_App.Modelos;

/// <summary>Representa um item comercializado e seu saldo atual no estoque.</summary>
public sealed class Produto
{
    public int Id { get; set; }
    public string Codigo { get; set; } = "";
    public string Nome { get; set; } = "";
    public string Categoria { get; set; } = "";
    public decimal Preco { get; set; }
    public int Estoque { get; set; }
    public int EstoqueMinimo { get; set; }
}
