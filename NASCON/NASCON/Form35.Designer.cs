namespace NASCON
{
    partial class Form35
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form35));
            button5 = new Button();
            textBox2 = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            button10 = new Button();
            button1 = new Button();
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
            button5.Location = new Point(172, 331);
            button5.Name = "button5";
            button5.Size = new Size(150, 29);
            button5.TabIndex = 100;
            button5.Text = "SUBMIT";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(44, 253);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(414, 27);
            textBox2.TabIndex = 99;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(44, 211);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(192, 36);
            pictureBox2.TabIndex = 97;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(123, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(255, 72);
            pictureBox1.TabIndex = 96;
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
            button10.Size = new Size(475, 426);
            button10.TabIndex = 94;
            button10.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ImageAlign = ContentAlignment.TopLeft;
            button1.Location = new Point(157, 114);
            button1.Name = "button1";
            button1.Size = new Size(177, 29);
            button1.TabIndex = 105;
            button1.Text = "ACCOMMODATIONS";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form35
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(501, 450);
            Controls.Add(button1);
            Controls.Add(button5);
            Controls.Add(textBox2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button10);
            Name = "Form35";
            Text = "ACCOMMODATION FORM";
            Load += Form35_Load;
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
        private Button button1;
    }
}