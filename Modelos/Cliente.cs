namespace PetShop_App.Modelos;

/// <summary>Dados pessoais e de contato do tutor responsável por pets e pedidos.</summary>
public sealed class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; } = "";
    public string Cpf { get; set; } = "";
    public string Telefone { get; set; } = "";
    public string Email { get; set; } = "";
}
