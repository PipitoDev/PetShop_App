using PetShop_App.Componentes;

namespace PetShop_App.Telas.Vendas;

/// <summary>Captura o saldo informado na abertura ou no fechamento do caixa.</summary>
public partial class FormularioCaixa : Form
{
    /// <summary>Construtor necessário para o Designer.</summary>
    public FormularioCaixa()
    {
        InitializeComponent();
        Tema.ArredondarCamposFormulario(this);
    }

    /// <summary>Ajusta textos conforme a mesma janela seja usada para abrir ou fechar.</summary>
    public FormularioCaixa(bool abertura) : this()
    {
        Text = abertura ? "Abrir caixa" : "Fechar caixa";
        lblSaldo.Text = abertura ? "Saldo inicial (R$)" : "Saldo final contado (R$)";
        btnSalvar.Text = abertura ? "Abrir caixa" : "Fechar caixa";
        btnSalvar.Width = 125;
    }

    /// <summary>Valor informado que será persistido pela página PDV.</summary>
    public decimal Saldo => numSaldo.Value;
}
