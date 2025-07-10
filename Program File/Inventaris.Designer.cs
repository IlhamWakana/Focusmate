namespace Organresipi
{
    partial class Inventaris
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 47;
            dataGridView1.Size = new Size(457, 128);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(8, 15);
            button1.Name = "button1";
            button1.Size = new Size(86, 26);
            button1.TabIndex = 1;
            button1.Text = "Simpan";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(19, 160);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 26);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(19, 192);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(230, 26);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(19, 224);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(230, 26);
            textBox3.TabIndex = 4;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(276, 164);
            label1.Name = "label1";
            label1.Size = new Size(45, 19);
            label1.TabIndex = 6;
            label1.Text = "Nama";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(276, 199);
            label2.Name = "label2";
            label2.Size = new Size(46, 19);
            label2.TabIndex = 7;
            label2.Text = "Harga";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(276, 231);
            label3.Name = "label3";
            label3.Size = new Size(52, 19);
            label3.TabIndex = 8;
            label3.Text = "Jumlah";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(19, 256);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(230, 26);
            dateTimePicker1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(276, 262);
            label4.Name = "label4";
            label4.Size = new Size(121, 19);
            label4.TabIndex = 10;
            label4.Text = "Tanggal Pembelian";
            label4.Click += label4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(8, 47);
            button2.Name = "button2";
            button2.Size = new Size(86, 26);
            button2.TabIndex = 11;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(8, 79);
            button3.Name = "button3";
            button3.Size = new Size(86, 26);
            button3.TabIndex = 12;
            button3.Text = "Hapus";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(475, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(102, 128);
            panel1.TabIndex = 13;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Location = new Point(12, 146);
            panel2.Name = "panel2";
            panel2.Size = new Size(457, 146);
            panel2.TabIndex = 14;
            // 
            // Inventaris
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Inventaris";
            Text = "Inventaris";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private Panel panel2;
    }
}