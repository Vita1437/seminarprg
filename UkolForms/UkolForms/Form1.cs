using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UkolForms
{
    public partial class Form1 : Form
    {

        public Point currentPoint = new Point();
        public Point oldPoint = new Point();    
        public Pen pen1 = new Pen(Color.DarkRed, 2);
        public Graphics panelGraphics;
        public Form1()
        {
            InitializeComponent();

            panelGraphics = panel1.CreateGraphics();
            pen1.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            panelGraphics.DrawEllipse(pen1, 100, 100, 400, 100);
            button1.Size = new Size(button1.Width + 100, button1.Height + 100);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelGraphics.DrawArc(pen1, 100, 100, 300, 300, 40, 40);
            panelGraphics.Clear(Color.White);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
