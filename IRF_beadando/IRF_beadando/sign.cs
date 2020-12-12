using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_beadando
{
    public abstract class Sign : Label
    {
        public Sign()
        {
            AutoSize = false;
            Width = 70;
            Height = Width;
            Paint += Sign_Paint;
        }

        private void Sign_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }
        protected abstract void DrawImage(Graphics g);
    }
}
