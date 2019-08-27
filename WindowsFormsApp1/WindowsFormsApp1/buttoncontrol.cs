using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class buttoncontrol : System.Windows.Forms.Button
    {
        private Color color1 = Color.LightGreen;
        private Color color2 = Color.DarkBlue;
        private int weight = 120;
        private int height = 150;
        private int angle = 100;
        private int color1Transparent = 150;
        private int color2Transparent = 150;

        public Color Color1 { get => color1; set => color1 = value; }
        public Color Color2 { get => color2; set => color2 = value; }
        public int Color1Transparent { get => color1Transparent; set => color1Transparent = value; }
        public int Color2Transparent { get => color2Transparent; set => color2Transparent = value; }
        public void buttonz()
        {
            this.Size = new System.Drawing.Size(200, 50);
            this.ForeColor = Color.White;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Color c1 = Color.FromArgb(color1Transparent, color1);
            Color c2 = Color.FromArgb(color2Transparent, color2);
            Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(ClientRectangle, c1, c2, angle);
            pevent.Graphics.FillRectangle(b, ClientRectangle);
            b.Dispose();
        }
    }

}
