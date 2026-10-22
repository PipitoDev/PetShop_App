using PetShop_App.Componentes;
using PetShop_App.Dados;

namespace PetShop_App.Telas.Principal;

/// <summary>
/// Resumo operacional exibido ao entrar no sistema. Combina atendimentos, pets
/// e pedidos para montar indicadores e a agenda do dia.
/// </summary>
public partial class PainelDiario : UserControl
{
    public PainelDiario()
    {
        // Cria todos os controles configurados no PainelDiario.Designer.cs.
        InitializeComponent();

        // Impede consultas ao MySQL enquanto a tela está aberta
        // somente no Designer do Visual Studio.
        if (AmbienteDesign.EstaAtivo(this))
            return;

        // Quando a tela aparecer no programa, busca os dados no banco.
        Load += PainelDiario_Load;
        Resize += (_, _) => AjustarLayoutDosCartoes();
    }

    /// <summary>Executa a primeira carga quando o controle entra na árvore visual.</summary>
    private async void PainelDiario_Load(object? sender, EventArgs e)
    {
        AjustarLayoutDosCartoes();
        await CarregarAsync();
    }

    /// <summary>
    /// Distribui os cartões conforme a largura disponível; em telas menores,
    /// eles passam para a linha seguinte em vez de serem cortados.
    /// </summary>
    private void AjustarLayoutDosCartoes()
    {
        const int espacamento = 12;
        const int alturaCartao = 149;
        const int larguraMinimaCartao = 220;

        var larguraDisponivel = ClientSize.Width;
        if (larguraDisponivel <= 0)
            return;

        var quantidadeColunas = Math.Clamp(
            (larguraDisponivel + espacamento) /
            (larguraMinimaCartao + espacamento),
            1,
            4);

        var larguraCartao =
            (larguraDisponivel - (quantidadeColunas * espacamento)) /
            quantidadeColunas;

        var cartoes = new[]
        {
            pnlAtendimentos,
            pnlAgendamentos,
            pnlPets,
            pnlFaturamento
        };

        foreach (var cartao in cartoes)
        {
            cartao.Width = larguraCartao;
            cartao.Height = alturaCartao;
            cartao.Margin = new Padding(0, 0, espacamento, espacamento);
        }

        flpCartoes.WrapContents = true;
        var quantidadeLinhas = (int)Math.Ceiling(
            cartoes.Length / (double)quantidadeColunas);
        flpCartoes.Height = flpCartoes.Padding.Top +
            (quantidadeLinhas * (alturaCartao + espacamento)) +
            flpCartoes.Padding.Bottom;
    }

    /// <summary>
    /// Consulta os atendimentos cadastrados no MySQL e atualiza
    /// os números apresentados no cartão de atendimentos.
    /// </summary>
    private async Task CarregarAsync()
    {
        lblAtendimentosEmAndamento.Text = "Carregando...";
        gradeAgenda.DataSource = null;

        try
        {
            /*
             * RepositorioPetShop:
             *   ↓ usa ConexaoBanco
             * ConexaoBanco:
             *   ↓ utiliza ConfiguracaoBanco
             * MySQL/Laragon:
             *   ↓ retorna os registros da tabela "atendimentos"
             * PainelDiario:
             *   ↓ exibe as quantidades nas Labels
             */

            var repositorio = new RepositorioPetShop();

            // As consultas usam conexões independentes e podem ser executadas juntas.
            var atendimentosTask = repositorio.ListarAtendimentosAsync();
            var petsTask = repositorio.ListarPetsAsync();
            var pedidosTask = repositorio.ListarPedidosAsync();

            await Task.WhenAll(atendimentosTask, petsTask, pedidosTask);

            var atendimentos = await atendimentosTask;
            var pets = await petsTask;
            var pedidos = await pedidosTask;

            // Considera apenas os atendimentos marcados para hoje.
            var atendimentosHoje = atendimentos
                .Where(atendimento =>
                    atendimento.DataHora.Date == DateTime.Today)
                .ToList();

            // Atualiza o número grande apresentado no cartão.
            // Atendimentos cancelados não entram nessa quantidade.
            var quantidadeHoje = atendimentosHoje.Count(atendimento =>
                !string.Equals(
                    atendimento.Status,
                    "Cancelado",
                    StringComparison.OrdinalIgnoreCase));

            lblValorAtendimentos.Text = quantidadeHoje.ToString();

            // Conta somente os atendimentos de hoje que estão em andamento.
            var quantidadeEmAndamento = atendimentosHoje.Count(atendimento =>
                string.Equals(
                    atendimento.Status,
                    "Em atendimento",
                    StringComparison.OrdinalIgnoreCase));

            // Ajusta o texto automaticamente e trata singular e plural.
            lblAtendimentosEmAndamento.Text =
                quantidadeEmAndamento == 1
                    ? "1 em andamento"
                    : $"{quantidadeEmAndamento} em andamento";

            lblValorAgendamentos.Text = atendimentosHoje.Count(atendimento =>
                string.Equals(
                    atendimento.Status,
                    "Agendado",
                    StringComparison.OrdinalIgnoreCase)).ToString();

            lblValorPets.Text = pets.Count.ToString();

            var faturamentoAtendimentos = atendimentosHoje
                .Where(atendimento => !string.Equals(
                    atendimento.Status,
                    "Cancelado",
                    StringComparison.OrdinalIgnoreCase))
                .Sum(atendimento => atendimento.Valor);

            var faturamentoPedidos = pedidos
                .Where(pedido =>
                    pedido.Data.Date == DateTime.Today &&
                    string.Equals(
                        pedido.Status,
                        "Concluído",
                        StringComparison.OrdinalIgnoreCase))
                .Sum(pedido => pedido.Total);

            lblValorFaturamento.Text =
                (faturamentoAtendimentos + faturamentoPedidos).ToString("C");

            gradeAgenda.DataSource = atendimentosHoje
                .OrderBy(atendimento => atendimento.DataHora)
                .Select(atendimento => new
                {
                    Horario = atendimento.DataHora.ToString("HH:mm"),
                    atendimento.Pet,
                    atendimento.Tutor,
                    Servico = atendimento.Servico,
                    Valor = atendimento.Valor.ToString("C"),
                    atendimento.Status
                })
                .ToList();
        }
        catch (Exception erro)
        {
            /*
             * Se o MySQL estiver desligado, a conexão estiver incorreta
             * ou ocorrer outro erro, o painel não fecha inesperadamente.
             */
            lblValorAtendimentos.Text = "0";
            lblAtendimentosEmAndamento.Text = "Erro ao carregar";
            lblValorAgendamentos.Text = "0";
            lblValorPets.Text = "0";
            lblValorFaturamento.Text = 0m.ToString("C");

            MessageBox.Show(
                $"Não foi possível carregar os atendimentos.\n\n{erro.Message}",
                "Erro de conexão",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

}
