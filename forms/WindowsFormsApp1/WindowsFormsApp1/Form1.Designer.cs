namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dividing = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.minus = new System.Windows.Forms.Button();
            this.times_x = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.squared = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.Equals = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.clearall = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.panel1_mousedown = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dividing
            // 
            this.dividing.Location = new System.Drawing.Point(435, 239);
            this.dividing.Name = "dividing";
            this.dividing.Size = new System.Drawing.Size(54, 43);
            this.dividing.TabIndex = 0;
            this.dividing.Text = "÷";
            this.dividing.UseVisualStyleBackColor = true;
            //this.dividing.Click += new System.EventHandler(this.dividing_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(817, 391);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 2;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(195, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(242, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(547, 357);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(214, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(268, 239);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(51, 43);
            this.minus.TabIndex = 6;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // times_x
            // 
            this.times_x.Location = new System.Drawing.Point(347, 239);
            this.times_x.Name = "times_x";
            this.times_x.Size = new System.Drawing.Size(54, 43);
            this.times_x.TabIndex = 7;
            this.times_x.Text = "X";
            this.times_x.UseVisualStyleBackColor = true;
            this.times_x.Click += new System.EventHandler(this.times_x_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(183, 239);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(55, 43);
            this.plus.TabIndex = 8;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(183, 288);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(55, 48);
            this.seven.TabIndex = 9;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(268, 288);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(51, 48);
            this.eight.TabIndex = 10;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(347, 288);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(54, 48);
            this.nine.TabIndex = 11;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // squared
            // 
            this.squared.Location = new System.Drawing.Point(435, 288);
            this.squared.Name = "squared";
            this.squared.Size = new System.Drawing.Size(54, 48);
            this.squared.TabIndex = 12;
            this.squared.Text = "x^";
            this.squared.UseVisualStyleBackColor = true;
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(183, 389);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(55, 41);
            this.one.TabIndex = 13;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(268, 389);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(51, 41);
            this.two.TabIndex = 14;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(347, 342);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(54, 41);
            this.six.TabIndex = 15;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // Equals
            // 
            this.Equals.Location = new System.Drawing.Point(435, 342);
            this.Equals.Name = "Equals";
            this.Equals.Size = new System.Drawing.Size(54, 41);
            this.Equals.TabIndex = 16;
            this.Equals.Text = "=";
            this.Equals.UseVisualStyleBackColor = true;
            this.Equals.Click += new System.EventHandler(this.Equals_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(183, 342);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(55, 41);
            this.four.TabIndex = 17;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(268, 342);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(51, 41);
            this.five.TabIndex = 18;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(347, 389);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(54, 41);
            this.three.TabIndex = 19;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(435, 389);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(54, 41);
            this.button16.TabIndex = 20;
            this.button16.Text = "button16";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // backspace
            // 
            this.backspace.Location = new System.Drawing.Point(183, 436);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(55, 39);
            this.backspace.TabIndex = 21;
            this.backspace.Text = "⌫";
            this.backspace.UseVisualStyleBackColor = true;
            this.backspace.Click += new System.EventHandler(this.backspace_Click);
            // 
            // clearall
            // 
            this.clearall.Location = new System.Drawing.Point(264, 436);
            this.clearall.Name = "clearall";
            this.clearall.Size = new System.Drawing.Size(55, 39);
            this.clearall.TabIndex = 22;
            this.clearall.Text = "CE";
            this.clearall.UseVisualStyleBackColor = true;
            this.clearall.Click += new System.EventHandler(this.clearall_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(346, 436);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(55, 39);
            this.button19.TabIndex = 23;
            this.button19.Text = "button19";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(434, 436);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(55, 39);
            this.button20.TabIndex = 24;
            this.button20.Text = "button20";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // panel1_mousedown
            // 
            this.panel1_mousedown.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.panel1_mousedown.Location = new System.Drawing.Point(1140, 216);
            this.panel1_mousedown.Name = "panel1_mousedown";
            this.panel1_mousedown.Size = new System.Drawing.Size(200, 140);
            this.panel1_mousedown.TabIndex = 26;
            this.panel1_mousedown.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_mousedown_Paint);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1171, 459);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(101, 107);
            this.panel1.TabIndex = 27;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.zawg;
            this.pictureBox2.Location = new System.Drawing.Point(183, 548);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(754, 318);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(707, 272);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1089, 632);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 71);
            this.button1.TabIndex = 28;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 973);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel1_mousedown);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.clearall);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.three);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.Equals);
            this.Controls.Add(this.six);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.squared);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.times_x);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.dividing);
            this.Name = "Form1";
            this.Text = "pa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dividing;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button times_x;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button squared;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button Equals;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button clearall;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1_mousedown;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}

