namespace Organresipi.MVC.Views
{
    partial class Dashboard
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
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            label1 = new Label();
            button1 = new Button();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            button5 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(22, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 382);
            panel1.TabIndex = 5;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(128, 128, 255);
            button4.Font = new Font("Bahnschrift", 9.818182F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(38, 289);
            button4.Name = "button4";
            button4.Size = new Size(147, 55);
            button4.TabIndex = 7;
            button4.Text = "MENU MAKAN HARIAN";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(128, 128, 255);
            button3.Font = new Font("Bahnschrift", 9.818182F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(38, 206);
            button3.Name = "button3";
            button3.Size = new Size(147, 55);
            button3.TabIndex = 6;
            button3.Text = "BELANJA HARIAN";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 128, 255);
            button2.Font = new Font("Bahnschrift", 9.818182F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(38, 127);
            button2.Name = "button2";
            button2.Size = new Size(147, 55);
            button2.TabIndex = 5;
            button2.Text = "INVENTARIS";
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 15.7090912F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(70, 10);
            label1.Name = "label1";
            label1.Size = new Size(84, 28);
            label1.TabIndex = 4;
            label1.Text = "MENU";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 128, 255);
            button1.Font = new Font("Bahnschrift", 9.818182F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(38, 51);
            button1.Name = "button1";
            button1.Size = new Size(147, 55);
            button1.TabIndex = 0;
            button1.Text = "KELOLA RESEP";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(616, 228);
            panel5.Name = "panel5";
            panel5.Size = new Size(163, 199);
            panel5.TabIndex = 10;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(274, 251);
            panel4.Name = "panel4";
            panel4.Size = new Size(314, 176);
            panel4.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(542, 56);
            panel3.Name = "panel3";
            panel3.Size = new Size(237, 151);
            panel3.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(274, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(234, 151);
            panel2.TabIndex = 7;
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.Font = new Font("Bahnschrift", 9.818182F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(693, 24);
            button5.Name = "button5";
            button5.Size = new Size(86, 26);
            button5.TabIndex = 6;
            button5.Text = "KELUAR";
            button5.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(button5);
            Name = "Dashboard";
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label label1;
        private Button button1;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Button button5;
    }
}