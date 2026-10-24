using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QLSV_App.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LopHoc",
                columns: table => new
                {
                    MaLop = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TenLop = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LopHoc", x => x.MaLop);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    MaNV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.MaNV);
                });

            migrationBuilder.CreateTable(
                name: "SinhVien",
                columns: table => new
                {
                    MaSV = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "date", nullable: false),
                    GioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DienThoai = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MaLop = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Diem = table.Column<double>(type: "float", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinhVien", x => x.MaSV);
                    table.ForeignKey(
                        name: "FK_SinhVien_LopHoc_MaLop",
                        column: x => x.MaLop,
                        principalTable: "LopHoc",
                        principalColumn: "MaLop",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "LopHoc",
                columns: new[] { "MaLop", "TenLop" },
                values: new object[,]
                {
                    { "L01", "Kỹ thuật phần mềm 01" },
                    { "L02", "Trí tuệ nhân tạo 01" },
                    { "L03", "Khoa học dữ liệu 01" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "MaNV", "Active", "Password", "Role" },
                values: new object[] { "admin", true, "123", "Admin" });

            migrationBuilder.InsertData(
                table: "SinhVien",
                columns: new[] { "MaSV", "Diem", "DienThoai", "Email", "GioiTinh", "HoTen", "MaLop", "NgaySinh", "TrangThai" },
                values: new object[,]
                {
                    { "SV000123", 8.5, "0912345678", "an.nv@vju.ac.vn", true, "Nguyễn Văn An", "L01", new DateTime(2006, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đang học" },
                    { "SV000124", 9.0, "0987654321", "anh.tm@vju.ac.vn", false, "Trần Minh Anh", "L02", new DateTime(2006, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đang học" },
                    { "SV000125", 7.4000000000000004, "0355556677", "binh.lh@vju.ac.vn", true, "Lê Hoàng Bình", "L01", new DateTime(2006, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đang học" },
                    { "SV000126", 8.0999999999999996, "0777888999", "hong.dt@vju.ac.vn", false, "Đỗ Thị Hồng", "L03", new DateTime(2006, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đang học" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SinhVien_MaLop",
                table: "SinhVien",
                column: "MaLop");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SinhVien");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "LopHoc");
        }
    }
}
