CREATE DATABASE [QL_NHASACH]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QL_NHASACH', FILENAME = N'C:\Users\NGHI DANG\Dropbox\My PC (LAPTOP-9NVMENQT)\Documents\VAN BANG 2_CNTT\Project\DataBase\QL_NHASACH.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QL_NHASACH_log', FILENAME = N'C:\Users\NGHI DANG\Dropbox\My PC (LAPTOP-9NVMENQT)\Documents\VAN BANG 2_CNTT\Project\DataBase\QL_NHASACH_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 
GO


USE [QL_NHASACH]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[IdHoaDon] [varchar](50) NOT NULL,
	[IdSach] [int] NOT NULL,
	[SoLuong] [bigint] NOT NULL,
	[DonGia] [bigint] NOT NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietNhapSach](
	[IdPhieuNhap] [varchar](50) NOT NULL,
	[IdSach] [int] NOT NULL,
	[SoLuong] [bigint] NOT NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_ChiTietNhapSach_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonBanHang](
	[Id] [varchar](50) NOT NULL,
	[Ngay] [date] NOT NULL,
	[IdKhachHang] [int] NOT NULL,
	[ThanhTien] [bigint] NOT NULL,
 CONSTRAINT [PK_HoaDonBanHang] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](250) NULL,
	[DiaChi] [nvarchar](250) NULL,
	[DienThoai] [varchar](50) NULL,
	[Email] [nvarchar](250) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[TaiKhoan] [nvarchar](50) NULL,
	[MatKhau] [nvarchar](255) NULL,
	[VaitroId] [int] NULL,
	[NguoiDungId] [int] IDENTITY(1,1) NOT NULL,
	[NhanVienId] [int] NULL,
	[Trangthai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[NguoiDungId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/** Object:  Table [dbo].[NhanVien]**/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TenNhanVien] [nvarchar](50) NULL,
	[SoDT] [nvarchar](50) NULL,
	[Email] [nvarchar](250) NULL,
	[ChucVu] [nvarchar](50) NULL,
 CONSTRAINT [PK__NhanVien__3214EC07CC56B2D9] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/** Object:  Table [dbo].[PhieuNhapSach]**/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhapSach](
	[Id] [varchar](50) NOT NULL,
	[Ngay] [date] NOT NULL,
 CONSTRAINT [PK_PhieuNhapSach] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/** Object:  Table [dbo].[PhieuThuTien]**/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuThuTien](
	[Id] [varchar](50) NOT NULL,
	[IdKhachHang] [int] NOT NULL,
	[Ngay] [date] NOT NULL,
	[Tien] [bigint] NOT NULL,
 CONSTRAINT [PK_PhieuThuTien] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/** Object:  Table [dbo].[QuyDinh]**/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuyDinh](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](250) NOT NULL,
	[GiaTri] [nvarchar](max) NOT NULL,
	[Kieu] [nvarchar](50) NULL,
 CONSTRAINT [PK_QuyDinh] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/** Object:  Table [dbo].[Sach] **/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](250) NOT NULL,
	[IdTacGia] [int] NOT NULL,
	[IdTheLoai] [int] NOT NULL,
	[SoluongTon] [bigint] NOT NULL,
 CONSTRAINT [PK_Sach] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/** Object:  Table [dbo].[TacGia]**/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TacGia](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](250) NULL,
 CONSTRAINT [PK_TacGia] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/** Object:  Table [dbo].[TheLoai]**/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheLoai](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TheLoai] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/** Object:  Table [dbo].[VaiTro]**/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VaiTro](
	[TenVaitro] [nvarchar](150) NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK__VaiTro__7FD379C5654DC451] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[QuyDinh] ON 

INSERT [dbo].[QuyDinh] ([Id], [Ten], [GiaTri], [Kieu]) VALUES (1, N'QĐ1- Số lượng sách nhập ít nhất', N'120', N'Cuốn')
INSERT [dbo].[QuyDinh] ([Id], [Ten], [GiaTri], [Kieu]) VALUES (2, N'QĐ1- Số lượng sách tồn ít hơn 300', N'300', N'Cuốn')
INSERT [dbo].[QuyDinh] ([Id], [Ten], [GiaTri], [Kieu]) VALUES (3, N'QĐ2 - Chỉ bán cho khách hàng có nợ không quá 20.000', N'20000', N'đồng')
INSERT [dbo].[QuyDinh] ([Id], [Ten], [GiaTri], [Kieu]) VALUES (4, N'QĐ2 - và sô lượng đầu sách tồn sau khi bán it nhất là 20', N'11', N'Cuốn')
INSERT [dbo].[QuyDinh] ([Id], [Ten], [GiaTri], [Kieu]) VALUES (5, N'QĐ3 - Số tiền thu không vượt quá số tiền khách hàng đang nợ', N'true', N'bool')
INSERT [dbo].[QuyDinh] ([Id], [Ten], [GiaTri], [Kieu]) VALUES (6, N'QĐ4 - Sử dụng hay không sử dụng quy định này', N'true', N'bool')
SET IDENTITY_INSERT [dbo].[QuyDinh] OFF
GO

SET IDENTITY_INSERT [dbo].[TacGia] ON 

INSERT [dbo].[TacGia] ([Id], [Ten]) VALUES (1, N'Hồ Xuân Hương')
INSERT [dbo].[TacGia] ([Id], [Ten]) VALUES (2, N'Nguyễn Bính')
INSERT [dbo].[TacGia] ([Id], [Ten]) VALUES (3, N'Xuân Diệu')
SET IDENTITY_INSERT [dbo].[TacGia] OFF
GO
SET IDENTITY_INSERT [dbo].[TheLoai] ON 

INSERT [dbo].[TheLoai] ([Id], [Ten]) VALUES (1, N'Chính trị – pháp luật ')
INSERT [dbo].[TheLoai] ([Id], [Ten]) VALUES (2, N'Khoa học công nghệ – Kinh tế')
INSERT [dbo].[TheLoai] ([Id], [Ten]) VALUES (3, N'Văn học nghệ thuật')
INSERT [dbo].[TheLoai] ([Id], [Ten]) VALUES (4, N'Văn hóa xã hội – Lịch sử')
INSERT [dbo].[TheLoai] ([Id], [Ten]) VALUES (5, N'Giáo trình')
INSERT [dbo].[TheLoai] ([Id], [Ten]) VALUES (6, N'Truyện, tiểu thuyết')
INSERT [dbo].[TheLoai] ([Id], [Ten]) VALUES (7, N'Thơ')
INSERT [dbo].[TheLoai] ([Id], [Ten]) VALUES (8, N'Tâm lý, tâm linh, tôn giáo')
INSERT [dbo].[TheLoai] ([Id], [Ten]) VALUES (9, N'Thiếu nhi')

SET IDENTITY_INSERT [dbo].[TheLoai] OFF
GO
SET IDENTITY_INSERT [dbo].[VaiTro] ON 

INSERT [dbo].[VaiTro] ([TenVaitro], [Id]) VALUES (N'Admin', 1)
INSERT [dbo].[VaiTro] ([TenVaitro], [Id]) VALUES (N'Giám đốc', 2)
INSERT [dbo].[VaiTro] ([TenVaitro], [Id]) VALUES (N'Trưởng phòng', 3)
INSERT [dbo].[VaiTro] ([TenVaitro], [Id]) VALUES (N'Tổ Trưởng', 4)
INSERT [dbo].[VaiTro] ([TenVaitro], [Id]) VALUES (N'Nhân viên Kế toán', 5)
INSERT [dbo].[VaiTro] ([TenVaitro], [Id]) VALUES (N'Nhân viên bán hàng', 6)
INSERT [dbo].[VaiTro] ([TenVaitro], [Id]) VALUES (N'Thủ quỹ', 7)
SET IDENTITY_INSERT [dbo].[VaiTro] OFF
GO
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([Id], [TenNhanVien], [SoDT], [Email], [ChucVu]) VALUES (1, N'Quản trị hệ thống', N'0392727740', N'admin@gmail.com', N'Admin')
INSERT [dbo].[NhanVien] ([Id], [TenNhanVien], [SoDT], [Email], [ChucVu]) VALUES (2, N'Trương Đình Chương', N'0392727740', N'chuongtddhl@gmail.com', N'Giám đốc')
INSERT [dbo].[NhanVien] ([Id], [TenNhanVien], [SoDT], [Email], [ChucVu]) VALUES (3, N'Đặng Trần Phúc Nghi', N'0948681941', N'phucnghi@gmail.com ', N'Phó Giám đốc')
INSERT [dbo].[NhanVien] ([Id], [TenNhanVien], [SoDT], [Email], [ChucVu]) VALUES (4, N'Nguyễn Văn Đắc', N'09864422112', N'thanhdac@gmail.com', N'Nhân viên')
INSERT [dbo].[NhanVien] ([Id], [TenNhanVien], [SoDT], [Email], [ChucVu]) VALUES (5, N'Nguyen Quang Hạnh', N'98989089', N'quanghanh@gmail.com', N'Nhân viên')
INSERT [dbo].[NhanVien] ([Id], [TenNhanVien], [SoDT], [Email], [ChucVu]) VALUES (6, N'Nguyễn Trung Chính', N'099772321', N'trungchinh@gmai.com', N'Nhân viên')
INSERT [dbo].[NhanVien] ([Id], [TenNhanVien], [SoDT], [Email], [ChucVu]) VALUES (7, N'Trần Thanh Toàn', N'0949402340', N'thanhtoan@gmail.com', N'nhân viên')
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
GO
SET IDENTITY_INSERT [dbo].[NguoiDung] ON 

INSERT [dbo].[NguoiDung] ([TaiKhoan], [MatKhau], [VaitroId], [NguoiDungId], [NhanVienId], [Trangthai]) VALUES (N'admin', N'admin', 1, 1, 1, 1)
INSERT [dbo].[NguoiDung] ([TaiKhoan], [MatKhau], [VaitroId], [NguoiDungId], [NhanVienId], [Trangthai]) VALUES (N'chuontd', N'1234', 1, 2, 3, 1)
INSERT [dbo].[NguoiDung] ([TaiKhoan], [MatKhau], [VaitroId], [NguoiDungId], [NhanVienId], [Trangthai]) VALUES (N'nghidtp', N'1234', 2, 3, 4, 1)
INSERT [dbo].[NguoiDung] ([TaiKhoan], [MatKhau], [VaitroId], [NguoiDungId], [NhanVienId], [Trangthai]) VALUES (N'chinhnt', N'123', 3, 4, 2, 0)
SET IDENTITY_INSERT [dbo].[NguoiDung] OFF
GO

SET IDENTITY_INSERT [dbo].[Sach] ON 

INSERT [dbo].[Sach] ([Id], [Ten], [IdTacGia], [IdTheLoai], [SoluongTon]) VALUES (1, N'Truyện Kiều', 3, 6, 100)
INSERT [dbo].[Sach] ([Id], [Ten], [IdTacGia], [IdTheLoai], [SoluongTon]) VALUES (2, N'Vội vàng', 3, 7, 288)
INSERT [dbo].[Sach] ([Id], [Ten], [IdTacGia], [IdTheLoai], [SoluongTon]) VALUES (3, N'Bánh Trôi Nước', 1, 7, 404)
INSERT [dbo].[Sach] ([Id], [Ten], [IdTacGia], [IdTheLoai], [SoluongTon]) VALUES (4, N'Chân Quê', 2, 7, 260)
INSERT [dbo].[Sach] ([Id], [Ten], [IdTacGia], [IdTheLoai], [SoluongTon]) VALUES (5, N'Tương Tư', 2, 7, 65)
SET IDENTITY_INSERT [dbo].[Sach] OFF
GO
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([Id], [Ten], [DiaChi], [DienThoai], [Email]) VALUES (1, N'Đinh Bá Tiến', N'1127 Hồ Văn Huê', N'0914114234', N'Batien@gmail.com')
INSERT [dbo].[KhachHang] ([Id], [Ten], [DiaChi], [DienThoai], [Email]) VALUES (2, N'Nguyễn Thanh Trực', N'322 Lê Lai', N'09871124422', N'thanhtruc@gmail.com')
INSERT [dbo].[KhachHang] ([Id], [Ten], [DiaChi], [DienThoai], [Email]) VALUES (3, N'Nguyễn Hoàng Nhân', N'33 Hoàng Văn Thụ', N'0978126755', N'hoangnhan@gmail.com')
INSERT [dbo].[KhachHang] ([Id], [Ten], [DiaChi], [DienThoai], [Email]) VALUES (5, N'Nguyễn Hải Đăng', N'1137 Hai Bà Trưng', N'09178632313', N'haidang@gmail.com')
INSERT [dbo].[KhachHang] ([Id], [Ten], [DiaChi], [DienThoai], [Email]) VALUES (6, N'Nguyễn Thị Quyên', N'227 Nguyễn Văn Cừ', N'0909888122', N'thiquyen@gmail.com')
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
GO

INSERT [dbo].[PhieuNhapSach] ([Id], [Ngay]) VALUES (N'11', CAST(N'2023-05-2' AS Date))
INSERT [dbo].[PhieuNhapSach] ([Id], [Ngay]) VALUES (N'22', CAST(N'2023-05-2' AS Date))
INSERT [dbo].[PhieuNhapSach] ([Id], [Ngay]) VALUES (N'33', CAST(N'2023-05-2' AS Date))
INSERT [dbo].[PhieuNhapSach] ([Id], [Ngay]) VALUES (N'44', CAST(N'2023-05-2' AS Date))
GO
SET IDENTITY_INSERT [dbo].[ChiTietNhapSach] ON 

INSERT [dbo].[ChiTietNhapSach] ([IdPhieuNhap], [IdSach], [SoLuong], [Id]) VALUES (N'11', 2, 115, 1)
INSERT [dbo].[ChiTietNhapSach] ([IdPhieuNhap], [IdSach], [SoLuong], [Id]) VALUES (N'11', 3, 145, 2)
INSERT [dbo].[ChiTietNhapSach] ([IdPhieuNhap], [IdSach], [SoLuong], [Id]) VALUES (N'22', 3, 160, 3)
INSERT [dbo].[ChiTietNhapSach] ([IdPhieuNhap], [IdSach], [SoLuong], [Id]) VALUES (N'22', 4, 170, 4)
INSERT [dbo].[ChiTietNhapSach] ([IdPhieuNhap], [IdSach], [SoLuong], [Id]) VALUES (N'33', 3, 245, 5)
INSERT [dbo].[ChiTietNhapSach] ([IdPhieuNhap], [IdSach], [SoLuong], [Id]) VALUES (N'33', 1, 120, 6)
INSERT [dbo].[ChiTietNhapSach] ([IdPhieuNhap], [IdSach], [SoLuong], [Id]) VALUES (N'44', 6, 150, 7)
INSERT [dbo].[ChiTietNhapSach] ([IdPhieuNhap], [IdSach], [SoLuong], [Id]) VALUES (N'44', 4, 110, 8)
INSERT [dbo].[ChiTietNhapSach] ([IdPhieuNhap], [IdSach], [SoLuong], [Id]) VALUES (N'44', 2, 135, 9)
SET IDENTITY_INSERT [dbo].[ChiTietNhapSach] OFF
GO


INSERT [dbo].[HoaDonBanHang] ([Id], [Ngay], [IdKhachHang], [ThanhTien]) VALUES (N'11', CAST(N'2023-05-6' AS Date), 1, 600)
INSERT [dbo].[HoaDonBanHang] ([Id], [Ngay], [IdKhachHang], [ThanhTien]) VALUES (N'15', CAST(N'2023-05-8' AS Date), 6, 2600)
INSERT [dbo].[HoaDonBanHang] ([Id], [Ngay], [IdKhachHang], [ThanhTien]) VALUES (N'212', CAST(N'2023-05-9' AS Date), 3, 1220)
INSERT [dbo].[HoaDonBanHang] ([Id], [Ngay], [IdKhachHang], [ThanhTien]) VALUES (N'2121', CAST(N'2023-05-9' AS Date), 2, 289)
INSERT [dbo].[HoaDonBanHang] ([Id], [Ngay], [IdKhachHang], [ThanhTien]) VALUES (N'22', CAST(N'2023-05-3' AS Date), 6, 900)
INSERT [dbo].[HoaDonBanHang] ([Id], [Ngay], [IdKhachHang], [ThanhTien]) VALUES (N'23', CAST(N'2023-05-3' AS Date), 1, 1660)
GO

SET IDENTITY_INSERT [dbo].[ChiTietHoaDon] ON 

INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdSach], [SoLuong], [DonGia], [id]) VALUES (N'22', 3, 30, 111, 1)
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdSach], [SoLuong], [DonGia], [id]) VALUES (N'22', 4, 10, 112, 2)
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdSach], [SoLuong], [DonGia], [id]) VALUES (N'21', 2, 12, 112, 3)
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdSach], [SoLuong], [DonGia], [id]) VALUES (N'21', 3, 12, 112, 4)
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdSach], [SoLuong], [DonGia], [id]) VALUES (N'24', 6, 15, 212, 6)
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdSach], [SoLuong], [DonGia], [id]) VALUES (N'24', 4, 30, 119, 7)
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdSach], [SoLuong], [DonGia], [id]) VALUES (N'23', 6, 30, 212, 8)
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdSach], [SoLuong], [DonGia], [id]) VALUES (N'23', 1, 50, 210, 9)
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdSach], [SoLuong], [DonGia], [id]) VALUES (N'11', 1, 10, 212, 10)
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdSach], [SoLuong], [DonGia], [id]) VALUES (N'11', 2, 20, 119, 11)
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdSach], [SoLuong], [DonGia], [id]) VALUES (N'12', 3, 30, 212, 13)
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdSach], [SoLuong], [DonGia], [id]) VALUES (N'12', 6, 40, 210, 14)
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdSach], [SoLuong], [DonGia], [id]) VALUES (N'13', 4, 60, 119, 15)
SET IDENTITY_INSERT [dbo].[ChiTietHoaDon] OFF
GO
INSERT [dbo].[PhieuThuTien] ([Id], [IdKhachHang], [Ngay], [Tien]) VALUES (N'22', 2, CAST(N'2023-05-30' AS Date), 200)
INSERT [dbo].[PhieuThuTien] ([Id], [IdKhachHang], [Ngay], [Tien]) VALUES (N'21', 3, CAST(N'2023-05-30' AS Date), 89)
GO


SET ANSI_PADDING ON
GO
/****** Object:  Index [Contrain_ChitietHoaDon_ID_Hoadon_Sach]    Script Date: 01/11/2022 3:31:03 PM ******/
ALTER TABLE [dbo].[ChiTietHoaDon] ADD  CONSTRAINT [Contrain_ChitietHoaDon_ID_Hoadon_Sach] UNIQUE NONCLUSTERED 
(
	[IdHoaDon] ASC,
	[IdSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,  ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/** Object:  Index [Constraint_ChitietNhapSach_IdPhieu_IdSach] **/
ALTER TABLE [dbo].[ChiTietNhapSach] ADD  CONSTRAINT [Constraint_ChitietNhapSach_IdPhieu_IdSach] UNIQUE NONCLUSTERED 
(
	[IdPhieuNhap] ASC,
	[IdSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/** Object:  Index [UQ__NguoiDun__D5B8C7F057CCBA24] **/
ALTER TABLE [dbo].[NguoiDung] ADD UNIQUE NONCLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/**Object:  Index [constrain_Tacgia] **/
ALTER TABLE [dbo].[TacGia] ADD  CONSTRAINT [constrain_Tacgia] UNIQUE NONCLUSTERED 
(
	[Ten] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/** Object:  Index [constrain_TheLoai] **/
ALTER TABLE [dbo].[TheLoai] ADD  CONSTRAINT [constrain_TheLoai] UNIQUE NONCLUSTERED 
(
	[Ten] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[NguoiDung] ADD  DEFAULT ((0)) FOR [VaitroId]
GO
ALTER TABLE [dbo].[NguoiDung] ADD  DEFAULT ((0)) FOR [Trangthai]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDonBanHang] FOREIGN KEY([IdHoaDon])
REFERENCES [dbo].[HoaDonBanHang] ([Id])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDonBanHang]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_Sach] FOREIGN KEY([IdSach])
REFERENCES [dbo].[Sach] ([Id])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_Sach]
GO
ALTER TABLE [dbo].[ChiTietNhapSach]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietNhapSach_PhieuNhapSach] FOREIGN KEY([IdPhieuNhap])
REFERENCES [dbo].[PhieuNhapSach] ([Id])
GO
ALTER TABLE [dbo].[ChiTietNhapSach] CHECK CONSTRAINT [FK_ChiTietNhapSach_PhieuNhapSach]
GO
ALTER TABLE [dbo].[ChiTietNhapSach]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietNhapSach_Sach] FOREIGN KEY([IdSach])
REFERENCES [dbo].[Sach] ([Id])
GO
ALTER TABLE [dbo].[ChiTietNhapSach] CHECK CONSTRAINT [FK_ChiTietNhapSach_Sach]
GO
ALTER TABLE [dbo].[HoaDonBanHang]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonBanHang_KhachHang] FOREIGN KEY([IdKhachHang])
REFERENCES [dbo].[KhachHang] ([Id])
GO
ALTER TABLE [dbo].[HoaDonBanHang] CHECK CONSTRAINT [FK_HoaDonBanHang_KhachHang]
GO
ALTER TABLE [dbo].[NguoiDung]  WITH CHECK ADD  CONSTRAINT [FK_NguoiDung_NhanVien] FOREIGN KEY([NhanVienId])
REFERENCES [dbo].[NhanVien] ([Id])
GO
ALTER TABLE [dbo].[NguoiDung] CHECK CONSTRAINT [FK_NguoiDung_NhanVien]
GO
ALTER TABLE [dbo].[NguoiDung]  WITH CHECK ADD  CONSTRAINT [FK_NguoiDung_VaiTro] FOREIGN KEY([VaitroId])
REFERENCES [dbo].[VaiTro] ([Id])
GO
ALTER TABLE [dbo].[NguoiDung] CHECK CONSTRAINT [FK_NguoiDung_VaiTro]
GO
ALTER TABLE [dbo].[PhieuThuTien]  WITH CHECK ADD  CONSTRAINT [FK_PhieuThuTien_KhachHang] FOREIGN KEY([IdKhachHang])
REFERENCES [dbo].[KhachHang] ([Id])
GO
ALTER TABLE [dbo].[PhieuThuTien] CHECK CONSTRAINT [FK_PhieuThuTien_KhachHang]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_TacGia] FOREIGN KEY([IdTacGia])
REFERENCES [dbo].[TacGia] ([Id])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_TacGia]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_TheLoai] FOREIGN KEY([IdTheLoai])
REFERENCES [dbo].[TheLoai] ([Id])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_TheLoai]
GO
