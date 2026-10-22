namespace PetShop_App.Componentes;

/// <summary>Cria e posiciona os botões comuns de edição e exclusão das páginas CRUD.</summary>
public static class BotoesCrud
{
    /// <summary>
    /// Injeta os botões Editar e Remover em um cabeçalho e conecta os delegates
    /// fornecidos pela página. O posicionamento acompanha o redimensionamento.
    /// </summary>
    public static void Adicionar(
        Control painel,
        Func<Task> editar,
        Func<Task> excluir,
        int margemDireita = 190)
    {
        var botaoPrincipal = painel.Controls
            .OfType<Button>()
            .FirstOrDefault(botao =>
                botao.Name is not "btnEditarRegistro" and not "btnExcluirRegistro");

        var botaoEditar = CriarBotao("btnEditarRegistro", "Editar", new Size(90, 40));
        var botaoExcluir = CriarBotao("btnExcluirRegistro", "Remover", new Size(105, 40));
        botaoExcluir.ForeColor = Color.FromArgb(220, 38, 38);

        botaoEditar.Click += async (_, _) => await editar();
        botaoExcluir.Click += async (_, _) => await excluir();
        painel.Controls.Add(botaoEditar);
        painel.Controls.Add(botaoExcluir);

        // Recalcula a posição quando o cabeçalho muda de tamanho no Designer ou em execução.
        var reposicionando = false;
        void Posicionar()
        {
            if (reposicionando) return;
            reposicionando = true;
            try
            {
                var limiteDireito = botaoPrincipal?.Left ?? painel.ClientSize.Width - margemDireita;
                botaoExcluir.Location = new Point(Math.Max(98, limiteDireito - 113), 8);
                botaoEditar.Location = new Point(Math.Max(0, botaoExcluir.Left - 98), 8);
                botaoEditar.BringToFront();
                botaoExcluir.BringToFront();
                botaoPrincipal?.BringToFront();
            }
            finally
            {
                reposicionando = false;
            }
        }

        botaoEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        botaoExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        painel.Resize += (_, _) => Posicionar();
        painel.Layout += (_, _) => Posicionar();
        painel.HandleCreated += (_, _) => Posicionar();
        Posicionar();
    }

    /// <summary>Exibe a confirmação padronizada antes de uma exclusão permanente.</summary>
    public static bool Confirmar(string item)
    {
        return MessageBox.Show(
            $"Deseja realmente remover {item}?",
            "Confirmar remoção",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning) == DialogResult.Yes;
    }

    /// <summary>Cria um botão secundário usando a fábrica visual central.</summary>
    private static Button CriarBotao(string nome, string texto, Size tamanho)
    {
        var botao = Tema.Botao(texto, principal: false);
        botao.AutoSize = false;
        botao.Name = nome;
        botao.Size = tamanho;
        return botao;
    }
}
