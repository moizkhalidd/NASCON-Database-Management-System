namespace NASCON
{
    partial class Form33
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form33));
            button5 = new Button();
            textBox2 = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            button10 = new Button();
            textBox3 = new TextBox();
            comboBox2 = new ComboBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.BackgroundImageLayout = ImageLayout.Center;
            button5.Cursor = Cursors.Hand;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ImageAlign = ContentAlignment.TopLeft;
            button5.Location = new Point(174, 528);
            button5.Name = "button5";
            button5.Size = new Size(150, 29);
            button5.TabIndex = 89;
            button5.Text = "PAY";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(44, 332);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(414, 27);
            textBox2.TabIndex = 88;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(44, 220);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(192, 27);
            pictureBox2.TabIndex = 86;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(162, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 51);
            pictureBox1.TabIndex = 85;
            pictureBox1.TabStop = false;
            // 
            // button10
            // 
            button10.AccessibleRole = AccessibleRole.None;
            button10.BackColor = Color.White;
            button10.Enabled = false;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Location = new Point(12, 12);
            button10.Name = "button10";
            button10.Size = new Size(475, 584);
            button10.TabIndex = 83;
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Sans Serif Collection", 7.799999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(44, 365);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(160, 35);
            textBox3.TabIndex = 90;
            textBox3.Text = "PAYMENT FOR";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "EVENT", "ACCOMMODATION" });
            comboBox2.Location = new Point(44, 397);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(414, 28);
            comboBox2.TabIndex = 91;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.White;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Sans Serif Collection", 7.799999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(44, 431);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(160, 35);
            textBox4.TabIndex = 92;
            textBox4.Text = "EVENT ID";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(44, 463);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(414, 27);
            textBox5.TabIndex = 93;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Sans Serif Collection", 7.799999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(44, 291);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(160, 35);
            textBox1.TabIndex = 87;
            textBox1.Text = "ENTER AMOUNT";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ONLINE", "CASH" });
            comboBox1.Location = new Point(44, 253);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(414, 28);
            comboBox1.TabIndex = 84;
            // 
            // Form33
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(500, 604);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(comboBox2);
            Controls.Add(textBox3);
            Controls.Add(button5);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox1);
            Controls.Add(button10);
            Name = "Form33";
            Text = "PAYMENT FORM";
            Load += Form33_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private TextBox textBox2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button button10;
        private TextBox textBox3;
        private ComboBox comboBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox1;
        private ComboBox comboBox1;
    }
}