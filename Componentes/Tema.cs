using System.Drawing.Drawing2D;

namespace PetShop_App.Componentes;

public static class Tema
{
    public static readonly Color Laranja = Color.FromArgb(255, 128, 0);
    public static readonly Color LaranjaClaro = Color.FromArgb(255, 240, 226);
    public static readonly Color Fundo = Color.FromArgb(241, 245, 249);
    public static readonly Color Texto = Color.FromArgb(15, 23, 42);
    public static readonly Color Secundario = Color.FromArgb(100, 116, 139);

    public static Button Botao(string texto, bool principal = true)
    {
        return new Button { Text = texto, AutoSize = true, Height = 40, Padding = new Padding(14, 0, 14, 0), FlatStyle = FlatStyle.Flat,
            BackColor = principal ? Laranja : Color.White, ForeColor = principal ? Color.White : Laranja,
            Font = new Font("Segoe UI", 10, FontStyle.Bold), Cursor = Cursors.Hand };
    }

    public static Label Titulo(string texto) => new() { Text = texto, AutoSize = true, Font = new Font("Segoe UI", 22, FontStyle.Bold), ForeColor = Texto };
    public static Label Subtitulo(string texto) => new() { Text = texto, AutoSize = true, Font = new Font("Segoe UI", 10), ForeColor = Secundario };

    public static DataGridView Grade()
    {
        var grade = new DataGridView { Dock = DockStyle.Fill, BackgroundColor = Color.White, BorderStyle = BorderStyle.None, AutoGenerateColumns = true,
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill, ReadOnly = true, AllowUserToAddRows = false, AllowUserToDeleteRows = false,
            RowHeadersVisible = false, SelectionMode = DataGridViewSelectionMode.FullRowSelect, MultiSelect = false };
        grade.EnableHeadersVisualStyles = false;
        grade.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.FromArgb(248,250,252), ForeColor = Texto, Font = new Font("Segoe UI", 9, FontStyle.Bold), Padding = new Padding(8) };
        grade.DefaultCellStyle = new DataGridViewCellStyle { Font = new Font("Segoe UI", 9), ForeColor = Texto, SelectionBackColor = LaranjaClaro, SelectionForeColor = Texto, Padding = new Padding(8) };
        grade.RowTemplate.Height = 42;
        return grade;
    }

    public static void Arredondar(Control controle, int raio = 12)
    {
        if (controle.Width < 1 || controle.Height < 1) return;
        using var caminho = new GraphicsPath();
        var d = raio * 2; var r = controle.ClientRectangle;
        caminho.AddArc(r.Left, r.Top, d, d, 180, 90); caminho.AddArc(r.Right-d, r.Top, d, d, 270, 90);
        caminho.AddArc(r.Right-d, r.Bottom-d, d, d, 0, 90); caminho.AddArc(r.Left, r.Bottom-d, d, d, 90, 90); caminho.CloseFigure();
        controle.Region?.Dispose(); controle.Region = new Region(caminho);
    }
}
