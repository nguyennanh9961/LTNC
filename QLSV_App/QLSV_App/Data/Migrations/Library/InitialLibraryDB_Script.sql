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

CREATE TABLE [TheLoai] (
    [MaTheLoai] nvarchar(20) NOT NULL,
    [TenTheLoai] nvarchar(100) NOT NULL,
    CONSTRAINT [PK_TheLoai] PRIMARY KEY ([MaTheLoai])
);
GO

CREATE TABLE [Sach] (
    [MaSach] nvarchar(20) NOT NULL,
    [TenSach] nvarchar(200) NOT NULL,
    [TacGia] nvarchar(100) NOT NULL,
    [NamXuatBan] int NOT NULL,
    [SoLuong] int NOT NULL,
    [MaTheLoai] nvarchar(20) NOT NULL,
    CONSTRAINT [PK_Sach] PRIMARY KEY ([MaSach]),
    CONSTRAINT [FK_Sach_TheLoai_MaTheLoai] FOREIGN KEY ([MaTheLoai]) REFERENCES [TheLoai] ([MaTheLoai]) ON DELETE NO ACTION
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'MaTheLoai', N'TenTheLoai') AND [object_id] = OBJECT_ID(N'[TheLoai]'))
    SET IDENTITY_INSERT [TheLoai] ON;
INSERT INTO [TheLoai] ([MaTheLoai], [TenTheLoai])
VALUES (N'TL01', N'Công nghệ thông tin'),
(N'TL02', N'Kinh tế - Quản trị'),
(N'TL03', N'Văn học - Kỹ năng sống');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'MaTheLoai', N'TenTheLoai') AND [object_id] = OBJECT_ID(N'[TheLoai]'))
    SET IDENTITY_INSERT [TheLoai] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'MaSach', N'MaTheLoai', N'NamXuatBan', N'SoLuong', N'TacGia', N'TenSach') AND [object_id] = OBJECT_ID(N'[Sach]'))
    SET IDENTITY_INSERT [Sach] ON;
INSERT INTO [Sach] ([MaSach], [MaTheLoai], [NamXuatBan], [SoLuong], [TacGia], [TenSach])
VALUES (N'S001', N'TL01', 2023, 50, N'Chu Thị Minh Huệ', N'Lập trình C# nâng cao'),
(N'S002', N'TL01', 2022, 30, N'Nguyễn Văn An', N'Cơ sở dữ liệu và ADO.NET'),
(N'S003', N'TL02', 2021, 20, N'Trần Minh Anh', N'Kinh tế vi mô căn bản'),
(N'S004', N'TL03', 2020, 100, N'Dale Carnegie', N'Đắc nhân tâm');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'MaSach', N'MaTheLoai', N'NamXuatBan', N'SoLuong', N'TacGia', N'TenSach') AND [object_id] = OBJECT_ID(N'[Sach]'))
    SET IDENTITY_INSERT [Sach] OFF;
GO

CREATE INDEX [IX_Sach_MaTheLoai] ON [Sach] ([MaTheLoai]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20261024040954_InitialLibraryDB', N'8.0.11');
GO

COMMIT;
GO

