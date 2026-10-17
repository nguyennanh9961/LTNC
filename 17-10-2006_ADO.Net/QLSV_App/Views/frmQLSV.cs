using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QLSV_App.BUL;
using QLSV_App.Data.Entity;

namespace QLSV_App.Views
{
    public partial class frmQLSV : Form
    {
        // Khai báo các đối tượng nghiệp vụ tầng BUL
        private readonly SinhVienBUL _sinhVienBUL;
        private readonly LopBUL _lopBUL;

        // Cờ tránh vòng lặp xử lý sự kiện khi gán dữ liệu tự động
        private bool _isBindingData = false;

        public frmQLSV()
        {
            InitializeComponent();
            _sinhVienBUL = new SinhVienBUL();
            _lopBUL = new LopBUL();
        }

        private void frmQLSV_Load(object sender, EventArgs e)
        {
            CauHinhGiaoDienDataGridView();
            ThietLapThuTuTabVaFocus();
            NapDuLieuKhoiTao();

            // Đăng ký sự kiện TextChanged cho txtMaSV
            txtMaSV.TextChanged += txtMaSV_TextChanged;

            // Chế độ nhập ban đầu: mã chưa có, cho phép Thêm
            ThietLapCheDoNhap(isExisted: false);
        }

        // Cấu hình giao diện và cột hiển thị cho DataGridView giống hệt ảnh 1
        private void CauHinhGiaoDienDataGridView()
        {
            dgvSinhVien.AutoGenerateColumns = false;
            dgvSinhVien.Columns.Clear();

            dgvSinhVien.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(235, 243, 250);
            dgvSinhVien.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(24, 56, 92);
            dgvSinhVien.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvSinhVien.ColumnHeadersHeight = 35;
            dgvSinhVien.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgvSinhVien.DefaultCellStyle.SelectionBackColor = Color.FromArgb(217, 236, 249);
            dgvSinhVien.DefaultCellStyle.SelectionForeColor = Color.FromArgb(24, 56, 92);
            dgvSinhVien.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 252, 255);

            dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaSV",
                DataPropertyName = "MaSV",
                HeaderText = "Mã SV",
                FillWeight = 11
            });

            dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "HoTen",
                DataPropertyName = "HoTen",
                HeaderText = "Họ và tên",
                FillWeight = 16
            });

            dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NgaySinh",
                DataPropertyName = "NgaySinh",
                HeaderText = "Ngày sinh",
                FillWeight = 12,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "GioiTinhText",
                HeaderText = "Giới tính",
                FillWeight = 9
            });

            dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Email",
                DataPropertyName = "Email",
                HeaderText = "Email",
                FillWeight = 16
            });

            dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DienThoai",
                DataPropertyName = "DienThoai",
                HeaderText = "Điện thoại",
                FillWeight = 12
            });

            dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Diem",
                DataPropertyName = "Diem",
                HeaderText = "Điểm",
                FillWeight = 8,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "0.0" }
            });

            dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TenLop",
                DataPropertyName = "TenLop",
                HeaderText = "Lớp",
                FillWeight = 18
            });

            dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TrangThai",
                DataPropertyName = "TrangThai",
                HeaderText = "Trạng thái",
                FillWeight = 12
            });

            // Định dạng hiển thị Giới tính (Nam/Nữ)
            dgvSinhVien.CellFormatting += (s, e) =>
            {
                if (e.RowIndex >= 0 && dgvSinhVien.Columns[e.ColumnIndex].Name == "GioiTinhText")
                {
                    if (dgvSinhVien.Rows[e.RowIndex].DataBoundItem is SinhVien sv)
                    {
                        e.Value = sv.GioiTinh ? "Nam" : "Nữ";
                    }
                }
            };
        }

        // Thiết lập thứ tự phím Tab từ trên xuống dưới, từ trái sang phải
        private void ThietLapThuTuTabVaFocus()
        {
            txtMaSV.TabIndex = 0;
            dtpNgaySinh.TabIndex = 1;
            txtEmail.TabIndex = 2;

            txtHoTen.TabIndex = 3;
            radNam.TabIndex = 4;
            radNu.TabIndex = 5;
            txtDienThoai.TabIndex = 6;

            cboLopHoc.TabIndex = 7;
            nudDiem.TabIndex = 8;
            cboTrangThai.TabIndex = 9;

            btnThem.TabIndex = 10;
            btnSua.TabIndex = 11;
            btnXoa.TabIndex = 12;
            btnLamMoi.TabIndex = 13;

            txtTuKhoa.TabIndex = 14;
            cboLocLop.TabIndex = 15;
            nudDiemTu.TabIndex = 16;
            btnTimKiem.TabIndex = 17;
            btnHienThiTatCa.TabIndex = 18;

            this.ActiveControl = txtMaSV;
            txtMaSV.Focus();
        }

        // Nạp dữ liệu các combobox và danh sách sinh viên ban đầu
        private void NapDuLieuKhoiTao()
        {
            // 1. Nạp danh sách lớp học
            var danhSachLop = _lopBUL.LayDanhSachLop();
            cboLopHoc.DataSource = new BindingSource(danhSachLop, null);
            cboLopHoc.DisplayMember = "TenLop";
            cboLopHoc.ValueMember = "MaLop";

            // 2. Nạp combobox lọc lớp
            var danhSachLocLop = new List<LopHoc> { new LopHoc { MaLop = "", TenLop = "Tất cả lớp" } };
            danhSachLocLop.AddRange(danhSachLop);
            cboLocLop.DataSource = new BindingSource(danhSachLocLop, null);
            cboLocLop.DisplayMember = "TenLop";
            cboLocLop.ValueMember = "MaLop";

            // 3. Nạp danh mục trạng thái
            cboTrangThai.Items.Clear();
            cboTrangThai.Items.AddRange(new object[] { "Đang học", "Bảo lưu", "Đã tốt nghiệp" });
            cboTrangThai.SelectedIndex = 0;

            // 4. Nạp danh sách sinh viên hiển thị lên DataGridView
            var danhSachSV = _sinhVienBUL.LayDanhSachSinhVien();
            HienThiDanhSachLenDGV(danhSachSV);
        }

        // Hiển thị danh sách sinh viên lên DataGridView và cập nhật nhãn số lượng
        private void HienThiDanhSachLenDGV(List<SinhVien> list)
        {
            dgvSinhVien.DataSource = null;
            dgvSinhVien.DataSource = list;
            lblTongSo.Text = $"Tổng số: {list.Count} sinh viên";
        }

        // Xử lý sự kiện khi nhập mã sinh viên (yêu cầu 2.d)
        private void txtMaSV_TextChanged(object? sender, EventArgs e)
        {
            if (_isBindingData) return;

            string maSV = txtMaSV.Text.Trim();
            if (string.IsNullOrEmpty(maSV))
            {
                XoaTrangCacOConLai();
                ThietLapCheDoNhap(isExisted: false);
                return;
            }

            // Gọi tầng BUL kiểm tra thông tin
            var sv = _sinhVienBUL.LaySinhVienTheoMa(maSV);
            if (sv != null)
            {
                // MÃ ĐÃ TỒN TẠI: Đổ dữ liệu lên các điều khiển
                _isBindingData = true;
                txtHoTen.Text = sv.HoTen;
                dtpNgaySinh.Value = sv.NgaySinh;
                txtEmail.Text = sv.Email;
                txtDienThoai.Text = sv.DienThoai;
                cboLopHoc.SelectedValue = sv.MaLop;
                nudDiem.Value = (decimal)sv.Diem;
                cboTrangThai.SelectedItem = sv.TrangThai;

                if (sv.GioiTinh)
                    radNam.Checked = true;
                else
                    radNu.Checked = true;
                _isBindingData = false;

                // Disable nút Thêm, Enable nút Sửa và Xóa
                ThietLapCheDoNhap(isExisted: true);
            }
            else
            {
                // MÃ CHƯA TỒN TẠI: Xóa giá trị các ô nhập liệu còn lại
                XoaTrangCacOConLai();

                // Enable nút Thêm, Disable nút Sửa và Xóa
                ThietLapCheDoNhap(isExisted: false);
            }
        }

        // Bật / tắt trạng thái các nút bấm theo chế độ
        private void ThietLapCheDoNhap(bool isExisted)
        {
            if (isExisted)
            {
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            else
            {
                btnThem.Enabled = true;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        // Xóa trắng các ô nhập liệu (trừ Mã sinh viên)
        private void XoaTrangCacOConLai()
        {
            _isBindingData = true;
            txtHoTen.Clear();
            txtEmail.Clear();
            txtDienThoai.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            radNam.Checked = true;
            nudDiem.Value = 0;
            if (cboLopHoc.Items.Count > 0) cboLopHoc.SelectedIndex = 0;
            if (cboTrangThai.Items.Count > 0) cboTrangThai.SelectedIndex = 0;
            _isBindingData = false;
        }

        // Chọn một dòng trên DataGridView để xem, sửa, xóa
        private void dgvSinhVien_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvSinhVien.Rows.Count)
            {
                if (dgvSinhVien.Rows[e.RowIndex].DataBoundItem is SinhVien sv)
                {
                    txtMaSV.Text = sv.MaSV;
                }
            }
        }

        // Xử lý nút THÊM
        private void btnThem_Click(object? sender, EventArgs e)
        {
            var svMoi = new SinhVien
            {
                MaSV = txtMaSV.Text.Trim(),
                HoTen = txtHoTen.Text.Trim(),
                NgaySinh = dtpNgaySinh.Value,
                GioiTinh = radNam.Checked,
                Email = txtEmail.Text.Trim(),
                DienThoai = txtDienThoai.Text.Trim(),
                MaLop = cboLopHoc.SelectedValue?.ToString() ?? "",
                Diem = (double)nudDiem.Value,
                TrangThai = cboTrangThai.SelectedItem?.ToString() ?? "Đang học"
            };

            // Gọi nghiệp vụ tầng BUL
            var (success, message, errors) = _sinhVienBUL.ThemSinhVien(svMoi);

            if (!success)
            {
                string chiTietLoi = errors != null && errors.Count > 0 ? "\n• " + string.Join("\n• ", errors) : "";
                MessageBox.Show($"{message}{chiTietLoi}", "Lỗi xác thực dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Làm mới hiển thị
            LamMoiDanhSach();
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Xử lý nút SỬA
        private void btnSua_Click(object? sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            if (string.IsNullOrEmpty(maSV))
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập mã sinh viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var svCapNhat = new SinhVien
            {
                MaSV = maSV,
                HoTen = txtHoTen.Text.Trim(),
                NgaySinh = dtpNgaySinh.Value,
                GioiTinh = radNam.Checked,
                Email = txtEmail.Text.Trim(),
                DienThoai = txtDienThoai.Text.Trim(),
                MaLop = cboLopHoc.SelectedValue?.ToString() ?? "",
                Diem = (double)nudDiem.Value,
                TrangThai = cboTrangThai.SelectedItem?.ToString() ?? "Đang học"
            };

            // Hộp thoại xác nhận sửa
            DialogResult dialog = MessageBox.Show(
                $"Bạn có chắc chắn muốn lưu các thay đổi cho sinh viên [{svCapNhat.MaSV}] không?",
                "Xác nhận cập nhật thông tin",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dialog != DialogResult.Yes) return;

            // Gọi nghiệp vụ tầng BUL
            var (success, message, errors) = _sinhVienBUL.SuaSinhVien(svCapNhat);

            if (!success)
            {
                string chiTietLoi = errors != null && errors.Count > 0 ? "\n• " + string.Join("\n• ", errors) : "";
                MessageBox.Show($"{message}{chiTietLoi}", "Lỗi cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LamMoiDanhSach();
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Xử lý nút XÓA
        private void btnXoa_Click(object? sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            var sv = _sinhVienBUL.LaySinhVienTheoMa(maSV);

            if (sv == null)
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập mã sinh viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Hộp thoại xác nhận xóa nguy hiểm
            DialogResult dialog = MessageBox.Show(
                $"HÀNH ĐỘNG NGUY HIỂM: Bạn có chắc chắn muốn xóa sinh viên [{sv.HoTen}] (Mã: {sv.MaSV}) không?\n\nDữ liệu sau khi xóa sẽ không thể phục hồi!",
                "Xác nhận hành động nguy hiểm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2
            );

            if (dialog != DialogResult.Yes) return;

            // Gọi tầng BUL để xóa
            var (success, message) = _sinhVienBUL.XoaSinhVien(maSV);

            if (!success)
            {
                MessageBox.Show(message, "Lỗi xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtMaSV.Clear();
            XoaTrangCacOConLai();
            ThietLapCheDoNhap(isExisted: false);
            LamMoiDanhSach();
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Xử lý nút LÀM MỚI
        private void btnLamMoi_Click(object? sender, EventArgs e)
        {
            txtMaSV.Clear();
            XoaTrangCacOConLai();
            txtTuKhoa.Clear();
            if (cboLocLop.Items.Count > 0) cboLocLop.SelectedIndex = 0;
            nudDiemTu.Value = 0;

            ThietLapCheDoNhap(isExisted: false);
            LamMoiDanhSach();

            txtMaSV.Focus();
        }

        // Xử lý nút TÌM KIẾM
        private void btnTimKiem_Click(object? sender, EventArgs e)
        {
            string tuKhoa = txtTuKhoa.Text.Trim();
            string maLop = cboLocLop.SelectedValue?.ToString() ?? "";
            double diemTu = (double)nudDiemTu.Value;

            // Gọi tầng BUL tìm kiếm và lọc
            var ketQua = _sinhVienBUL.TimKiemVaLoc(tuKhoa, maLop, diemTu);
            HienThiDanhSachLenDGV(ketQua);
        }

        // Xử lý nút HIỂN THỊ TẤT CẢ
        private void btnHienThiTatCa_Click(object? sender, EventArgs e)
        {
            txtTuKhoa.Clear();
            if (cboLocLop.Items.Count > 0) cboLocLop.SelectedIndex = 0;
            nudDiemTu.Value = 0;

            LamMoiDanhSach();
        }

        // Nạp lại toàn bộ danh sách sinh viên từ BUL
        private void LamMoiDanhSach()
        {
            var danhSachSV = _sinhVienBUL.LayDanhSachSinhVien();
            HienThiDanhSachLenDGV(danhSachSV);
        }
    }
}
