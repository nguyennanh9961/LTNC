namespace QLSV_App.Data.Entity
{
    /// <summary>
    /// Thực thể Users đại diện cho tài khoản người dùng 
    /// </summary>
    public class Users
    {
        public string MaNV { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public bool Active { get; set; } = true;
    }
}
