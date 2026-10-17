using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using QLSV_App.Data.Entity;

namespace QLSV_App.Data.DAL
{
    /// <summary>
    /// Lớp truy xuất dữ liệu LopHoc (LopDAL) sử dụng ADO.NET qua DataHelper 
    /// </summary>
    public class LopDAL
    {
        public static DataHelper dh = null!;

        // Khởi tạo mặc định đọc cấu hình từ App.config
        public LopDAL()
        {
            if (dh == null)
            {
                string strcon = DataHelper.GetConnectionString("studentDataBase");
                dh = new DataHelper(strcon);
            }
        }

        public LopDAL(string strcon)
        {
            dh = new DataHelper(strcon);
        }

        // Lấy về toàn bộ danh sách lớp học 
        public List<LopHoc> GetAll()
        {
            List<LopHoc> list = new List<LopHoc>();
            string sql = "SELECT MaLop, TenLop FROM LopHoc";
            SqlDataReader? dr = dh.ExecuteReader(sql);

            if (dr != null)
            {
                try
                {
                    while (dr.Read())
                    {
                        list.Add(new LopHoc
                        {
                            MaLop = dr["MaLop"].ToString() ?? "",
                            TenLop = dr["TenLop"].ToString() ?? ""
                        });
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

        // Lấy về lớp học theo mã lớp
        public LopHoc? GetById(string maLop)
        {
            if (string.IsNullOrWhiteSpace(maLop)) return null;

            string safeMa = maLop.Trim().Replace("'", "''");
            string sql = $"SELECT MaLop, TenLop FROM LopHoc WHERE MaLop = '{safeMa}'";
            SqlDataReader? dr = dh.ExecuteReader(sql);

            if (dr != null)
            {
                try
                {
                    if (dr.Read())
                    {
                        return new LopHoc
                        {
                            MaLop = dr["MaLop"].ToString() ?? "",
                            TenLop = dr["TenLop"].ToString() ?? ""
                        };
                    }
                }
                finally
                {
                    dh.DongKetNoi();
                }
                return null;
            }

            return GetMockData().FirstOrDefault(l => l.MaLop.Equals(maLop.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        // Thêm mới một lớp học (ExecuteNonQuery)
        public bool Add(LopHoc lop)
        {
            if (lop == null || string.IsNullOrWhiteSpace(lop.MaLop)) return false;
            if (Exists(lop.MaLop)) return false;

            string safeMa = lop.MaLop.Trim().Replace("'", "''");
            string safeTen = lop.TenLop.Trim().Replace("'", "''");
            string sql = $"INSERT INTO LopHoc (MaLop, TenLop) VALUES ('{safeMa}', N'{safeTen}')";

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

        // Sửa thông tin một lớp học (ExecuteNonQuery)
        public bool Update(LopHoc lop)
        {
            if (lop == null || string.IsNullOrWhiteSpace(lop.MaLop)) return false;

            string safeMa = lop.MaLop.Trim().Replace("'", "''");
            string safeTen = lop.TenLop.Trim().Replace("'", "''");
            string sql = $"UPDATE LopHoc SET TenLop = N'{safeTen}' WHERE MaLop = '{safeMa}'";

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

        // Xóa một lớp học theo mã (ExecuteNonQuery)
        public bool Delete(string maLop)
        {
            if (string.IsNullOrWhiteSpace(maLop)) return false;

            string safeMa = maLop.Trim().Replace("'", "''");
            string sql = $"DELETE FROM LopHoc WHERE MaLop = '{safeMa}'";

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

        // Kiểm tra tồn tại (ExecuteScalar)
        public bool Exists(string maLop)
        {
            if (string.IsNullOrWhiteSpace(maLop)) return false;

            string safeMa = maLop.Trim().Replace("'", "''");
            string sql = $"SELECT COUNT(*) FROM LopHoc WHERE MaLop = '{safeMa}'";
            object? res = dh.ExecuteScalar(sql);

            if (res != null && int.TryParse(res.ToString(), out int count))
            {
                return count > 0;
            }

            return GetMockData().Any(l => l.MaLop.Equals(maLop.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        // Dữ liệu mẫu dự phòng
        private static List<LopHoc> GetMockData()
        {
            return new List<LopHoc>
            {
                new LopHoc { MaLop = "L01", TenLop = "Kỹ thuật phần mềm 01" },
                new LopHoc { MaLop = "L02", TenLop = "Trí tuệ nhân tạo 01" },
                new LopHoc { MaLop = "L03", TenLop = "Khoa học dữ liệu 01" }
            };
        }
    }
}
