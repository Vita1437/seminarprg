using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prace_s_textem_a_soubory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toUpper_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToUpper();
        }

        private void toLower_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToLower();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            string[] words = textBox1.Text.Split(' ');
            textBox1.Clear();
            foreach (string word in words)
            {
                textBox1.Text += word;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            int position = int.Parse(textBox2.Text) + 1;
            string text = textBox1.Text;
            string newText = text.Insert(position, textBox3.Text);
            textBox1.Text  = newText;

        }
    }
}
