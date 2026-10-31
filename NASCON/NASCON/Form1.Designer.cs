namespace NASCON
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            checkBox1 = new CheckBox();
            linkLabel3 = new LinkLabel();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            button2 = new Button();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            linkLabel2 = new LinkLabel();
            textBox1 = new TextBox();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(922, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(199, 196);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(-2, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(764, 578);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.Font = new Font("Nirmala UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(852, 434);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(117, 21);
            checkBox1.TabIndex = 23;
            checkBox1.Text = "Remember Me";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // linkLabel3
            // 
            linkLabel3.ActiveLinkColor = Color.Teal;
            linkLabel3.AutoSize = true;
            linkLabel3.Cursor = Cursors.Hand;
            linkLabel3.Font = new Font("Nirmala UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel3.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel3.LinkColor = Color.Teal;
            linkLabel3.Location = new Point(1090, 434);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(113, 17);
            linkLabel3.TabIndex = 22;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Forgot Password?";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.White;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Cursor = Cursors.IBeam;
            textBox6.Font = new Font("Nirmala UI", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox6.ForeColor = Color.Black;
            textBox6.Location = new Point(852, 385);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(156, 14);
            textBox6.TabIndex = 21;
            textBox6.Text = "Password";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.White;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Cursor = Cursors.IBeam;
            textBox5.Font = new Font("Nirmala UI", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.ForeColor = Color.Black;
            textBox5.Location = new Point(852, 318);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(156, 14);
            textBox5.TabIndex = 20;
            textBox5.Text = "Username";
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(852, 475);
            button2.Name = "button2";
            button2.Size = new Size(351, 42);
            button2.TabIndex = 19;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.White;
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Cursor = Cursors.IBeam;
            textBox7.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox7.ForeColor = Color.Black;
            textBox7.Location = new Point(876, 284);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(156, 18);
            textBox7.TabIndex = 18;
            textBox7.Text = "Manage your account";
            // 
            // textBox8
            // 
            textBox8.AccessibleRole = AccessibleRole.None;
            textBox8.BackColor = Color.White;
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Cursor = Cursors.IBeam;
            textBox8.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox8.ForeColor = Color.Black;
            textBox8.Location = new Point(876, 242);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(297, 36);
            textBox8.TabIndex = 17;
            textBox8.Text = "Login to your Account";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(852, 404);
            textBox9.Name = "textBox9";
            textBox9.PasswordChar = '*';
            textBox9.PlaceholderText = "************";
            textBox9.Size = new Size(351, 27);
            textBox9.TabIndex = 16;
            // 
            // textBox10
            // 
            textBox10.BackColor = Color.White;
            textBox10.Location = new Point(852, 338);
            textBox10.Name = "textBox10";
            textBox10.PlaceholderText = "mail@abc.com";
            textBox10.Size = new Size(351, 27);
            textBox10.TabIndex = 15;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Cursor = Cursors.Hand;
            linkLabel2.Font = new Font("Nirmala UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel2.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel2.LinkColor = Color.Teal;
            linkLabel2.Location = new Point(1038, 549);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(113, 17);
            linkLabel2.TabIndex = 26;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Create an account";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Nirmala UI", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(917, 550);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(115, 16);
            textBox1.TabIndex = 25;
            textBox1.Text = "Not Registered Yet?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(904, 513);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 20);
            linkLabel1.TabIndex = 24;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1306, 576);
            Controls.Add(linkLabel2);
            Controls.Add(textBox1);
            Controls.Add(linkLabel1);
            Controls.Add(checkBox1);
            Controls.Add(linkLabel3);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(button2);
            Controls.Add(textBox7);
            Controls.Add(textBox8);
            Controls.Add(textBox9);
            Controls.Add(textBox10);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "Form1";
            Text = "LOGIN/SIGN-UP";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private CheckBox checkBox1;
        private LinkLabel linkLabel3;
        private TextBox textBox6;
        private TextBox textBox5;
        private Button button2;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private LinkLabel linkLabel2;
        private TextBox textBox1;
        private LinkLabel linkLabel1;
    }
}
