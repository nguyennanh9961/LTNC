using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLSV_App.Data.Entity
{
    // Lớp thực thể SinhVien (Phía N trong quan hệ 1 - N) - Ánh xạ sang bảng 'SinhVien'
    [Table("SinhVien")]
    public class SinhVien
    {
        [Key]
        [Required(ErrorMessage = "Mã sinh viên không được để trống.")]
        [RegularExpression(@"^SV\d{6}$", ErrorMessage = "Mã sinh viên phải có định dạng SVxxxxxx (ví dụ SV000123).")]
        [StringLength(20)]
        [Column(TypeName = "nvarchar(20)")]
        public string MaSV { get; set; } = string.Empty;

        [Required(ErrorMessage = "Họ và tên không được để trống.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Họ và tên từ 2 đến 50 ký tự.")]
        [Column(TypeName = "nvarchar(50)")]
        public string HoTen { get; set; } = string.Empty;

        [Required(ErrorMessage = "Ngày sinh không được để trống.")]
        [DataType(DataType.Date)]
        [Column(TypeName = "date")]
        public DateTime NgaySinh { get; set; } = DateTime.Now;

        public bool GioiTinh { get; set; } = true; // true: Nam, false: Nữ

        [Required(ErrorMessage = "Email không được để trống.")]
        [EmailAddress(ErrorMessage = "Địa chỉ Email không đúng định dạng (ví dụ: an.nv@vju.ac.vn).")]
        [StringLength(100)]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Số điện thoại không được để trống.")]
        [RegularExpression(@"^(0[3|5|7|8|9])[0-9]{8}$", ErrorMessage = "Số điện thoại không hợp lệ (gồm 10 số bắt đầu bằng 03, 05, 07, 08, 09).")]
        [StringLength(20)]
        public string DienThoai { get; set; } = string.Empty;

        // Khóa ngoại liên kết tới bảng LopHoc
        [Required(ErrorMessage = "Lớp học không được để trống.")]
        [StringLength(20)]
        [Column(TypeName = "nvarchar(20)")]
        public string MaLop { get; set; } = string.Empty;

        // Navigation property trỏ về thực thể LopHoc
        [ForeignKey(nameof(MaLop))]
        public virtual LopHoc? LopHoc { get; set; }

        [Range(0.0, 10.0, ErrorMessage = "Điểm phải nằm trong thang điểm từ 0.0 đến 10.0.")]
        public double Diem { get; set; } = 0.0;

        [StringLength(50)]
        public string TrangThai { get; set; } = "Đang học";

        // Thuộc tính phụ trợ hiển thị tên lớp trên giao diện (Không ánh xạ vào cột CSDL)
        [NotMapped]
        public string TenLop
        {
            get => LopHoc != null ? LopHoc.TenLop : _tenLop;
            set => _tenLop = value;
        }
        private string _tenLop = string.Empty;

        // Phương thức kiểm tra tính hợp lệ của thuộc tính theo Data Annotations
        public static (bool IsValid, List<string> Errors) ValidateModel(SinhVien sv)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(sv, serviceProvider: null, items: null);
            bool isValid = Validator.TryValidateObject(sv, context, results, validateAllProperties: true);

            var errorMessages = new List<string>();
            foreach (var validationResult in results)
            {
                if (!string.IsNullOrEmpty(validationResult.ErrorMessage))
                {
                    errorMessages.Add(validationResult.ErrorMessage);
                }
            }
            return (isValid, errorMessages);
        }
    }
}
