using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP.Forms
{
    internal class Recangle
    {
        public int  width, height;
        Color color;
        Brush brush;
        Pen pen;
        public bool fill;
        public Recangle(Color color, int width, int height)
        {
            this.color = color;
            Brush = new SolidBrush(color);
            this.height = height;
        }

        public void Draw()
    }
}
