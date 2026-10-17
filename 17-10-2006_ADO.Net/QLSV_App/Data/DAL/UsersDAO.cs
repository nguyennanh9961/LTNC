using System;
using System.Data.SqlClient;
using QLSV_App.Data.Entity;

namespace QLSV_App.Data.DAL
{
    /// <summary>
    /// Lớp truy xuất dữ liệu người dùng (UsersDAO) 
    /// </summary>
    public class UsersDAO
    {
        public static DataHelper dh = null!;

        public UsersDAO(string stcon)
        {
            dh = new DataHelper(stcon);
        }

        // Lấy thông tin user đăng nhập 
        public Users? GetUsers(string ma, string pas)
        {
            SqlDataReader? dr = dh.ExecuteReader("select * from Users where (manv='" + ma + "') and (password='" + pas + "')");
            if (dr != null)
            {
                if (dr.Read())
                {
                    Users us = new Users();
                    us.MaNV = dr["MaNV"].ToString() ?? "";
                    us.Password = dr["Password"].ToString() ?? "";
                    us.Role = dr["Role"].ToString() ?? "";
                    us.Active = bool.Parse(dr["Active"].ToString() ?? "true");
                    dh.DongKetNoi();
                    return us;
                }
                dh.DongKetNoi();
                return null;
            }
            else
            {
                return null;
            }
        }
    }
}
