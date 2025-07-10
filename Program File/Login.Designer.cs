namespace Organresipi
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 66);
            label1.Name = "label1";
            label1.Size = new Size(71, 19);
            label1.TabIndex = 0;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 125);
            label2.Name = "label2";
            label2.Size = new Size(67, 19);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(272, 26);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(14, 147);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(272, 26);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Location = new Point(14, 203);
            button1.Name = "button1";
            button1.Size = new Size(86, 26);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Blue;
            button3.ForeColor = Color.White;
            button3.Location = new Point(682, 12);
            button3.Name = "button3";
            button3.Size = new Size(86, 26);
            button3.TabIndex = 6;
            button3.Text = "Lihat akun";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(470, 266);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(115, 207);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(204, 19);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Belum punya akun? daftar disini";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14F, FontStyle.Bold);
            label3.Location = new Point(14, 15);
            label3.Name = "label3";
            label3.Size = new Size(80, 26);
            label3.TabIndex = 8;
            label3.Text = "LOGIN";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 304);
            Controls.Add(panel1);
            Controls.Add(button3);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button3;
        private Panel panel1;
        private Label label3;
        private LinkLabel linkLabel1;
    }
}