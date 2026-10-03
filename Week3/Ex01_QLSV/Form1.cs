using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QLSV_App
{
    public partial class Form1 : Form
    {
        // Danh sách dữ liệu mẫu trong bộ nhớ
        private List<LopHoc> danhSachLop = new List<LopHoc>();
        private List<SinhVien> danhSachSV = new List<SinhVien>();

        // DataGridView hiển thị danh sách (nếu Form Designer của bạn chưa kéo dgv)
        private DataGridView dgvSinhVien;
        private Label lblTongSo;

        public Form1()
        {
            InitializeComponent();
            KhoiTaoDuLieuMau();
            KhoiTaoThemControlsConThieu();
        }

        private void KhoiTaoDuLieuMau()
        {
            danhSachLop = new List<LopHoc>
            {
                new LopHoc { MaLop = "L01", TenLop = "Kỹ thuật phần mềm 01" },
                new LopHoc { MaLop = "L02", TenLop = "Trí tuệ nhân tạo 01" },
                new LopHoc { MaLop = "L03", TenLop = "Khoa học dữ liệu 01" }
            };

            danhSachSV = new List<SinhVien>
            {
                new SinhVien { MaSV = "SV000123", HoTen = "Nguyễn Văn An", NgaySinh = new DateTime(2006, 8, 15), GioiTinh = true, Email = "an.nv@vju.ac.vn", DienThoai = "0912345678", MaLop = "L01", Diem = 8.5, TrangThai = "Đang học" },
                new SinhVien { MaSV = "SV000124", HoTen = "Trần Minh Anh", NgaySinh = new DateTime(2006, 1, 22), GioiTinh = false, Email = "anh.tm@vju.ac.vn", DienThoai = "0987654321", MaLop = "L02", Diem = 9.0, TrangThai = "Đang học" },
                new SinhVien { MaSV = "SV000125", HoTen = "Lê Hoàng Bình", NgaySinh = new DateTime(2006, 5, 9), GioiTinh = true, Email = "binh.lh@vju.ac.vn", DienThoai = "0355556677", MaLop = "L01", Diem = 7.4, TrangThai = "Đang học" },
                new SinhVien { MaSV = "SV000126", HoTen = "Đỗ Thị Hồng", NgaySinh = new DateTime(2006, 11, 30), GioiTinh = false, Email = "hong.dt@vju.ac.vn", DienThoai = "0777888999", MaLop = "L03", Diem = 8.1, TrangThai = "Đang học" }
            };
        }

        // Tự động bổ sung DataGridView nếu file designer của bạn đang thiếu control này
        private void KhoiTaoThemControlsConThieu()
        {
            lblTongSo = new Label
            {
                Text = "Tổng số: 0 sinh viên",
                Location = new Point(850, 375),
                AutoSize = true,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold)
            };
            this.Controls.Add(lblTongSo);

            dgvSinhVien = new DataGridView
            {
                Location = new Point(12, 400),
                Size = new Size(1010, 210),
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                ReadOnly = true,
                AllowUserToAddRows = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                RowHeadersVisible = false
            };
            this.Controls.Add(dgvSinhVien);

            dgvSinhVien.CellClick += (s, e) =>
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvSinhVien.Rows.Count)
                {
                    string ma = dgvSinhVien.Rows[e.RowIndex].Cells["MaSV"].Value?.ToString();
                    if (!string.IsNullOrEmpty(ma))
                    {
                        txtMaSV.Text = ma;
                    }
                }
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 2.a: Thứ tự phím Tab từ trên xuống dưới, từ trái sang phải
            ThietLapThuTuTabVaFocus();

            // 2.b: Lấy danh sách lớp học nạp vào combobox
            cboLopHoc.DataSource = new BindingSource(danhSachLop, null);
            cboLopHoc.DisplayMember = "TenLop";
            cboLopHoc.ValueMember = "MaLop";

            // Nạp combobox tìm kiếm lớp ở panel2
            var danhSachLocLop = new List<LopHoc> { new LopHoc { MaLop = "", TenLop = "Tất cả lớp" } };
            danhSachLocLop.AddRange(danhSachLop);
            cboLop.DataSource = danhSachLocLop;
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";

            // Nạp danh mục trạng thái
            cboTrangThai.Items.Clear();
            cboTrangThai.Items.AddRange(new object[] { "Đang học", "Bảo lưu", "Đã tốt nghiệp" });
            cboTrangThai.SelectedIndex = 0;

            // 2.c: Lấy về danh sách sinh viên hiển thị lên DataGridView
            HienThiDataGridView(danhSachSV);

            // Gán sự kiện TextChanged cho txtMaSV (yêu cầu 2.d)
            txtMaSV.TextChanged += txtMaSV_TextChanged;

            // Trạng thái ban đầu: chưa có mã, ở chế độ nhập mới
            ThietLapCheDoNhap(isExisted: false);
        }

        // 2.a: Thiết lập TabIndex theo chiều từ trên xuống dưới, từ trái sang phải
        private void ThietLapThuTuTabVaFocus()
        {
            txtMaSV.TabIndex = 0;
            dtpNgaySinh.TabIndex = 1;
            txtEmail.TabIndex = 2;

            txtHoTen.TabIndex = 3;
            radioButton1.TabIndex = 4; // Nam
            radioButton2.TabIndex = 5; // Nữ
            txtDienThoai.TabIndex = 6;

            cboLopHoc.TabIndex = 7;
            nudDiem.TabIndex = 8;
            cboTrangThai.TabIndex = 9;

            btnThem.TabIndex = 10;
            btnSua.TabIndex = 11;
            btnXoa.TabIndex = 12;
            btnLamMoi.TabIndex = 13;

            // Mặc định con trỏ chuột nhảy vào txtMaSV
            this.ActiveControl = txtMaSV;
            txtMaSV.Focus();
        }

        // 2.c: Hiển thị DataGridView và cập nhật nhãn tổng số
        private void HienThiDataGridView(List<SinhVien> list)
        {
            dgvSinhVien.DataSource = null;
            var bangDuLieu = list.Select(sv => new
            {
                MaSV = sv.MaSV,
                HoTen = sv.HoTen,
                NgaySinh = sv.NgaySinh.ToString("dd/MM/yyyy"),
                GioiTinh = sv.GioiTinh ? "Nam" : "Nữ",
                Email = sv.Email,
                DienThoai = sv.DienThoai,
                Diem = sv.Diem,
                Lop = danhSachLop.FirstOrDefault(l => l.MaLop == sv.MaLop)?.TenLop ?? sv.MaLop,
                TrangThai = sv.TrangThai
            }).ToList();

            dgvSinhVien.DataSource = bangDuLieu;

            // Đặt tiêu đề hiển thị cột tiếng Việt
            if (dgvSinhVien.Columns.Count > 0)
            {
                dgvSinhVien.Columns["MaSV"].HeaderText = "Mã SV";
                dgvSinhVien.Columns["HoTen"].HeaderText = "Họ và tên";
                dgvSinhVien.Columns["NgaySinh"].HeaderText = "Ngày sinh";
                dgvSinhVien.Columns["GioiTinh"].HeaderText = "Giới tính";
                dgvSinhVien.Columns["Email"].HeaderText = "Email";
                dgvSinhVien.Columns["DienThoai"].HeaderText = "Điện thoại";
                dgvSinhVien.Columns["Diem"].HeaderText = "Điểm";
                dgvSinhVien.Columns["Lop"].HeaderText = "Lớp";
                dgvSinhVien.Columns["TrangThai"].HeaderText = "Trạng thái";
            }

            lblTongSo.Text = $"Tổng số: {list.Count} sinh viên";
        }

        // 2.d: Xử lý khi người dùng nhập mã sinh viên
        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            var sv = danhSachSV.FirstOrDefault(s => s.MaSV.Equals(maSV, StringComparison.OrdinalIgnoreCase));

            if (sv != null)
            {
                // MÃ ĐÃ TỒN TẠI:
                // - Đổ dữ liệu lên các điều khiển
                txtHoTen.Text = sv.HoTen;
                dtpNgaySinh.Value = sv.NgaySinh;
                txtEmail.Text = sv.Email;
                txtDienThoai.Text = sv.DienThoai;
                cboLopHoc.SelectedValue = sv.MaLop;
                nudDiem.Value = (decimal)sv.Diem;
                cboTrangThai.SelectedItem = sv.TrangThai;

                if (sv.GioiTinh)
                    radioButton1.Checked = true;
                else
                    radioButton2.Checked = true;

                // - Disable chức năng nhập (Thêm), Enable sửa và xóa
                ThietLapCheDoNhap(isExisted: true);
            }
            else
            {
                // MÃ CHƯA TỒN TẠI:
                // - Xóa giá trị các ô nhập liệu còn lại
                XoaTrangCacOConLai();

                // - Enable chức năng nhập (Thêm), Disable sửa và xóa
                ThietLapCheDoNhap(isExisted: false);
            }
        }

        // Bật/tắt trạng thái các nút bấm và chế độ nhập liệu
        private void ThietLapCheDoNhap(bool isExisted)
        {
            if (isExisted)
            {
                // Đã tồn tại: Không cho Thêm, cho phép Sửa/Xóa
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            else
            {
                // Chưa tồn tại: Cho phép Thêm, cấm Sửa/Xóa
                btnThem.Enabled = true;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        private void XoaTrangCacOConLai()
        {
            txtHoTen.Clear();
            txtEmail.Clear();
            txtDienThoai.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            radioButton1.Checked = true;
            nudDiem.Value = 0;
            if (cboLopHoc.Items.Count > 0) cboLopHoc.SelectedIndex = 0;
            if (cboTrangThai.Items.Count > 0) cboTrangThai.SelectedIndex = 0;
        }

        // Ví dụ kiểm tra Validate bằng Data Annotations khi bấm Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            var svMoi = new SinhVien
            {
                MaSV = txtMaSV.Text.Trim(),
                HoTen = txtHoTen.Text.Trim(),
                NgaySinh = dtpNgaySinh.Value,
                GioiTinh = radioButton1.Checked,
                Email = txtEmail.Text.Trim(),
                DienThoai = txtDienThoai.Text.Trim(),
                MaLop = cboLopHoc.SelectedValue?.ToString() ?? "",
                Diem = (double)nudDiem.Value,
                TrangThai = cboTrangThai.SelectedItem?.ToString() ?? "Đang học"
            };

            // Gọi phương thức kiểm tra hợp lệ đã viết ở Lớp SinhVien
            var (isValid, errors) = SinhVien.ValidateModel(svMoi);

            if (!isValid)
            {
                string thongBaoLoi = string.Join("\n• ", errors);
                MessageBox.Show("Dữ liệu nhập không hợp lệ:\n• " + thongBaoLoi, "Lỗi xác thực", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            danhSachSV.Add(svMoi);
            HienThiDataGridView(danhSachSV);
            MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        // 1. Xác thực khi người dùng bấm nút XÓA
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            var sv = danhSachSV.FirstOrDefault(s => s.MaSV.Equals(maSV, StringComparison.OrdinalIgnoreCase));

            if (sv == null)
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập mã sinh viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // HỘP THOẠI XÁC THỰC NGUY HIỂM
            DialogResult result = MessageBox.Show(
                $"HÀNH ĐỘNG NGUY HIỂM: Bạn có chắc chắn muốn xóa sinh viên [{sv.HoTen}] (Mã: {sv.MaSV}) không?\n\nDữ liệu sau khi xóa sẽ không thể phục hồi!",
                "Xác nhận hành động nguy hiểm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2 // Mặc định focus vào nút "No" để tránh bấm nhầm
            );

            // Nếu người dùng chọn "No", hủy thao tác ngay lập tức
            if (result != DialogResult.Yes)
            {
                return;
            }

            // Tiến hành xóa nếu người dùng đã xác nhận "Yes"
            danhSachSV.Remove(sv);
            HienThiDataGridView(danhSachSV);
            XoaTrangCacOConLai();
            txtMaSV.Clear();

            MessageBox.Show("Đã xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 2. Xác thực khi người dùng bấm nút SỬA (Ghi đè thông tin)
        private void btnSua_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            var sv = danhSachSV.FirstOrDefault(s => s.MaSV.Equals(maSV, StringComparison.OrdinalIgnoreCase));

            if (sv == null)
            {
                MessageBox.Show("Không tìm thấy sinh viên để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo đối tượng cập nhật tạm để kiểm tra validate dữ liệu trước
            var svCapNhat = new SinhVien
            {
                MaSV = maSV,
                HoTen = txtHoTen.Text.Trim(),
                NgaySinh = dtpNgaySinh.Value,
                GioiTinh = radioButton1.Checked,
                Email = txtEmail.Text.Trim(),
                DienThoai = txtDienThoai.Text.Trim(),
                MaLop = cboLopHoc.SelectedValue?.ToString() ?? "",
                Diem = (double)nudDiem.Value,
                TrangThai = cboTrangThai.SelectedItem?.ToString() ?? "Đang học"
            };

            var (isValid, errors) = SinhVien.ValidateModel(svCapNhat);
            if (!isValid)
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ:\n• " + string.Join("\n• ", errors), "Lỗi xác thực", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // HỘP THOẠI XÁC THỰC CẬP NHẬT
            DialogResult result = MessageBox.Show(
                $"Bạn có chắc chắn muốn lưu các thay đổi cho sinh viên [{sv.MaSV}] không?",
                "Xác nhận cập nhật thông tin",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Gán dữ liệu mới
                sv.HoTen = svCapNhat.HoTen;
                sv.NgaySinh = svCapNhat.NgaySinh;
                sv.GioiTinh = svCapNhat.GioiTinh;
                sv.Email = svCapNhat.Email;
                sv.DienThoai = svCapNhat.DienThoai;
                sv.MaLop = svCapNhat.MaLop;
                sv.Diem = svCapNhat.Diem;
                sv.TrangThai = svCapNhat.TrangThai;

                HienThiDataGridView(danhSachSV);
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}