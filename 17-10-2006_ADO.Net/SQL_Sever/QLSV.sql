-- ========================================================
-- TẠO CƠ SỞ DỮ LIỆU QLSV CHO QLSV_App
-- Môn: Lập trình nâng cao (LTNC)
-- ========================================================

IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'QLSV')
BEGIN
    CREATE DATABASE QLSV;
END
GO

USE QLSV;
GO

-- 1. BẢNG LỚP HỌC (LopHoc)
IF OBJECT_ID(N'dbo.SinhVien', N'U') IS NOT NULL
    DROP TABLE dbo.SinhVien;
GO

IF OBJECT_ID(N'dbo.LopHoc', N'U') IS NOT NULL
    DROP TABLE dbo.LopHoc;
GO

IF OBJECT_ID(N'dbo.Users', N'U') IS NOT NULL
    DROP TABLE dbo.Users;
GO

CREATE TABLE LopHoc (
    MaLop NVARCHAR(20) PRIMARY KEY,
    TenLop NVARCHAR(100) NOT NULL
);
GO

-- 2. BẢNG SINH VIÊN (SinhVien) - 
CREATE TABLE SinhVien (
    MaSV NVARCHAR(20) PRIMARY KEY,
    HoTen NVARCHAR(50) NOT NULL,
    NgaySinh DATE NOT NULL,
    GioiTinh BIT NOT NULL, -- 1: Nam, 0: Nữ
    Email NVARCHAR(100) NOT NULL,
    DienThoai NVARCHAR(20) NOT NULL,
    MaLop NVARCHAR(20) NOT NULL FOREIGN KEY REFERENCES LopHoc(MaLop),
    Diem FLOAT DEFAULT 0.0,
    TrangThai NVARCHAR(50) DEFAULT N'Đang học'
);
GO

-- 3. BẢNG USERS (Theo Slide 19)
CREATE TABLE Users (
    MaNV NVARCHAR(50) PRIMARY KEY,
    Password NVARCHAR(100) NOT NULL,
    Role NVARCHAR(50),
    Active BIT DEFAULT 1
);
GO

-- ========================================================
-- CHÈN DỮ LIỆU KHỞI TẠO 
-- ========================================================

-- Dữ liệu lớp học
INSERT INTO LopHoc (MaLop, TenLop) VALUES
(N'L01', N'Kỹ thuật phần mềm 01'),
(N'L02', N'Trí tuệ nhân tạo 01'),
(N'L03', N'Khoa học dữ liệu 01');
GO

-- Dữ liệu sinh viên
INSERT INTO SinhVien (MaSV, HoTen, NgaySinh, GioiTinh, Email, DienThoai, MaLop, Diem, TrangThai) VALUES
(N'SV000123', N'Nguyễn Văn An', '2006-08-15', 1, N'an.nv@vju.ac.vn', N'0912345678', N'L01', 8.5, N'Đang học'),
(N'SV000124', N'Trần Minh Anh', '2006-01-22', 0, N'anh.tm@vju.ac.vn', N'0987654321', N'L02', 9.0, N'Đang học'),
(N'SV000125', N'Lê Hoàng Bình', '2006-05-09', 1, N'binh.lh@vju.ac.vn', N'0355556677', N'L01', 7.4, N'Đang học'),
(N'SV000126', N'Đỗ Thị Hồng', '2006-11-30', 0, N'hong.dt@vju.ac.vn', N'0777888999', N'L03', 8.1, N'Đang học');
GO

-- Dữ liệu tài khoản đăng nhập (Slide 19)
INSERT INTO Users (MaNV, Password, Role, Active) VALUES
(N'admin', N'123', N'Admin', 1),
(N'nhanvien1', N'123', N'User', 1);
GO

-- Kiểm tra dữ liệu đã nạp
SELECT * FROM LopHoc;
SELECT * FROM SinhVien;
SELECT * FROM Users;
GO
