namespace NASCON
{
    partial class Form23
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form23));
            button5 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            button10 = new Button();
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
            button5.Location = new Point(173, 488);
            button5.Name = "button5";
            button5.Size = new Size(150, 29);
            button5.TabIndex = 82;
            button5.Text = "PAY";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(44, 332);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(414, 27);
            textBox2.TabIndex = 81;
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
            textBox1.TabIndex = 80;
            textBox1.Text = "ENTER AMOUNT";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(44, 220);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(192, 27);
            pictureBox2.TabIndex = 75;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(162, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 51);
            pictureBox1.TabIndex = 74;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ONLINE", "CASH" });
            comboBox1.Location = new Point(44, 253);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(414, 28);
            comboBox1.TabIndex = 73;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
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
            button10.TabIndex = 72;
            button10.UseVisualStyleBackColor = false;
            // 
            // Form23
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(501, 605);
            Controls.Add(button5);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox1);
            Controls.Add(button10);
            Name = "Form23";
            Text = "PAYMENT FORM";
            Load += Form23_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private TextBox textBox2;
        private TextBox textBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private Button button10;
    }
}