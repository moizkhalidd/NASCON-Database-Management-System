namespace NASCON
{
    partial class Form16
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form16));
            button10 = new Button();
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
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
            button10.TabIndex = 50;
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click_1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "EVENT", "SPONSOR", "VENUE", "ACCOMMODATION" });
            comboBox1.Location = new Point(44, 253);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(414, 28);
            comboBox1.TabIndex = 62;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(148, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 51);
            pictureBox1.TabIndex = 63;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(44, 220);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(101, 27);
            pictureBox2.TabIndex = 64;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ImageAlign = ContentAlignment.TopLeft;
            button1.Location = new Point(320, 109);
            button1.Name = "button1";
            button1.Size = new Size(150, 29);
            button1.TabIndex = 65;
            button1.Text = "VENUES";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ImageAlign = ContentAlignment.TopLeft;
            button2.Location = new Point(32, 109);
            button2.Name = "button2";
            button2.Size = new Size(150, 29);
            button2.TabIndex = 66;
            button2.Text = "EVENTS";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ImageAlign = ContentAlignment.TopLeft;
            button3.Location = new Point(32, 166);
            button3.Name = "button3";
            button3.Size = new Size(150, 29);
            button3.TabIndex = 67;
            button3.Text = "SPONSORS";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ImageAlign = ContentAlignment.TopLeft;
            button4.Location = new Point(320, 166);
            button4.Name = "button4";
            button4.Size = new Size(150, 29);
            button4.TabIndex = 68;
            button4.Text = "ACCOMODATIONS";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Sans Serif Collection", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(44, 299);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(160, 40);
            textBox1.TabIndex = 69;
            textBox1.Text = "ENTER ID NUMBER";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(44, 332);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(414, 27);
            textBox2.TabIndex = 70;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.BackgroundImageLayout = ImageLayout.Center;
            button5.Cursor = Cursors.Hand;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ImageAlign = ContentAlignment.TopLeft;
            button5.Location = new Point(173, 488);
            button5.Name = "button5";
            button5.Size = new Size(150, 29);
            button5.TabIndex = 71;
            button5.Text = "SUBMIT";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Form16
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(501, 608);
            Controls.Add(button5);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox1);
            Controls.Add(button10);
            Name = "Form16";
            Text = "ORGANIZER FORM";
            Load += Form16_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button10;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button5;
    }
}