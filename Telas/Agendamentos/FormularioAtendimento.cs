using PetShop_App.Modelos;

namespace PetShop_App.Telas.Agendamentos;

public partial class FormularioAtendimento : Form
{
    private readonly Atendimento? atendimentoExistente;

    public FormularioAtendimento()
    {
        InitializeComponent();
        cmbStatus.SelectedIndex = 0;
        dtpDataHora.Value = DateTime.Now.AddHours(1);
    }

    public FormularioAtendimento(
        IReadOnlyList<Pet> pets,
        IReadOnlyList<Servico> servicos,
        Atendimento? atendimento = null) : this()
    {
        atendimentoExistente = atendimento;
        cmbPet.DataSource = pets.ToList();
        cmbPet.DisplayMember = nameof(Pet.Nome);
        cmbPet.ValueMember = nameof(Pet.Id);
        cmbServico.DataSource = servicos.ToList();
        cmbServico.DisplayMember = nameof(Servico.Nome);
        cmbServico.ValueMember = nameof(Servico.Id);

        if (atendimento is null)
        {
            Text = "Agendar atendimento";
            cmbStatus.Text = "Agendado";
            cmbStatus.Enabled = false;
            return;
        }

        Text = "Atualizar atendimento";
        cmbPet.SelectedValue = atendimento.PetId;
        cmbServico.SelectedValue = atendimento.ServicoId;
        cmbPet.Enabled = false;
        cmbServico.Enabled = false;
        dtpDataHora.Value = atendimento.DataHora;
        cmbStatus.Text = atendimento.Status;
        txtObservacoes.Text = atendimento.Observacoes;
    }

    public Atendimento Atendimento
    {
        get
        {
            var servico = cmbServico.SelectedItem as Servico;
            return new Atendimento
            {
                Id = atendimentoExistente?.Id ?? 0,
                PetId = cmbPet.SelectedValue is int petId ? petId : 0,
                ServicoId = servico?.Id ?? atendimentoExistente?.ServicoId ?? 0,
                DataHora = dtpDataHora.Value,
                Valor = servico?.Valor ?? atendimentoExistente?.Valor ?? 0,
                Status = cmbStatus.Text,
                Observacoes = txtObservacoes.Text.Trim()
            };
        }
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        if (DialogResult == DialogResult.OK &&
            (cmbPet.SelectedValue is not int || cmbServico.SelectedItem is not Servico))
        {
            e.Cancel = true;
            MessageBox.Show(this, "Selecione o pet e o serviço.", "Campos obrigatórios");
        }
        base.OnFormClosing(e);
    }
}
