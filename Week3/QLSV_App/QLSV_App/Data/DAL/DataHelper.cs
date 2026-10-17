using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace QLSV_App.Data.DAL
{
    /// <summary>
    /// Lớp thao tác dữ liệu (DataHelper) được xây dựng theo đúng yêu cầu Slide 12 - 16
    /// của cô Chu Thị Minh Huệ (Môn Lập trình nâng cao).
    /// </summary>
    public class DataHelper
    {
        private SqlConnection con;

        // Y1 (Slide 13): Phương thức khởi tạo nhận thông tin chuỗi kết nối
        public DataHelper(string strcon)
        {
            con = new SqlConnection(strcon);
        }

        // Y2 (Slide 14): Phương thức mở kết nối đến CSDL
        public string MoKetNoi()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // Phương thức đóng kết nối
        public void DongKetNoi()
        {
            try
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch
            {
            }
        }

        // Y3 (Slide 15): Phương thức thực thi câu lệnh truy vấn hành động (Insert, Update, Delete)
        public void ExecuteNonQuery(string sqlString)
        {
            MoKetNoi();
            try
            {
                using (SqlCommand cm = new SqlCommand(sqlString, con))
                {
                    cm.ExecuteNonQuery();
                }
            }
            finally
            {
                DongKetNoi();
            }
        }

        // Y4 (Slide 16): Phương thức thực thi câu lệnh truy vấn Select trả về SqlDataReader
        public SqlDataReader? ExecuteReader(string sqlString)
        {
            string err = MoKetNoi();
            if (!string.IsNullOrEmpty(err))
            {
                return null;
            }

            try
            {
                SqlCommand cm = new SqlCommand(sqlString, con);
                return cm.ExecuteReader();
            }
            catch (Exception)
            {
                DongKetNoi();
                return null;
            }
        }

        // Phương thức thực thi trả về giá trị đơn (Slide 8: ExecuteScalar)
        public object? ExecuteScalar(string sqlString)
        {
            string err = MoKetNoi();
            if (!string.IsNullOrEmpty(err))
            {
                return null;
            }

            try
            {
                using (SqlCommand cm = new SqlCommand(sqlString, con))
                {
                    return cm.ExecuteScalar();
                }
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                DongKetNoi();
            }
        }

        // Tiện ích đọc chuỗi kết nối từ App.config theo Slide 18
        public static string GetConnectionString(string connectionName = "studentDataBase")
        {
            try
            {
                var connSetting = ConfigurationManager.ConnectionStrings[connectionName];
                if (connSetting != null && !string.IsNullOrWhiteSpace(connSetting.ConnectionString))
                {
                    return connSetting.ConnectionString;
                }
            }
            catch
            {
            }

            // Fallback mặc định nếu chưa đọc được file cấu hình
            return "Data Source=.;Initial Catalog=QLSV;Integrated Security=True;TrustServerCertificate=True";
        }
    }
}
