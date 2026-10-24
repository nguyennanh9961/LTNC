IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [LopHoc] (
    [MaLop] nvarchar(20) NOT NULL,
    [TenLop] nvarchar(100) NOT NULL,
    CONSTRAINT [PK_LopHoc] PRIMARY KEY ([MaLop])
);
GO

CREATE TABLE [Users] (
    [MaNV] nvarchar(450) NOT NULL,
    [Password] nvarchar(max) NOT NULL,
    [Role] nvarchar(max) NOT NULL,
    [Active] bit NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY ([MaNV])
);
GO

CREATE TABLE [SinhVien] (
    [MaSV] nvarchar(20) NOT NULL,
    [HoTen] nvarchar(50) NOT NULL,
    [NgaySinh] date NOT NULL,
    [GioiTinh] bit NOT NULL,
    [Email] nvarchar(100) NOT NULL,
    [DienThoai] nvarchar(20) NOT NULL,
    [MaLop] nvarchar(20) NOT NULL,
    [Diem] float NOT NULL,
    [TrangThai] nvarchar(50) NOT NULL,
    CONSTRAINT [PK_SinhVien] PRIMARY KEY ([MaSV]),
    CONSTRAINT [FK_SinhVien_LopHoc_MaLop] FOREIGN KEY ([MaLop]) REFERENCES [LopHoc] ([MaLop]) ON DELETE NO ACTION
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'MaLop', N'TenLop') AND [object_id] = OBJECT_ID(N'[LopHoc]'))
    SET IDENTITY_INSERT [LopHoc] ON;
INSERT INTO [LopHoc] ([MaLop], [TenLop])
VALUES (N'L01', N'Kỹ thuật phần mềm 01'),
(N'L02', N'Trí tuệ nhân tạo 01'),
(N'L03', N'Khoa học dữ liệu 01');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'MaLop', N'TenLop') AND [object_id] = OBJECT_ID(N'[LopHoc]'))
    SET IDENTITY_INSERT [LopHoc] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'MaNV', N'Active', N'Password', N'Role') AND [object_id] = OBJECT_ID(N'[Users]'))
    SET IDENTITY_INSERT [Users] ON;
INSERT INTO [Users] ([MaNV], [Active], [Password], [Role])
VALUES (N'admin', CAST(1 AS bit), N'123', N'Admin');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'MaNV', N'Active', N'Password', N'Role') AND [object_id] = OBJECT_ID(N'[Users]'))
    SET IDENTITY_INSERT [Users] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'MaSV', N'Diem', N'DienThoai', N'Email', N'GioiTinh', N'HoTen', N'MaLop', N'NgaySinh', N'TrangThai') AND [object_id] = OBJECT_ID(N'[SinhVien]'))
    SET IDENTITY_INSERT [SinhVien] ON;
INSERT INTO [SinhVien] ([MaSV], [Diem], [DienThoai], [Email], [GioiTinh], [HoTen], [MaLop], [NgaySinh], [TrangThai])
VALUES (N'SV000123', 8.5E0, N'0912345678', N'an.nv@vju.ac.vn', CAST(1 AS bit), N'Nguyễn Văn An', N'L01', '2006-08-15', N'Đang học'),
(N'SV000124', 9.0E0, N'0987654321', N'anh.tm@vju.ac.vn', CAST(0 AS bit), N'Trần Minh Anh', N'L02', '2006-01-22', N'Đang học'),
(N'SV000125', 7.4000000000000004E0, N'0355556677', N'binh.lh@vju.ac.vn', CAST(1 AS bit), N'Lê Hoàng Bình', N'L01', '2006-05-09', N'Đang học'),
(N'SV000126', 8.0999999999999996E0, N'0777888999', N'hong.dt@vju.ac.vn', CAST(0 AS bit), N'Đỗ Thị Hồng', N'L03', '2006-11-30', N'Đang học');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'MaSV', N'Diem', N'DienThoai', N'Email', N'GioiTinh', N'HoTen', N'MaLop', N'NgaySinh', N'TrangThai') AND [object_id] = OBJECT_ID(N'[SinhVien]'))
    SET IDENTITY_INSERT [SinhVien] OFF;
GO

CREATE INDEX [IX_SinhVien_MaLop] ON [SinhVien] ([MaLop]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20261024035505_InitialCreate', N'8.0.11');
GO

COMMIT;
GO

