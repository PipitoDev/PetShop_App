namespace PetShop_App.Telas.Vendas;

public partial class FormularioCaixa : Form
{
    public FormularioCaixa()
    {
        InitializeComponent();
    }

    public FormularioCaixa(bool abertura) : this()
    {
        Text = abertura ? "Abrir caixa" : "Fechar caixa";
        lblSaldo.Text = abertura ? "Saldo inicial (R$)" : "Saldo final contado (R$)";
    }

    public decimal Saldo => numSaldo.Value;
}
