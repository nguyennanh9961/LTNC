namespace QLSV_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pnlThongTin = new Panel();
            nudDiem = new NumericUpDown();
            cboTrangThai = new ComboBox();
            cboLopHoc = new ComboBox();
            radioButton2 = new RadioButton();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            txtDienThoai = new TextBox();
            radioButton1 = new RadioButton();
            txtHoTen = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            dtpNgaySinh = new DateTimePicker();
            txtEmail = new TextBox();
            txtMaSV = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            panel2 = new Panel();
            cboLop = new ComboBox();
            txtTuKhoa = new TextBox();
            btnHienThiTatCa = new Button();
            btnTimKiem = new Button();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            numericUpDown2 = new NumericUpDown();
            panel1.SuspendLayout();
            pnlThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDiem).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(27, 59, 111);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1363, 45);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.ImageAlign = ContentAlignment.BottomCenter;
            label1.Location = new Point(57, 9);
            label1.Name = "label1";
            label1.Size = new Size(243, 23);
            label1.TabIndex = 0;
            label1.Text = "Ứng Dụng Quản Lý Sinh Viên";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(27, 59, 111);
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(233, 31);
            label2.TabIndex = 1;
            label2.Text = "QUẢN LÝ SINH VIÊN";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(610, 57);
            label3.Name = "label3";
            label3.Size = new Size(404, 20);
            label3.TabIndex = 2;
            label3.Text = "Bài tập Windows Forms • Quan hệ SchoolClass 1 — n Student";
            // 
            // pnlThongTin
            // 
            pnlThongTin.BackColor = Color.White;
            pnlThongTin.Controls.Add(nudDiem);
            pnlThongTin.Controls.Add(cboTrangThai);
            pnlThongTin.Controls.Add(cboLopHoc);
            pnlThongTin.Controls.Add(radioButton2);
            pnlThongTin.Controls.Add(label13);
            pnlThongTin.Controls.Add(label12);
            pnlThongTin.Controls.Add(label11);
            pnlThongTin.Controls.Add(txtDienThoai);
            pnlThongTin.Controls.Add(radioButton1);
            pnlThongTin.Controls.Add(txtHoTen);
            pnlThongTin.Controls.Add(label10);
            pnlThongTin.Controls.Add(label9);
            pnlThongTin.Controls.Add(label8);
            pnlThongTin.Controls.Add(dtpNgaySinh);
            pnlThongTin.Controls.Add(txtEmail);
            pnlThongTin.Controls.Add(txtMaSV);
            pnlThongTin.Controls.Add(label7);
            pnlThongTin.Controls.Add(label6);
            pnlThongTin.Controls.Add(label5);
            pnlThongTin.Controls.Add(label4);
            pnlThongTin.Location = new Point(12, 82);
            pnlThongTin.Name = "pnlThongTin";
            pnlThongTin.Size = new Size(1010, 158);
            pnlThongTin.TabIndex = 3;
            // 
            // nudDiem
            // 
            nudDiem.DecimalPlaces = 1;
            nudDiem.Location = new Point(798, 78);
            nudDiem.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudDiem.Name = "nudDiem";
            nudDiem.Size = new Size(166, 27);
            nudDiem.TabIndex = 21;
            nudDiem.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // cboTrangThai
            // 
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(798, 117);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(166, 28);
            cboTrangThai.TabIndex = 20;
            // 
            // cboLopHoc
            // 
            cboLopHoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLopHoc.FormattingEnabled = true;
            cboLopHoc.Location = new Point(798, 35);
            cboLopHoc.Name = "cboLopHoc";
            cboLopHoc.Size = new Size(166, 28);
            cboLopHoc.TabIndex = 19;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(503, 74);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(50, 24);
            radioButton2.TabIndex = 18;
            radioButton2.TabStop = true;
            radioButton2.Text = "Nữ";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(674, 124);
            label13.Name = "label13";
            label13.Size = new Size(75, 20);
            label13.TabIndex = 17;
            label13.Text = "Trạng thái";
            label13.Click += label13_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(674, 78);
            label12.Name = "label12";
            label12.Size = new Size(55, 20);
            label12.TabIndex = 16;
            label12.Text = "Điểm *";
            label12.Click += label12_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(674, 38);
            label11.Name = "label11";
            label11.Size = new Size(72, 20);
            label11.TabIndex = 15;
            label11.Text = "Lớp học *";
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(435, 117);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(189, 27);
            txtDienThoai.TabIndex = 14;
            txtDienThoai.TextChanged += textBox1_TextChanged_2;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(435, 74);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(62, 24);
            radioButton1.TabIndex = 13;
            radioButton1.TabStop = true;
            radioButton1.Text = "Nam";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(435, 31);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(189, 27);
            txtHoTen.TabIndex = 11;
            txtHoTen.TextChanged += textBox1_TextChanged_1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(331, 124);
            label10.Name = "label10";
            label10.Size = new Size(88, 20);
            label10.TabIndex = 10;
            label10.Text = "Điện thoại *";
            label10.Click += label10_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(331, 78);
            label9.Name = "label9";
            label9.Size = new Size(65, 20);
            label9.TabIndex = 9;
            label9.Text = "Giới tính";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(331, 38);
            label8.Name = "label8";
            label8.Size = new Size(83, 20);
            label8.TabIndex = 8;
            label8.Text = "Họ và tên *";
            label8.Click += label8_Click;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(127, 71);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(161, 27);
            dtpNgaySinh.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(126, 121);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(162, 27);
            txtEmail.TabIndex = 6;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(126, 31);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(162, 27);
            txtMaSV.TabIndex = 5;
            txtMaSV.TextChanged += textBox2_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 124);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 3;
            label7.Text = "Email";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 78);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 2;
            label6.Text = "Ngày sinh";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 38);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 1;
            label5.Text = "Mã sinh viên *";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 9);
            label4.Name = "label4";
            label4.Size = new Size(143, 20);
            label4.TabIndex = 0;
            label4.Text = "Thông tin sinh viên";
            label4.Click += label4_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(46, 125, 50);
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(501, 263);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(25, 118, 210);
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(647, 263);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += button2_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(211, 47, 47);
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(797, 263);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += button3_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(69, 90, 100);
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(928, 263);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 7;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(numericUpDown2);
            panel2.Controls.Add(cboLop);
            panel2.Controls.Add(txtTuKhoa);
            panel2.Controls.Add(btnHienThiTatCa);
            panel2.Controls.Add(btnTimKiem);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label14);
            panel2.Location = new Point(12, 310);
            panel2.Name = "panel2";
            panel2.Size = new Size(1010, 54);
            panel2.TabIndex = 8;
            // 
            // cboLop
            // 
            cboLop.FormattingEnabled = true;
            cboLop.Location = new Point(346, 12);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(97, 28);
            cboLop.TabIndex = 8;
            cboLop.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.Location = new Point(103, 12);
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(151, 27);
            txtTuKhoa.TabIndex = 5;
            txtTuKhoa.TextChanged += textBox1_TextChanged_3;
            // 
            // btnHienThiTatCa
            // 
            btnHienThiTatCa.BackColor = Color.Gainsboro;
            btnHienThiTatCa.Location = new Point(870, 9);
            btnHienThiTatCa.Name = "btnHienThiTatCa";
            btnHienThiTatCa.Size = new Size(132, 29);
            btnHienThiTatCa.TabIndex = 4;
            btnHienThiTatCa.Text = "Hiển Thị Tất Cả";
            btnHienThiTatCa.UseVisualStyleBackColor = false;
            btnHienThiTatCa.Click += button5_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(25, 118, 210);
            btnTimKiem.Location = new Point(752, 9);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += button4_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(490, 18);
            label16.Name = "label16";
            label16.Size = new Size(63, 20);
            label16.TabIndex = 2;
            label16.Text = "Điểm từ";
            label16.Click += label16_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(306, 18);
            label15.Name = "label15";
            label15.Size = new Size(34, 20);
            label15.TabIndex = 1;
            label15.Text = "Lớp";
            label15.Click += label15_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(16, 19);
            label14.Name = "label14";
            label14.Size = new Size(64, 20);
            label14.TabIndex = 0;
            label14.Text = "Từ Khóa";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(559, 12);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(150, 27);
            numericUpDown2.TabIndex = 9;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1363, 653);
            Controls.Add(panel2);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(pnlThongTin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlThongTin.ResumeLayout(false);
            pnlThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDiem).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel pnlThongTin;
        private Label label4;
        private TextBox txtEmail;
        private TextBox txtMaSV;
        private Label label7;
        private Label label6;
        private Label label5;
        private DateTimePicker dtpNgaySinh;
        private RadioButton radioButton1;
        private TextBox textBox2;
        private TextBox txtHoTen;
        private Label label10;
        private Label label9;
        private Label label8;
        private System.Windows.Forms.TextBox txtDienThoai;
        private Label label13;
        private Label label12;
        private Label label11;
        private ContextMenuStrip contextMenuStrip1;
        private NumericUpDown numericUpDown1;
        private ComboBox cboTrangThai;
        private ComboBox cboLopHoc;
        private RadioButton radioButton2;
        private System.Windows.Forms.NumericUpDown nudDiem;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private ComboBox comboBox2;
        private TextBox textBox3;
        private TextBox txtTuKhoa;
        private Button button5;
        private Button btnTimKiem;
        private Label label16;
        private Label label15;
        private Label label14;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.ComboBox cboLocLop;
        private System.Windows.Forms.Button btnHienThiTatCa;
        private NumericUpDown numericUpDown2;
    }
}
