using System;
using System.Collections.Generic;
using System.Linq;
using QLSV_App.Data.Entity;

namespace QLSV_App.Data.DAL
{
    public class SinhVienDAL
    {
        // Nguồn dữ liệu mô phỏng trong bộ nhớ
        private static readonly List<SinhVien> _danhSachSV = new List<SinhVien>
        {
            new SinhVien
            {
                MaSV = "SV000123",
                HoTen = "Nguyễn Văn An",
                NgaySinh = new DateTime(2006, 8, 15),
                GioiTinh = true,
                Email = "an.nv@vju.ac.vn",
                DienThoai = "0912345678",
                MaLop = "L01",
                Diem = 8.5,
                TrangThai = "Đang học"
            },
            new SinhVien
            {
                MaSV = "SV000124",
                HoTen = "Trần Minh Anh",
                NgaySinh = new DateTime(2006, 1, 22),
                GioiTinh = false,
                Email = "anh.tm@vju.ac.vn",
                DienThoai = "0987654321",
                MaLop = "L02",
                Diem = 9.0,
                TrangThai = "Đang học"
            },
            new SinhVien
            {
                MaSV = "SV000125",
                HoTen = "Lê Hoàng Bình",
                NgaySinh = new DateTime(2006, 5, 9),
                GioiTinh = true,
                Email = "binh.lh@vju.ac.vn",
                DienThoai = "0355556677",
                MaLop = "L01",
                Diem = 7.4,
                TrangThai = "Đang học"
            },
            new SinhVien
            {
                MaSV = "SV000126",
                HoTen = "Đỗ Thị Hồng",
                NgaySinh = new DateTime(2006, 11, 30),
                GioiTinh = false,
                Email = "hong.dt@vju.ac.vn",
                DienThoai = "0777888999",
                MaLop = "L03",
                Diem = 8.1,
                TrangThai = "Đang học"
            }
        };

        // Lấy về toàn bộ danh sách sinh viên (bản sao)
        public List<SinhVien> GetAll()
        {
            return _danhSachSV.Select(sv => Clone(sv)).ToList();
        }

        // Lấy về sinh viên theo mã SV
        public SinhVien? GetById(string maSV)
        {
            if (string.IsNullOrWhiteSpace(maSV)) return null;
            var sv = _danhSachSV.FirstOrDefault(s => s.MaSV.Equals(maSV.Trim(), StringComparison.OrdinalIgnoreCase));
            return sv != null ? Clone(sv) : null;
        }

        // Thêm sinh viên vào nguồn dữ liệu
        public bool Add(SinhVien sv)
        {
            if (sv == null || string.IsNullOrWhiteSpace(sv.MaSV)) return false;
            if (Exists(sv.MaSV)) return false;

            _danhSachSV.Add(Clone(sv));
            return true;
        }

        // Cập nhật thông tin sinh viên
        public bool Update(SinhVien sv)
        {
            if (sv == null || string.IsNullOrWhiteSpace(sv.MaSV)) return false;
            var existing = _danhSachSV.FirstOrDefault(s => s.MaSV.Equals(sv.MaSV.Trim(), StringComparison.OrdinalIgnoreCase));
            if (existing == null) return false;

            existing.HoTen = sv.HoTen;
            existing.NgaySinh = sv.NgaySinh;
            existing.GioiTinh = sv.GioiTinh;
            existing.Email = sv.Email;
            existing.DienThoai = sv.DienThoai;
            existing.MaLop = sv.MaLop;
            existing.Diem = sv.Diem;
            existing.TrangThai = sv.TrangThai;

            return true;
        }

        // Xóa sinh viên khỏi nguồn dữ liệu
        public bool Delete(string maSV)
        {
            if (string.IsNullOrWhiteSpace(maSV)) return false;
            var existing = _danhSachSV.FirstOrDefault(s => s.MaSV.Equals(maSV.Trim(), StringComparison.OrdinalIgnoreCase));
            if (existing == null) return false;

            return _danhSachSV.Remove(existing);
        }

        // Kiểm tra mã sinh viên đã tồn tại chưa
        public bool Exists(string maSV)
        {
            if (string.IsNullOrWhiteSpace(maSV)) return false;
            return _danhSachSV.Any(s => s.MaSV.Equals(maSV.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        // Lọc và tìm kiếm sinh viên
        public List<SinhVien> Search(string? tuKhoa, string? maLop, double diemTu)
        {
            var query = _danhSachSV.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(tuKhoa))
            {
                string kw = tuKhoa.Trim().ToLowerInvariant();
                query = query.Where(sv =>
                    (sv.MaSV != null && sv.MaSV.ToLowerInvariant().Contains(kw)) ||
                    (sv.HoTen != null && sv.HoTen.ToLowerInvariant().Contains(kw)) ||
                    (sv.Email != null && sv.Email.ToLowerInvariant().Contains(kw)) ||
                    (sv.DienThoai != null && sv.DienThoai.Contains(kw))
                );
            }

            if (!string.IsNullOrWhiteSpace(maLop))
            {
                query = query.Where(sv => sv.MaLop.Equals(maLop.Trim(), StringComparison.OrdinalIgnoreCase));
            }

            if (diemTu > 0)
            {
                query = query.Where(sv => sv.Diem >= diemTu);
            }

            return query.Select(sv => Clone(sv)).ToList();
        }

        // Helper nhân bản object để tránh tham chiếu ngoài ý muốn
        private static SinhVien Clone(SinhVien sv)
        {
            return new SinhVien
            {
                MaSV = sv.MaSV,
                HoTen = sv.HoTen,
                NgaySinh = sv.NgaySinh,
                GioiTinh = sv.GioiTinh,
                Email = sv.Email,
                DienThoai = sv.DienThoai,
                MaLop = sv.MaLop,
                Diem = sv.Diem,
                TrangThai = sv.TrangThai
            };
        }
    }
}
