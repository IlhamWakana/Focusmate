namespace Organresipi.MVC.Views
{
    partial class RMasakan
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
            textBox4 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox4
            // 
            textBox4.Location = new Point(408, 139);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(86, 26);
            textBox4.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 139);
            label3.Name = "label3";
            label3.Size = new Size(64, 19);
            label3.TabIndex = 32;
            label3.Text = "Deskripsi";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(51, 162);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(321, 32);
            textBox3.TabIndex = 31;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.Location = new Point(408, 106);
            button3.Name = "button3";
            button3.Size = new Size(86, 26);
            button3.TabIndex = 30;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.Location = new Point(408, 74);
            button2.Name = "button2";
            button2.Size = new Size(86, 26);
            button2.TabIndex = 29;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSeaGreen;
            button1.Location = new Point(408, 42);
            button1.Name = "button1";
            button1.Size = new Size(86, 26);
            button1.TabIndex = 28;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 79);
            label2.Name = "label2";
            label2.Size = new Size(91, 19);
            label2.TabIndex = 27;
            label2.Text = "Bahan-Bahan";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 15);
            label1.Name = "label1";
            label1.Size = new Size(104, 19);
            label1.TabIndex = 26;
            label1.Text = "Nama Masakan";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(49, 101);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(321, 32);
            textBox2.TabIndex = 25;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(49, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(321, 26);
            textBox1.TabIndex = 24;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 247);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 47;
            dataGridView1.Size = new Size(756, 188);
            dataGridView1.TabIndex = 23;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // RMasakan
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "RMasakan";
            Text = "RMasakan";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox4;
        private Label label3;
        private TextBox textBox3;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
    }
}