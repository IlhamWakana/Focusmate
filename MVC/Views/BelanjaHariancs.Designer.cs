namespace Organresipi.MVC.Views
{
    partial class BelanjaHariancs
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
            button1 = new Button();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 48);
            label1.Name = "label1";
            label1.Size = new Size(100, 19);
            label1.TabIndex = 3;
            label1.Text = "Belanja Hari Ini";
            // 
            // button1
            // 
            button1.Location = new Point(235, 13);
            button1.Name = "button1";
            button1.Size = new Size(86, 26);
            button1.TabIndex = 4;
            button1.Text = "Tambah";
            button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(8, 70);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(213, 251);
            listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(8, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 26);
            textBox1.TabIndex = 2;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(235, 70);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(104, 23);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Sudah Dibeli";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(checkBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(343, 338);
            panel1.TabIndex = 6;
            // 
            // BelanjaHariancs
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "BelanjaHariancs";
            Text = "BelanjaHariancs";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private ListBox listBox1;
        private TextBox textBox1;
        private CheckBox checkBox1;
        private Panel panel1;
    }
}