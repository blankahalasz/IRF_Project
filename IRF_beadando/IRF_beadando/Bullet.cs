using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_beadando
{
    public class Bullet : Label
    {
        public Bullet()
        {
            AutoSize = false;
            Width = 10;
            Height = Width;
            Paint += Bullet_Paint;
        }

        public void Bullet_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }

        public void DrawImage(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.Black), 0, 0, Width, Height);
        }

        public void MoveBullet()
        {
            Left += 1;
        }
    }
}

