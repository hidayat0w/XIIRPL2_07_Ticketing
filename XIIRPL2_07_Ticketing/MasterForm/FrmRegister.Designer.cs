namespace XIIRPL2_07_Ticketing.MasterForm
{
    partial class FrmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(30, 33);
            label1.Name = "label1";
            label1.Size = new Size(180, 38);
            label1.TabIndex = 0;
            label1.Text = "Daftar Akun";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 80);
            label2.Name = "label2";
            label2.Size = new Size(379, 20);
            label2.TabIndex = 1;
            label2.Text = "Daftarkan diri Anda untuk menggunakan Bromo Airlines";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 126);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 159);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 3;
            label4.Text = "Nama";
            label4.Click += label4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(154, 123);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 27);
            textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(154, 156);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(260, 27);
            textBox2.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 194);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 14;
            label5.Text = "Tanggal Lahir";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(154, 189);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(260, 27);
            dateTimePicker1.TabIndex = 15;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(154, 222);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(260, 27);
            textBox3.TabIndex = 16;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(154, 255);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(260, 27);
            textBox4.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 225);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 18;
            label6.Text = "Nomor Telepon";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 258);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 19;
            label7.Text = "Password";
            // 
            // button1
            // 
            button1.Location = new Point(309, 307);
            button1.Name = "button1";
            button1.Size = new Size(105, 37);
            button1.TabIndex = 20;
            button1.Text = "Daftar";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(455, 123);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(302, 222);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 400);
            label8.Name = "label8";
            label8.Size = new Size(136, 20);
            label8.TabIndex = 22;
            label8.Text = "Sudah punya akun?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(172, 400);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(50, 20);
            linkLabel1.TabIndex = 23;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Login!";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel1);
            Controls.Add(label8);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmRegister";
            Text = "FrmRegister";
            Load += FrmRegister_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label6;
        private Label label7;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label8;
        private LinkLabel linkLabel1;
    }
}