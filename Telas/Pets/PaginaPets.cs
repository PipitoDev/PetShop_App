using MySqlConnector;
using PetShop_App.Componentes;
using PetShop_App.Dados;

namespace PetShop_App.Telas.Pets;

/// <summary>
/// Página de consulta e manutenção de pets. Conecta botões e pesquisa ao
/// repositório e abre FormularioPet para operações de escrita.
/// </summary>
public partial class PaginaPets : UserControl
{
    private readonly RepositorioPetShop repositorio = new();

    public PaginaPets()
    {
        InitializeComponent();
        if (AmbienteDesign.EstaAtivo(this)) return;

        // A página coordena a interface; a persistência permanece no repositório.
        Load += async (_, _) => await CarregarAsync();
        txtPesquisa.TextChanged += async (_, _) => await CarregarAsync();
        btnNovo.Click += async (_, _) => await CadastrarAsync();
        btnEditarRegistro.Click += async (_, _) => await EditarAsync();
        btnExcluirRegistro.Click += async (_, _) => await ExcluirAsync();
    }

    /// <summary>Atualiza a grade aplicando a pesquisa digitada.</summary>
    private async Task CarregarAsync()
    {
        try
        {
            var pets = await repositorio.ListarPetsAsync(txtPesquisa.Text);
            gradePets.DataSource = pets.Select(pet => new
            {
                pet.Id,
                pet.Nome,
                pet.Tutor,
                pet.Especie,
                pet.Raca,
                pet.Porte,
                Peso = $"{pet.Peso:N2} kg"
            }).ToList();

            if (gradePets.Columns["Id"] is { } colunaId)
                colunaId.Visible = false;
        }
        catch (Exception erro)
        {
            MessageBox.Show(this, $"Não foi possível carregar os pets.\n\n{erro.Message}", "Pets");
        }
    }

    /// <summary>Carrega tutores, abre o formulário e insere o pet retornado.</summary>
    private async Task CadastrarAsync()
    {
        var clientes = await repositorio.ListarClientesAsync();
        if (clientes.Count == 0)
        {
            MessageBox.Show(this, "Cadastre um cliente antes de cadastrar o pet.", "Vínculo obrigatório");
            return;
        }

        using var formulario = new FormularioPet(clientes);
        if (formulario.ShowDialog(this) != DialogResult.OK) return;

        await repositorio.SalvarPetAsync(formulario.Pet);
        await CarregarAsync();
    }

    /// <summary>Busca o registro completo e abre o formulário preenchido.</summary>
    private async Task EditarAsync()
    {
        var petId = ObterIdSelecionado();
        if (petId is null) return;

        var pet = (await repositorio.ListarPetsAsync()).First(p => p.Id == petId);
        var clientes = await repositorio.ListarClientesAsync();
        using var formulario = new FormularioPet(clientes, pet);
        if (formulario.ShowDialog(this) != DialogResult.OK) return;

        await repositorio.AtualizarPetAsync(formulario.Pet);
        await CarregarAsync();
    }

    /// <summary>Remove o pet quando não existem atendimentos vinculados.</summary>
    private async Task ExcluirAsync()
    {
        var petId = ObterIdSelecionado();
        if (petId is null || !BotoesCrud.Confirmar("o pet selecionado")) return;

        try
        {
            await repositorio.ExcluirPetAsync(petId.Value);
            await CarregarAsync();
        }
        catch (MySqlException erro) when (erro.Number == 1451)
        {
            MessageBox.Show(this, "O pet possui atendimentos vinculados e não pode ser removido.", "Pet vinculado");
        }
    }

    /// <summary>Obtém o ID oculto da linha selecionada ou orienta o usuário.</summary>
    private int? ObterIdSelecionado()
    {
        if (gradePets.CurrentRow?.Cells["Id"].Value is int id) return id;
        MessageBox.Show(this, "Selecione um pet na lista.", "Pets");
        return null;
    }
}
