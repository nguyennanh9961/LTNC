using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLSV_App.Data.Entity
{
    // Thực thể Sach (Sách thư viện - Phía N trong quan hệ 1 - N)
    [Table("Sach")]
    public class Sach
    {
        [Key]
        [Required(ErrorMessage = "Mã sách không được để trống.")]
        [StringLength(20)]
        [Column(TypeName = "nvarchar(20)")]
        public string MaSach { get; set; } = string.Empty;

        [Required(ErrorMessage = "Tên sách không được để trống.")]
        [StringLength(200)]
        [Column(TypeName = "nvarchar(200)")]
        public string TenSach { get; set; } = string.Empty;

        [StringLength(100)]
        [Column(TypeName = "nvarchar(100)")]
        public string TacGia { get; set; } = string.Empty;

        public int NamXuatBan { get; set; } = 2024;

        public int SoLuong { get; set; } = 1;

        // Khóa ngoại trỏ về bảng TheLoai
        [Required(ErrorMessage = "Phải chọn thể loại cho sách.")]
        [StringLength(20)]
        [Column(TypeName = "nvarchar(20)")]
        public string MaTheLoai { get; set; } = string.Empty;

        // Navigation property trỏ về thực thể TheLoai
        [ForeignKey(nameof(MaTheLoai))]
        public virtual TheLoai? TheLoai { get; set; }
    }
}
