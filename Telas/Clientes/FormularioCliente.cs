using PetShop_App.Componentes;
using PetShop_App.Modelos;

namespace PetShop_App.Telas.Clientes;

/// <summary>
/// Janela modal de inclusão e edição de cliente. O Designer define os campos;
/// a propriedade Cliente converte seus valores para o modelo persistido pela página.
/// </summary>
public partial class FormularioCliente : Form
{
    private readonly int clienteId;

    /// <summary>Construtor exigido pelo Windows Forms Designer.</summary>
    public FormularioCliente()
    {
        InitializeComponent();
        Tema.ArredondarCamposFormulario(this);
    }

    /// <summary>Configura modo de cadastro quando nulo ou edição quando recebe cliente.</summary>
    public FormularioCliente(Cliente? cliente) : this()
    {
        clienteId = cliente?.Id ?? 0;
        Text = cliente is null ? "Cadastrar cliente" : "Editar cliente";
        txtNome.Text = cliente?.Nome ?? "";
        txtCpf.Text = cliente?.Cpf ?? "";
        txtTelefone.Text = cliente?.Telefone ?? "";
        txtEmail.Text = cliente?.Email ?? "";
    }

    /// <summary>Cria um modelo com os valores atuais dos controles.</summary>
    public Cliente Cliente => new()
    {
        Id = clienteId,
        Nome = txtNome.Text.Trim(),
        Cpf = txtCpf.Text.Trim(),
        Telefone = txtTelefone.Text.Trim(),
        Email = txtEmail.Text.Trim()
    };

    /// <summary>Impede o fechamento pelo botão Salvar quando o nome não foi informado.</summary>
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
