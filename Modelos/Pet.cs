namespace PetShop_App.Modelos;

public sealed class Pet
{
    public int Id { get; set; }
    public int ClienteId { get; set; }
    public string Tutor { get; set; } = "";
    public string Nome { get; set; } = "";
    public string Especie { get; set; } = "";
    public string Raca { get; set; } = "";
    public string Porte { get; set; } = "";
    public DateTime? Nascimento { get; set; }
    public decimal Peso { get; set; }
}
