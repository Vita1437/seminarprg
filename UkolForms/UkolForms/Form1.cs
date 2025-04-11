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
        bool paint = false;
        public Point currentPoint = new Point();
        public Point oldPoint = new Point();    
        public Pen pen1 = new Pen(Color.DarkRed, 2);
        public Graphics panelGraphics;
        static Random rng = new Random();
        public Point randomCoords = new Point(rng.Next(400, 1000),rng.Next(400, 1000));
        Bitmap bmp;

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
            
            //button3.Size = new Size(button3.Width + 1000, button3.Height + 1000);
            
            int rng_1 = rng.Next(1, 10);
            if(rng_1 == 9)
            {
                button3. Location = new Point(1008, 25);
                button3.Size = new Size(75, 23);

            }
            else { button3.Location = new Point(0, 0); button3.Height = button3.Height + 500;button3.Width = button3.Width + 500;}
            
            panel1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //panelGraphics.DrawArc(pen1, 100, 100, 300, 300, 40, 40);
            panelGraphics.Clear(Color.White);
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            paint = true;

            if (operationNum == 2 )
            {
                sizeX = e.X - oldPoint.X;
                sizeY = e.Y - oldPoint.Y;
                currentPoint = new Point(Math.Min(e.X, oldPoint.X), Math.Min(e.Y, oldPoint.Y));
                panelGraphics.DrawEllipse(pen1, currentPoint.X, currentPoint.Y, sizeX, sizeY);
                panel1.Invalidate();
            }
            else if (operationNum == 3 )
            {
                sizeX = e.X - oldPoint.X;
                sizeY = e.Y - oldPoint.Y;
                currentPoint = new Point(Math.Min(e.X, oldPoint.X), Math.Min(e.Y, oldPoint.Y));
                panelGraphics.DrawRectangle(pen1, currentPoint.X, currentPoint.Y, sizeX, sizeY);
                panel1.Invalidate();
            }

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Point panelPoint = panel1.PointToClient(Cursor.Position);
            if(paint == true )
            {
                if(operationNum == 1)
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
        /*private void setimage()
        {
            blueColorSwich.Image = Properties.Recources
        }*/
        private void elipseMode_Click(object sender, EventArgs e)
        {
            operationNum = 2;
        }

        private void drawing_Click(object sender, EventArgs e)
        {
            operationNum = 1;
        }

        private void rubber_Click(object sender, EventArgs e)
        {
            pen1.Color = Color.White;
            operationNum = 1;
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            oldPoint = e.Location;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void whiteColorSwich_Click(object sender, EventArgs e)
        {
            pen1.Color = Color.White;
        }

        private void blackColorSwich_Click(object sender, EventArgs e)
        {
            pen1.Color = Color.Black;
        }

        private void greyColorSwich_Click(object sender, EventArgs e)
        {
            pen1.Color = Color.Gray;
        }

        private void lightBrownColorSwich_Click(object sender, EventArgs e)
        {
            pen1.Color = Color.BlanchedAlmond;
        }

        private void redColorSwich_Click(object sender, EventArgs e)
        {
            pen1.Color = Color.Red;
        }

        private void brownColorSwich_Click(object sender, EventArgs e)
        {
            pen1.Color = Color.Brown;
        }

        private void orangeColorSwich_Click(object sender, EventArgs e)
        {
            pen1.Color = Color.Orange;
        }

        private void pinkColorSwich_Click(object sender, EventArgs e)
        {
            pen1.Color = Color.Pink;
        }

        private void yellowColorSwich_Click(object sender, EventArgs e)
        {
            pen1.Color = Color.Yellow;
        }

        private void cyanColorSwich_Click(object sender, EventArgs e)
        {
            pen1.Color = Color.Cyan;
        }

        private void greenColorSwitch_Click(object sender, EventArgs e)
        {
            pen1.Color = Color.Green;
        }

        private void LightBlueColorSwich_Click(object sender, EventArgs e)
        {
            pen1.Color = Color.LightBlue;
        }

        private void DarkBlueColorSwich_Click(object sender, EventArgs e)
        {
            darkBlueColorSwich.Location = new Point(rng.Next(40, 1000), rng.Next(40, 600));
            pen1.Color = Color.DarkBlue;
        }

        private void BlueColorSwich_Click(object sender, EventArgs e)
        {
            pen1.Color = Color.Blue;
        }

        private void PenSize_Scroll(object sender, EventArgs e)
        {
            pen1.Width = penSize.Value;
            label1.Text = penSize.Value.ToString();
        }

        private void PictureBox17_Click(object sender, EventArgs e)
        {
            oldPoint = currentPoint;
            panelGraphics.DrawEllipse(pen1, oldPoint.X, oldPoint.Y, currentPoint.X, currentPoint.Y);

        }



        private void Filling_Click(object sender, EventArgs e)
        {
            operationNum = 4;
        }

        private void rectangleMode_Click(object sender, EventArgs e)
        {
            operationNum = 3;
        }


    }
}
