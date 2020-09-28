using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public class Grafic:Control
    {
        private void Grafic_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.P)
            {
                int contor = 0;
                MessageBox.Show("Tiparire...");
                PrintDocument document = new PrintDocument();
                document.PrintPage += (s, pea) =>
                {
                    Desenare(pea.Graphics, pea.MarginBounds);
                    contor++;
                    pea.Graphics.DrawString("Pagina" + contor, Font, Brushes.Black, pea.MarginBounds.Location);
                    pea.HasMorePages = contor < 3;

                };
                PrintPreviewDialog dialog = new PrintPreviewDialog();
                dialog.Document = document;
                dialog.ShowDialog();
            }
        }
        void Desenare(Graphics g, Rectangle r)
        {
            g.FillRectangle(Brushes.White, r);

            if (valori.Length == 0)
            {
                return;
            }
            float W = r.Width, H = r.Height;
            int n = valori.Length;
            float w = W / n, f = H * 0.9f / Valori.Max();

            for (int i = 0; i < n; i++)
            {
                float hi = Valori[i] * f;
                RectangleF rElem = new RectangleF(x: i * w + 0.1f * w + r.Left, y: H - hi + r.Top, width: w * 0.8f, height: hi);
                g.FillRectangle(Brushes.LightCoral, rElem);
                g.DrawRectangle(Pens.Black, Rectangle.Round(rElem));
            }
        }

        int[] valori = new int[0];
        public int[] Valori
        {
            get { return valori; }
            set
            {
                if (value != null)
                {
                    valori = value;
                    Invalidate(); //sa redesenam cu noile valori
                }
            }
        }
    }
}
