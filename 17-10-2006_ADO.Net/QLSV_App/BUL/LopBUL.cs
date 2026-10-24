using System;
using System.Collections.Generic;
using QLSV_App.Data.DAL;
using QLSV_App.Data.Entity;

namespace QLSV_App.BUL
{
    public class LopBUL
    {
        private readonly LopDAL _lopDAL;

        public LopBUL()
        {
            _lopDAL = new LopDAL();
        }

        public LopBUL(LopDAL lopDAL)
        {
            _lopDAL = lopDAL;
        }

        // Lấy danh sách tất cả các lớp học
        public List<LopHoc> LayDanhSachLop()
        {
            return _lopDAL.GetAll();
        }

        // Lấy thông tin lớp học theo mã
        public LopHoc? LayLopTheoMa(string maLop)
        {
            if (string.IsNullOrWhiteSpace(maLop)) return null;
            return _lopDAL.GetById(maLop.Trim());
        }

        // Kiểm tra mã lớp đã tồn tại chưa
        public bool KiemTraTonTai(string maLop)
        {
            if (string.IsNullOrWhiteSpace(maLop)) return false;
            return _lopDAL.Exists(maLop.Trim());
        }

        // Thêm lớp học mới với các kiểm tra nghiệp vụ
        public (bool Success, string Message) ThemLop(LopHoc lop)
        {
            if (lop == null)
            {
                return (false, "Dữ liệu lớp học không được để trống.");
            }

            if (string.IsNullOrWhiteSpace(lop.MaLop))
            {
                return (false, "Mã lớp không được để trống.");
            }

            if (string.IsNullOrWhiteSpace(lop.TenLop))
            {
                return (false, "Tên lớp không được để trống.");
            }

            if (_lopDAL.Exists(lop.MaLop))
            {
                return (false, $"Mã lớp '{lop.MaLop}' đã tồn tại trong hệ thống.");
            }

            bool ketQua = _lopDAL.Add(lop);
            return ketQua ? (true, "Thêm lớp học thành công.") : (false, "Thêm lớp học thất bại.");
        }

        // Sửa thông tin lớp học
        public (bool Success, string Message) SuaLop(LopHoc lop)
        {
            if (lop == null || string.IsNullOrWhiteSpace(lop.MaLop))
            {
                return (false, "Thông tin lớp học không hợp lệ.");
            }

            if (!_lopDAL.Exists(lop.MaLop))
            {
                return (false, $"Không tìm thấy lớp học có mã '{lop.MaLop}'.");
            }

            bool ketQua = _lopDAL.Update(lop);
            return ketQua ? (true, "Cập nhật lớp học thành công.") : (false, "Cập nhật lớp học thất bại.");
        }

        // Xóa lớp học
        public (bool Success, string Message) XoaLop(string maLop)
        {
            if (string.IsNullOrWhiteSpace(maLop))
            {
                return (false, "Mã lớp không được để trống.");
            }

            if (!_lopDAL.Exists(maLop))
            {
                return (false, $"Không tìm thấy lớp học có mã '{maLop}'.");
            }

            bool ketQua = _lopDAL.Delete(maLop);
            return ketQua ? (true, "Xóa lớp học thành công.") : (false, "Xóa lớp học thất bại.");
        }
    }
}
