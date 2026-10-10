using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QLSV_App.Data.Entity
{
    // Lớp LopHoc (Phía 1 trong quan hệ 1 - n)
    public class LopHoc
    {
        [Required(ErrorMessage = "Mã lớp không được để trống.")]
        [StringLength(20, ErrorMessage = "Mã lớp tối đa 20 ký tự.")]
        public string MaLop { get; set; } = string.Empty;

        [Required(ErrorMessage = "Tên lớp không được để trống.")]
        [StringLength(100, ErrorMessage = "Tên lớp tối đa 100 ký tự.")]
        public string TenLop { get; set; } = string.Empty;

        // Quan hệ 1 - n: Một lớp có danh sách nhiều sinh viên
        public List<SinhVien> DanhSachSinhVien { get; set; } = new List<SinhVien>();

        public override string ToString()
        {
            return TenLop;
        }
    }
}
