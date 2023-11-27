namespace XIIRPL2_07_Ticketing.MasterForm
{
    partial class FrmMasterBandara
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
            BtnEdit = new DataGridViewButtonColumn();
            BtnDelete = new DataGridViewButtonColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNama = new TextBox();
            txtKodeIATA = new TextBox();
            label4 = new Label();
            txtKota = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            label8 = new Label();
            txtAlamat = new TextBox();
            txtNegara = new ComboBox();
            txtJmlTerminal = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtJmlTerminal).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnEdit, BtnDelete });
            dataGridView1.Location = new Point(10, 67);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(838, 206);
            dataGridView1.TabIndex = 0;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(178, 30);
            label1.TabIndex = 2;
            label1.Text = "Master Bandara";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 35);
            label2.Name = "label2";
            label2.Size = new Size(269, 15);
            label2.TabIndex = 3;
            label2.Text = "Semua bandara yang terdaftar akan muncul disini";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 302);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 4;
            label3.Text = "Nama";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(84, 299);
            txtNama.Margin = new Padding(3, 2, 3, 2);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(254, 23);
            txtNama.TabIndex = 5;
            txtNama.TextChanged += txtNama_TextChanged;
            // 
            // txtKodeIATA
            // 
            txtKodeIATA.Location = new Point(84, 326);
            txtKodeIATA.Margin = new Padding(3, 2, 3, 2);
            txtKodeIATA.Name = "txtKodeIATA";
            txtKodeIATA.Size = new Size(254, 23);
            txtKodeIATA.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 329);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 6;
            label4.Text = "Kode IATA";
            label4.Click += label4_Click;
            // 
            // txtKota
            // 
            txtKota.Location = new Point(84, 353);
            txtKota.Margin = new Padding(3, 2, 3, 2);
            txtKota.Name = "txtKota";
            txtKota.Size = new Size(254, 23);
            txtKota.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 356);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 8;
            label5.Text = "Kota";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 384);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 10;
            label6.Text = "Negara";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(370, 301);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 12;
            label7.Text = "Jumlah Terminal";
            // 
            // button1
            // 
            button1.Location = new Point(475, 420);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(118, 30);
            button1.TabIndex = 15;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(612, 420);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(118, 30);
            button2.TabIndex = 16;
            button2.Text = "Simpan";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(370, 327);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 18;
            label8.Text = "Alamat";
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(477, 325);
            txtAlamat.Margin = new Padding(3, 2, 3, 2);
            txtAlamat.Multiline = true;
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(254, 82);
            txtAlamat.TabIndex = 19;
            // 
            // txtNegara
            // 
            txtNegara.FormattingEnabled = true;
            txtNegara.Location = new Point(84, 381);
            txtNegara.Name = "txtNegara";
            txtNegara.Size = new Size(254, 23);
            txtNegara.TabIndex = 22;
            // 
            // txtJmlTerminal
            // 
            txtJmlTerminal.Location = new Point(477, 297);
            txtJmlTerminal.Name = "txtJmlTerminal";
            txtJmlTerminal.Size = new Size(254, 23);
            txtJmlTerminal.TabIndex = 24;
            // 
            // FrmMasterBandara
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(859, 501);
            Controls.Add(txtJmlTerminal);
            Controls.Add(txtNegara);
            Controls.Add(txtAlamat);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtKota);
            Controls.Add(label5);
            Controls.Add(txtKodeIATA);
            Controls.Add(label4);
            Controls.Add(txtNama);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmMasterBandara";
            Text = "FrmMasterBandara";
            Load += FrmMasterBandara_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtJmlTerminal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNama;
        private TextBox txtKodeIATA;
        private Label label4;
        private TextBox txtKota;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private Button button2;
        private Label label8;
        private TextBox txtAlamat;
        private ComboBox txtNegara;
        private NumericUpDown txtJmlTerminal;
        private DataGridViewButtonColumn BtnEdit;
        private DataGridViewButtonColumn BtnDelete;
    }
}