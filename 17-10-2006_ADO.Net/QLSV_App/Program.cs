using System;
using System.Windows.Forms;
using QLSV_App.Data;
using QLSV_App.Views;

namespace QLSV_App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Khởi tạo cơ sở dữ liệu tự động bằng Entity Framework Code First
            QLSVDbContext.KhoiTaoDatabase();

            Application.Run(new frmQLSV());
        }
    }
}
