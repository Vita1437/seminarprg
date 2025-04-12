using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms_paint
{
    public partial class Form1 : Form
    {
        bool paint = false;
        public Point currentPoint = new Point();
        public Point oldPoint = new Point();
        public Pen pen1 = new Pen(Color.DarkRed, 2);
        public Graphics panelGraphics;
        static Random rng = new Random();
        public Point randomCoords = new Point(rng.Next(400, 1000), rng.Next(400, 1000));
        Bitmap bmp;
        Brush brush = new TextureBrush(Properties.Resources.texture);
        

        int operationNum;
        int sizeX, sizeY;
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(panel1.Width, panel1.Height);
            panelGraphics = Graphics.FromImage(bmp);
            pen1.SetLineCap(System.Drawing.Drawing2D.LineCap.Round,
                            System.Drawing.Drawing2D.LineCap.Round,
                            System.Drawing.Drawing2D.DashCap.Round);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelGraphics.Clear(Color.White);
            panel1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rng_1 = rng.Next(1, 8);
            if (rng_1 == 7)
            {
                button2.Location = new Point(1008, 25);
                button2.Size = new Size(75, 23);

            }
            else { button2.Location = new Point(0, 0); button2.Height = button2.Height + 500; button2.Width = button2.Width + 500; }

            panel1.Invalidate();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Point panelPoint = panel1.PointToClient(Cursor.Position);
            if (paint == true)
            {
                if (operationNum == 1)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        currentPoint = panelPoint;
                        panelGraphics.DrawLine(pen1, oldPoint, currentPoint);
                        panel1.Invalidate();
                        oldPoint = currentPoint;
                    }
                }
                
            }
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            paint = true;

            if (operationNum == 2)
            {
                sizeX = Math.Abs(e.X - oldPoint.X);
                sizeY = Math.Abs(e.Y - oldPoint.Y);
                currentPoint = new Point(Math.Min(e.X, oldPoint.X), Math.Min(e.Y, oldPoint.Y));
                panelGraphics.DrawEllipse(pen1, currentPoint.X, currentPoint.Y, sizeX, sizeY);
                panel1.Invalidate();
            }
            else if (operationNum == 3)
            {
                sizeX = Math.Abs(e.X - oldPoint.X);
                sizeY = Math.Abs(e.Y - oldPoint.Y);
                currentPoint = new Point(Math.Min(e.X, oldPoint.X), Math.Min(e.Y, oldPoint.Y));
                panelGraphics.DrawRectangle(pen1, currentPoint.X, currentPoint.Y, sizeX, sizeY);
                panel1.Invalidate();
            }
            else if(operationNum == 4)
            {
                sizeX = Math.Abs(e.X - oldPoint.X);
                sizeY = Math.Abs(e.Y - oldPoint.Y);
                currentPoint = new Point(Math.Min(e.X, oldPoint.X), Math.Min(e.Y, oldPoint.Y));
                panelGraphics.DrawLine(pen1, oldPoint, currentPoint);
                panel1.Invalidate();
            }
            else if (operationNum == 5)
            {

                if (e.Button == MouseButtons.Left)
                {
                    sizeX = Math.Abs(e.X - oldPoint.X);
                    sizeY = Math.Abs(e.Y - oldPoint.Y);
                    currentPoint = new Point(Math.Min(e.X, oldPoint.X), Math.Min(e.Y, oldPoint.Y));
                    panelGraphics.FillEllipse(brush, currentPoint.X, currentPoint.Y, sizeX, sizeY);
                    panel1.Invalidate();
                }
            }
            else if (operationNum == 6)
            {
                sizeX = Math.Abs(e.X - oldPoint.X);
                sizeY = Math.Abs(e.Y - oldPoint.Y);
                currentPoint = new Point(Math.Min(e.X, oldPoint.X), Math.Min(e.Y, oldPoint.Y));
                panelGraphics.FillRectangle(brush, currentPoint.X, currentPoint.Y, sizeX, sizeY);
                panel1.Invalidate();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            oldPoint = e.Location;
        }

        private void penSize_Scroll(object sender, EventArgs e)
        {
            pen1.Width = penSize.Value;
            label1.Text = penSize.Value.ToString();
        }

        private void drawing_Click(object sender, EventArgs e)
        {
            operationNum = 1;
            pen1 = new Pen(Color.DarkRed, 2);
        }

        private void rubber_Click(object sender, EventArgs e)
        {
            pen1.Color = Color.White;
            operationNum = 1;
        }

        private void elipseMode_Click(object sender, EventArgs e)
        {
            operationNum = 2;
        }

        private void rectangleMode_Click(object sender, EventArgs e)
        {
            operationNum = 3;
        }

        private void blueColorSwich_Click(object sender, EventArgs e)
        {
            blueColorSwich.Location = new Point(rng.Next(40, 1000), rng.Next(40, 600));
            pen1.Color = Color.Blue;
        }

        private void darkBlueColorSwich_Click(object sender, EventArgs e)
        {
            pen1.Color = Color.DarkBlue;
            
        }

        private void lightBlueColorSwich_Click(object sender, EventArgs e)
        {
            pen1.Color = Color.LightBlue;
        }

        private void greenColorSwich_Click(object sender, EventArgs e)
        {
            pen1.Color = Color.Green;
        }

        private void cyanColorSwich_Click(object sender, EventArgs e)
        {
            pen1.Color = Color.Cyan;
        }

        private void yellowColorSwich_Click(object sender, EventArgs e)
        {
            pen1.Color = Color.Yellow;
        }

        private void pinkColorSwich_Click(object sender, EventArgs e)
        {
            pen1.Color = Color.Pink;
        }

        private void orangeColorSwich_Click(object sender, EventArgs e)
        {
            pen1.Color = Color.Orange;
        }

        private void darkBrownColorSwich_Click(object sender, EventArgs e)
        {
            pen1.Color = Color.Brown;
        }

        private void redColorSwich_Click(object sender, EventArgs e)
        {
            pen1.Color = Color.Red;
        }

        private void lightBrownColorSwich_Click(object sender, EventArgs e)
        {
            pen1.Color = Color.BlanchedAlmond;
        }

        private void greyColorSwich_Click(object sender, EventArgs e)
        {
            pen1.Color = Color.Gray;
        }

        private void whiteColorSwich_Click(object sender, EventArgs e)
        {
            pen1.Color = Color.White;
        }

        private void lineMode_Click(object sender, EventArgs e)
        {
            operationNum = 4;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            operationNum = 1;
            //Pen pen2 = new Pen(brush);
            //pen1 = pen2;
        }

        private void fillElipseMode_Click(object sender, EventArgs e)
        {
            operationNum = 5;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            operationNum = 6;
        }

        private void blackColorSwich_Click(object sender, EventArgs e)
        {
            pen1.Color = Color.Black;
        }

        

        
    }
}
