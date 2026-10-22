using System.Drawing.Drawing2D;

namespace PetShop_App.Componentes;

/// <summary>
/// Paleta e comportamentos visuais compartilhados. Centralizar aqui evita que
/// cada tela implemente cores, grades e arredondamento de forma diferente.
/// </summary>
public static class Tema
{
    public static readonly Color Laranja = Color.FromArgb(255, 128, 0);
    public static readonly Color LaranjaClaro = Color.FromArgb(255, 240, 226);
    public static readonly Color Fundo = Color.FromArgb(241, 245, 249);
    public static readonly Color Texto = Color.FromArgb(15, 23, 42);
    public static readonly Color Secundario = Color.FromArgb(100, 116, 139);

    /// <summary>Cria um botão com o padrão visual usado nos cabeçalhos CRUD.</summary>
    public static Button Botao(string texto, bool principal = true)
    {
        return new Button
        {
            Text = texto,
            AutoSize = true,
            Height = 40,
            Padding = new Padding(14, 0, 14, 0),
            FlatStyle = FlatStyle.Flat,
            BackColor = principal ? Laranja : Color.White,
            ForeColor = principal ? Color.White : Laranja,
            Font = new Font("Segoe UI", 10, FontStyle.Bold),
            Cursor = Cursors.Hand
        };
    }

    /// <summary>Cria o título principal padronizado das páginas.</summary>
    public static Label Titulo(string texto) => new() { Text = texto, AutoSize = true, Font = new Font("Segoe UI", 22, FontStyle.Bold), ForeColor = Texto };

    /// <summary>Cria o texto auxiliar exibido abaixo dos títulos.</summary>
    public static Label Subtitulo(string texto) => new() { Text = texto, AutoSize = true, Font = new Font("Segoe UI", 10), ForeColor = Secundario };

    /// <summary>Cria uma grade somente leitura com seleção de linha completa.</summary>
    public static DataGridView Grade()
    {
        var grade = new DataGridView
        {
            Dock = DockStyle.Fill,
            BackgroundColor = Color.White,
            BorderStyle = BorderStyle.None,
            AutoGenerateColumns = true,
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
            ReadOnly = true,
            AllowUserToAddRows = false,
            AllowUserToDeleteRows = false,
            RowHeadersVisible = false,
            SelectionMode = DataGridViewSelectionMode.FullRowSelect,
            MultiSelect = false
        };
        grade.EnableHeadersVisualStyles = false;
        grade.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.FromArgb(248, 250, 252), ForeColor = Texto, Font = new Font("Segoe UI", 9, FontStyle.Bold), Padding = new Padding(8) };
        grade.DefaultCellStyle = new DataGridViewCellStyle { Font = new Font("Segoe UI", 9), ForeColor = Texto, SelectionBackColor = LaranjaClaro, SelectionForeColor = Texto, Padding = new Padding(8) };
        grade.RowTemplate.Height = 42;
        return grade;
    }

    /// <summary>Recorta qualquer controle usando uma região de cantos arredondados.</summary>
    public static void Arredondar(Control controle, int raio = 12)
    {
        if (controle.Width < 1 || controle.Height < 1) return;
        using var caminho = new GraphicsPath();
        var diametro = raio * 2;
        var area = controle.ClientRectangle;
        caminho.AddArc(area.Left, area.Top, diametro, diametro, 180, 90);
        caminho.AddArc(area.Right - diametro, area.Top, diametro, diametro, 270, 90);
        caminho.AddArc(area.Right - diametro, area.Bottom - diametro, diametro, diametro, 0, 90);
        caminho.AddArc(area.Left, area.Bottom - diametro, diametro, diametro, 90, 90);
        caminho.CloseFigure();

        controle.Region?.Dispose();
        controle.Region = new Region(caminho);
    }

    /// <summary>
    /// Aplica o tema completo aos antigos formulários genéricos, incluindo áreas
    /// de campos, barra de ações, botões e controles descendentes.
    /// </summary>
    public static void EstilizarFormularioCadastro(
        Form formulario,
        Button botaoPrincipal,
        Button botaoCancelar,
        string textoBotaoPrincipal)
    {
        formulario.BackColor = Color.FromArgb(248, 250, 252);
        formulario.Font = new Font("Segoe UI", 9.5F);

        var areaCampos = formulario.Controls.OfType<TableLayoutPanel>().FirstOrDefault();
        if (areaCampos is not null)
        {
            areaCampos.AutoScroll = true;
            areaCampos.Dock = DockStyle.Fill;
            areaCampos.BackColor = Color.White;
            areaCampos.Padding = new Padding(24, 20, 24, 20);
            areaCampos.ColumnCount = 1;
            areaCampos.ColumnStyles.Clear();
            areaCampos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        }

        var areaBotoes = formulario.Controls.OfType<FlowLayoutPanel>().FirstOrDefault();
        if (areaBotoes is not null)
        {
            if (!areaBotoes.Controls.Contains(botaoPrincipal))
                areaBotoes.Controls.Add(botaoPrincipal);
            if (!areaBotoes.Controls.Contains(botaoCancelar))
                areaBotoes.Controls.Add(botaoCancelar);
            areaBotoes.Dock = DockStyle.Bottom;
            areaBotoes.Height = 72;
            areaBotoes.FlowDirection = FlowDirection.RightToLeft;
            areaBotoes.Padding = new Padding(12, 12, 18, 12);
            areaBotoes.BackColor = Color.FromArgb(248, 250, 252);
        }

        formulario.AcceptButton = botaoPrincipal;
        formulario.CancelButton = botaoCancelar;
        formulario.FormBorderStyle = FormBorderStyle.FixedDialog;
        formulario.MaximizeBox = false;
        formulario.MinimizeBox = false;
        formulario.StartPosition = FormStartPosition.CenterParent;

        botaoPrincipal.Text = textoBotaoPrincipal;
        botaoPrincipal.BackColor = Laranja;
        botaoPrincipal.ForeColor = Color.White;
        botaoPrincipal.FlatStyle = FlatStyle.Flat;
        botaoPrincipal.FlatAppearance.BorderSize = 0;
        botaoPrincipal.Cursor = Cursors.Hand;
        botaoPrincipal.Height = 44;
        botaoPrincipal.Padding = new Padding(16, 0, 16, 0);
        botaoPrincipal.AutoSize = true;

        botaoCancelar.Text = "Cancelar";
        botaoCancelar.BackColor = Color.White;
        botaoCancelar.ForeColor = Laranja;
        botaoCancelar.FlatStyle = FlatStyle.Flat;
        botaoCancelar.FlatAppearance.BorderColor = Laranja;
        botaoCancelar.FlatAppearance.BorderSize = 1;
        botaoCancelar.Cursor = Cursors.Hand;
        botaoCancelar.Height = 44;
        botaoCancelar.Padding = new Padding(16, 0, 16, 0);
        botaoCancelar.AutoSize = true;

        EstilizarControles(formulario);
        ManterArredondado(botaoPrincipal, 10);
        ManterArredondado(botaoCancelar, 10);
    }

    /// <summary>
    /// Aplica somente o recorte arredondado. Cores, fontes, textos, margens e
    /// tamanhos continuam sendo controlados pelo Windows Forms Designer.
    /// </summary>
    public static void ArredondarCamposFormulario(Form formulario)
    {
        foreach (var controle in EnumerarControles(formulario))
        {
            switch (controle)
            {
                case Button botao:
                    ManterArredondado(botao, 10);
                    break;
                case TextBox:
                case ComboBox:
                case NumericUpDown:
                case DateTimePicker:
                    ManterArredondado(controle, 7);
                    break;
            }
        }
    }

    /// <summary>Percorre recursivamente todos os controles filhos de um contêiner.</summary>
    private static IEnumerable<Control> EnumerarControles(Control controlePai)
    {
        foreach (Control controle in controlePai.Controls)
        {
            yield return controle;
            foreach (var filho in EnumerarControles(controle))
                yield return filho;
        }
    }

    /// <summary>Aplica fonte, cor e espaçamento conforme o tipo de controle.</summary>
    private static void EstilizarControles(Control controlePai)
    {
        foreach (Control controle in controlePai.Controls)
        {
            switch (controle)
            {
                case TableLayoutPanel tabela:
                    tabela.BackColor = Color.White;
                    break;

                case FlowLayoutPanel painelBotoes:
                    painelBotoes.BackColor = Color.FromArgb(248, 250, 252);
                    break;

                case Label label:
                    label.ForeColor = Texto;
                    label.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                    label.Margin = new Padding(0, 10, 0, 5);
                    break;

                case TextBox texto:
                    texto.BackColor = Color.White;
                    texto.ForeColor = Texto;
                    texto.BorderStyle = BorderStyle.FixedSingle;
                    texto.Font = new Font("Segoe UI", 10.5F);
                    texto.Margin = new Padding(0, 0, 0, 8);
                    ManterArredondado(texto, 7);
                    break;

                case ComboBox combo:
                    combo.BackColor = Color.White;
                    combo.ForeColor = Texto;
                    combo.FlatStyle = FlatStyle.Flat;
                    combo.Font = new Font("Segoe UI", 10.5F);
                    combo.Margin = new Padding(0, 0, 0, 8);
                    ManterArredondado(combo, 7);
                    break;

                case NumericUpDown numero:
                    numero.BackColor = Color.White;
                    numero.ForeColor = Texto;
                    numero.BorderStyle = BorderStyle.FixedSingle;
                    numero.Font = new Font("Segoe UI", 10.5F);
                    numero.Margin = new Padding(0, 0, 0, 8);
                    ManterArredondado(numero, 7);
                    break;

                case DateTimePicker data:
                    data.CalendarForeColor = Texto;
                    data.CalendarMonthBackground = Color.White;
                    data.Font = new Font("Segoe UI", 10.5F);
                    data.Margin = new Padding(0, 0, 0, 8);
                    ManterArredondado(data, 7);
                    break;

                case CheckBox checkBox:
                    checkBox.ForeColor = Texto;
                    checkBox.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                    break;
            }

            if (controle.HasChildren)
                EstilizarControles(controle);
        }
    }

    /// <summary>Reaplica a região arredondada quando o handle ou tamanho mudar.</summary>
    private static void ManterArredondado(Control controle, int raio)
    {
        void Atualizar(object? _, EventArgs __) => Arredondar(controle, raio);
        controle.HandleCreated += Atualizar;
        controle.Resize += Atualizar;
        Arredondar(controle, raio);
    }
}
