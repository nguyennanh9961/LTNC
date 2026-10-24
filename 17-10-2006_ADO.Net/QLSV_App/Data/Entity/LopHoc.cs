using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLSV_App.Data.Entity
{
    // Lớp thực thể LopHoc (Phía 1 trong quan hệ 1 - N) - Ánh xạ sang bảng 'LopHoc'
    [Table("LopHoc")]
    public class LopHoc
    {
        [Key]
        [Required(ErrorMessage = "Mã lớp không được để trống.")]
        [StringLength(20, ErrorMessage = "Mã lớp tối đa 20 ký tự.")]
        [Column(TypeName = "nvarchar(20)")]
        public string MaLop { get; set; } = string.Empty;

        [Required(ErrorMessage = "Tên lớp không được để trống.")]
        [StringLength(100, ErrorMessage = "Tên lớp tối đa 100 ký tự.")]
        [Column(TypeName = "nvarchar(100)")]
        public string TenLop { get; set; } = string.Empty;

        // Quan hệ 1 - N: Một lớp học có nhiều sinh viên (Navigation Property)
        public virtual ICollection<SinhVien> DanhSachSinhVien { get; set; } = new List<SinhVien>();

        public override string ToString()
        {
            return TenLop;
        }
    }
}
