namespace PetShop_App.Modelos;

public sealed class Servico
{
    public int Id { get; set; }
    public string Nome { get; set; } = "";
    public string Descricao { get; set; } = "";
    public decimal Valor { get; set; }
    public int DuracaoMinutos { get; set; }
    public bool Ativo { get; set; } = true;
}
