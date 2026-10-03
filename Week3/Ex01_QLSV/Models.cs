using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QLSV_App
{
    // 1. Lớp LopHoc (Phía 1 trong quan hệ 1 - n)
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

    // 2. Lớp SinhVien (Phía n trong quan hệ 1 - n)
    public class SinhVien
    {
        [Required(ErrorMessage = "Mã sinh viên không được để trống.")]
        [RegularExpression(@"^SV\d{6}$", ErrorMessage = "Mã sinh viên phải có định dạng SVxxxxxx (ví dụ SV000123).")]
        public string MaSV { get; set; } = string.Empty;

        [Required(ErrorMessage = "Họ và tên không được để trống.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Họ và tên từ 2 đến 50 ký tự.")]
        public string HoTen { get; set; } = string.Empty;

        [Required(ErrorMessage = "Ngày sinh không được để trống.")]
        [DataType(DataType.Date)]
        public DateTime NgaySinh { get; set; }

        public bool GioiTinh { get; set; } // true: Nam, false: Nữ

        [Required(ErrorMessage = "Email không được để trống.")]
        [EmailAddress(ErrorMessage = "Địa chỉ Email không đúng định dạng (ví dụ: an.nv@vju.ac.vn).")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Số điện thoại không được để trống.")]
        [RegularExpression(@"^(0[3|5|7|8|9])[0-9]{8}$", ErrorMessage = "Số điện thoại không hợp lệ (gồm 10 số bắt đầu bằng 03, 05, 07, 08, 09).")]
        public string DienThoai { get; set; } = string.Empty;

        [Required(ErrorMessage = "Lớp học không được để trống.")]
        public string MaLop { get; set; } = string.Empty;

        [Range(0.0, 10.0, ErrorMessage = "Điểm phải nằm trong thang điểm từ 0.0 đến 10.0.")]
        public double Diem { get; set; }

        public string TrangThai { get; set; } = "Đang học";

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