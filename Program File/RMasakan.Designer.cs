namespace Organresipi
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
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 18);
            label1.Name = "label1";
            label1.Size = new Size(104, 19);
            label1.TabIndex = 11;
            label1.Text = "Nama Masakan";
            label1.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(39, 104);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(321, 32);
            textBox2.TabIndex = 10;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(39, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(321, 26);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 250);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 47;
            dataGridView1.Size = new Size(756, 188);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 82);
            label2.Name = "label2";
            label2.Size = new Size(91, 19);
            label2.TabIndex = 16;
            label2.Text = "Bahan-Bahan";
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.Location = new Point(398, 109);
            button3.Name = "button3";
            button3.Size = new Size(86, 26);
            button3.TabIndex = 19;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.Location = new Point(398, 77);
            button2.Name = "button2";
            button2.Size = new Size(86, 26);
            button2.TabIndex = 18;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSeaGreen;
            button1.Location = new Point(398, 45);
            button1.Name = "button1";
            button1.Size = new Size(86, 26);
            button1.TabIndex = 17;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(41, 165);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(321, 32);
            textBox3.TabIndex = 20;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 142);
            label3.Name = "label3";
            label3.Size = new Size(64, 19);
            label3.TabIndex = 21;
            label3.Text = "Deskripsi";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(398, 142);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(86, 26);
            textBox4.TabIndex = 22;
            textBox4.TextChanged += textBox4_TextChanged;
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
            Text = "Resep Masakan";
            Load += RMasakan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Label label2;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
    }
}