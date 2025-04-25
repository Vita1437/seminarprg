namespace forms_paint
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.penSize = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.fillElipseMode = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lineMode = new System.Windows.Forms.Button();
            this.elipseMode = new System.Windows.Forms.Button();
            this.rectangleMode = new System.Windows.Forms.Button();
            this.rubber = new System.Windows.Forms.Button();
            this.drawing = new System.Windows.Forms.Button();
            this.whiteColorSwich = new System.Windows.Forms.PictureBox();
            this.lightBrownColorSwich = new System.Windows.Forms.PictureBox();
            this.darkBrownColorSwich = new System.Windows.Forms.PictureBox();
            this.pinkColorSwich = new System.Windows.Forms.PictureBox();
            this.cyanColorSwich = new System.Windows.Forms.PictureBox();
            this.lightBlueColorSwich = new System.Windows.Forms.PictureBox();
            this.blackColorSwich = new System.Windows.Forms.PictureBox();
            this.greyColorSwich = new System.Windows.Forms.PictureBox();
            this.redColorSwich = new System.Windows.Forms.PictureBox();
            this.orangeColorSwich = new System.Windows.Forms.PictureBox();
            this.yellowColorSwich = new System.Windows.Forms.PictureBox();
            this.greenColorSwich = new System.Windows.Forms.PictureBox();
            this.blueColorSwich = new System.Windows.Forms.PictureBox();
            this.darkBlueColorSwich = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteColorSwich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightBrownColorSwich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkBrownColorSwich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkColorSwich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyanColorSwich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightBlueColorSwich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackColorSwich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greyColorSwich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redColorSwich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeColorSwich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowColorSwich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenColorSwich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueColorSwich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkBlueColorSwich)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1383, 750);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.fillElipseMode);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.lineMode);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.elipseMode);
            this.panel2.Controls.Add(this.rectangleMode);
            this.panel2.Controls.Add(this.rubber);
            this.panel2.Controls.Add(this.drawing);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.penSize);
            this.panel2.Controls.Add(this.whiteColorSwich);
            this.panel2.Controls.Add(this.lightBrownColorSwich);
            this.panel2.Controls.Add(this.darkBrownColorSwich);
            this.panel2.Controls.Add(this.pinkColorSwich);
            this.panel2.Controls.Add(this.cyanColorSwich);
            this.panel2.Controls.Add(this.lightBlueColorSwich);
            this.panel2.Controls.Add(this.blackColorSwich);
            this.panel2.Controls.Add(this.greyColorSwich);
            this.panel2.Controls.Add(this.redColorSwich);
            this.panel2.Controls.Add(this.orangeColorSwich);
            this.panel2.Controls.Add(this.yellowColorSwich);
            this.panel2.Controls.Add(this.greenColorSwich);
            this.panel2.Controls.Add(this.blueColorSwich);
            this.panel2.Controls.Add(this.darkBlueColorSwich);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1383, 108);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(658, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "0";
            // 
            // penSize
            // 
            this.penSize.BackColor = System.Drawing.Color.DarkGray;
            this.penSize.LargeChange = 1;
            this.penSize.Location = new System.Drawing.Point(442, 25);
            this.penSize.Maximum = 100;
            this.penSize.Name = "penSize";
            this.penSize.Size = new System.Drawing.Size(195, 45);
            this.penSize.TabIndex = 15;
            this.penSize.Scroll += new System.EventHandler(this.penSize_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1110, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1008, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::forms_paint.Properties.Resources.filledRectangleSign;
            this.button4.Location = new System.Drawing.Point(192, 53);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(26, 26);
            this.button4.TabIndex = 24;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // fillElipseMode
            // 
            this.fillElipseMode.BackgroundImage = global::forms_paint.Properties.Resources.filledElipseSign;
            this.fillElipseMode.Location = new System.Drawing.Point(160, 54);
            this.fillElipseMode.Name = "fillElipseMode";
            this.fillElipseMode.Size = new System.Drawing.Size(26, 26);
            this.fillElipseMode.TabIndex = 23;
            this.fillElipseMode.UseVisualStyleBackColor = true;
            this.fillElipseMode.Click += new System.EventHandler(this.fillElipseMode_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::forms_paint.Properties.Resources.brushSign;
            this.button3.Location = new System.Drawing.Point(96, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 26);
            this.button3.TabIndex = 22;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lineMode
            // 
            this.lineMode.BackgroundImage = global::forms_paint.Properties.Resources.lineSign;
            this.lineMode.Location = new System.Drawing.Point(128, 22);
            this.lineMode.Name = "lineMode";
            this.lineMode.Size = new System.Drawing.Size(26, 26);
            this.lineMode.TabIndex = 21;
            this.lineMode.UseVisualStyleBackColor = true;
            this.lineMode.Click += new System.EventHandler(this.lineMode_Click);
            // 
            // elipseMode
            // 
            this.elipseMode.BackgroundImage = global::forms_paint.Properties.Resources.elipseSign;
            this.elipseMode.Location = new System.Drawing.Point(160, 22);
            this.elipseMode.Name = "elipseMode";
            this.elipseMode.Size = new System.Drawing.Size(26, 26);
            this.elipseMode.TabIndex = 20;
            this.elipseMode.UseVisualStyleBackColor = true;
            this.elipseMode.Click += new System.EventHandler(this.elipseMode_Click);
            // 
            // rectangleMode
            // 
            this.rectangleMode.BackgroundImage = global::forms_paint.Properties.Resources.reactangleSign;
            this.rectangleMode.Location = new System.Drawing.Point(192, 22);
            this.rectangleMode.Name = "rectangleMode";
            this.rectangleMode.Size = new System.Drawing.Size(26, 26);
            this.rectangleMode.TabIndex = 19;
            this.rectangleMode.UseVisualStyleBackColor = true;
            this.rectangleMode.Click += new System.EventHandler(this.rectangleMode_Click);
            // 
            // rubber
            // 
            this.rubber.BackgroundImage = global::forms_paint.Properties.Resources.rubberSign;
            this.rubber.Location = new System.Drawing.Point(302, 22);
            this.rubber.Name = "rubber";
            this.rubber.Size = new System.Drawing.Size(26, 26);
            this.rubber.TabIndex = 18;
            this.rubber.UseVisualStyleBackColor = true;
            this.rubber.Click += new System.EventHandler(this.rubber_Click);
            // 
            // drawing
            // 
            this.drawing.BackgroundImage = global::forms_paint.Properties.Resources.Untitled;
            this.drawing.Location = new System.Drawing.Point(334, 22);
            this.drawing.Name = "drawing";
            this.drawing.Size = new System.Drawing.Size(26, 26);
            this.drawing.TabIndex = 17;
            this.drawing.UseVisualStyleBackColor = true;
            this.drawing.Click += new System.EventHandler(this.drawing_Click);
            // 
            // whiteColorSwich
            // 
            this.whiteColorSwich.Image = global::forms_paint.Properties.Resources.Crystal_Absolute_White;
            this.whiteColorSwich.Location = new System.Drawing.Point(728, 53);
            this.whiteColorSwich.Name = "whiteColorSwich";
            this.whiteColorSwich.Size = new System.Drawing.Size(26, 26);
            this.whiteColorSwich.TabIndex = 14;
            this.whiteColorSwich.TabStop = false;
            this.whiteColorSwich.Click += new System.EventHandler(this.whiteColorSwich_Click);
            // 
            // lightBrownColorSwich
            // 
            this.lightBrownColorSwich.Image = global::forms_paint.Properties.Resources.light_brown_color_solid_background_1920x1080;
            this.lightBrownColorSwich.Location = new System.Drawing.Point(760, 53);
            this.lightBrownColorSwich.Name = "lightBrownColorSwich";
            this.lightBrownColorSwich.Size = new System.Drawing.Size(26, 26);
            this.lightBrownColorSwich.TabIndex = 13;
            this.lightBrownColorSwich.TabStop = false;
            this.lightBrownColorSwich.Click += new System.EventHandler(this.lightBrownColorSwich_Click);
            // 
            // darkBrownColorSwich
            // 
            this.darkBrownColorSwich.Image = global::forms_paint.Properties.Resources.chocolate_brown_color_color;
            this.darkBrownColorSwich.Location = new System.Drawing.Point(792, 53);
            this.darkBrownColorSwich.Name = "darkBrownColorSwich";
            this.darkBrownColorSwich.Size = new System.Drawing.Size(26, 26);
            this.darkBrownColorSwich.TabIndex = 12;
            this.darkBrownColorSwich.TabStop = false;
            this.darkBrownColorSwich.Click += new System.EventHandler(this.darkBrownColorSwich_Click);
            // 
            // pinkColorSwich
            // 
            this.pinkColorSwich.Image = global::forms_paint.Properties.Resources._5531ab8e057b2a649f748d341dcd41df;
            this.pinkColorSwich.Location = new System.Drawing.Point(824, 53);
            this.pinkColorSwich.Name = "pinkColorSwich";
            this.pinkColorSwich.Size = new System.Drawing.Size(26, 26);
            this.pinkColorSwich.TabIndex = 11;
            this.pinkColorSwich.TabStop = false;
            this.pinkColorSwich.Click += new System.EventHandler(this.pinkColorSwich_Click);
            // 
            // cyanColorSwich
            // 
            this.cyanColorSwich.Image = global::forms_paint.Properties.Resources._360_F_423788551_FBeHBMSNAl9h9bVpfTjUPqpvf54binzo;
            this.cyanColorSwich.Location = new System.Drawing.Point(856, 53);
            this.cyanColorSwich.Name = "cyanColorSwich";
            this.cyanColorSwich.Size = new System.Drawing.Size(26, 26);
            this.cyanColorSwich.TabIndex = 10;
            this.cyanColorSwich.TabStop = false;
            this.cyanColorSwich.Click += new System.EventHandler(this.cyanColorSwich_Click);
            // 
            // lightBlueColorSwich
            // 
            this.lightBlueColorSwich.Image = global::forms_paint.Properties.Resources.blue;
            this.lightBlueColorSwich.Location = new System.Drawing.Point(888, 53);
            this.lightBlueColorSwich.Name = "lightBlueColorSwich";
            this.lightBlueColorSwich.Size = new System.Drawing.Size(26, 26);
            this.lightBlueColorSwich.TabIndex = 9;
            this.lightBlueColorSwich.TabStop = false;
            this.lightBlueColorSwich.Click += new System.EventHandler(this.lightBlueColorSwich_Click);
            // 
            // blackColorSwich
            // 
            this.blackColorSwich.Image = global::forms_paint.Properties.Resources.Black;
            this.blackColorSwich.Location = new System.Drawing.Point(728, 21);
            this.blackColorSwich.Name = "blackColorSwich";
            this.blackColorSwich.Size = new System.Drawing.Size(26, 26);
            this.blackColorSwich.TabIndex = 8;
            this.blackColorSwich.TabStop = false;
            this.blackColorSwich.Click += new System.EventHandler(this.blackColorSwich_Click);
            // 
            // greyColorSwich
            // 
            this.greyColorSwich.Image = global::forms_paint.Properties.Resources._360_F_331785873_kGJgDPmF7YEHRAwPsF3LdGeqjoAuULK4;
            this.greyColorSwich.Location = new System.Drawing.Point(760, 21);
            this.greyColorSwich.Name = "greyColorSwich";
            this.greyColorSwich.Size = new System.Drawing.Size(26, 26);
            this.greyColorSwich.TabIndex = 7;
            this.greyColorSwich.TabStop = false;
            this.greyColorSwich.Click += new System.EventHandler(this.greyColorSwich_Click);
            // 
            // redColorSwich
            // 
            this.redColorSwich.Image = global::forms_paint.Properties.Resources._360_F_303401956_ufTeSp9EX62zQnJnbed9Q0kEgqaKKL44;
            this.redColorSwich.Location = new System.Drawing.Point(792, 21);
            this.redColorSwich.Name = "redColorSwich";
            this.redColorSwich.Size = new System.Drawing.Size(26, 26);
            this.redColorSwich.TabIndex = 6;
            this.redColorSwich.TabStop = false;
            this.redColorSwich.Click += new System.EventHandler(this.redColorSwich_Click);
            // 
            // orangeColorSwich
            // 
            this.orangeColorSwich.Image = global::forms_paint.Properties.Resources.F78523_1200x;
            this.orangeColorSwich.Location = new System.Drawing.Point(824, 21);
            this.orangeColorSwich.Name = "orangeColorSwich";
            this.orangeColorSwich.Size = new System.Drawing.Size(26, 26);
            this.orangeColorSwich.TabIndex = 5;
            this.orangeColorSwich.TabStop = false;
            this.orangeColorSwich.Click += new System.EventHandler(this.orangeColorSwich_Click);
            // 
            // yellowColorSwich
            // 
            this.yellowColorSwich.Image = global::forms_paint.Properties.Resources.yellow;
            this.yellowColorSwich.Location = new System.Drawing.Point(856, 21);
            this.yellowColorSwich.Name = "yellowColorSwich";
            this.yellowColorSwich.Size = new System.Drawing.Size(26, 26);
            this.yellowColorSwich.TabIndex = 4;
            this.yellowColorSwich.TabStop = false;
            this.yellowColorSwich.Click += new System.EventHandler(this.yellowColorSwich_Click);
            // 
            // greenColorSwich
            // 
            this.greenColorSwich.Image = global::forms_paint.Properties.Resources.pft401;
            this.greenColorSwich.Location = new System.Drawing.Point(888, 21);
            this.greenColorSwich.Name = "greenColorSwich";
            this.greenColorSwich.Size = new System.Drawing.Size(26, 26);
            this.greenColorSwich.TabIndex = 3;
            this.greenColorSwich.TabStop = false;
            this.greenColorSwich.Click += new System.EventHandler(this.greenColorSwich_Click);
            // 
            // blueColorSwich
            // 
            this.blueColorSwich.Image = global::forms_paint.Properties.Resources.images;
            this.blueColorSwich.Location = new System.Drawing.Point(920, 53);
            this.blueColorSwich.Name = "blueColorSwich";
            this.blueColorSwich.Size = new System.Drawing.Size(26, 26);
            this.blueColorSwich.TabIndex = 2;
            this.blueColorSwich.TabStop = false;
            this.blueColorSwich.Click += new System.EventHandler(this.blueColorSwich_Click);
            // 
            // darkBlueColorSwich
            // 
            this.darkBlueColorSwich.Image = global::forms_paint.Properties.Resources.images;
            this.darkBlueColorSwich.Location = new System.Drawing.Point(920, 21);
            this.darkBlueColorSwich.Name = "darkBlueColorSwich";
            this.darkBlueColorSwich.Size = new System.Drawing.Size(26, 26);
            this.darkBlueColorSwich.TabIndex = 0;
            this.darkBlueColorSwich.TabStop = false;
            this.darkBlueColorSwich.Click += new System.EventHandler(this.darkBlueColorSwich_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 854);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteColorSwich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightBrownColorSwich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkBrownColorSwich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkColorSwich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyanColorSwich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightBlueColorSwich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackColorSwich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greyColorSwich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redColorSwich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeColorSwich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowColorSwich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenColorSwich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueColorSwich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkBlueColorSwich)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button drawing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar penSize;
        private System.Windows.Forms.PictureBox whiteColorSwich;
        private System.Windows.Forms.PictureBox lightBrownColorSwich;
        private System.Windows.Forms.PictureBox darkBrownColorSwich;
        private System.Windows.Forms.PictureBox pinkColorSwich;
        private System.Windows.Forms.PictureBox cyanColorSwich;
        private System.Windows.Forms.PictureBox lightBlueColorSwich;
        private System.Windows.Forms.PictureBox blackColorSwich;
        private System.Windows.Forms.PictureBox greyColorSwich;
        private System.Windows.Forms.PictureBox redColorSwich;
        private System.Windows.Forms.PictureBox orangeColorSwich;
        private System.Windows.Forms.PictureBox yellowColorSwich;
        private System.Windows.Forms.PictureBox greenColorSwich;
        private System.Windows.Forms.PictureBox blueColorSwich;
        private System.Windows.Forms.PictureBox darkBlueColorSwich;
        private System.Windows.Forms.Button elipseMode;
        private System.Windows.Forms.Button rectangleMode;
        private System.Windows.Forms.Button rubber;
        private System.Windows.Forms.Button lineMode;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button fillElipseMode;
        private System.Windows.Forms.Button button4;
    }
}

