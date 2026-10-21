namespace PetShop_App.Modelos;

public sealed class Atendimento
{
    public int Id { get; set; }
    public int PetId { get; set; }
    public int ServicoId { get; set; }
    public string Pet { get; set; } = "";
    public string Tutor { get; set; } = "";
    public string Servico { get; set; } = "";
    public DateTime DataHora { get; set; }
    public decimal Valor { get; set; }
    public string Status { get; set; } = "Agendado";
    public string Observacoes { get; set; } = "";
}
