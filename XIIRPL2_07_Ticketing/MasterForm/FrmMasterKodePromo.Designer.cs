namespace XIIRPL2_07_Ticketing.MasterForm
{
    partial class FrmMasterKodePromo
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtBerlakuSampai = new DateTimePicker();
            txtKodePromo = new TextBox();
            txtPresentaseDiskon = new NumericUpDown();
            txtMaksimumDiskon = new NumericUpDown();
            label7 = new Label();
            txtDeskripsi = new TextBox();
            button1 = new Button();
            button2 = new Button();
            BtnEdit = new DataGridViewButtonColumn();
            BtnDelete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPresentaseDiskon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMaksimumDiskon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(220, 30);
            label1.TabIndex = 0;
            label1.Text = "Master Kode Promo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 35);
            label2.Name = "label2";
            label2.Size = new Size(291, 15);
            label2.TabIndex = 1;
            label2.Text = "Semua kode promo yang terdaftar akan muncul disini";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnEdit, BtnDelete });
            dataGridView1.Location = new Point(10, 62);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(838, 224);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 317);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 3;
            label3.Text = "Kode Promo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 342);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 5;
            label4.Text = "Berlaku Sampai";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 366);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 7;
            label5.Text = "Presentase Diskon";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 391);
            label6.Name = "label6";
            label6.Size = new Size(106, 15);
            label6.TabIndex = 9;
            label6.Text = "Maksimum Diskon";
            // 
            // txtBerlakuSampai
            // 
            txtBerlakuSampai.Location = new Point(130, 339);
            txtBerlakuSampai.Margin = new Padding(3, 2, 3, 2);
            txtBerlakuSampai.Name = "txtBerlakuSampai";
            txtBerlakuSampai.Size = new Size(254, 23);
            txtBerlakuSampai.TabIndex = 11;
            txtBerlakuSampai.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // txtKodePromo
            // 
            txtKodePromo.Location = new Point(130, 314);
            txtKodePromo.Margin = new Padding(3, 2, 3, 2);
            txtKodePromo.Name = "txtKodePromo";
            txtKodePromo.Size = new Size(254, 23);
            txtKodePromo.TabIndex = 4;
            // 
            // txtPresentaseDiskon
            // 
            txtPresentaseDiskon.Location = new Point(130, 364);
            txtPresentaseDiskon.Margin = new Padding(3, 2, 3, 2);
            txtPresentaseDiskon.Name = "txtPresentaseDiskon";
            txtPresentaseDiskon.Size = new Size(254, 23);
            txtPresentaseDiskon.TabIndex = 12;
            // 
            // txtMaksimumDiskon
            // 
            txtMaksimumDiskon.Location = new Point(130, 391);
            txtMaksimumDiskon.Margin = new Padding(3, 2, 3, 2);
            txtMaksimumDiskon.Name = "txtMaksimumDiskon";
            txtMaksimumDiskon.Size = new Size(254, 23);
            txtMaksimumDiskon.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(428, 317);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 14;
            label7.Text = "Deskripsi";
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(494, 314);
            txtDeskripsi.Margin = new Padding(3, 2, 3, 2);
            txtDeskripsi.Multiline = true;
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(254, 98);
            txtDeskripsi.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(494, 422);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(118, 30);
            button1.TabIndex = 16;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(629, 422);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(118, 30);
            button2.TabIndex = 17;
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
            // FrmMasterKodePromo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(859, 501);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtDeskripsi);
            Controls.Add(label7);
            Controls.Add(txtMaksimumDiskon);
            Controls.Add(txtPresentaseDiskon);
            Controls.Add(txtBerlakuSampai);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtKodePromo);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmMasterKodePromo";
            Text = "FrmMasterKodePromo";
            Load += FrmMasterKodePromo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPresentaseDiskon).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMaksimumDiskon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker txtBerlakuSampai;
        private TextBox txtKodePromo;
        private NumericUpDown txtPresentaseDiskon;
        private NumericUpDown txtMaksimumDiskon;
        private Label label7;
        private TextBox txtDeskripsi;
        private Button button1;
        private Button button2;
        private DataGridViewButtonColumn BtnEdit;
        private DataGridViewButtonColumn BtnDelete;
    }
}