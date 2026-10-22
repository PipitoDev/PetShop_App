using PetShop_App.Modelos;

namespace PetShop_App.Telas.Clientes;

public partial class FormularioCliente : Form
{
    private readonly int clienteId;

    public FormularioCliente()
    {
        InitializeComponent();
    }

    public FormularioCliente(Cliente? cliente) : this()
    {
        clienteId = cliente?.Id ?? 0;
        Text = cliente is null ? "Cadastrar cliente" : "Editar cliente";
        txtNome.Text = cliente?.Nome ?? "";
        txtCpf.Text = cliente?.Cpf ?? "";
        txtTelefone.Text = cliente?.Telefone ?? "";
        txtEmail.Text = cliente?.Email ?? "";
    }

    public Cliente Cliente => new()
    {
        Id = clienteId,
        Nome = txtNome.Text.Trim(),
        Cpf = txtCpf.Text.Trim(),
        Telefone = txtTelefone.Text.Trim(),
        Email = txtEmail.Text.Trim()
    };

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        if (DialogResult == DialogResult.OK && string.IsNullOrWhiteSpace(txtNome.Text))
        {
            e.Cancel = true;
            MessageBox.Show(this, "Informe o nome do cliente.", "Campo obrigatório");
            txtNome.Focus();
        }

        base.OnFormClosing(e);
    }
}
