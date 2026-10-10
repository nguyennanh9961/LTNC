using System;
using System.Collections.Generic;
using System.Linq;
using QLSV_App.Data.Entity;

namespace QLSV_App.Data.DAL
{
    public class LopDAL
    {
        // Nguồn dữ liệu mô phỏng trong bộ nhớ
        private static readonly List<LopHoc> _danhSachLop = new List<LopHoc>
        {
            new LopHoc { MaLop = "L01", TenLop = "Kỹ thuật phần mềm 01" },
            new LopHoc { MaLop = "L02", TenLop = "Trí tuệ nhân tạo 01" },
            new LopHoc { MaLop = "L03", TenLop = "Khoa học dữ liệu 01" }
        };

        // Lấy về toàn bộ danh sách lớp học
        public List<LopHoc> GetAll()
        {
            return _danhSachLop.Select(l => new LopHoc
            {
                MaLop = l.MaLop,
                TenLop = l.TenLop
            }).ToList();
        }

        // Lấy về lớp học theo mã lớp
        public LopHoc? GetById(string maLop)
        {
            if (string.IsNullOrWhiteSpace(maLop)) return null;
            return _danhSachLop.FirstOrDefault(l => l.MaLop.Equals(maLop.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        // Thêm mới một lớp học
        public bool Add(LopHoc lop)
        {
            if (lop == null || string.IsNullOrWhiteSpace(lop.MaLop)) return false;
            if (Exists(lop.MaLop)) return false;

            _danhSachLop.Add(new LopHoc
            {
                MaLop = lop.MaLop.Trim(),
                TenLop = lop.TenLop.Trim()
            });
            return true;
        }

        // Sửa thông tin một lớp học
        public bool Update(LopHoc lop)
        {
            if (lop == null || string.IsNullOrWhiteSpace(lop.MaLop)) return false;
            var existing = GetById(lop.MaLop);
            if (existing == null) return false;

            existing.TenLop = lop.TenLop.Trim();
            return true;
        }

        // Xóa một lớp học theo mã
        public bool Delete(string maLop)
        {
            var existing = GetById(maLop);
            if (existing == null) return false;

            return _danhSachLop.Remove(existing);
        }

        // Kiểm tra tồn tại
        public bool Exists(string maLop)
        {
            if (string.IsNullOrWhiteSpace(maLop)) return false;
            return _danhSachLop.Any(l => l.MaLop.Equals(maLop.Trim(), StringComparison.OrdinalIgnoreCase));
        }
    }
}
