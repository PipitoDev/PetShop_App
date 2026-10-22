namespace PetShop_App.Componentes;

/// <summary>
/// Formulário genérico legado capaz de criar campos em execução. Os cadastros
/// atuais usam Forms próprios para permitir edição visual pelo Designer.
/// Mantido apenas para compatibilidade com futuras telas simples.
/// </summary>
public partial class FormularioCadastro : Form
{
    /// <summary>Construtor sem parâmetros exigido pelo Windows Forms Designer.</summary>
    public FormularioCadastro()
    {
        InitializeComponent();
    }

    /// <summary>Cria a janela genérica com título e altura específicos.</summary>
    public FormularioCadastro(string titulo, int altura = 590) : this()
    {
        Text = titulo;
        Height = altura;
    }

    /// <summary>Adiciona um campo de texto ao painel de campos.</summary>
    public TextBox Texto(string rotulo, string placeholder = "")
    {
        var controle = new TextBox
        {
            Dock = DockStyle.Top,
            Height = 32,
            PlaceholderText = placeholder,
            Font = new Font("Segoe UI", 10)
        };
        Adicionar(rotulo, controle);
        return controle;
    }

    /// <summary>Adiciona um campo numérico com limite e casas decimais.</summary>
    public NumericUpDown Numero(string rotulo, decimal max = 99999, int casas = 0)
    {
        var controle = new NumericUpDown
        {
            Dock = DockStyle.Top,
            Height = 32,
            Maximum = max,
            DecimalPlaces = casas,
            Font = new Font("Segoe UI", 10)
        };
        Adicionar(rotulo, controle);
        return controle;
    }

    /// <summary>Adiciona uma lista de seleção sem digitação livre.</summary>
    public ComboBox Combo(string rotulo)
    {
        var controle = new ComboBox
        {
            Dock = DockStyle.Top,
            Height = 32,
            DropDownStyle = ComboBoxStyle.DropDownList,
            Font = new Font("Segoe UI", 10)
        };
        Adicionar(rotulo, controle);
        return controle;
    }

    /// <summary>Adiciona um seletor de data, opcionalmente com horário.</summary>
    public DateTimePicker Data(string rotulo, bool hora = false)
    {
        var controle = new DateTimePicker
        {
            Dock = DockStyle.Top,
            Height = 32,
            Format = hora ? DateTimePickerFormat.Custom : DateTimePickerFormat.Short,
            CustomFormat = hora ? "dd/MM/yyyy HH:mm" : "dd/MM/yyyy",
            Font = new Font("Segoe UI", 10)
        };
        Adicionar(rotulo, controle);
        return controle;
    }

    /// <summary>Inclui label e controle em sequência no layout vertical.</summary>
    private void Adicionar(string rotulo, Control controle)
    {
        campos.Controls.Add(new Label
        {
            Text = rotulo,
            AutoSize = true,
            Margin = new Padding(0, 8, 0, 4),
            ForeColor = Tema.Texto,
            Font = new Font("Segoe UI", 9, FontStyle.Bold)
        });
        campos.Controls.Add(controle);
    }
}
