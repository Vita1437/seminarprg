using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Random rng = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            dividing.Text = "clicked";
            int timesClicked = 1;
            int num1 = rng.Next(0,20);
            
            if (num1 == 0)
            {
                dividing.Size = new Size(dividing.Width - 10, dividing.Height -10);
                dividing.Visible = false;
            }
            else { dividing.Size = new Size(dividing.Width + 10, dividing.Height + 10); dividing.Visible = true; dividing.Text = "clicked " + timesClicked + " times";}
            
        }*/
        


     

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void plus_Click(object sender, EventArgs e)
        {
            double temp = Convert.ToDouble(textBox1.Text);
            textBox1.Text += " + ";
        }
        private void minus_Click(object sender, EventArgs e)
        {
            double temp = Convert.ToDouble(textBox1.Text);
            textBox1.Text += " + ";
        }

        private void one_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }
        private void five_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }
        private void six_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void backspace_Click(object sender, EventArgs e)
        {

            string textArray = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            Console.WriteLine(textArray.Length);
            textBox1.Clear();
            textBox1.Text = textArray;

            
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            textBox1.Text.Split(' ');
            List<string> input = new List<string>();
            for (int i = 0; i < textBox1.Text.Length;)
            {

            }

        }

        private void clearall_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void times_x_Click(object sender, EventArgs e)
        {
            textBox1.Text += " x ";
        }

        private void dividing_Click(object sender, EventArgs e)
        {
            textBox1.Text += " ÷ ";
        }
    }
}
