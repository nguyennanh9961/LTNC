using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using QLSV_App.Data.Entity;

namespace QLSV_App.Data
{
    /// <summary>
    /// Lớp ngữ cảnh cơ sở dữ liệu Quản lý thư viện (QLTVDBContext)
    /// Sử dụng Entity Framework Core Code-First để map sang CSDL LibraryDB.
    /// </summary>
    public class QLTVDBContext : DbContext
    {
        public DbSet<TheLoai> TheLoais { get; set; } = null!;
        public DbSet<Sach> Sachs { get; set; } = null!;

        public QLTVDBContext()
        {
        }

        public QLTVDBContext(DbContextOptions<QLTVDBContext> options) : base(options)
        {
        }

        // Cấu hình chuỗi kết nối đến cơ sở dữ liệu LibraryDB
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["libraryDataBase"]?.ConnectionString
                    ?? ConfigurationManager.ConnectionStrings["studentDataBase"]?.ConnectionString
                    ?? "Data Source=.;Initial Catalog=LibraryDB;Integrated Security=True;TrustServerCertificate=True";

                // Đổi Initial Catalog sang LibraryDB nếu dùng chuỗi kết nối chung
                if (connectionString.Contains("Initial Catalog=QLSV", StringComparison.OrdinalIgnoreCase))
                {
                    connectionString = connectionString.Replace("Initial Catalog=QLSV", "Initial Catalog=LibraryDB", StringComparison.OrdinalIgnoreCase);
                }

                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        // Cấu hình Fluent API và Seeding dữ liệu thư viện
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Thiết lập quan hệ 1 - N: TheLoai (1) - Sach (N)
            modelBuilder.Entity<Sach>()
                .HasOne(s => s.TheLoai)
                .WithMany(t => t.Sachs)
                .HasForeignKey(s => s.MaTheLoai)
                .OnDelete(DeleteBehavior.Restrict);

            // Seed Data mẫu cho Quản lý thư viện
            modelBuilder.Entity<TheLoai>().HasData(
                new TheLoai { MaTheLoai = "TL01", TenTheLoai = "Công nghệ thông tin" },
                new TheLoai { MaTheLoai = "TL02", TenTheLoai = "Kinh tế - Quản trị" },
                new TheLoai { MaTheLoai = "TL03", TenTheLoai = "Văn học - Kỹ năng sống" }
            );

            modelBuilder.Entity<Sach>().HasData(
                new Sach
                {
                    MaSach = "S001",
                    TenSach = "Lập trình C# nâng cao",
                    TacGia = "Chu Thị Minh Huệ",
                    NamXuatBan = 2023,
                    SoLuong = 50,
                    MaTheLoai = "TL01"
                },
                new Sach
                {
                    MaSach = "S002",
                    TenSach = "Cơ sở dữ liệu và ADO.NET",
                    TacGia = "Nguyễn Văn An",
                    NamXuatBan = 2022,
                    SoLuong = 30,
                    MaTheLoai = "TL01"
                },
                new Sach
                {
                    MaSach = "S003",
                    TenSach = "Kinh tế vi mô căn bản",
                    TacGia = "Trần Minh Anh",
                    NamXuatBan = 2021,
                    SoLuong = 20,
                    MaTheLoai = "TL02"
                },
                new Sach
                {
                    MaSach = "S004",
                    TenSach = "Đắc nhân tâm",
                    TacGia = "Dale Carnegie",
                    NamXuatBan = 2020,
                    SoLuong = 100,
                    MaTheLoai = "TL03"
                }
            );
        }

        /// <summary>
        /// Khởi tạo database tự động bằng Code First nếu chưa tồn tại
        /// </summary>
        public static bool KhoiTaoDatabase()
        {
            try
            {
                using var db = new QLTVDBContext();
                return db.Database.EnsureCreated();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"[QLTVDBContext Error] {ex.Message}");
                return false;
            }
        }
    }
}
