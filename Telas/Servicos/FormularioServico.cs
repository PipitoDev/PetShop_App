using PetShop_App.Componentes;
using PetShop_App.Modelos;

namespace PetShop_App.Telas.Servicos;

/// <summary>Janela modal responsável por cadastrar ou editar um serviço.</summary>
public partial class FormularioServico : Form
{
    private readonly int servicoId;

    /// <summary>Inicializa valores padrão para um novo serviço.</summary>
    public FormularioServico()
    {
        InitializeComponent();
        Tema.ArredondarCamposFormulario(this);
        numDuracao.Value = 60;
        chkAtivo.Checked = true;
    }

    /// <summary>Preenche o formulário quando um serviço existente será editado.</summary>
    public FormularioServico(Servico? servico) : this()
    {
        servicoId = servico?.Id ?? 0;
        Text = servico is null ? "Cadastrar serviço" : "Editar serviço";
        if (servico is null) return;
        txtNome.Text = servico.Nome;
        txtDescricao.Text = servico.Descricao;
        numValor.Value = Math.Clamp(servico.Valor, numValor.Minimum, numValor.Maximum);
        numDuracao.Value = Math.Clamp(servico.DuracaoMinutos, (int)numDuracao.Minimum, (int)numDuracao.Maximum);
        chkAtivo.Checked = servico.Ativo;
    }

    /// <summary>Converte os controles no modelo enviado ao repositório.</summary>
    public Servico Servico => new()
    {
        Id = servicoId,
        Nome = txtNome.Text.Trim(),
        Descricao = txtDescricao.Text.Trim(),
        Valor = numValor.Value,
        DuracaoMinutos = (int)numDuracao.Value,
        Ativo = chkAtivo.Checked
    };

    /// <summary>Exige nome e valor positivo antes de permitir o salvamento.</summary>
    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        if (DialogResult == DialogResult.OK &&
            (string.IsNullOrWhiteSpace(txtNome.Text) || numValor.Value <= 0))
        {
            e.Cancel = true;
            MessageBox.Show(this, "Informe o nome e o valor do serviço.", "Campos obrigatórios");
        }
        base.OnFormClosing(e);
    }
}
