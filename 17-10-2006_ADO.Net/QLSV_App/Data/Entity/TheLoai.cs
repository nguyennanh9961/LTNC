using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLSV_App.Data.Entity
{
    // Thực thể TheLoai (Thể loại sách - Phía 1 trong quan hệ 1 - N)
    [Table("TheLoai")]
    public class TheLoai
    {
        [Key]
        [Required(ErrorMessage = "Mã thể loại không được để trống.")]
        [StringLength(20)]
        [Column(TypeName = "nvarchar(20)")]
        public string MaTheLoai { get; set; } = string.Empty;

        [Required(ErrorMessage = "Tên thể loại không được để trống.")]
        [StringLength(100)]
        [Column(TypeName = "nvarchar(100)")]
        public string TenTheLoai { get; set; } = string.Empty;

        // Navigation property: Một thể loại có nhiều sách
        public virtual ICollection<Sach> Sachs { get; set; } = new List<Sach>();

        public override string ToString()
        {
            return TenTheLoai;
        }
    }
}
