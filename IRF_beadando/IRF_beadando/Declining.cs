using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF_beadando
{
    class Declining : Sign
    {
        protected override void DrawImage(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.Blue), 4, 4, Width, Height);
        }
    }
}
