namespace XIIRPL2_07_Ticketing.MasterForm
{
    partial class FrmListCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListCustomer));
            label1 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            button2 = new Button();
            comboBox1 = new ComboBox();
            label3 = new Label();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            BtnEdit = new DataGridViewButtonColumn();
            BtnDelete = new DataGridViewButtonColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(57, 10);
            label1.Name = "label1";
            label1.Size = new Size(192, 30);
            label1.TabIndex = 0;
            label1.Text = "List Penerbangan";
            label1.TextAlign = ContentAlignment.MiddleRight;
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(10, 9);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(41, 29);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(10, 65);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(838, 130);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button2
            // 
            button2.Location = new Point(663, 88);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(163, 28);
            button2.TabIndex = 4;
            button2.Text = "Terapkan Filter";
            button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(5, 92);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(220, 23);
            comboBox1.TabIndex = 6;
            comboBox1.Tag = "";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 75);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 5;
            label3.Text = "Urutkan Berdasarkan";
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(336, 42);
            checkBox4.Margin = new Padding(3, 2, 3, 2);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(91, 19);
            checkBox4.TabIndex = 4;
            checkBox4.Text = "18:00 - 24:00";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(230, 42);
            checkBox3.Margin = new Padding(3, 2, 3, 2);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(91, 19);
            checkBox3.TabIndex = 3;
            checkBox3.Text = "12:00 - 18:00";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(124, 42);
            checkBox2.Margin = new Padding(3, 2, 3, 2);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(91, 19);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "06:00 - 12:00";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(18, 42);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(91, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "00:00 - 06:00";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 21);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 0;
            label2.Text = "Waktu Keberangkatan";
            label2.Click += label2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnEdit, BtnDelete });
            dataGridView1.Location = new Point(10, 200);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(838, 277);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.GrayText;
            label4.Location = new Point(58, 38);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 4;
            label4.Text = "Juanda (SUB)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.GrayText;
            label5.Location = new Point(147, 38);
            label5.Name = "label5";
            label5.Size = new Size(19, 15);
            label5.TabIndex = 5;
            label5.Text = "➜";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.GrayText;
            label6.Location = new Point(173, 38);
            label6.Name = "label6";
            label6.Size = new Size(124, 15);
            label6.TabIndex = 6;
            label6.Text = "Soekarno-Hatta (CGK)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.GrayText;
            label7.Location = new Point(315, 38);
            label7.Name = "label7";
            label7.Size = new Size(14, 15);
            label7.TabIndex = 7;
            label7.Text = "●";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.GrayText;
            label8.Location = new Point(341, 38);
            label8.Name = "label8";
            label8.Size = new Size(103, 15);
            label8.TabIndex = 8;
            label8.Text = "Mon, 22 May 2023";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.GrayText;
            label9.Location = new Point(460, 38);
            label9.Name = "label9";
            label9.Size = new Size(14, 15);
            label9.TabIndex = 9;
            label9.Text = "●";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.GrayText;
            label10.Location = new Point(486, 38);
            label10.Name = "label10";
            label10.Size = new Size(81, 15);
            label10.TabIndex = 10;
            label10.Text = "1 Penumpang";
            // 
            // BtnEdit
            // 
            BtnEdit.FlatStyle = FlatStyle.Flat;
            BtnEdit.HeaderText = "Edit";
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Text = "Edit";
            BtnEdit.UseColumnTextForButtonValue = true;
            // 
            // BtnDelete
            // 
            BtnDelete.FlatStyle = FlatStyle.Flat;
            BtnDelete.HeaderText = "Delete";
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Text = "Delete";
            BtnDelete.UseColumnTextForButtonValue = true;
            // 
            // FrmListCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(859, 501);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmListCustomer";
            Text = "FrmListCustomer";
            Load += FrmListCustomer_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private GroupBox groupBox1;
        private Label label2;
        private CheckBox checkBox1;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private Label label3;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private Button button2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private DataGridViewButtonColumn BtnEdit;
        private DataGridViewButtonColumn BtnDelete;
    }
}