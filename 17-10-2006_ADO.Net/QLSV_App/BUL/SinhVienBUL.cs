using System;
using System.Collections.Generic;
using System.Linq;
using QLSV_App.Data.DAL;
using QLSV_App.Data.Entity;

namespace QLSV_App.BUL
{
    public class SinhVienBUL
    {
        private readonly SinhVienDAL _sinhVienDAL;
        private readonly LopDAL _lopDAL;

        public SinhVienBUL()
        {
            _sinhVienDAL = new SinhVienDAL();
            _lopDAL = new LopDAL();
        }

        public SinhVienBUL(SinhVienDAL sinhVienDAL, LopDAL lopDAL)
        {
            _sinhVienDAL = sinhVienDAL;
            _lopDAL = lopDAL;
        }

        // Lấy toàn bộ danh sách sinh viên cùng tên lớp
        public List<SinhVien> LayDanhSachSinhVien()
        {
            var danhSachSV = _sinhVienDAL.GetAll();
            NapTenLopChoSinhVien(danhSachSV);
            return danhSachSV;
        }

        // Lấy sinh viên theo mã
        public SinhVien? LaySinhVienTheoMa(string maSV)
        {
            if (string.IsNullOrWhiteSpace(maSV)) return null;
            var sv = _sinhVienDAL.GetById(maSV.Trim());
            if (sv != null)
            {
                var lop = _lopDAL.GetById(sv.MaLop);
                sv.TenLop = lop?.TenLop ?? sv.MaLop;
            }
            return sv;
        }

        // Kiểm tra mã sinh viên đã tồn tại chưa
        public bool KiemTraTonTai(string maSV)
        {
            if (string.IsNullOrWhiteSpace(maSV)) return false;
            return _sinhVienDAL.Exists(maSV.Trim());
        }

        // Nghiệp vụ thêm sinh viên mới
        public (bool Success, string Message, List<string>? Errors) ThemSinhVien(SinhVien sv)
        {
            if (sv == null)
            {
                return (false, "Dữ liệu sinh viên không được để trống.", null);
            }

            // 1. Kiểm tra tính hợp lệ dữ liệu qua Data Annotations
            var (isValid, errors) = SinhVien.ValidateModel(sv);
            if (!isValid)
            {
                return (false, "Dữ liệu nhập không hợp lệ.", errors);
            }

            // 2. Kiểm tra trùng mã sinh viên
            if (_sinhVienDAL.Exists(sv.MaSV))
            {
                return (false, $"Mã sinh viên '{sv.MaSV}' đã tồn tại trong hệ thống.", new List<string> { "Mã sinh viên đã bị trùng." });
            }

            // 3. Kiểm tra lớp học có tồn tại
            if (!string.IsNullOrWhiteSpace(sv.MaLop) && !_lopDAL.Exists(sv.MaLop))
            {
                return (false, $"Lớp học được chọn không tồn tại trong hệ thống.", new List<string> { "Lớp học không hợp lệ." });
            }

            // 4. Lưu vào nguồn dữ liệu
            bool ketQua = _sinhVienDAL.Add(sv);
            if (ketQua)
            {
                return (true, "Thêm sinh viên thành công!", null);
            }
            else
            {
                return (false, "Thêm sinh viên thất bại vào nguồn dữ liệu.", null);
            }
        }

        // Nghiệp vụ sửa sinh viên
        public (bool Success, string Message, List<string>? Errors) SuaSinhVien(SinhVien sv)
        {
            if (sv == null || string.IsNullOrWhiteSpace(sv.MaSV))
            {
                return (false, "Thông tin sinh viên không hợp lệ.", null);
            }

            // 1. Kiểm tra tồn tại
            if (!_sinhVienDAL.Exists(sv.MaSV))
            {
                return (false, $"Không tìm thấy sinh viên có mã '{sv.MaSV}' để cập nhật.", null);
            }

            // 2. Kiểm tra tính hợp lệ dữ liệu qua Data Annotations
            var (isValid, errors) = SinhVien.ValidateModel(sv);
            if (!isValid)
            {
                return (false, "Dữ liệu nhập không hợp lệ.", errors);
            }

            // 3. Kiểm tra lớp học
            if (!string.IsNullOrWhiteSpace(sv.MaLop) && !_lopDAL.Exists(sv.MaLop))
            {
                return (false, "Lớp học được chọn không tồn tại trong hệ thống.", new List<string> { "Lớp học không hợp lệ." });
            }

            // 4. Cập nhật vào nguồn dữ liệu
            bool ketQua = _sinhVienDAL.Update(sv);
            if (ketQua)
            {
                return (true, "Cập nhật thông tin sinh viên thành công!", null);
            }
            else
            {
                return (false, "Cập nhật sinh viên thất bại.", null);
            }
        }

        // Nghiệp vụ xóa sinh viên
        public (bool Success, string Message) XoaSinhVien(string maSV)
        {
            if (string.IsNullOrWhiteSpace(maSV))
            {
                return (false, "Vui lòng chọn hoặc nhập mã sinh viên cần xóa!");
            }

            if (!_sinhVienDAL.Exists(maSV))
            {
                return (false, $"Không tìm thấy sinh viên có mã '{maSV}' trong hệ thống.");
            }

            bool ketQua = _sinhVienDAL.Delete(maSV);
            if (ketQua)
            {
                return (true, "Đã xóa sinh viên thành công!");
            }
            else
            {
                return (false, "Xóa sinh viên thất bại.");
            }
        }

        // Lọc và tìm kiếm sinh viên
        public List<SinhVien> TimKiemVaLoc(string? tuKhoa, string? maLop, double diemTu)
        {
            var ketQua = _sinhVienDAL.Search(tuKhoa, maLop, diemTu);
            NapTenLopChoSinhVien(ketQua);
            return ketQua;
        }

        // Bổ sung tên lớp cho danh sách sinh viên
        private void NapTenLopChoSinhVien(List<SinhVien> list)
        {
            var cacLop = _lopDAL.GetAll().ToDictionary(l => l.MaLop, l => l.TenLop, StringComparer.OrdinalIgnoreCase);
            foreach (var sv in list)
            {
                if (!string.IsNullOrWhiteSpace(sv.MaLop) && cacLop.TryGetValue(sv.MaLop, out var tenLop))
                {
                    sv.TenLop = tenLop;
                }
                else
                {
                    sv.TenLop = sv.MaLop;
                }
            }
        }
    }
}
