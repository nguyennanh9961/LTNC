namespace QLSV_App.Views
{
    partial class frmQLSV
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblAppIcon = new Label();
            lblHeaderTitle = new Label();
            lblMainTitle = new Label();
            lblSubtitle = new Label();
            pnlThongTin = new Panel();
            pnlAccentBar = new Panel();
            lblTitleThongTin = new Label();
            lblMaSV = new Label();
            txtMaSV = new TextBox();
            lblNgaySinh = new Label();
            dtpNgaySinh = new DateTimePicker();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblGioiTinh = new Label();
            radNam = new RadioButton();
            radNu = new RadioButton();
            lblDienThoai = new Label();
            txtDienThoai = new TextBox();
            lblLopHoc = new Label();
            cboLopHoc = new ComboBox();
            lblDiem = new Label();
            nudDiem = new NumericUpDown();
            lblTrangThai = new Label();
            cboTrangThai = new ComboBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            pnlTimKiem = new Panel();
            lblTuKhoa = new Label();
            txtTuKhoa = new TextBox();
            lblLocLop = new Label();
            cboLocLop = new ComboBox();
            lblDiemTu = new Label();
            nudDiemTu = new NumericUpDown();
            btnTimKiem = new Button();
            btnHienThiTatCa = new Button();
            pnlDanhSach = new Panel();
            lblTitleDanhSach = new Label();
            lblTongSo = new Label();
            dgvSinhVien = new DataGridView();
            lblHuongDan = new Label();
            lblBatBuoc = new Label();
            pnlFooter = new Panel();
            lblFooterLeft = new Label();
            lblFooterRight = new Label();
            pnlHeader.SuspendLayout();
            pnlThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDiem).BeginInit();
            pnlTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDiemTu).BeginInit();
            pnlDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            pnlFooter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(24, 56, 92);
            pnlHeader.Controls.Add(lblAppIcon);
            pnlHeader.Controls.Add(lblHeaderTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1034, 46);
            pnlHeader.TabIndex = 0;
            // 
            // lblAppIcon
            // 
            lblAppIcon.BackColor = Color.FromArgb(242, 107, 34);
            lblAppIcon.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblAppIcon.ForeColor = Color.White;
            lblAppIcon.Location = new Point(16, 9);
            lblAppIcon.Name = "lblAppIcon";
            lblAppIcon.Size = new Size(26, 26);
            lblAppIcon.TabIndex = 0;
            lblAppIcon.Text = "S";
            lblAppIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.White;
            lblHeaderTitle.Location = new Point(48, 10);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(251, 25);
            lblHeaderTitle.TabIndex = 1;
            lblHeaderTitle.Text = "Ứng dụng quản lý sinh viên";
            // 
            // lblMainTitle
            // 
            lblMainTitle.AutoSize = true;
            lblMainTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblMainTitle.ForeColor = Color.FromArgb(24, 56, 92);
            lblMainTitle.Location = new Point(14, 56);
            lblMainTitle.Name = "lblMainTitle";
            lblMainTitle.Size = new Size(269, 35);
            lblMainTitle.TabIndex = 1;
            lblMainTitle.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // lblSubtitle
            // 
            lblSubtitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 8.8F);
            lblSubtitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblSubtitle.Location = new Point(626, 68);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(393, 20);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Bài tập Windows Forms • Quan hệ SchoolClass 1 — n Student";
            // 
            // pnlThongTin
            // 
            pnlThongTin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlThongTin.BackColor = Color.White;
            pnlThongTin.Controls.Add(pnlAccentBar);
            pnlThongTin.Controls.Add(lblTitleThongTin);
            pnlThongTin.Controls.Add(lblMaSV);
            pnlThongTin.Controls.Add(txtMaSV);
            pnlThongTin.Controls.Add(lblNgaySinh);
            pnlThongTin.Controls.Add(dtpNgaySinh);
            pnlThongTin.Controls.Add(lblEmail);
            pnlThongTin.Controls.Add(txtEmail);
            pnlThongTin.Controls.Add(lblHoTen);
            pnlThongTin.Controls.Add(txtHoTen);
            pnlThongTin.Controls.Add(lblGioiTinh);
            pnlThongTin.Controls.Add(radNam);
            pnlThongTin.Controls.Add(radNu);
            pnlThongTin.Controls.Add(lblDienThoai);
            pnlThongTin.Controls.Add(txtDienThoai);
            pnlThongTin.Controls.Add(lblLopHoc);
            pnlThongTin.Controls.Add(cboLopHoc);
            pnlThongTin.Controls.Add(lblDiem);
            pnlThongTin.Controls.Add(nudDiem);
            pnlThongTin.Controls.Add(lblTrangThai);
            pnlThongTin.Controls.Add(cboTrangThai);
            pnlThongTin.Location = new Point(16, 96);
            pnlThongTin.Name = "pnlThongTin";
            pnlThongTin.Size = new Size(1003, 142);
            pnlThongTin.TabIndex = 3;
            // 
            // pnlAccentBar
            // 
            pnlAccentBar.BackColor = Color.FromArgb(242, 107, 34);
            pnlAccentBar.Location = new Point(14, 11);
            pnlAccentBar.Name = "pnlAccentBar";
            pnlAccentBar.Size = new Size(4, 16);
            pnlAccentBar.TabIndex = 0;
            // 
            // lblTitleThongTin
            // 
            lblTitleThongTin.AutoSize = true;
            lblTitleThongTin.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTitleThongTin.ForeColor = Color.FromArgb(24, 56, 92);
            lblTitleThongTin.Location = new Point(23, 9);
            lblTitleThongTin.Name = "lblTitleThongTin";
            lblTitleThongTin.Size = new Size(157, 21);
            lblTitleThongTin.TabIndex = 1;
            lblTitleThongTin.Text = "Thông tin sinh viên";
            // 
            // lblMaSV
            // 
            lblMaSV.AutoSize = true;
            lblMaSV.Font = new Font("Segoe UI", 8.8F);
            lblMaSV.ForeColor = Color.FromArgb(30, 41, 59);
            lblMaSV.Location = new Point(14, 38);
            lblMaSV.Name = "lblMaSV";
            lblMaSV.Size = new Size(100, 20);
            lblMaSV.TabIndex = 2;
            lblMaSV.Text = "Mã sinh viên *";
            // 
            // txtMaSV
            // 
            txtMaSV.Font = new Font("Segoe UI", 9F);
            txtMaSV.Location = new Point(116, 35);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(176, 27);
            txtMaSV.TabIndex = 3;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Font = new Font("Segoe UI", 8.8F);
            lblNgaySinh.ForeColor = Color.FromArgb(30, 41, 59);
            lblNgaySinh.Location = new Point(14, 72);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(74, 20);
            lblNgaySinh.TabIndex = 4;
            lblNgaySinh.Text = "Ngày sinh";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Font = new Font("Segoe UI", 9F);
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(116, 69);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(176, 27);
            dtpNgaySinh.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 8.8F);
            lblEmail.ForeColor = Color.FromArgb(30, 41, 59);
            lblEmail.Location = new Point(14, 106);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 20);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email *";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9F);
            txtEmail.Location = new Point(116, 103);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(176, 27);
            txtEmail.TabIndex = 7;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 8.8F);
            lblHoTen.ForeColor = Color.FromArgb(30, 41, 59);
            lblHoTen.Location = new Point(314, 38);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(81, 20);
            lblHoTen.TabIndex = 8;
            lblHoTen.Text = "Họ và tên *";
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Segoe UI", 9F);
            txtHoTen.Location = new Point(400, 35);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(176, 27);
            txtHoTen.TabIndex = 9;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Font = new Font("Segoe UI", 8.8F);
            lblGioiTinh.ForeColor = Color.FromArgb(30, 41, 59);
            lblGioiTinh.Location = new Point(314, 72);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(65, 20);
            lblGioiTinh.TabIndex = 10;
            lblGioiTinh.Text = "Giới tính";
            // 
            // radNam
            // 
            radNam.AutoSize = true;
            radNam.Checked = true;
            radNam.Font = new Font("Segoe UI", 8.8F);
            radNam.Location = new Point(400, 71);
            radNam.Name = "radNam";
            radNam.Size = new Size(62, 24);
            radNam.TabIndex = 11;
            radNam.TabStop = true;
            radNam.Text = "Nam";
            radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            radNu.AutoSize = true;
            radNu.Font = new Font("Segoe UI", 8.8F);
            radNu.Location = new Point(468, 71);
            radNu.Name = "radNu";
            radNu.Size = new Size(50, 24);
            radNu.TabIndex = 12;
            radNu.Text = "Nữ";
            radNu.UseVisualStyleBackColor = true;
            // 
            // lblDienThoai
            // 
            lblDienThoai.AutoSize = true;
            lblDienThoai.Font = new Font("Segoe UI", 8.8F);
            lblDienThoai.ForeColor = Color.FromArgb(30, 41, 59);
            lblDienThoai.Location = new Point(314, 106);
            lblDienThoai.Name = "lblDienThoai";
            lblDienThoai.Size = new Size(86, 20);
            lblDienThoai.TabIndex = 13;
            lblDienThoai.Text = "Điện thoại *";
            // 
            // txtDienThoai
            // 
            txtDienThoai.Font = new Font("Segoe UI", 9F);
            txtDienThoai.Location = new Point(400, 103);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(176, 27);
            txtDienThoai.TabIndex = 14;
            // 
            // lblLopHoc
            // 
            lblLopHoc.AutoSize = true;
            lblLopHoc.Font = new Font("Segoe UI", 8.8F);
            lblLopHoc.ForeColor = Color.FromArgb(30, 41, 59);
            lblLopHoc.Location = new Point(598, 38);
            lblLopHoc.Name = "lblLopHoc";
            lblLopHoc.Size = new Size(71, 20);
            lblLopHoc.TabIndex = 15;
            lblLopHoc.Text = "Lớp học *";
            // 
            // cboLopHoc
            // 
            cboLopHoc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboLopHoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLopHoc.Font = new Font("Segoe UI", 9F);
            cboLopHoc.FormattingEnabled = true;
            cboLopHoc.Location = new Point(680, 34);
            cboLopHoc.Name = "cboLopHoc";
            cboLopHoc.Size = new Size(307, 28);
            cboLopHoc.TabIndex = 16;
            // 
            // lblDiem
            // 
            lblDiem.AutoSize = true;
            lblDiem.Font = new Font("Segoe UI", 8.8F);
            lblDiem.ForeColor = Color.FromArgb(30, 41, 59);
            lblDiem.Location = new Point(598, 72);
            lblDiem.Name = "lblDiem";
            lblDiem.Size = new Size(53, 20);
            lblDiem.TabIndex = 17;
            lblDiem.Text = "Điểm *";
            // 
            // nudDiem
            // 
            nudDiem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nudDiem.DecimalPlaces = 1;
            nudDiem.Font = new Font("Segoe UI", 9F);
            nudDiem.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudDiem.Location = new Point(680, 69);
            nudDiem.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudDiem.Name = "nudDiem";
            nudDiem.Size = new Size(307, 27);
            nudDiem.TabIndex = 18;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Font = new Font("Segoe UI", 8.8F);
            lblTrangThai.ForeColor = Color.FromArgb(30, 41, 59);
            lblTrangThai.Location = new Point(598, 106);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(75, 20);
            lblTrangThai.TabIndex = 19;
            lblTrangThai.Text = "Trạng thái";
            // 
            // cboTrangThai
            // 
            cboTrangThai.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.Font = new Font("Segoe UI", 9F);
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(680, 102);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(307, 28);
            cboTrangThai.TabIndex = 20;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThem.BackColor = Color.FromArgb(46, 125, 50);
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(656, 246);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(78, 33);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSua.BackColor = Color.FromArgb(25, 118, 210);
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(742, 246);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(78, 33);
            btnSua.TabIndex = 5;
            btnSua.Text = "✎ Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXoa.BackColor = Color.FromArgb(211, 47, 47);
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(828, 246);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(78, 33);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLamMoi.BackColor = Color.FromArgb(69, 90, 100);
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(914, 246);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(105, 33);
            btnLamMoi.TabIndex = 7;
            btnLamMoi.Text = "↻ Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // pnlTimKiem
            // 
            pnlTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlTimKiem.BackColor = Color.White;
            pnlTimKiem.Controls.Add(lblTuKhoa);
            pnlTimKiem.Controls.Add(txtTuKhoa);
            pnlTimKiem.Controls.Add(lblLocLop);
            pnlTimKiem.Controls.Add(cboLocLop);
            pnlTimKiem.Controls.Add(lblDiemTu);
            pnlTimKiem.Controls.Add(nudDiemTu);
            pnlTimKiem.Controls.Add(btnTimKiem);
            pnlTimKiem.Controls.Add(btnHienThiTatCa);
            pnlTimKiem.Location = new Point(16, 288);
            pnlTimKiem.Name = "pnlTimKiem";
            pnlTimKiem.Size = new Size(1003, 50);
            pnlTimKiem.TabIndex = 8;
            // 
            // lblTuKhoa
            // 
            lblTuKhoa.AutoSize = true;
            lblTuKhoa.Font = new Font("Segoe UI", 8.8F, FontStyle.Bold);
            lblTuKhoa.ForeColor = Color.FromArgb(30, 41, 59);
            lblTuKhoa.Location = new Point(12, 14);
            lblTuKhoa.Name = "lblTuKhoa";
            lblTuKhoa.Size = new Size(63, 20);
            lblTuKhoa.TabIndex = 0;
            lblTuKhoa.Text = "Từ khóa";
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.Font = new Font("Segoe UI", 9F);
            txtTuKhoa.Location = new Point(78, 11);
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.PlaceholderText = "Mã, họ tên, email hoặc điện thoại";
            txtTuKhoa.Size = new Size(244, 27);
            txtTuKhoa.TabIndex = 1;
            // 
            // lblLocLop
            // 
            lblLocLop.AutoSize = true;
            lblLocLop.Font = new Font("Segoe UI", 8.8F, FontStyle.Bold);
            lblLocLop.ForeColor = Color.FromArgb(30, 41, 59);
            lblLocLop.Location = new Point(340, 14);
            lblLocLop.Name = "lblLocLop";
            lblLocLop.Size = new Size(35, 20);
            lblLocLop.TabIndex = 2;
            lblLocLop.Text = "Lớp";
            // 
            // cboLocLop
            // 
            cboLocLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocLop.Font = new Font("Segoe UI", 9F);
            cboLocLop.FormattingEnabled = true;
            cboLocLop.Location = new Point(382, 11);
            cboLocLop.Name = "cboLocLop";
            cboLocLop.Size = new Size(168, 28);
            cboLocLop.TabIndex = 3;
            // 
            // lblDiemTu
            // 
            lblDiemTu.AutoSize = true;
            lblDiemTu.Font = new Font("Segoe UI", 8.8F, FontStyle.Bold);
            lblDiemTu.ForeColor = Color.FromArgb(30, 41, 59);
            lblDiemTu.Location = new Point(568, 14);
            lblDiemTu.Name = "lblDiemTu";
            lblDiemTu.Size = new Size(65, 20);
            lblDiemTu.TabIndex = 4;
            lblDiemTu.Text = "Điểm từ";
            // 
            // nudDiemTu
            // 
            nudDiemTu.DecimalPlaces = 1;
            nudDiemTu.Font = new Font("Segoe UI", 9F);
            nudDiemTu.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nudDiemTu.Location = new Point(638, 11);
            nudDiemTu.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudDiemTu.Name = "nudDiemTu";
            nudDiemTu.Size = new Size(68, 27);
            nudDiemTu.TabIndex = 5;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimKiem.BackColor = Color.FromArgb(25, 118, 210);
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(720, 9);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(116, 31);
            btnTimKiem.TabIndex = 6;
            btnTimKiem.Text = "🔍 Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnHienThiTatCa
            // 
            btnHienThiTatCa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnHienThiTatCa.BackColor = Color.White;
            btnHienThiTatCa.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnHienThiTatCa.FlatStyle = FlatStyle.Flat;
            btnHienThiTatCa.Font = new Font("Segoe UI", 9F);
            btnHienThiTatCa.ForeColor = Color.FromArgb(30, 41, 59);
            btnHienThiTatCa.Location = new Point(846, 9);
            btnHienThiTatCa.Name = "btnHienThiTatCa";
            btnHienThiTatCa.Size = new Size(142, 31);
            btnHienThiTatCa.TabIndex = 7;
            btnHienThiTatCa.Text = "Hiển thị tất cả";
            btnHienThiTatCa.UseVisualStyleBackColor = false;
            btnHienThiTatCa.Click += btnHienThiTatCa_Click;
            // 
            // pnlDanhSach
            // 
            pnlDanhSach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlDanhSach.BackColor = Color.White;
            pnlDanhSach.Controls.Add(lblTitleDanhSach);
            pnlDanhSach.Controls.Add(lblTongSo);
            pnlDanhSach.Controls.Add(dgvSinhVien);
            pnlDanhSach.Controls.Add(lblHuongDan);
            pnlDanhSach.Controls.Add(lblBatBuoc);
            pnlDanhSach.Location = new Point(16, 347);
            pnlDanhSach.Name = "pnlDanhSach";
            pnlDanhSach.Size = new Size(1003, 335);
            pnlDanhSach.TabIndex = 9;
            // 
            // lblTitleDanhSach
            // 
            lblTitleDanhSach.AutoSize = true;
            lblTitleDanhSach.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTitleDanhSach.ForeColor = Color.FromArgb(24, 56, 92);
            lblTitleDanhSach.Location = new Point(12, 11);
            lblTitleDanhSach.Name = "lblTitleDanhSach";
            lblTitleDanhSach.Size = new Size(168, 23);
            lblTitleDanhSach.TabIndex = 0;
            lblTitleDanhSach.Text = "Danh sách sinh viên";
            // 
            // lblTongSo
            // 
            lblTongSo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTongSo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTongSo.ForeColor = Color.FromArgb(24, 56, 92);
            lblTongSo.Location = new Point(782, 11);
            lblTongSo.Name = "lblTongSo";
            lblTongSo.Size = new Size(207, 23);
            lblTongSo.TabIndex = 1;
            lblTongSo.Text = "Tổng số: 4 sinh viên";
            lblTongSo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.AllowUserToAddRows = false;
            dgvSinhVien.AllowUserToDeleteRows = false;
            dgvSinhVien.AllowUserToResizeRows = false;
            dgvSinhVien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSinhVien.BackgroundColor = Color.White;
            dgvSinhVien.BorderStyle = BorderStyle.None;
            dgvSinhVien.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.EnableHeadersVisualStyles = false;
            dgvSinhVien.GridColor = Color.FromArgb(226, 232, 240);
            dgvSinhVien.Location = new Point(14, 40);
            dgvSinhVien.MultiSelect = false;
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.ReadOnly = true;
            dgvSinhVien.RowHeadersVisible = false;
            dgvSinhVien.RowHeadersWidth = 51;
            dgvSinhVien.RowTemplate.Height = 32;
            dgvSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSinhVien.Size = new Size(975, 260);
            dgvSinhVien.TabIndex = 2;
            dgvSinhVien.CellClick += dgvSinhVien_CellClick;
            // 
            // lblHuongDan
            // 
            lblHuongDan.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblHuongDan.AutoSize = true;
            lblHuongDan.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            lblHuongDan.ForeColor = Color.FromArgb(100, 116, 139);
            lblHuongDan.Location = new Point(14, 308);
            lblHuongDan.Name = "lblHuongDan";
            lblHuongDan.Size = new Size(328, 20);
            lblHuongDan.TabIndex = 3;
            lblHuongDan.Text = "Chọn một dòng để xem, sửa hoặc xóa thông tin sinh viên.";
            // 
            // lblBatBuoc
            // 
            lblBatBuoc.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblBatBuoc.AutoSize = true;
            lblBatBuoc.Font = new Font("Segoe UI", 8.5F);
            lblBatBuoc.ForeColor = Color.FromArgb(100, 116, 139);
            lblBatBuoc.Location = new Point(812, 308);
            lblBatBuoc.Name = "lblBatBuoc";
            lblBatBuoc.Size = new Size(177, 20);
            lblBatBuoc.TabIndex = 4;
            lblBatBuoc.Text = "Các trường có dấu * là bắt buộc.";
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.FromArgb(240, 244, 248);
            pnlFooter.Controls.Add(lblFooterLeft);
            pnlFooter.Controls.Add(lblFooterRight);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 694);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(1034, 32);
            pnlFooter.TabIndex = 10;
            // 
            // lblFooterLeft
            // 
            lblFooterLeft.AutoSize = true;
            lblFooterLeft.Font = new Font("Segoe UI", 8.5F);
            lblFooterLeft.ForeColor = Color.FromArgb(100, 116, 139);
            lblFooterLeft.Location = new Point(14, 6);
            lblFooterLeft.Name = "lblFooterLeft";
            lblFooterLeft.Size = new Size(335, 20);
            lblFooterLeft.TabIndex = 0;
            lblFooterLeft.Text = "Bài tập: xây dựng Windows Forms quản lý sinh viên theo lớp";
            // 
            // lblFooterRight
            // 
            lblFooterRight.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFooterRight.AutoSize = true;
            lblFooterRight.Font = new Font("Segoe UI", 8.5F);
            lblFooterRight.ForeColor = Color.FromArgb(100, 116, 139);
            lblFooterRight.Location = new Point(748, 6);
            lblFooterRight.Name = "lblFooterRight";
            lblFooterRight.Size = new Size(271, 20);
            lblFooterRight.TabIndex = 1;
            lblFooterRight.Text = "Thêm • Sửa • Xóa • Tìm kiếm • Lọc theo lớp";
            // 
            // frmQLSV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 250);
            ClientSize = new Size(1034, 726);
            Controls.Add(pnlFooter);
            Controls.Add(pnlDanhSach);
            Controls.Add(pnlTimKiem);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(pnlThongTin);
            Controls.Add(lblSubtitle);
            Controls.Add(lblMainTitle);
            Controls.Add(pnlHeader);
            MinimumSize = new Size(1040, 760);
            Name = "frmQLSV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ứng dụng quản lý sinh viên";
            Load += frmQLSV_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlThongTin.ResumeLayout(false);
            pnlThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDiem).EndInit();
            pnlTimKiem.ResumeLayout(false);
            pnlTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDiemTu).EndInit();
            pnlDanhSach.ResumeLayout(false);
            pnlDanhSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            pnlFooter.ResumeLayout(false);
            pnlFooter.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblAppIcon;
        private Label lblHeaderTitle;
        private Label lblMainTitle;
        private Label lblSubtitle;
        private Panel pnlThongTin;
        private Panel pnlAccentBar;
        private Label lblTitleThongTin;
        private Label lblMaSV;
        private TextBox txtMaSV;
        private Label lblNgaySinh;
        private DateTimePicker dtpNgaySinh;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblGioiTinh;
        private RadioButton radNam;
        private RadioButton radNu;
        private Label lblDienThoai;
        private TextBox txtDienThoai;
        private Label lblLopHoc;
        private ComboBox cboLopHoc;
        private Label lblDiem;
        private NumericUpDown nudDiem;
        private Label lblTrangThai;
        private ComboBox cboTrangThai;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private Panel pnlTimKiem;
        private Label lblTuKhoa;
        private TextBox txtTuKhoa;
        private Label lblLocLop;
        private ComboBox cboLocLop;
        private Label lblDiemTu;
        private NumericUpDown nudDiemTu;
        private Button btnTimKiem;
        private Button btnHienThiTatCa;
        private Panel pnlDanhSach;
        private Label lblTitleDanhSach;
        private Label lblTongSo;
        private DataGridView dgvSinhVien;
        private Label lblHuongDan;
        private Label lblBatBuoc;
        private Panel pnlFooter;
        private Label lblFooterLeft;
        private Label lblFooterRight;
    }
}
