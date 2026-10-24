using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QLSV_App.Data.Migrations.Library
{
    /// <inheritdoc />
    public partial class InitialLibraryDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TheLoai",
                columns: table => new
                {
                    MaTheLoai = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TenTheLoai = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheLoai", x => x.MaTheLoai);
                });

            migrationBuilder.CreateTable(
                name: "Sach",
                columns: table => new
                {
                    MaSach = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TenSach = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TacGia = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NamXuatBan = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    MaTheLoai = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sach", x => x.MaSach);
                    table.ForeignKey(
                        name: "FK_Sach_TheLoai_MaTheLoai",
                        column: x => x.MaTheLoai,
                        principalTable: "TheLoai",
                        principalColumn: "MaTheLoai",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "TheLoai",
                columns: new[] { "MaTheLoai", "TenTheLoai" },
                values: new object[,]
                {
                    { "TL01", "Công nghệ thông tin" },
                    { "TL02", "Kinh tế - Quản trị" },
                    { "TL03", "Văn học - Kỹ năng sống" }
                });

            migrationBuilder.InsertData(
                table: "Sach",
                columns: new[] { "MaSach", "MaTheLoai", "NamXuatBan", "SoLuong", "TacGia", "TenSach" },
                values: new object[,]
                {
                    { "S001", "TL01", 2023, 50, "Chu Thị Minh Huệ", "Lập trình C# nâng cao" },
                    { "S002", "TL01", 2022, 30, "Nguyễn Văn An", "Cơ sở dữ liệu và ADO.NET" },
                    { "S003", "TL02", 2021, 20, "Trần Minh Anh", "Kinh tế vi mô căn bản" },
                    { "S004", "TL03", 2020, 100, "Dale Carnegie", "Đắc nhân tâm" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sach_MaTheLoai",
                table: "Sach",
                column: "MaTheLoai");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sach");

            migrationBuilder.DropTable(
                name: "TheLoai");
        }
    }
}
