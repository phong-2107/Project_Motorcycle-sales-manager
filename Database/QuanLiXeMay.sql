USE [QuanLiXeMay1]
GO
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 10/28/2023 11:17:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhap](
	[MaPN] [nvarchar](50) NOT NULL,
	[MaXe] [nvarchar](10) NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [float] NULL,
	[ThanhTien] [float] NULL,
 CONSTRAINT [PK_ChiTietPhieuNhap_1] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC,
	[MaXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietPhieuXuat]    Script Date: 10/28/2023 11:17:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuXuat](
	[MaPX] [nvarchar](50) NOT NULL,
	[MaXe] [nvarchar](10) NOT NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_ChiTietPhieuXuat_1] PRIMARY KEY CLUSTERED 
(
	[MaPX] ASC,
	[MaXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietXe]    Script Date: 10/28/2023 11:17:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietXe](
	[MaCT] [int] IDENTITY(1,1) NOT NULL,
	[MaXe] [nvarchar](10) NULL,
	[SoKhung] [nvarchar](50) NULL,
	[SoMay] [nvarchar](50) NULL,
	[Active] [bit] NULL,
	[MaPN] [nvarchar](50) NULL,
	[MaPX] [nvarchar](50) NULL,
 CONSTRAINT [PK_ChiTietXe] PRIMARY KEY CLUSTERED 
(
	[MaCT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DangNhap]    Script Date: 10/28/2023 11:17:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DangNhap](
	[TaiKhoan] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NULL,
	[TenQuyen] [nvarchar](50) NULL,
 CONSTRAINT [PK_DangNhap] PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HangXe]    Script Date: 10/28/2023 11:17:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangXe](
	[MaHang] [nvarchar](50) NOT NULL,
	[TenHang] [nvarchar](50) NULL,
 CONSTRAINT [PK_HangXe] PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 10/28/2023 11:17:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [nvarchar](50) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[DienThoai] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[HoatDong] [int] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MauXe]    Script Date: 10/28/2023 11:17:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MauXe](
	[MaMau] [nvarchar](50) NOT NULL,
	[TenMau] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMau] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 10/28/2023 11:17:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [nvarchar](50) NOT NULL,
	[TenNCC] [nvarchar](250) NULL,
	[DiaChi] [nvarchar](250) NULL,
	[DienThoai] [nvarchar](12) NULL,
	[Email] [nvarchar](150) NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 10/28/2023 11:17:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nvarchar](50) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](5) NULL,
	[DienThoai] [nvarchar](12) NULL,
	[Email] [nvarchar](250) NULL,
	[DiaChi] [nvarchar](350) NULL,
	[Anh] [nvarchar](200) NULL,
	[TaiKhoan] [nvarchar](50) NULL,
	[ChucVu] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhanCong]    Script Date: 10/28/2023 11:17:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanCong](
	[CVID] [nvarchar](50) NOT NULL,
	[ChucVu] [nvarchar](20) NULL,
 CONSTRAINT [PK_PhanCong] PRIMARY KEY CLUSTERED 
(
	[CVID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 10/28/2023 11:17:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaPN] [nvarchar](50) NOT NULL,
	[MaNV] [nvarchar](50) NULL,
	[MaNCC] [nvarchar](50) NULL,
	[NgayNhap] [date] NULL,
	[TongTien] [float] NULL,
 CONSTRAINT [PK_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuThanhToan]    Script Date: 10/28/2023 11:17:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuThanhToan](
	[MaTT] [nvarchar](50) NOT NULL,
	[MaPX] [nvarchar](50) NULL,
	[TongThanhTien] [float] NULL,
	[TienDaThu] [float] NULL,
	[TienConThieu] [float] NULL,
	[NgayThu] [date] NULL,
	[PTThanhToanID] [nchar](10) NULL,
 CONSTRAINT [PK_PhieuThanhToan] PRIMARY KEY CLUSTERED 
(
	[MaTT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuXuat]    Script Date: 10/28/2023 11:17:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuXuat](
	[MaPX] [nvarchar](50) NOT NULL,
	[MaNV] [nvarchar](50) NULL,
	[MaKH] [nvarchar](50) NULL,
	[NgayXuat] [datetime] NULL,
	[TongThanhTien] [float] NULL,
	[PromoID] [nvarchar](50) NULL,
 CONSTRAINT [PK_PhieuXuat] PRIMARY KEY CLUSTERED 
(
	[MaPX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhuongThucTT]    Script Date: 10/28/2023 11:17:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhuongThucTT](
	[PTThanhToanID] [nchar](10) NOT NULL,
	[PTTilte] [nvarchar](30) NULL,
 CONSTRAINT [PK_PhuongThucTT] PRIMARY KEY CLUSTERED 
(
	[PTThanhToanID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PX_GiamGiaKhuyenMai]    Script Date: 10/28/2023 11:17:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PX_GiamGiaKhuyenMai](
	[PromoID] [nvarchar](50) NOT NULL,
	[Promotilte] [nvarchar](50) NULL,
	[CTPromo] [nvarchar](500) NULL,
 CONSTRAINT [PK_PX_GiamGiaKhuyenMai] PRIMARY KEY CLUSTERED 
(
	[PromoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Xe]    Script Date: 10/28/2023 11:17:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Xe](
	[MaXe] [nvarchar](10) NOT NULL,
	[TenXe] [nvarchar](50) NULL,
	[MaMau] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[DonGia] [float] NULL,
	[NhienLieu] [nvarchar](50) NULL,
	[PhanKhoi] [int] NULL,
	[LoaiXe] [nvarchar](50) NULL,
	[AnhXe] [nvarchar](200) NULL,
	[MaHang] [nvarchar](50) NULL,
	[HoatDong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[XeDaXoa]    Script Date: 10/28/2023 11:17:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[XeDaXoa](
	[MaXe] [nvarchar](10) NOT NULL,
	[TenXe] [nvarchar](50) NULL,
	[MaMau] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[DonGia] [float] NULL,
	[NhienLieu] [nvarchar](50) NULL,
	[PhanKhoi] [int] NULL,
	[LoaiXe] [nvarchar](50) NULL,
	[AnhXe] [nvarchar](200) NULL,
	[MaHang] [nvarchar](50) NULL,
	[ThoiGianXoa] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaXe], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HDNH0000000001', N'XM00001', 2, 19500000, 39000000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaXe], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HDNH0000000002', N'XM00040', 1, 30000000, 30000000)
GO
SET IDENTITY_INSERT [dbo].[ChiTietXe] ON 

INSERT [dbo].[ChiTietXe] ([MaCT], [MaXe], [SoKhung], [SoMay], [Active], [MaPN], [MaPX]) VALUES (1, N'XM00001', N'00000000001', N'10000000001', 0, N'HDNH0000000001', NULL)
INSERT [dbo].[ChiTietXe] ([MaCT], [MaXe], [SoKhung], [SoMay], [Active], [MaPN], [MaPX]) VALUES (2, N'XM00001', N'00000000002', N'10000000002', 0, N'HDNH0000000001', NULL)
INSERT [dbo].[ChiTietXe] ([MaCT], [MaXe], [SoKhung], [SoMay], [Active], [MaPN], [MaPX]) VALUES (3, N'XM00041', N'00000000003', N'10000000003', 0, N'HDNH0000000002', NULL)
SET IDENTITY_INSERT [dbo].[ChiTietXe] OFF
GO
INSERT [dbo].[DangNhap] ([TaiKhoan], [MatKhau], [TenQuyen]) VALUES (N'adindeptrai', N'123456', N'Quản trị viên')
INSERT [dbo].[DangNhap] ([TaiKhoan], [MatKhau], [TenQuyen]) VALUES (N'adindeptrai2', N'123456', N'Quản trị viên')
INSERT [dbo].[DangNhap] ([TaiKhoan], [MatKhau], [TenQuyen]) VALUES (N'admin', N'admin', N'Quản trị viên')
INSERT [dbo].[DangNhap] ([TaiKhoan], [MatKhau], [TenQuyen]) VALUES (N'nhanvienxauxi', N'123456', N'Nhân Viên')
INSERT [dbo].[DangNhap] ([TaiKhoan], [MatKhau], [TenQuyen]) VALUES (N'nhanvienxauxi2', N'123456', N'Nhân Viên')
GO
INSERT [dbo].[HangXe] ([MaHang], [TenHang]) VALUES (N'HX001', N'HONDA')
INSERT [dbo].[HangXe] ([MaHang], [TenHang]) VALUES (N'HX002', N'Yamaha')
INSERT [dbo].[HangXe] ([MaHang], [TenHang]) VALUES (N'HX003', N'SYM')
INSERT [dbo].[HangXe] ([MaHang], [TenHang]) VALUES (N'HX004', N'Piaggio')
INSERT [dbo].[HangXe] ([MaHang], [TenHang]) VALUES (N'HX005', N'Suzuki')
INSERT [dbo].[HangXe] ([MaHang], [TenHang]) VALUES (N'HX006', N'Nijia')
GO
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DienThoai], [Email], [DiaChi], [HoatDong]) VALUES (N'KH001', N'Nguyễn văn Chí', N'0963243462', N'test1@gmail.com', N'Thái Bình', 1)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DienThoai], [Email], [DiaChi], [HoatDong]) VALUES (N'KH002', N'Lương Thị Khuê', N'01682314585', N'conmemeibel123@gmail.com', N'HCM', 1)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DienThoai], [Email], [DiaChi], [HoatDong]) VALUES (N'KH003', N'Vũ Chiến Thắng', N'01234679246', N'ambatukam@gmail.com', N'Bắc Ninh', 1)
GO
INSERT [dbo].[MauXe] ([MaMau], [TenMau]) VALUES (N'M001', N'Đen')
INSERT [dbo].[MauXe] ([MaMau], [TenMau]) VALUES (N'M002', N'Xám')
INSERT [dbo].[MauXe] ([MaMau], [TenMau]) VALUES (N'M003', N'Trắng')
INSERT [dbo].[MauXe] ([MaMau], [TenMau]) VALUES (N'M004', N'Đỏ đậm')
INSERT [dbo].[MauXe] ([MaMau], [TenMau]) VALUES (N'M005', N'Xanh')
INSERT [dbo].[MauXe] ([MaMau], [TenMau]) VALUES (N'M006', N'Xanh Xi Măng')
INSERT [dbo].[MauXe] ([MaMau], [TenMau]) VALUES (N'M007', N'Cam')
INSERT [dbo].[MauXe] ([MaMau], [TenMau]) VALUES (N'M008', N'Bạc')
INSERT [dbo].[MauXe] ([MaMau], [TenMau]) VALUES (N'M009', N'Vàng')
INSERT [dbo].[MauXe] ([MaMau], [TenMau]) VALUES (N'M010', N'Đen Vàng')
INSERT [dbo].[MauXe] ([MaMau], [TenMau]) VALUES (N'M011', N'Đen Xám')
INSERT [dbo].[MauXe] ([MaMau], [TenMau]) VALUES (N'M012', N'Đỏ Đen')
INSERT [dbo].[MauXe] ([MaMau], [TenMau]) VALUES (N'M013', N'Đen Cam')
INSERT [dbo].[MauXe] ([MaMau], [TenMau]) VALUES (N'M014', N'Đỏ Xám')
INSERT [dbo].[MauXe] ([MaMau], [TenMau]) VALUES (N'M015', N'Xanh Dương')
INSERT [dbo].[MauXe] ([MaMau], [TenMau]) VALUES (N'M016', N'Trắng Xám')
INSERT [dbo].[MauXe] ([MaMau], [TenMau]) VALUES (N'M017', N'Xanh Lá')
INSERT [dbo].[MauXe] ([MaMau], [TenMau]) VALUES (N'M018', N'Trắng Đỏ')
INSERT [dbo].[MauXe] ([MaMau], [TenMau]) VALUES (N'M019', N'Trắng Đen')
INSERT [dbo].[MauXe] ([MaMau], [TenMau]) VALUES (N'M020', N'Đỏ Trắng')
INSERT [dbo].[MauXe] ([MaMau], [TenMau]) VALUES (N'M021', N'Xanh Bạc')
INSERT [dbo].[MauXe] ([MaMau], [TenMau]) VALUES (N'M022', N'Xanh Ngọc')
INSERT [dbo].[MauXe] ([MaMau], [TenMau]) VALUES (N'M023', N'Hồng')
INSERT [dbo].[MauXe] ([MaMau], [TenMau]) VALUES (N'M024', N'Hồng cánh sen')
GO
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [DienThoai], [Email]) VALUES (N'NCC001', N'Nhà cung cấp số 1', N'Hà Nội', N'', N'ncc01@gmail.com')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [DienThoai], [Email]) VALUES (N'NCC002', N'Nhà cung cấp số 2', N'Thái Bình', N'BRVT', N'ncc02@gmail.com')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [DienThoai], [Email]) VALUES (N'NCC003', N'Nhà cung cấp số 3', N'HCM', N'1234567899', N'ncc03@gmail.com')
GO
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [DienThoai], [Email], [DiaChi], [Anh], [TaiKhoan], [ChucVu]) VALUES (N'NV0001', N'Hoàng Đức Hưng', N'Nữ', N'023456789', N'ambatukamugg@Anh3.com', N'HCM', N'638340907493110709-Nijia Swift 2 Yen.png', N'admin', N'AD01      ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [DienThoai], [Email], [DiaChi], [Anh], [TaiKhoan], [ChucVu]) VALUES (N'NV0002', N'Lại Hoàng Khuê', N'Nam', N'098712345', N'ohmaygot123@Anh3.com', N'HCM', NULL, NULL, N'NV02      ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [DienThoai], [Email], [DiaChi], [Anh], [TaiKhoan], [ChucVu]) VALUES (N'NV0003', N'Vũ Trung Khánh', N'Nam', N'024613579', N'changebelwemeanstay@MienTayTeu.com', N'HCM', NULL, NULL, N'NV01      ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [DienThoai], [Email], [DiaChi], [Anh], [TaiKhoan], [ChucVu]) VALUES (N'NV0004', N'Nguyễn Thanh Phong', N'Nữ', N'089123456', N'phongbrvtbeovail@gmail.com', N'HCM', NULL, NULL, N'AD01      ')
GO
INSERT [dbo].[PhanCong] ([CVID], [ChucVu]) VALUES (N'AD01      ', N'Nhân viên Quản Lý')
INSERT [dbo].[PhanCong] ([CVID], [ChucVu]) VALUES (N'NV01      ', N'Nhân viên Bán Hàng')
INSERT [dbo].[PhanCong] ([CVID], [ChucVu]) VALUES (N'NV02      ', N'Nhân viên Nhập Xuất')
GO
INSERT [dbo].[PhieuNhap] ([MaPN], [MaNV], [MaNCC], [NgayNhap], [TongTien]) VALUES (N'HDNH0000000001', N'NV0002', N'NCC001', CAST(N'2023-04-28' AS Date), 39000000)
INSERT [dbo].[PhieuNhap] ([MaPN], [MaNV], [MaNCC], [NgayNhap], [TongTien]) VALUES (N'HDNH0000000002', N'NV0001', N'NCC002', CAST(N'2023-04-28' AS Date), 39000000)
GO
INSERT [dbo].[PhuongThucTT] ([PTThanhToanID], [PTTilte]) VALUES (N'P1        ', N'VĐT Momo')
INSERT [dbo].[PhuongThucTT] ([PTThanhToanID], [PTTilte]) VALUES (N'P2        ', N'VĐT VNPay')
INSERT [dbo].[PhuongThucTT] ([PTThanhToanID], [PTTilte]) VALUES (N'P3        ', N'Thẻ ATM')
INSERT [dbo].[PhuongThucTT] ([PTThanhToanID], [PTTilte]) VALUES (N'P4        ', N'InternetBanking')
INSERT [dbo].[PhuongThucTT] ([PTThanhToanID], [PTTilte]) VALUES (N'P5        ', N'Thẻ Tín Dụng')
INSERT [dbo].[PhuongThucTT] ([PTThanhToanID], [PTTilte]) VALUES (N'P6        ', N'TIền Mặt')
GO
INSERT [dbo].[PX_GiamGiaKhuyenMai] ([PromoID], [Promotilte], [CTPromo]) VALUES (N'PR001', N'Giảm 3%', N'Giảm 3% tổng giá trị đơn hàng')
INSERT [dbo].[PX_GiamGiaKhuyenMai] ([PromoID], [Promotilte], [CTPromo]) VALUES (N'PR002', N'Giảm 15%', N'Giảm 15% tổng giá trị đơn hàng')
INSERT [dbo].[PX_GiamGiaKhuyenMai] ([PromoID], [Promotilte], [CTPromo]) VALUES (N'PR003', N'Giảm 50%', N'Giảm 50% tổng giá trị đơn hàng')
GO
INSERT [dbo].[Xe] ([MaXe], [TenXe], [MaMau], [SoLuong], [DonGia], [NhienLieu], [PhanKhoi], [LoaiXe], [AnhXe], [MaHang], [HoatDong]) VALUES (N'XM00001', N'Nijia GOGO MAX 3', N'M007', 10, 20000000, N'Điện', 50, N'Xe Ði?n', NULL, N'HX006', NULL)
INSERT [dbo].[Xe] ([MaXe], [TenXe], [MaMau], [SoLuong], [DonGia], [NhienLieu], [PhanKhoi], [LoaiXe], [AnhXe], [MaHang], [HoatDong]) VALUES (N'XM00002', N'Nijia ZX', N'M012', 10, 25000000, N'Điện', 50, N'Xe Ði?n', NULL, N'HX006', NULL)
INSERT [dbo].[Xe] ([MaXe], [TenXe], [MaMau], [SoLuong], [DonGia], [NhienLieu], [PhanKhoi], [LoaiXe], [AnhXe], [MaHang], [HoatDong]) VALUES (N'XM00003', N'Nijia X1', NULL, 10, 21000000, N'Điện', 50, N'Xe Ði?n', NULL, N'HX006', NULL)
INSERT [dbo].[Xe] ([MaXe], [TenXe], [MaMau], [SoLuong], [DonGia], [NhienLieu], [PhanKhoi], [LoaiXe], [AnhXe], [MaHang], [HoatDong]) VALUES (N'XM00004', N'Nijia ZX', N'M002', 10, 23000000, N'Điện', 50, N'Xe Ði?n', NULL, N'HX006', NULL)
INSERT [dbo].[Xe] ([MaXe], [TenXe], [MaMau], [SoLuong], [DonGia], [NhienLieu], [PhanKhoi], [LoaiXe], [AnhXe], [MaHang], [HoatDong]) VALUES (N'XM00005', N'Nijia e-max', N'M005', 10, 28000000, N'Điện', 100, N'Xe Ði?n', NULL, N'HX006', NULL)
INSERT [dbo].[Xe] ([MaXe], [TenXe], [MaMau], [SoLuong], [DonGia], [NhienLieu], [PhanKhoi], [LoaiXe], [AnhXe], [MaHang], [HoatDong]) VALUES (N'XM00006', N'Nijia Z2', NULL, 10, 26000000, N'Điện', 50, N'Xe Ði?n', NULL, N'HX006', NULL)
INSERT [dbo].[Xe] ([MaXe], [TenXe], [MaMau], [SoLuong], [DonGia], [NhienLieu], [PhanKhoi], [LoaiXe], [AnhXe], [MaHang], [HoatDong]) VALUES (N'XM00007', N'Vision 110', N'M015', 10, 19500000, N'Xăng', 110, N'Côn Tay', NULL, N'HX001', NULL)
INSERT [dbo].[Xe] ([MaXe], [TenXe], [MaMau], [SoLuong], [DonGia], [NhienLieu], [PhanKhoi], [LoaiXe], [AnhXe], [MaHang], [HoatDong]) VALUES (N'XM00008', N'Winner X', N'M001', 10, 40000000, N'Xăng', 150, N'Côn Tay', NULL, N'HX001', NULL)
INSERT [dbo].[Xe] ([MaXe], [TenXe], [MaMau], [SoLuong], [DonGia], [NhienLieu], [PhanKhoi], [LoaiXe], [AnhXe], [MaHang], [HoatDong]) VALUES (N'XM00009', N'LEAD', N'M002', 10, 39500000, N'Xăng', 125, N'Côn Tay', NULL, N'HX001', NULL)
INSERT [dbo].[Xe] ([MaXe], [TenXe], [MaMau], [SoLuong], [DonGia], [NhienLieu], [PhanKhoi], [LoaiXe], [AnhXe], [MaHang], [HoatDong]) VALUES (N'XM00010', N'Air Blade', N'M006', 10, 49500000, N'Xăng', 150, N'Côn Tay', NULL, N'HX001', NULL)
INSERT [dbo].[Xe] ([MaXe], [TenXe], [MaMau], [SoLuong], [DonGia], [NhienLieu], [PhanKhoi], [LoaiXe], [AnhXe], [MaHang], [HoatDong]) VALUES (N'XM00011', N'SH Mode', N'M002', 10, 59500000, N'Xăng', 110, N'Côn Tay', NULL, N'HX001', NULL)
INSERT [dbo].[Xe] ([MaXe], [TenXe], [MaMau], [SoLuong], [DonGia], [NhienLieu], [PhanKhoi], [LoaiXe], [AnhXe], [MaHang], [HoatDong]) VALUES (N'XM00012', N'Blade', N'M001', 10, 29500000, N'Xăng', 125, N'Côn Tay', NULL, N'HX001', NULL)
INSERT [dbo].[Xe] ([MaXe], [TenXe], [MaMau], [SoLuong], [DonGia], [NhienLieu], [PhanKhoi], [LoaiXe], [AnhXe], [MaHang], [HoatDong]) VALUES (N'XM00013', N'Super Dream', NULL, 10, 19500000, N'Xăng', 110, N'Côn Tay', NULL, N'HX001', NULL)
INSERT [dbo].[Xe] ([MaXe], [TenXe], [MaMau], [SoLuong], [DonGia], [NhienLieu], [PhanKhoi], [LoaiXe], [AnhXe], [MaHang], [HoatDong]) VALUES (N'XM00014', N'Cub', N'M006', 10, 19500000, N'Xăng', 110, N'Côn Tay', NULL, N'HX001', NULL)
INSERT [dbo].[Xe] ([MaXe], [TenXe], [MaMau], [SoLuong], [DonGia], [NhienLieu], [PhanKhoi], [LoaiXe], [AnhXe], [MaHang], [HoatDong]) VALUES (N'XM00015', N'GSX S150', N'M012', 10, 89500000, N'Xăng', 150, N'Côn Tay', NULL, N'HX002', NULL)
INSERT [dbo].[Xe] ([MaXe], [TenXe], [MaMau], [SoLuong], [DonGia], [NhienLieu], [PhanKhoi], [LoaiXe], [AnhXe], [MaHang], [HoatDong]) VALUES (N'XM00016', N'Raider 2023', N'M010', 10, 39500000, N'Xăng', 150, N'Côn Tay', NULL, N'HX002', NULL)
INSERT [dbo].[Xe] ([MaXe], [TenXe], [MaMau], [SoLuong], [DonGia], [NhienLieu], [PhanKhoi], [LoaiXe], [AnhXe], [MaHang], [HoatDong]) VALUES (N'XM00017', N'Satria', N'M001', 10, 38500000, N'Xăng', 150, N'Côn Tay', NULL, N'HX002', NULL)
INSERT [dbo].[Xe] ([MaXe], [TenXe], [MaMau], [SoLuong], [DonGia], [NhienLieu], [PhanKhoi], [LoaiXe], [AnhXe], [MaHang], [HoatDong]) VALUES (N'XM00018', N'Suzuki Motor', N'M015', 10, 59500000, N'Xăng', 125, N'Côn Tay', NULL, N'HX002', NULL)
INSERT [dbo].[Xe] ([MaXe], [TenXe], [MaMau], [SoLuong], [DonGia], [NhienLieu], [PhanKhoi], [LoaiXe], [AnhXe], [MaHang], [HoatDong]) VALUES (N'XM00019', N'Suzuki Burgman', N'M001', 10, 39500000, N'Xăng', 150, N'Côn Tay', NULL, N'HX002', NULL)
INSERT [dbo].[Xe] ([MaXe], [TenXe], [MaMau], [SoLuong], [DonGia], [NhienLieu], [PhanKhoi], [LoaiXe], [AnhXe], [MaHang], [HoatDong]) VALUES (N'XM00020', N'Suzuki Shooter', N'M001', 10, 29500000, N'Xăng', 110, N'Côn Tay', NULL, N'HX002', NULL)
INSERT [dbo].[Xe] ([MaXe], [TenXe], [MaMau], [SoLuong], [DonGia], [NhienLieu], [PhanKhoi], [LoaiXe], [AnhXe], [MaHang], [HoatDong]) VALUES (N'XM00021', N'Suzuki Viva', N'M002', 10, 19500000, N'Xăng', 110, N'Côn Tay', NULL, N'HX002', NULL)
INSERT [dbo].[Xe] ([MaXe], [TenXe], [MaMau], [SoLuong], [DonGia], [NhienLieu], [PhanKhoi], [LoaiXe], [AnhXe], [MaHang], [HoatDong]) VALUES (N'XM00022', N'CBR 150R', N'M001', 10, 30000000, N'Xăng', 150, N'Côn Tay', NULL, N'HX004', NULL)
INSERT [dbo].[Xe] ([MaXe], [TenXe], [MaMau], [SoLuong], [DonGia], [NhienLieu], [PhanKhoi], [LoaiXe], [AnhXe], [MaHang], [HoatDong]) VALUES (N'XM00023', N'Exciter 155 VVA', N'M012', 10, 35900000, N'Xăng', 155, N'Côn Tay', NULL, N'HX004', NULL)
INSERT [dbo].[Xe] ([MaXe], [TenXe], [MaMau], [SoLuong], [DonGia], [NhienLieu], [PhanKhoi], [LoaiXe], [AnhXe], [MaHang], [HoatDong]) VALUES (N'XM00024', N'Grande', NULL, 10, 40000000, N'Xăng', 125, N'Côn Tay', NULL, N'HX004', NULL)
INSERT [dbo].[Xe] ([MaXe], [TenXe], [MaMau], [SoLuong], [DonGia], [NhienLieu], [PhanKhoi], [LoaiXe], [AnhXe], [MaHang], [HoatDong]) VALUES (N'XM00026', N'Lumina', N'M015', 10, 29500000, N'Xăng', 125, N'Côn Tay', NULL, N'HX004', NULL)
INSERT [dbo].[Xe] ([MaXe], [TenXe], [MaMau], [SoLuong], [DonGia], [NhienLieu], [PhanKhoi], [LoaiXe], [AnhXe], [MaHang], [HoatDong]) VALUES (N'XM00027', N'Nouvo LX', N'M012', 10, 28500000, N'Xăng', 125, N'Côn Tay', NULL, N'HX004', NULL)
INSERT [dbo].[Xe] ([MaXe], [TenXe], [MaMau], [SoLuong], [DonGia], [NhienLieu], [PhanKhoi], [LoaiXe], [AnhXe], [MaHang], [HoatDong]) VALUES (N'XM00028', N'Acruzo 155', N'M002', 10, 50000000, N'Xăng', 155, N'Côn Tay', NULL, N'HX004', NULL)
INSERT [dbo].[Xe] ([MaXe], [TenXe], [MaMau], [SoLuong], [DonGia], [NhienLieu], [PhanKhoi], [LoaiXe], [AnhXe], [MaHang], [HoatDong]) VALUES (N'XM00029', N'NVX 155', N'M012', 10, 48000000, N'Xăng', 155, N'Côn Tay', NULL, N'HX004', NULL)
INSERT [dbo].[Xe] ([MaXe], [TenXe], [MaMau], [SoLuong], [DonGia], [NhienLieu], [PhanKhoi], [LoaiXe], [AnhXe], [MaHang], [HoatDong]) VALUES (N'XM00030', N'XSR 155', N'M015', 10, 39500000, N'Xăng', 155, N'Côn Tay', NULL, N'HX004', NULL)
INSERT [dbo].[Xe] ([MaXe], [TenXe], [MaMau], [SoLuong], [DonGia], [NhienLieu], [PhanKhoi], [LoaiXe], [AnhXe], [MaHang], [HoatDong]) VALUES (N'XM00031', N'MT-15', N'M015', 10, 38500000, N'Xăng', 155, N'Côn Tay', NULL, N'HX004', NULL)
INSERT [dbo].[Xe] ([MaXe], [TenXe], [MaMau], [SoLuong], [DonGia], [NhienLieu], [PhanKhoi], [LoaiXe], [AnhXe], [MaHang], [HoatDong]) VALUES (N'XM00032', N'Liberty 50', N'M004', 10, 29500000, N'Xăng', 50, N'Côn T? Ð?ng', NULL, N'HX005', NULL)
INSERT [dbo].[Xe] ([MaXe], [TenXe], [MaMau], [SoLuong], [DonGia], [NhienLieu], [PhanKhoi], [LoaiXe], [AnhXe], [MaHang], [HoatDong]) VALUES (N'XM00033', N'Medley 125', N'M002', 10, 49500000, N'Xăng', 125, N'Côn T? Ð?ng', NULL, N'HX005', NULL)
INSERT [dbo].[Xe] ([MaXe], [TenXe], [MaMau], [SoLuong], [DonGia], [NhienLieu], [PhanKhoi], [LoaiXe], [AnhXe], [MaHang], [HoatDong]) VALUES (N'XM00034', N'Vespa Primavera', N'M015', 10, 59500000, N'Xăng', 125, N'Côn T? Ð?ng', NULL, N'HX005', NULL)
INSERT [dbo].[Xe] ([MaXe], [TenXe], [MaMau], [SoLuong], [DonGia], [NhienLieu], [PhanKhoi], [LoaiXe], [AnhXe], [MaHang], [HoatDong]) VALUES (N'XM00036', N'Vespa Sprint', N'M012', 10, 58500000, N'Xăng', 125, N'Côn T? Ð?ng', NULL, N'HX005', NULL)
INSERT [dbo].[Xe] ([MaXe], [TenXe], [MaMau], [SoLuong], [DonGia], [NhienLieu], [PhanKhoi], [LoaiXe], [AnhXe], [MaHang], [HoatDong]) VALUES (N'XM00037', N'Vespa GTS', N'M005', 10, 69500000, N'Xăng', 150, N'Côn T? Ð?ng', NULL, N'HX005', NULL)
INSERT [dbo].[Xe] ([MaXe], [TenXe], [MaMau], [SoLuong], [DonGia], [NhienLieu], [PhanKhoi], [LoaiXe], [AnhXe], [MaHang], [HoatDong]) VALUES (N'XM00038', N'Zip 100', N'M015', 10, 29500000, N'Xăng', 100, N'Côn T? Ð?ng', NULL, N'HX005', NULL)
INSERT [dbo].[Xe] ([MaXe], [TenXe], [MaMau], [SoLuong], [DonGia], [NhienLieu], [PhanKhoi], [LoaiXe], [AnhXe], [MaHang], [HoatDong]) VALUES (N'XM00039', N'Fly 125', N'M012', 10, 39500000, N'Xăng', 125, N'Côn T? Ð?ng', NULL, N'HX005', NULL)
INSERT [dbo].[Xe] ([MaXe], [TenXe], [MaMau], [SoLuong], [DonGia], [NhienLieu], [PhanKhoi], [LoaiXe], [AnhXe], [MaHang], [HoatDong]) VALUES (N'XM00040', N'Vespa LX', N'M002', 10, 49500000, N'Xăng', 125, N'Côn T? Ð?ng', NULL, N'HX005', NULL)
INSERT [dbo].[Xe] ([MaXe], [TenXe], [MaMau], [SoLuong], [DonGia], [NhienLieu], [PhanKhoi], [LoaiXe], [AnhXe], [MaHang], [HoatDong]) VALUES (N'XM00041', N'Vespa S', N'M005', 10, 58500000, N'Xăng', 125, N'Côn T? Ð?ng', NULL, N'HX005', NULL)
GO
ALTER TABLE [dbo].[XeDaXoa] ADD  DEFAULT (getdate()) FOR [ThoiGianXoa]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap] FOREIGN KEY([MaPN])
REFERENCES [dbo].[PhieuNhap] ([MaPN])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_Xe] FOREIGN KEY([MaXe])
REFERENCES [dbo].[Xe] ([MaXe])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_Xe]
GO
ALTER TABLE [dbo].[ChiTietPhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuXuat_PhieuXuat] FOREIGN KEY([MaPX])
REFERENCES [dbo].[PhieuXuat] ([MaPX])
GO
ALTER TABLE [dbo].[ChiTietPhieuXuat] CHECK CONSTRAINT [FK_ChiTietPhieuXuat_PhieuXuat]
GO
ALTER TABLE [dbo].[ChiTietPhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuXuat_Xe] FOREIGN KEY([MaXe])
REFERENCES [dbo].[Xe] ([MaXe])
GO
ALTER TABLE [dbo].[ChiTietPhieuXuat] CHECK CONSTRAINT [FK_ChiTietPhieuXuat_Xe]
GO
ALTER TABLE [dbo].[ChiTietXe]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietXe_PhieuNhap] FOREIGN KEY([MaPN])
REFERENCES [dbo].[PhieuNhap] ([MaPN])
GO
ALTER TABLE [dbo].[ChiTietXe] CHECK CONSTRAINT [FK_ChiTietXe_PhieuNhap]
GO
ALTER TABLE [dbo].[ChiTietXe]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietXe_PhieuXuat] FOREIGN KEY([MaPX])
REFERENCES [dbo].[PhieuXuat] ([MaPX])
GO
ALTER TABLE [dbo].[ChiTietXe] CHECK CONSTRAINT [FK_ChiTietXe_PhieuXuat]
GO
ALTER TABLE [dbo].[ChiTietXe]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietXe_Xe] FOREIGN KEY([MaXe])
REFERENCES [dbo].[Xe] ([MaXe])
GO
ALTER TABLE [dbo].[ChiTietXe] CHECK CONSTRAINT [FK_ChiTietXe_Xe]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_DangNhap] FOREIGN KEY([TaiKhoan])
REFERENCES [dbo].[DangNhap] ([TaiKhoan])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_DangNhap]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_PhanCong] FOREIGN KEY([ChucVu])
REFERENCES [dbo].[PhanCong] ([CVID])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_PhanCong]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhaCungCap]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhanVien]
GO
ALTER TABLE [dbo].[PhieuThanhToan]  WITH CHECK ADD  CONSTRAINT [FK_PhieuThanhToan_PhieuXuat] FOREIGN KEY([MaPX])
REFERENCES [dbo].[PhieuXuat] ([MaPX])
GO
ALTER TABLE [dbo].[PhieuThanhToan] CHECK CONSTRAINT [FK_PhieuThanhToan_PhieuXuat]
GO
ALTER TABLE [dbo].[PhieuThanhToan]  WITH CHECK ADD  CONSTRAINT [FK_PhieuThanhToan_PhuongThucTT] FOREIGN KEY([PTThanhToanID])
REFERENCES [dbo].[PhuongThucTT] ([PTThanhToanID])
GO
ALTER TABLE [dbo].[PhieuThanhToan] CHECK CONSTRAINT [FK_PhieuThanhToan_PhuongThucTT]
GO
ALTER TABLE [dbo].[PhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_PhieuXuat_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[PhieuXuat] CHECK CONSTRAINT [FK_PhieuXuat_KhachHang]
GO
ALTER TABLE [dbo].[PhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_PhieuXuat_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuXuat] CHECK CONSTRAINT [FK_PhieuXuat_NhanVien]
GO
ALTER TABLE [dbo].[PhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_PhieuXuat_PX_GiamGiaKhuyenMai] FOREIGN KEY([PromoID])
REFERENCES [dbo].[PX_GiamGiaKhuyenMai] ([PromoID])
GO
ALTER TABLE [dbo].[PhieuXuat] CHECK CONSTRAINT [FK_PhieuXuat_PX_GiamGiaKhuyenMai]
GO
ALTER TABLE [dbo].[Xe]  WITH CHECK ADD  CONSTRAINT [FK_Xe_HangXe] FOREIGN KEY([MaHang])
REFERENCES [dbo].[HangXe] ([MaHang])
GO
ALTER TABLE [dbo].[Xe] CHECK CONSTRAINT [FK_Xe_HangXe]
GO
ALTER TABLE [dbo].[Xe]  WITH CHECK ADD  CONSTRAINT [FK_Xe_MauXe] FOREIGN KEY([MaMau])
REFERENCES [dbo].[MauXe] ([MaMau])
GO
ALTER TABLE [dbo].[Xe] CHECK CONSTRAINT [FK_Xe_MauXe]
GO
ALTER TABLE [dbo].[Xe]  WITH CHECK ADD  CONSTRAINT [CK_PhanKhoi] CHECK  (([PhanKhoi]=(1500) OR [PhanKhoi]=(225) OR [PhanKhoi]=(200) OR [PhanKhoi]=(175) OR [PhanKhoi]=(155) OR [PhanKhoi]=(150) OR [PhanKhoi]=(125) OR [PhanKhoi]=(110) OR [PhanKhoi]=(100) OR [PhanKhoi]=(50)))
GO
ALTER TABLE [dbo].[Xe] CHECK CONSTRAINT [CK_PhanKhoi]
GO
