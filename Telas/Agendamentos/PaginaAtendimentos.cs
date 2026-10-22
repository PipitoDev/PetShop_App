using PetShop_App.Componentes;
using PetShop_App.Dados;

namespace PetShop_App.Telas.Agendamentos;

/// <summary>
/// Página compartilhada pelos itens Agendamentos e Atendimentos do menu.
/// O título muda, mas ambos trabalham sobre a mesma tabela e o mesmo fluxo CRUD.
/// </summary>
public partial class PaginaAtendimentos : UserControl
{
    private readonly RepositorioPetShop repositorio = new();

    public PaginaAtendimentos() : this("Atendimentos")
    {
    }

    public PaginaAtendimentos(string titulo)
    {
        InitializeComponent();
        if (AmbienteDesign.EstaAtivo(this)) return;

        lblTitulo.Text = titulo;
        Load += async (_, _) => await CarregarAsync();
        btnNovo.Click += async (_, _) => await AgendarAsync();
        btnEditarRegistro.Click += async (_, _) => await EditarAsync();
        btnExcluirRegistro.Click += async (_, _) => await ExcluirAsync();
    }

    /// <summary>Consulta e projeta atendimentos para a grade.</summary>
    private async Task CarregarAsync()
    {
        try
        {
            var atendimentos = await repositorio.ListarAtendimentosAsync();
            gradeAtendimentos.DataSource = atendimentos.Select(atendimento => new
            {
                atendimento.Id,
                Data = atendimento.DataHora.ToString("dd/MM/yyyy HH:mm"),
                atendimento.Pet,
                atendimento.Tutor,
                atendimento.Servico,
                Valor = atendimento.Valor.ToString("C"),
                atendimento.Status
            }).ToList();

            if (gradeAtendimentos.Columns["Id"] is { } colunaId)
                colunaId.Visible = false;
        }
        catch (Exception erro)
        {
            MessageBox.Show(this, $"Não foi possível carregar os atendimentos.\n\n{erro.Message}", "Atendimentos");
        }
    }

    /// <summary>Carrega dependências e cria um novo agendamento.</summary>
    private async Task AgendarAsync()
    {
        // Pets e serviços são dependências obrigatórias do atendimento.
        var pets = await repositorio.ListarPetsAsync();
        var servicosAtivos = (await repositorio.ListarServicosAsync())
            .Where(servico => servico.Ativo)
            .ToList();

        if (pets.Count == 0 || servicosAtivos.Count == 0)
        {
            MessageBox.Show(this, "Cadastre ao menos um pet e um serviço ativo antes de agendar.", "Cadastro necessário");
            return;
        }

        using var formulario = new FormularioAtendimento(pets, servicosAtivos);
        if (formulario.ShowDialog(this) != DialogResult.OK) return;

        await repositorio.SalvarAtendimentoAsync(formulario.Atendimento);
        await CarregarAsync();
    }

    /// <summary>Carrega o registro e as listas necessárias ao formulário de edição.</summary>
    private async Task EditarAsync()
    {
        var atendimentoId = ObterIdSelecionado();
        if (atendimentoId is null) return;

        var atendimento = (await repositorio.ListarAtendimentosAsync())
            .First(item => item.Id == atendimentoId);
        var pets = await repositorio.ListarPetsAsync();
        var servicos = await repositorio.ListarServicosAsync();

        using var formulario = new FormularioAtendimento(pets, servicos, atendimento);
        if (formulario.ShowDialog(this) != DialogResult.OK) return;

        await repositorio.AtualizarAtendimentoAsync(formulario.Atendimento);
        await CarregarAsync();
    }

    /// <summary>Confirma e remove o atendimento selecionado.</summary>
    private async Task ExcluirAsync()
    {
        var atendimentoId = ObterIdSelecionado();
        if (atendimentoId is null || !BotoesCrud.Confirmar("o atendimento selecionado")) return;

        await repositorio.ExcluirAtendimentoAsync(atendimentoId.Value);
        await CarregarAsync();
    }

    /// <summary>Lê o ID oculto da linha selecionada.</summary>
    private int? ObterIdSelecionado()
    {
        if (gradeAtendimentos.CurrentRow?.Cells["Id"].Value is int id) return id;
        MessageBox.Show(this, "Selecione um atendimento na lista.", "Atendimentos");
        return null;
    }
}
