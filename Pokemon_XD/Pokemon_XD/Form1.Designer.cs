namespace Pokemon_XD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            button5 = new Button();
            button6 = new Button();
            button8 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            labelEND = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(77, 200);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(77, 233);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(501, 263);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(501, 230);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 236);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 4;
            label1.Text = "HP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 203);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 5;
            label2.Text = "NAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(444, 233);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 7;
            label3.Text = "NAME";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(444, 266);
            label4.Name = "label4";
            label4.Size = new Size(28, 20);
            label4.TabIndex = 6;
            label4.Text = "HP";
            // 
            // button1
            // 
            button1.Location = new Point(6, 26);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(6, 61);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(6, 96);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 10;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(6, 131);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 11;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Location = new Point(12, 266);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(228, 172);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "My Pokemon";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(button8);
            groupBox2.Location = new Point(444, 297);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(223, 141);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Command";
            // 
            // button5
            // 
            button5.Location = new Point(11, 30);
            button5.Name = "button5";
            button5.Size = new Size(106, 29);
            button5.TabIndex = 10;
            button5.Text = "Attack";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(11, 65);
            button6.Name = "button6";
            button6.Size = new Size(106, 29);
            button6.TabIndex = 11;
            button6.Text = "HP +50";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button8
            // 
            button8.Location = new Point(11, 100);
            button8.Name = "button8";
            button8.Size = new Size(106, 29);
            button8.TabIndex = 9;
            button8.Text = "Defense +50";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Machoke;
            pictureBox1.Location = new Point(40, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 174);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Golem;
            pictureBox2.Location = new Point(444, 49);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(162, 174);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // labelEND
            // 
            labelEND.AutoSize = true;
            labelEND.Location = new Point(300, 174);
            labelEND.Name = "labelEND";
            labelEND.Size = new Size(30, 20);
            labelEND.TabIndex = 16;
            labelEND.Text = ".......";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 450);
            Controls.Add(labelEND);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button5;
        private Button button6;
        private Button button8;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label labelEND;
    }
}