
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PetShop_App.Componentes
{
    /// <summary>
    /// Painel reutilizável com borda e cantos arredondados. Pode ser configurado
    /// diretamente pela janela de propriedades do Windows Forms Designer.
    /// </summary>
    public class PainelArredondado : Panel
    {
        private int raio = 12;
        private Color corBorda = Color.FromArgb(200, 205, 215);
        private int espessuraBorda = 1;

        [Category("Aparência")]
        public int Raio
        {
            get => raio;
            set
            {
                raio = Math.Max(0, value);
                AtualizarRegiao();
                Invalidate();
            }
        }

        [Category("Aparência")]
        public Color CorBorda
        {
            get => corBorda;
            set
            {
                corBorda = value;
                Invalidate();
            }
        }

        [Category("Aparência")]
        public int EspessuraBorda
        {
            get => espessuraBorda;
            set
            {
                espessuraBorda = Math.Max(1, value);
                Invalidate();
            }
        }

        public PainelArredondado()
        {
            DoubleBuffered = true;
            BackColor = Color.White;
            Padding = new Padding(12, 5, 12, 5);
        }

        /// <summary>Cria o caminho gráfico usado tanto no recorte quanto na borda.</summary>
        private GraphicsPath CriarCaminho(Rectangle area)
        {
            GraphicsPath caminho = new GraphicsPath();

            int diametro = Math.Min(
                raio * 2,
                Math.Min(area.Width, area.Height)
            );

            if (diametro <= 0)
            {
                caminho.AddRectangle(area);
                return caminho;
            }

            caminho.AddArc(
                area.Left, area.Top,
                diametro, diametro, 180, 90);

            caminho.AddArc(
                area.Right - diametro, area.Top,
                diametro, diametro, 270, 90);

            caminho.AddArc(
                area.Right - diametro,
                area.Bottom - diametro,
                diametro, diametro, 0, 90);

            caminho.AddArc(
                area.Left,
                area.Bottom - diametro,
                diametro, diametro, 90, 90);

            caminho.CloseFigure();

            return caminho;
        }

        /// <summary>Atualiza a região clicável/visível sempre que o tamanho muda.</summary>
        private void AtualizarRegiao()
        {
            if (Width <= 0 || Height <= 0)
                return;

            using var caminho = CriarCaminho(
                new Rectangle(0, 0, Width, Height)
            );

            var regiaoAnterior = Region;
            Region = new Region(caminho);
            regiaoAnterior?.Dispose();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            AtualizarRegiao();
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (Width <= 2 || Height <= 2)
                return;

            e.Graphics.SmoothingMode =
                SmoothingMode.AntiAlias;

            using var caminho = CriarCaminho(
                new Rectangle(
                    1, 1,
                    Width - 3,
                    Height - 3
                )
            );

            using var caneta = new Pen(
                corBorda,
                espessuraBorda
            );

            e.Graphics.DrawPath(caneta, caminho);
        }
    }
}
