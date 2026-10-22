using MySqlConnector;
using PetShop_App.Componentes;
using PetShop_App.Dados;

namespace PetShop_App.Telas.Servicos;

/// <summary>Página CRUD de serviços oferecidos pelo pet shop.</summary>
public partial class PaginaServicos : UserControl
{
    private readonly RepositorioPetShop repositorio = new();

    public PaginaServicos()
    {
        InitializeComponent();
        if (AmbienteDesign.EstaAtivo(this)) return;

        Load += async (_, _) => await CarregarAsync();
        btnNovo.Click += async (_, _) => await CadastrarAsync();
        btnEditarRegistro.Click += async (_, _) => await EditarAsync();
        btnExcluirRegistro.Click += async (_, _) => await ExcluirAsync();
    }

    /// <summary>Consulta serviços e formata valores para apresentação na grade.</summary>
    private async Task CarregarAsync()
    {
        try
        {
            var servicos = await repositorio.ListarServicosAsync();
            gradeServicos.DataSource = servicos.Select(servico => new
            {
                servico.Id,
                servico.Nome,
                servico.Descricao,
                Valor = servico.Valor.ToString("C"),
                Duração = $"{servico.DuracaoMinutos} min",
                Status = servico.Ativo ? "Ativo" : "Inativo"
            }).ToList();

            if (gradeServicos.Columns["Id"] is { } colunaId)
                colunaId.Visible = false;
        }
        catch (Exception erro)
        {
            MessageBox.Show(this, $"Não foi possível carregar os serviços.\n\n{erro.Message}", "Serviços");
        }
    }

    /// <summary>Abre um formulário vazio e persiste o serviço confirmado.</summary>
    private async Task CadastrarAsync()
    {
        using var formulario = new FormularioServico(null);
        if (formulario.ShowDialog(this) != DialogResult.OK) return;

        await repositorio.SalvarServicoAsync(formulario.Servico);
        await CarregarAsync();
    }

    /// <summary>Abre o serviço selecionado para alteração.</summary>
    private async Task EditarAsync()
    {
        var servicoId = ObterIdSelecionado();
        if (servicoId is null) return;

        var servico = (await repositorio.ListarServicosAsync()).First(s => s.Id == servicoId);
        using var formulario = new FormularioServico(servico);
        if (formulario.ShowDialog(this) != DialogResult.OK) return;

        await repositorio.AtualizarServicoAsync(formulario.Servico);
        await CarregarAsync();
    }

    /// <summary>Remove o serviço se nenhum atendimento depender dele.</summary>
    private async Task ExcluirAsync()
    {
        var servicoId = ObterIdSelecionado();
        if (servicoId is null || !BotoesCrud.Confirmar("o serviço selecionado")) return;

        try
        {
            await repositorio.ExcluirServicoAsync(servicoId.Value);
            await CarregarAsync();
        }
        catch (MySqlException erro) when (erro.Number == 1451)
        {
            MessageBox.Show(this, "O serviço possui atendimentos vinculados e não pode ser removido.", "Serviço vinculado");
        }
    }

    /// <summary>Obtém o ID oculto na grade ou exibe orientação de seleção.</summary>
    private int? ObterIdSelecionado()
    {
        if (gradeServicos.CurrentRow?.Cells["Id"].Value is int id) return id;
        MessageBox.Show(this, "Selecione um serviço na lista.", "Serviços");
        return null;
    }
}
