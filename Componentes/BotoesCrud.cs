namespace PetShop_App.Componentes;

public static class BotoesCrud
{
    public static void Adicionar(Control painel, Func<Task> editar, Func<Task> excluir, int margemDireita = 190)
    {
        var botaoPrincipal = painel.Controls.OfType<Button>().FirstOrDefault(b => b.Name != "btnEditarRegistro" && b.Name != "btnExcluirRegistro");
        var btnEditar = Tema.Botao("Editar", false); btnEditar.AutoSize = false; btnEditar.Name = "btnEditarRegistro"; btnEditar.Size = new Size(90, 40); btnEditar.Click += async (_, _) => await editar();
        var btnExcluir = Tema.Botao("Remover", false); btnExcluir.AutoSize = false; btnExcluir.Name = "btnExcluirRegistro"; btnExcluir.ForeColor = Color.FromArgb(220, 38, 38); btnExcluir.Size = new Size(105, 40); btnExcluir.Click += async (_, _) => await excluir();
        painel.Controls.Add(btnEditar); painel.Controls.Add(btnExcluir);
        var reposicionando = false;
        void Posicionar() { if (reposicionando) return; reposicionando = true; var direita = botaoPrincipal?.Left ?? painel.ClientSize.Width - margemDireita; btnExcluir.Location = new Point(Math.Max(98, direita - 113), 8); btnEditar.Location = new Point(Math.Max(0, btnExcluir.Left - 98), 8); btnEditar.BringToFront(); btnExcluir.BringToFront(); botaoPrincipal?.BringToFront(); reposicionando = false; }
        btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right; btnExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        painel.Resize += (_, _) => Posicionar();
        painel.Layout += (_, _) => Posicionar();
        painel.HandleCreated += (_, _) => Posicionar();
        Posicionar();
    }
    public static bool Confirmar(string item) => MessageBox.Show($"Deseja realmente remover {item}?", "Confirmar remoção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
}
