namespace XIIRPL2_07_Ticketing.MasterForm
{
    partial class FrmMasterMaskapai
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
            dataGridView1 = new DataGridView();
            label3 = new Label();
            txtNama = new TextBox();
            txtPerusahaan = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtJumlahKru = new NumericUpDown();
            label6 = new Label();
            txtDeskripsi = new TextBox();
            button1 = new Button();
            button2 = new Button();
            BtnEdit = new DataGridViewButtonColumn();
            BtnDelete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtJumlahKru).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(191, 30);
            label1.TabIndex = 0;
            label1.Text = "Master Maskapai";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 35);
            label2.Name = "label2";
            label2.Size = new Size(276, 15);
            label2.TabIndex = 1;
            label2.Text = "Semua maskapai yang terdaftar akan muncul disini";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnEdit, BtnDelete });
            dataGridView1.Location = new Point(10, 59);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(838, 238);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 324);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 3;
            label3.Text = "Nama";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(88, 321);
            txtNama.Margin = new Padding(3, 2, 3, 2);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(254, 23);
            txtNama.TabIndex = 4;
            txtNama.TextChanged += textBox1_TextChanged;
            // 
            // txtPerusahaan
            // 
            txtPerusahaan.Location = new Point(88, 346);
            txtPerusahaan.Margin = new Padding(3, 2, 3, 2);
            txtPerusahaan.Name = "txtPerusahaan";
            txtPerusahaan.Size = new Size(254, 23);
            txtPerusahaan.TabIndex = 6;
            txtPerusahaan.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 349);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 5;
            label4.Text = "Perusahaan";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 373);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 7;
            label5.Text = "Jumlah Kru";
            // 
            // txtJumlahKru
            // 
            txtJumlahKru.Location = new Point(88, 371);
            txtJumlahKru.Margin = new Padding(3, 2, 3, 2);
            txtJumlahKru.Name = "txtJumlahKru";
            txtJumlahKru.Size = new Size(254, 23);
            txtJumlahKru.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(388, 324);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 9;
            label6.Text = "Deskripsi";
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(454, 321);
            txtDeskripsi.Margin = new Padding(3, 2, 3, 2);
            txtDeskripsi.Multiline = true;
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(254, 82);
            txtDeskripsi.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(454, 412);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(118, 30);
            button1.TabIndex = 11;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(590, 412);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(118, 30);
            button2.TabIndex = 12;
            button2.Text = "Simpan";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
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
            // FrmMasterMaskapai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(859, 501);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtDeskripsi);
            Controls.Add(label6);
            Controls.Add(txtJumlahKru);
            Controls.Add(label5);
            Controls.Add(txtPerusahaan);
            Controls.Add(label4);
            Controls.Add(txtNama);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmMasterMaskapai";
            Text = "FrmMasterMaskapai";
            Load += FrmMasterMaskapai_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtJumlahKru).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label3;
        private TextBox txtNama;
        private TextBox txtPerusahaan;
        private Label label4;
        private Label label5;
        private NumericUpDown txtJumlahKru;
        private Label label6;
        private TextBox txtDeskripsi;
        private Button button1;
        private Button button2;
        private DataGridViewButtonColumn BtnEdit;
        private DataGridViewButtonColumn BtnDelete;
    }
}