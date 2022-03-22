using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Importador
{
    public class SplitButtont : Button
    {
        public ContextMenuStrip Cms = new ContextMenuStrip();
        
        Bitmap BmpSplit;

        private String[] Cole = new String[4];
        public String[] ColecaoItens {
            
            get { return Cole; }

            set { Cole = value; }
        }
        protected override void InitLayout() {
            
            base.InitLayout();

            Split();
            
            for (int count = 0; count < Cole.LongLength; count++) { Cms.Items.Add(Cole[count]); }
        }
        protected override void OnClick(EventArgs e) {
            
            base.OnClick(e);

            if (Posicao()) { Cms.Show(this, 0, this.Height); }
        }
        private bool Posicao() {

            bool pos = false;

            int X = PointToClient(MousePosition).X;
            int Y = PointToClient(MousePosition).Y;

            if ( X > this.Width - BmpSplit.Width && X < this.Width && Y > 0 && Y < this.Height )

            pos = true;

            return pos;
        }
        private void Split() { 
            BmpSplit = new Bitmap(15, this.Height);

            Graphics gra = Graphics.FromImage(BmpSplit);

            gra.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;

            Point[] ponto = {
                    new Point(15, BmpSplit.Height/2 - 5),
                    new Point(5, BmpSplit.Height/2 - 5),
                    new Point(10, BmpSplit.Height/2)
            };

            gra.FillPolygon(new SolidBrush(Color.Black), ponto);
            
            gra.DrawLine (
                new Pen(Color.Silver), 
                new Point(0, 0),
                new Point(0, BmpSplit.Height)
                );

            this.ImageAlign = ContentAlignment.MiddleRight;
            this.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Image = BmpSplit;
        }
    }
}
