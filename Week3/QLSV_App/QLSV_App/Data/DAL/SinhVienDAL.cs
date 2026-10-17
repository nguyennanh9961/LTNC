using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using QLSV_App.Data.Entity;

namespace QLSV_App.Data.DAL
{
    /// <summary>
    /// Lớp truy xuất dữ liệu SinhVien (SinhVienDAL) sử dụng ADO.NET qua DataHelper theo Slide bài giảng
    /// </summary>
    public class SinhVienDAL
    {
        public static DataHelper dh = null!;

        // Khởi tạo mặc định đọc cấu hình từ App.config (Slide 17, 18)
        public SinhVienDAL()
        {
            if (dh == null)
            {
                string strcon = DataHelper.GetConnectionString("studentDataBase");
                dh = new DataHelper(strcon);
            }
        }

        public SinhVienDAL(string strcon)
        {
            dh = new DataHelper(strcon);
        }

        // Lấy về toàn bộ danh sách sinh viên qua ExecuteReader (Slide 10, 11, 16)
        public List<SinhVien> GetAll()
        {
            List<SinhVien> list = new List<SinhVien>();
            string sql = "SELECT MaSV, HoTen, NgaySinh, GioiTinh, Email, DienThoai, MaLop, Diem, TrangThai FROM SinhVien";
            SqlDataReader? dr = dh.ExecuteReader(sql);

            if (dr != null)
            {
                try
                {
                    while (dr.Read())
                    {
                        list.Add(MapFromReader(dr));
                    }
                }
                finally
                {
                    dh.DongKetNoi();
                }
                return list;
            }

            // Fallback nguồn dữ liệu ban đầu nếu CSDL chưa mở được
            return GetMockData();
        }

        // Lấy về sinh viên theo mã SV (Slide 16)
        public SinhVien? GetById(string maSV)
        {
            if (string.IsNullOrWhiteSpace(maSV)) return null;

            string safeMa = maSV.Trim().Replace("'", "''");
            string sql = $"SELECT MaSV, HoTen, NgaySinh, GioiTinh, Email, DienThoai, MaLop, Diem, TrangThai FROM SinhVien WHERE MaSV = '{safeMa}'";
            SqlDataReader? dr = dh.ExecuteReader(sql);

            if (dr != null)
            {
                try
                {
                    if (dr.Read())
                    {
                        return MapFromReader(dr);
                    }
                }
                finally
                {
                    dh.DongKetNoi();
                }
                return null;
            }

            return GetMockData().FirstOrDefault(s => s.MaSV.Equals(maSV.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        // Thêm sinh viên vào CSDL qua ExecuteNonQuery (Slide 15)
        public bool Add(SinhVien sv)
        {
            if (sv == null || string.IsNullOrWhiteSpace(sv.MaSV)) return false;
            if (Exists(sv.MaSV)) return false;

            string safeMa = sv.MaSV.Trim().Replace("'", "''");
            string safeHoTen = sv.HoTen.Trim().Replace("'", "''");
            string safeEmail = sv.Email.Trim().Replace("'", "''");
            string safePhone = sv.DienThoai.Trim().Replace("'", "''");
            string safeMaLop = sv.MaLop.Trim().Replace("'", "''");
            string safeTrangThai = sv.TrangThai.Trim().Replace("'", "''");
            string ngaySinhStr = sv.NgaySinh.ToString("yyyy-MM-dd");
            int gioiTinhBit = sv.GioiTinh ? 1 : 0;
            string diemStr = sv.Diem.ToString(CultureInfo.InvariantCulture);

            string sql = $"INSERT INTO SinhVien (MaSV, HoTen, NgaySinh, GioiTinh, Email, DienThoai, MaLop, Diem, TrangThai) " +
                         $"VALUES ('{safeMa}', N'{safeHoTen}', '{ngaySinhStr}', {gioiTinhBit}, '{safeEmail}', '{safePhone}', '{safeMaLop}', {diemStr}, N'{safeTrangThai}')";

            try
            {
                dh.ExecuteNonQuery(sql);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Cập nhật thông tin sinh viên qua ExecuteNonQuery (Slide 15)
        public bool Update(SinhVien sv)
        {
            if (sv == null || string.IsNullOrWhiteSpace(sv.MaSV)) return false;

            string safeMa = sv.MaSV.Trim().Replace("'", "''");
            string safeHoTen = sv.HoTen.Trim().Replace("'", "''");
            string safeEmail = sv.Email.Trim().Replace("'", "''");
            string safePhone = sv.DienThoai.Trim().Replace("'", "''");
            string safeMaLop = sv.MaLop.Trim().Replace("'", "''");
            string safeTrangThai = sv.TrangThai.Trim().Replace("'", "''");
            string ngaySinhStr = sv.NgaySinh.ToString("yyyy-MM-dd");
            int gioiTinhBit = sv.GioiTinh ? 1 : 0;
            string diemStr = sv.Diem.ToString(CultureInfo.InvariantCulture);

            string sql = $"UPDATE SinhVien SET " +
                         $"HoTen = N'{safeHoTen}', " +
                         $"NgaySinh = '{ngaySinhStr}', " +
                         $"GioiTinh = {gioiTinhBit}, " +
                         $"Email = '{safeEmail}', " +
                         $"DienThoai = '{safePhone}', " +
                         $"MaLop = '{safeMaLop}', " +
                         $"Diem = {diemStr}, " +
                         $"TrangThai = N'{safeTrangThai}' " +
                         $"WHERE MaSV = '{safeMa}'";

            try
            {
                dh.ExecuteNonQuery(sql);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Xóa sinh viên khỏi CSDL qua ExecuteNonQuery (Slide 15)
        public bool Delete(string maSV)
        {
            if (string.IsNullOrWhiteSpace(maSV)) return false;

            string safeMa = maSV.Trim().Replace("'", "''");
            string sql = $"DELETE FROM SinhVien WHERE MaSV = '{safeMa}'";

            try
            {
                dh.ExecuteNonQuery(sql);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Kiểm tra mã sinh viên đã tồn tại chưa qua ExecuteScalar (Slide 8)
        public bool Exists(string maSV)
        {
            if (string.IsNullOrWhiteSpace(maSV)) return false;

            string safeMa = maSV.Trim().Replace("'", "''");
            string sql = $"SELECT COUNT(*) FROM SinhVien WHERE MaSV = '{safeMa}'";
            object? res = dh.ExecuteScalar(sql);

            if (res != null && int.TryParse(res.ToString(), out int count))
            {
                return count > 0;
            }

            return GetMockData().Any(s => s.MaSV.Equals(maSV.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        // Lọc và tìm kiếm sinh viên bằng truy vấn SQL linh hoạt (Slide 16)
        public List<SinhVien> Search(string? tuKhoa, string? maLop, double diemTu)
        {
            var conditions = new List<string>();

            if (!string.IsNullOrWhiteSpace(tuKhoa))
            {
                string kw = tuKhoa.Trim().Replace("'", "''");
                conditions.Add($"(MaSV LIKE '%{kw}%' OR HoTen LIKE N'%{kw}%' OR Email LIKE '%{kw}%' OR DienThoai LIKE '%{kw}%')");
            }

            if (!string.IsNullOrWhiteSpace(maLop))
            {
                string safeLop = maLop.Trim().Replace("'", "''");
                conditions.Add($"MaLop = '{safeLop}'");
            }

            if (diemTu > 0)
            {
                string diemStr = diemTu.ToString(CultureInfo.InvariantCulture);
                conditions.Add($"Diem >= {diemStr}");
            }

            string sql = "SELECT MaSV, HoTen, NgaySinh, GioiTinh, Email, DienThoai, MaLop, Diem, TrangThai FROM SinhVien";
            if (conditions.Count > 0)
            {
                sql += " WHERE " + string.Join(" AND ", conditions);
            }

            SqlDataReader? dr = dh.ExecuteReader(sql);
            if (dr != null)
            {
                List<SinhVien> list = new List<SinhVien>();
                try
                {
                    while (dr.Read())
                    {
                        list.Add(MapFromReader(dr));
                    }
                }
                finally
                {
                    dh.DongKetNoi();
                }
                return list;
            }

            // Fallback sang lọc bộ nhớ nếu CSDL tạm thời offline
            var query = GetMockData().AsEnumerable();
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
            return query.ToList();
        }

        // Đọc dữ liệu từ SqlDataReader theo cách trong Slide 11
        private static SinhVien MapFromReader(SqlDataReader dr)
        {
            var sv = new SinhVien
            {
                MaSV = dr["MaSV"].ToString() ?? "",
                HoTen = dr["HoTen"].ToString() ?? "",
                NgaySinh = dr["NgaySinh"] != DBNull.Value ? Convert.ToDateTime(dr["NgaySinh"]) : DateTime.Now,
                GioiTinh = dr["GioiTinh"] != DBNull.Value && Convert.ToBoolean(dr["GioiTinh"]),
                Email = dr["Email"] != DBNull.Value ? dr["Email"].ToString() ?? "" : "",
                DienThoai = dr["DienThoai"] != DBNull.Value ? dr["DienThoai"].ToString() ?? "" : "",
                MaLop = dr["MaLop"] != DBNull.Value ? dr["MaLop"].ToString() ?? "" : "",
                Diem = dr["Diem"] != DBNull.Value ? Convert.ToDouble(dr["Diem"]) : 0.0,
                TrangThai = dr["TrangThai"] != DBNull.Value ? dr["TrangThai"].ToString() ?? "Đang học" : "Đang học"
            };
            return sv;
        }

        // Dữ liệu mẫu ban đầu khớp với file của bạn
        private static List<SinhVien> GetMockData()
        {
            return new List<SinhVien>
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
        }
    }
}
