namespace PetShop_App.Componentes
{

    public partial class FormularioCadastro : Form
    {
        public FormularioCadastro()
        {
            InitializeComponent();
        }

        public FormularioCadastro(string titulo, int altura = 590) : this()
        {
            Text = titulo;
            Height = altura;
        }

        public TextBox Texto(string rotulo, string placeholder = "") { var c = new TextBox { Dock = DockStyle.Top, Height = 32, PlaceholderText = placeholder, Font = new Font("Segoe UI", 10) }; Adicionar(rotulo, c); return c; }
        public NumericUpDown Numero(string rotulo, decimal max = 99999, int casas = 0) { var c = new NumericUpDown { Dock = DockStyle.Top, Height = 32, Maximum = max, DecimalPlaces = casas, Font = new Font("Segoe UI", 10) }; Adicionar(rotulo, c); return c; }
        public ComboBox Combo(string rotulo) { var c = new ComboBox { Dock = DockStyle.Top, Height = 32, DropDownStyle = ComboBoxStyle.DropDownList, Font = new Font("Segoe UI", 10) }; Adicionar(rotulo, c); return c; }
        public DateTimePicker Data(string rotulo, bool hora = false) { var c = new DateTimePicker { Dock = DockStyle.Top, Height = 32, Format = hora ? DateTimePickerFormat.Custom : DateTimePickerFormat.Short, CustomFormat = hora ? "dd/MM/yyyy HH:mm" : "dd/MM/yyyy", Font = new Font("Segoe UI", 10) }; Adicionar(rotulo, c); return c; }
        private void Adicionar(string rotulo, Control controle) { campos.Controls.Add(new Label { Text = rotulo, AutoSize = true, Margin = new Padding(0, 8, 0, 4), ForeColor = Tema.Texto, Font = new Font("Segoe UI", 9, FontStyle.Bold) }); campos.Controls.Add(controle); }

        private void campos_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
