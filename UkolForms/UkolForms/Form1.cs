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
        public Pen pen = new Pen(Color.DarkRed, 1);
        public Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
