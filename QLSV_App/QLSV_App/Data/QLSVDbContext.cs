using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using QLSV_App.Data.Entity;

namespace QLSV_App.Data
{
    /// <summary>
    /// Lớp ngữ cảnh cơ sở dữ liệu (DbContext) cho Entity Framework Core Code-First.
    /// Quản lý các tập thực thể và ánh xạ tự động sang cơ sở dữ liệu SQL Server.
    /// </summary>
    public class QLSVDbContext : DbContext
    {
        // Khai báo các DbSet đại diện cho các bảng trong CSDL
        public DbSet<LopHoc> LopHocs { get; set; } = null!;
        public DbSet<SinhVien> SinhViens { get; set; } = null!;
        public DbSet<Users> Users { get; set; } = null!;

        public QLSVDbContext()
        {
        }

        public QLSVDbContext(DbContextOptions<QLSVDbContext> options) : base(options)
        {
        }

        // Cấu hình kết nối SQL Server thông qua chuỗi kết nối trong App.config
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["studentDataBase"]?.ConnectionString
                    ?? "Data Source=.;Initial Catalog=QLSV;Integrated Security=True;TrustServerCertificate=True";

                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        // Cấu hình ánh xạ Fluent API và Seeding dữ liệu mẫu
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Cấu hình rõ ràng mối quan hệ 1 - N: LopHoc (1) - SinhVien (N)
            modelBuilder.Entity<SinhVien>()
                .HasOne(s => s.LopHoc)
                .WithMany(l => l.DanhSachSinhVien)
                .HasForeignKey(s => s.MaLop)
                .OnDelete(DeleteBehavior.Restrict);

            // Cấu hình khóa chính cho Users
            modelBuilder.Entity<Users>()
                .HasKey(u => u.MaNV);

            // ==========================================
            // Data Seeding: Khởi tạo dữ liệu mẫu Code First
            // ==========================================

            // 1. Dữ liệu lớp học
            modelBuilder.Entity<LopHoc>().HasData(
                new LopHoc { MaLop = "L01", TenLop = "Kỹ thuật phần mềm 01" },
                new LopHoc { MaLop = "L02", TenLop = "Trí tuệ nhân tạo 01" },
                new LopHoc { MaLop = "L03", TenLop = "Khoa học dữ liệu 01" }
            );

            // 2. Dữ liệu sinh viên
            modelBuilder.Entity<SinhVien>().HasData(
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
            );

            // 3. Dữ liệu tài khoản quản trị
            modelBuilder.Entity<Users>().HasData(
                new Users { MaNV = "admin", Password = "123", Role = "Admin", Active = true }
            );
        }

        /// <summary>
        /// Phương thức tiện ích tự động khởi tạo CSDL và bảng theo Code First nếu chưa tồn tại
        /// </summary>
        public static bool KhoiTaoDatabase()
        {
            try
            {
                using var db = new QLSVDbContext();
                return db.Database.EnsureCreated();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"[EF Code-First Error] {ex.Message}");
                return false;
            }
        }
    }
}
