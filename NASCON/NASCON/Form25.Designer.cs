namespace NASCON
{
    partial class Form25
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form25));
            button4 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button10 = new Button();
            textBox10 = new TextBox();
            textBox9 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            richTextBox2 = new RichTextBox();
            richTextBox1 = new RichTextBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = Color.Gray;
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ImageAlign = ContentAlignment.TopLeft;
            button4.Location = new Point(16, 311);
            button4.Name = "button4";
            button4.Size = new Size(209, 29);
            button4.TabIndex = 88;
            button4.Text = "EVALUATE";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ImageAlign = ContentAlignment.TopLeft;
            button1.Location = new Point(16, 268);
            button1.Name = "button1";
            button1.Size = new Size(209, 29);
            button1.TabIndex = 87;
            button1.Text = "TEAMS EVALUATED";
            button1.TextAlign = ContentAlignment.TopLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Teal;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(16, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(209, 165);
            pictureBox1.TabIndex = 85;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ImageAlign = ContentAlignment.TopLeft;
            button2.Location = new Point(16, 222);
            button2.Name = "button2";
            button2.Size = new Size(209, 29);
            button2.TabIndex = 84;
            button2.Text = "EVENTS EVALUATED";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.TextImageRelation = TextImageRelation.TextAboveImage;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button10
            // 
            button10.AccessibleRole = AccessibleRole.None;
            button10.BackColor = Color.Teal;
            button10.Enabled = false;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Location = new Point(-7, -10);
            button10.Name = "button10";
            button10.Size = new Size(266, 698);
            button10.TabIndex = 86;
            button10.UseVisualStyleBackColor = false;
            // 
            // textBox10
            // 
            textBox10.BackColor = Color.White;
            textBox10.BorderStyle = BorderStyle.None;
            textBox10.Font = new Font("Sans Serif Collection", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox10.Location = new Point(295, 292);
            textBox10.Name = "textBox10";
            textBox10.ReadOnly = true;
            textBox10.Size = new Size(317, 48);
            textBox10.TabIndex = 107;
            textBox10.TextAlign = HorizontalAlignment.Center;
            textBox10.TextChanged += textBox10_TextChanged;
            // 
            // textBox9
            // 
            textBox9.BackColor = Color.White;
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Font = new Font("Sans Serif Collection", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox9.Location = new Point(757, 292);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(317, 48);
            textBox9.TabIndex = 106;
            textBox9.TextAlign = HorizontalAlignment.Center;
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Sans Serif Collection", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(757, 245);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(291, 54);
            textBox2.TabIndex = 102;
            textBox2.Text = "Total Teams Evaluated";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Sans Serif Collection", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(295, 245);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(291, 54);
            textBox1.TabIndex = 101;
            textBox1.Text = "Total Events Evaluated";
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.White;
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Location = new Point(747, 245);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(352, 95);
            richTextBox2.TabIndex = 99;
            richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.White;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(281, 245);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(341, 95);
            richTextBox1.TabIndex = 98;
            richTextBox1.Text = "";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(281, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(818, 106);
            pictureBox2.TabIndex = 97;
            pictureBox2.TabStop = false;
            // 
            // Form25
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1129, 472);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(pictureBox2);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button10);
            Name = "Form25";
            Text = "JUDGE";
            Load += Form25_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button10;
        private TextBox textBox10;
        private TextBox textBox9;
        private TextBox textBox2;
        private TextBox textBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox1;
        private PictureBox pictureBox2;
    }
}