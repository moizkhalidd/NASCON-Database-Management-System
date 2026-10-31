namespace NASCON
{
    partial class Form39
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form39));
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            button5 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            button10 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox5
            // 
            textBox5.Location = new Point(44, 306);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(414, 27);
            textBox5.TabIndex = 102;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.White;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Sans Serif Collection", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(44, 269);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(160, 40);
            textBox4.TabIndex = 101;
            textBox4.Text = "FUNDS";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(44, 236);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(414, 27);
            textBox3.TabIndex = 100;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Sans Serif Collection", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(44, 200);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(160, 40);
            textBox1.TabIndex = 99;
            textBox1.Text = "EVENT ID";
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.BackgroundImageLayout = ImageLayout.Center;
            button5.Cursor = Cursors.Hand;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ImageAlign = ContentAlignment.TopLeft;
            button5.Location = new Point(179, 371);
            button5.Name = "button5";
            button5.Size = new Size(150, 29);
            button5.TabIndex = 98;
            button5.Text = "SUBMIT";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(28, 134);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(131, 27);
            pictureBox2.TabIndex = 96;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(169, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 51);
            pictureBox1.TabIndex = 95;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Title Sponsor", "Gold Sponsor", "Silver Sponsor", "Media Partner" });
            comboBox1.Location = new Point(44, 167);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(414, 28);
            comboBox1.TabIndex = 94;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button10
            // 
            button10.AccessibleRole = AccessibleRole.None;
            button10.BackColor = Color.White;
            button10.Enabled = false;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Location = new Point(11, 12);
            button10.Name = "button10";
            button10.Size = new Size(475, 418);
            button10.TabIndex = 93;
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ImageAlign = ContentAlignment.TopLeft;
            button1.Location = new Point(179, 100);
            button1.Name = "button1";
            button1.Size = new Size(150, 29);
            button1.TabIndex = 109;
            button1.Text = "EVENTS";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form39
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(498, 441);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(button5);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox1);
            Controls.Add(button10);
            Name = "Form39";
            Text = "SPONSOR FORM";
            Load += Form39_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox1;
        private Button button5;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private Button button10;
        private Button button1;
    }
}