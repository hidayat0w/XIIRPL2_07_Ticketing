namespace XIIRPL2_07_Ticketing.MasterForm
{
    partial class FrmMasterJadwalPenerbangan
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
            BtnEdit = new DataGridViewButtonColumn();
            BtnDelete = new DataGridViewButtonColumn();
            txtMaskapai = new ComboBox();
            txtKe = new ComboBox();
            label3 = new Label();
            txtKodePenerbangan = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtDari = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            txtTanggal = new DateTimePicker();
            txtDurasiPenerbangan = new TextBox();
            button1 = new Button();
            button2 = new Button();
            txtHarga = new NumericUpDown();
            label9 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtHarga).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(307, 30);
            label1.TabIndex = 0;
            label1.Text = "Master Jadwal Penerbangan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 35);
            label2.Name = "label2";
            label2.Size = new Size(256, 15);
            label2.TabIndex = 1;
            label2.Text = "Semua jadwal penerbangan akan muncul disini";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnEdit, BtnDelete });
            dataGridView1.Location = new Point(10, 63);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(838, 223);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // txtMaskapai
            // 
            txtMaskapai.FormattingEnabled = true;
            txtMaskapai.Location = new Point(133, 388);
            txtMaskapai.Margin = new Padding(3, 2, 3, 2);
            txtMaskapai.Name = "txtMaskapai";
            txtMaskapai.Size = new Size(254, 23);
            txtMaskapai.TabIndex = 7;
            // 
            // txtKe
            // 
            txtKe.FormattingEnabled = true;
            txtKe.Location = new Point(133, 363);
            txtKe.Margin = new Padding(3, 2, 3, 2);
            txtKe.Name = "txtKe";
            txtKe.Size = new Size(254, 23);
            txtKe.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 315);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 3;
            label3.Text = "Kode Penerbangan";
            // 
            // txtKodePenerbangan
            // 
            txtKodePenerbangan.Location = new Point(133, 312);
            txtKodePenerbangan.Margin = new Padding(3, 2, 3, 2);
            txtKodePenerbangan.Name = "txtKodePenerbangan";
            txtKodePenerbangan.Size = new Size(254, 23);
            txtKodePenerbangan.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 390);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 10;
            label6.Text = "Maskapai";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 365);
            label5.Name = "label5";
            label5.Size = new Size(20, 15);
            label5.TabIndex = 9;
            label5.Text = "Ke";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 339);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 8;
            label4.Text = "Dari";
            // 
            // txtDari
            // 
            txtDari.FormattingEnabled = true;
            txtDari.Location = new Point(133, 337);
            txtDari.Margin = new Padding(3, 2, 3, 2);
            txtDari.Name = "txtDari";
            txtDari.Size = new Size(254, 23);
            txtDari.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(414, 365);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 18;
            label7.Text = "Harga Per Tiket";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(414, 340);
            label8.Name = "label8";
            label8.Size = new Size(113, 15);
            label8.TabIndex = 17;
            label8.Text = "Durasi Penerbangan";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(414, 315);
            label10.Name = "label10";
            label10.Size = new Size(130, 15);
            label10.TabIndex = 11;
            label10.Text = "Tanggal Keberangkatan";
            // 
            // txtTanggal
            // 
            txtTanggal.Location = new Point(554, 312);
            txtTanggal.Margin = new Padding(3, 2, 3, 2);
            txtTanggal.Name = "txtTanggal";
            txtTanggal.Size = new Size(254, 23);
            txtTanggal.TabIndex = 19;
            // 
            // txtDurasiPenerbangan
            // 
            txtDurasiPenerbangan.Location = new Point(554, 338);
            txtDurasiPenerbangan.Margin = new Padding(3, 2, 3, 2);
            txtDurasiPenerbangan.Name = "txtDurasiPenerbangan";
            txtDurasiPenerbangan.Size = new Size(254, 23);
            txtDurasiPenerbangan.TabIndex = 22;
            // 
            // button1
            // 
            button1.Location = new Point(554, 428);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(118, 30);
            button1.TabIndex = 23;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(690, 428);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(118, 30);
            button2.TabIndex = 24;
            button2.Text = "Simpan";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtHarga
            // 
            txtHarga.BackColor = SystemColors.Window;
            txtHarga.BorderStyle = BorderStyle.FixedSingle;
            txtHarga.Location = new Point(554, 363);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(254, 23);
            txtHarga.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(414, 390);
            label9.Name = "label9";
            label9.Size = new Size(123, 15);
            label9.TabIndex = 26;
            label9.Text = "Waktu Keberangkatan";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(554, 388);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(254, 23);
            textBox1.TabIndex = 27;
            // 
            // FrmMasterJadwalPenerbangan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(859, 501);
            Controls.Add(textBox1);
            Controls.Add(label9);
            Controls.Add(txtHarga);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtDurasiPenerbangan);
            Controls.Add(txtTanggal);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label10);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtMaskapai);
            Controls.Add(txtKe);
            Controls.Add(txtDari);
            Controls.Add(txtKodePenerbangan);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmMasterJadwalPenerbangan";
            Text = "FrmMasterJadwalPenerbangan";
            Load += FrmMasterJadwalPenerbangan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtHarga).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private ComboBox txtMaskapai;
        private ComboBox txtKe;
        private Label label3;
        private TextBox txtKodePenerbangan;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox txtDari;
        private Label label7;
        private Label label8;
        private Label label10;
        private DateTimePicker txtTanggal;
        private TextBox txtDurasiPenerbangan;
        private Button button1;
        private Button button2;
        private DataGridViewButtonColumn BtnEdit;
        private DataGridViewButtonColumn BtnDelete;
        private NumericUpDown txtHarga;
        private Label label9;
        private TextBox textBox1;
    }
}