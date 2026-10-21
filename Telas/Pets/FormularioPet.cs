using PetShop_App.Modelos;

namespace PetShop_App.Telas.Pets;

public partial class FormularioPet : Form
{
    private readonly int petId;

    public FormularioPet()
    {
        InitializeComponent();
        cmbEspecie.SelectedIndex = 0;
        cmbPorte.SelectedIndex = 0;
    }

    public FormularioPet(IReadOnlyList<Cliente> clientes, Pet? pet = null) : this()
    {
        petId = pet?.Id ?? 0;
        Text = pet is null ? "Cadastrar pet" : "Editar pet";
        cmbTutor.DataSource = clientes.ToList();
        cmbTutor.DisplayMember = nameof(Cliente.Nome);
        cmbTutor.ValueMember = nameof(Cliente.Id);
        if (pet is not null)
        {
            cmbTutor.SelectedValue = pet.ClienteId;
            txtNome.Text = pet.Nome;
            cmbEspecie.Text = pet.Especie;
            txtRaca.Text = pet.Raca;
            cmbPorte.Text = pet.Porte;
            if (pet.Nascimento is { } nascimento) dtpNascimento.Value = nascimento;
            numPeso.Value = Math.Clamp(pet.Peso, numPeso.Minimum, numPeso.Maximum);
        }
    }

    public Pet Pet => new()
    {
        Id = petId,
        ClienteId = cmbTutor.SelectedValue is int id ? id : 0,
        Nome = txtNome.Text.Trim(),
        Especie = cmbEspecie.Text,
        Raca = txtRaca.Text.Trim(),
        Porte = cmbPorte.Text,
        Nascimento = dtpNascimento.Value.Date,
        Peso = numPeso.Value
    };

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        if (DialogResult == DialogResult.OK &&
            (cmbTutor.SelectedValue is not int || string.IsNullOrWhiteSpace(txtNome.Text)))
        {
            e.Cancel = true;
            MessageBox.Show(this, "Informe o tutor e o nome do pet.", "Campos obrigatórios");
        }
        base.OnFormClosing(e);
    }
}
