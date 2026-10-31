namespace NASCON
{
    partial class Form5
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
            textBox9 = new TextBox();
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox9
            // 
            textBox9.BackColor = Color.Teal;
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Font = new Font("Sans Serif Collection", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox9.Location = new Point(29, 67);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(276, 40);
            textBox9.TabIndex = 35;
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Teal;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Sans Serif Collection", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(29, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(291, 54);
            textBox1.TabIndex = 34;
            textBox1.Text = "Total Funds";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Teal;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(15, 21);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(305, 95);
            richTextBox1.TabIndex = 33;
            richTextBox1.Text = "";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = Color.Teal;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 132);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(767, 478);
            dataGridView1.TabIndex = 36;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(791, 622);
            Controls.Add(dataGridView1);
            Controls.Add(textBox9);
            Controls.Add(textBox1);
            Controls.Add(richTextBox1);
            Name = "Form5";
            Text = "SPONSOR DETAILS";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox9;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private DataGridView dataGridView1;
    }
}