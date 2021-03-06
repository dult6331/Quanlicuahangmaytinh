USE [master]
GO
/****** Object:  Database [QLCuaHangMayTinh]    Script Date: 6/27/2021 8:17:55 PM ******/
CREATE DATABASE [QLCuaHangMayTinh]
GO
ALTER DATABASE [QLCuaHangMayTinh] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLCuaHangMayTinh].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLCuaHangMayTinh] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLCuaHangMayTinh] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLCuaHangMayTinh] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLCuaHangMayTinh] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLCuaHangMayTinh] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLCuaHangMayTinh] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLCuaHangMayTinh] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLCuaHangMayTinh] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLCuaHangMayTinh] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLCuaHangMayTinh] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLCuaHangMayTinh] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLCuaHangMayTinh] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLCuaHangMayTinh] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLCuaHangMayTinh] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLCuaHangMayTinh] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLCuaHangMayTinh] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLCuaHangMayTinh] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLCuaHangMayTinh] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLCuaHangMayTinh] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLCuaHangMayTinh] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLCuaHangMayTinh] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLCuaHangMayTinh] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLCuaHangMayTinh] SET RECOVERY FULL 
GO
ALTER DATABASE [QLCuaHangMayTinh] SET  MULTI_USER 
GO
ALTER DATABASE [QLCuaHangMayTinh] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLCuaHangMayTinh] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLCuaHangMayTinh] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLCuaHangMayTinh] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLCuaHangMayTinh] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLCuaHangMayTinh', N'ON'
GO
ALTER DATABASE [QLCuaHangMayTinh] SET QUERY_STORE = OFF
GO
USE [QLCuaHangMayTinh]
GO
/****** Object:  Table [dbo].[tblHoadonban]    Script Date: 6/27/2021 8:17:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHoadonban](
	[MaHDB] [varchar](10) NOT NULL,
	[MaNV] [varchar](10) NOT NULL,
	[MaKH] [varchar](10) NOT NULL,
	[Ngayban] [date] NOT NULL,
	[Diachi] [nvarchar](max) NOT NULL,
	[sdt] [varchar](10) NOT NULL,
 CONSTRAINT [PK_tblHoadonban] PRIMARY KEY CLUSTERED 
(
	[MaHDB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHoadonnhap]    Script Date: 6/27/2021 8:17:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHoadonnhap](
	[MaHDN] [varchar](10) NOT NULL,
	[MaNV] [varchar](10) NOT NULL,
	[MaMT] [varchar](10) NOT NULL,
	[Soluong] [int] NOT NULL,
	[Ngaynhap] [date] NOT NULL,
	[Diachi] [nvarchar](max) NOT NULL,
	[Sdt] [varchar](10) NOT NULL,
	[Gianhap] [float] NOT NULL,
 CONSTRAINT [PK_dbo.tblHoadonnhap] PRIMARY KEY CLUSTERED 
(
	[MaHDN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKhachhang]    Script Date: 6/27/2021 8:17:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKhachhang](
	[MaKH] [varchar](10) NOT NULL,
	[TenKH] [nvarchar](50) NOT NULL,
	[Gioitinh] [nvarchar](5) NOT NULL,
	[Diachi] [nvarchar](max) NOT NULL,
	[Sdt] [varchar](10) NOT NULL,
 CONSTRAINT [PK_tblKhachhang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNhaCC]    Script Date: 6/27/2021 8:17:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhaCC](
	[MaNCC] [varchar](10) NOT NULL,
	[TenNCC] [nvarchar](50) NOT NULL,
	[Diachi] [nvarchar](max) NOT NULL,
	[Sdt] [varchar](10) NOT NULL,
 CONSTRAINT [PK_tblNhaCC] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNhanVien]    Script Date: 6/27/2021 8:17:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhanVien](
	[MaNV] [varchar](10) NOT NULL,
	[TenNV] [nvarchar](50) NOT NULL,
	[Gioitinh] [nvarchar](5) NOT NULL,
	[Diachi] [nvarchar](max) NOT NULL,
	[sdt] [varchar](10) NOT NULL,
	[Lamviec] BIT NOT NULL,
 CONSTRAINT [PK_tblNhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTaiKhoan]    Script Date: 6/27/2021 8:17:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTaiKhoan](
	[SoTT] [int] NOT NULL,
	[TTaiKhoan] [varchar](24) NOT NULL,
	[MatKhau] [varchar](24) NOT NULL,
	[MaNV] [varchar](10) NOT NULL,
	[Quanli] [bit] NOT NULL,
 CONSTRAINT [PK_tblTaiKhoan] PRIMARY KEY CLUSTERED 
(
	[SoTT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblThongTinHD]    Script Date: 6/27/2021 8:17:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblThongTinHD](
	[MaHDB] [varchar](10) NOT NULL,
	[MaMT] [varchar](10) NOT NULL,
	[Soluong] [int] NOT NULL,
	[Giaban] [float] NOT NULL,
 CONSTRAINT [PK_tblThongTinHD] PRIMARY KEY CLUSTERED 
(
	[MaHDB] ASC,
	[MaMT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblThongtinMT]    Script Date: 6/27/2021 8:17:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblThongtinMT](
	[MaMT] [varchar](10) NOT NULL,
	[TenMT] [nvarchar](50) NOT NULL,
	[MaNCC] [varchar](10) NOT NULL,
	[Soluong] [int] NOT NULL,
	[Giaban] [float] NOT NULL,
 CONSTRAINT [PK_tblThongtinMT] PRIMARY KEY CLUSTERED 
(
	[MaMT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblHoadonban] ([MaHDB], [MaNV], [MaKH], [Ngayban], [Diachi], [sdt]) VALUES (N'ABC002', N'NV02', N'KH02', CAST(N'2021-04-27' AS Date), N'Ha Noi', N'1234567890')
INSERT [dbo].[tblHoadonban] ([MaHDB], [MaNV], [MaKH], [Ngayban], [Diachi], [sdt]) VALUES (N'CGV004', N'NV04', N'KH04', CAST(N'2021-04-01' AS Date), N'Sai Gon', N'1234567890')
INSERT [dbo].[tblHoadonban] ([MaHDB], [MaNV], [MaKH], [Ngayban], [Diachi], [sdt]) VALUES (N'GGY003', N'NV03', N'KH03', CAST(N'2021-03-29' AS Date), N'Ho Chi Minh', N'1234567890')
INSERT [dbo].[tblHoadonban] ([MaHDB], [MaNV], [MaKH], [Ngayban], [Diachi], [sdt]) VALUES (N'XXX005', N'NV05', N'KH05', CAST(N'2021-04-02' AS Date), N'Hoa Lac', N'1234567898')
INSERT [dbo].[tblHoadonban] ([MaHDB], [MaNV], [MaKH], [Ngayban], [Diachi], [sdt]) VALUES (N'XYZ001', N'NV01', N'KH01', CAST(N'2021-04-27' AS Date), N'Ha Noi', N'1203984756')
GO
INSERT [dbo].[tblHoadonnhap] ([MaHDN], [MaNV], [MaMT], [Soluong], [Ngaynhap], [Diachi], [Sdt], [Gianhap]) VALUES (N'001ABC', N'NV01', N'MT1', 1, CAST(N'2021-04-27' AS Date), N'Ha Noi', N'1203984756', 1000000)
INSERT [dbo].[tblHoadonnhap] ([MaHDN], [MaNV], [MaMT], [Soluong], [Ngaynhap], [Diachi], [Sdt], [Gianhap]) VALUES (N'002XYZ', N'NV02', N'MT4', 2, CAST(N'2021-04-27' AS Date), N'Ha Noi', N'1234567890', 1000000)
INSERT [dbo].[tblHoadonnhap] ([MaHDN], [MaNV], [MaMT], [Soluong], [Ngaynhap], [Diachi], [Sdt], [Gianhap]) VALUES (N'003XXX', N'NV03', N'MT5', 1, CAST(N'2021-03-29' AS Date), N'Ho Chi Minh', N'1234567890', 1500000)
INSERT [dbo].[tblHoadonnhap] ([MaHDN], [MaNV], [MaMT], [Soluong], [Ngaynhap], [Diachi], [Sdt], [Gianhap]) VALUES (N'004GGV', N'NV04', N'MT2', 1, CAST(N'2021-04-01' AS Date), N'Sai Gon', N'1234567890', 2000000)
INSERT [dbo].[tblHoadonnhap] ([MaHDN], [MaNV], [MaMT], [Soluong], [Ngaynhap], [Diachi], [Sdt], [Gianhap]) VALUES (N'005XXX', N'NV05', N'MT3', 1, CAST(N'2021-04-02' AS Date), N'Hoa Lac', N'1234567898', 2100000)
GO
INSERT [dbo].[tblKhachhang] ([MaKH], [TenKH], [Gioitinh], [Diachi], [Sdt]) VALUES (N'KH01', N'Nam', N'Nam', N'Ha Noi', N'1203984756')
INSERT [dbo].[tblKhachhang] ([MaKH], [TenKH], [Gioitinh], [Diachi], [Sdt]) VALUES (N'KH02', N'Trung', N'Nam', N'Ha Noi', N'1234567890')
INSERT [dbo].[tblKhachhang] ([MaKH], [TenKH], [Gioitinh], [Diachi], [Sdt]) VALUES (N'KH03', N'Linh', N'Nu', N'Ho Chi Minh', N'1234567890')
INSERT [dbo].[tblKhachhang] ([MaKH], [TenKH], [Gioitinh], [Diachi], [Sdt]) VALUES (N'KH04', N'Quynh', N'Nu', N'Sai Gon', N'1234567890')
INSERT [dbo].[tblKhachhang] ([MaKH], [TenKH], [Gioitinh], [Diachi], [Sdt]) VALUES (N'KH05', N'Tung', N'Nam', N'Hoa Lac', N'1234567898')
GO
INSERT [dbo].[tblNhaCC] ([MaNCC], [TenNCC], [Diachi], [Sdt]) VALUES (N'ACER892', N'Laptop Acer', N'CB', N'128841121')
INSERT [dbo].[tblNhaCC] ([MaNCC], [TenNCC], [Diachi], [Sdt]) VALUES (N'ASUS002', N'Laptop Asus', N'HCM', N'327488129')
INSERT [dbo].[tblNhaCC] ([MaNCC], [TenNCC], [Diachi], [Sdt]) VALUES (N'Dell001', N'Laptop Dell', N'HN', N'123456789')
INSERT [dbo].[tblNhaCC] ([MaNCC], [TenNCC], [Diachi], [Sdt]) VALUES (N'HP007', N'Laptop HP', N'HN', N'129984242')
INSERT [dbo].[tblNhaCC] ([MaNCC], [TenNCC], [Diachi], [Sdt]) VALUES (N'MACOS', N'Laptop Apple', N'TB', N'102045654')
INSERT [dbo].[tblNhaCC] ([MaNCC], [TenNCC], [Diachi], [Sdt]) VALUES (N'THINK032', N'Laptop Thinkpad', N'SG', N'328429894')
GO
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [Gioitinh], [Diachi], [sdt], [Lamviec]) VALUES (N'NV01', N'Dung', N'Nam', N'HaNoi', N'1234567890',1)
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [Gioitinh], [Diachi], [sdt], [Lamviec]) VALUES (N'NV02', N'Hieu', N'Nam', N'HaNoi', N'1234567889',1)
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [Gioitinh], [Diachi], [sdt], [Lamviec]) VALUES (N'NV03', N'Dat', N'Nam', N'Hola', N'1234567899',1)
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [Gioitinh], [Diachi], [sdt], [Lamviec]) VALUES (N'NV04', N'Dung', N'Nam', N'HaNoi', N'1234567899',1)
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [Gioitinh], [Diachi], [sdt], [Lamviec]) VALUES (N'NV05', N'Hien', N'Nu', N'HaNoi', N'1234567899',1)
GO
INSERT [dbo].[tblTaiKhoan] ([SoTT], [TTaiKhoan], [MatKhau], [MaNV], [Quanli]) VALUES (1, N'admin', N'123@123a', N'NV01', 1)
INSERT [dbo].[tblTaiKhoan] ([SoTT], [TTaiKhoan], [MatKhau], [MaNV], [Quanli]) VALUES (2, N'nhanvien02', N'123@123a', N'NV02', 0)
INSERT [dbo].[tblTaiKhoan] ([SoTT], [TTaiKhoan], [MatKhau], [MaNV], [Quanli]) VALUES (3, N'nhanvien03', N'123@123a', N'NV03', 0)
INSERT [dbo].[tblTaiKhoan] ([SoTT], [TTaiKhoan], [MatKhau], [MaNV], [Quanli]) VALUES (4, N'nhanvien04', N'123@123a', N'NV04', 0)
INSERT [dbo].[tblTaiKhoan] ([SoTT], [TTaiKhoan], [MatKhau], [MaNV], [Quanli]) VALUES (5, N'nhanvien05', N'123@123a', N'NV05', 0)
GO
INSERT [dbo].[tblThongTinHD] ([MaHDB], [MaMT], [Soluong], [Giaban]) VALUES (N'ABC002', N'MT4', 2, 1000000)
INSERT [dbo].[tblThongTinHD] ([MaHDB], [MaMT], [Soluong], [Giaban]) VALUES (N'CGV004', N'MT2', 1, 2000000)
INSERT [dbo].[tblThongTinHD] ([MaHDB], [MaMT], [Soluong], [Giaban]) VALUES (N'GGY003', N'MT5', 1, 1500000)
INSERT [dbo].[tblThongTinHD] ([MaHDB], [MaMT], [Soluong], [Giaban]) VALUES (N'XXX005', N'MT3', 1, 2100000)
INSERT [dbo].[tblThongTinHD] ([MaHDB], [MaMT], [Soluong], [Giaban]) VALUES (N'XYZ001', N'MT1', 1, 1000000)
GO
INSERT [dbo].[tblThongtinMT] ([MaMT], [TenMT], [MaNCC], [Soluong], [Giaban]) VALUES (N'MT1', N'Dell 2021', N'Dell001', 100, 10000000)
INSERT [dbo].[tblThongtinMT] ([MaMT], [TenMT], [MaNCC], [Soluong], [Giaban]) VALUES (N'MT2', N'Asus 2021', N'ASUS002', 100, 10000000)
INSERT [dbo].[tblThongtinMT] ([MaMT], [TenMT], [MaNCC], [Soluong], [Giaban]) VALUES (N'MT3', N'Thinkpad 2020', N'THINK032', 100, 20000000)
INSERT [dbo].[tblThongtinMT] ([MaMT], [TenMT], [MaNCC], [Soluong], [Giaban]) VALUES (N'MT4', N'MacBook 2021 pro', N'MACOS', 100, 30000000)
INSERT [dbo].[tblThongtinMT] ([MaMT], [TenMT], [MaNCC], [Soluong], [Giaban]) VALUES (N'MT5', N'Acer Fake TQ', N'ACER892', 100, 9000000)
INSERT [dbo].[tblThongtinMT] ([MaMT], [TenMT], [MaNCC], [Soluong], [Giaban]) VALUES (N'MT6', N'Laptop Gaming', N'HP007', 99, 21000000)
INSERT [dbo].[tblThongtinMT] ([MaMT], [TenMT], [MaNCC], [Soluong], [Giaban]) VALUES (N'MT7', N'MacAir 2019', N'MACOS', 14, 15000000)
GO
ALTER TABLE [dbo].[tblHoadonban]  WITH CHECK ADD  CONSTRAINT [FK_tblHoadonban_tblKhachhang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[tblKhachhang] ([MaKH])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblHoadonban] CHECK CONSTRAINT [FK_tblHoadonban_tblKhachhang]
GO
ALTER TABLE [dbo].[tblHoadonban]  WITH CHECK ADD  CONSTRAINT [FK_tblHoadonban_tblNhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tblNhanVien] ([MaNV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblHoadonban] CHECK CONSTRAINT [FK_tblHoadonban_tblNhanVien]
GO
ALTER TABLE [dbo].[tblHoadonnhap]  WITH CHECK ADD  CONSTRAINT [FK_dbo.tblHoadonnhap_tblNhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tblNhanVien] ([MaNV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblHoadonnhap] CHECK CONSTRAINT [FK_dbo.tblHoadonnhap_tblNhanVien]
GO
ALTER TABLE [dbo].[tblHoadonnhap]  WITH CHECK ADD  CONSTRAINT [FK_dbo.tblHoadonnhap_tblThongtinMT] FOREIGN KEY([MaMT])
REFERENCES [dbo].[tblThongtinMT] ([MaMT])
GO
ALTER TABLE [dbo].[tblHoadonnhap] CHECK CONSTRAINT [FK_dbo.tblHoadonnhap_tblThongtinMT]
GO
ALTER TABLE [dbo].[tblTaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_tblTaiKhoan_tblNhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tblNhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[tblTaiKhoan] CHECK CONSTRAINT [FK_tblTaiKhoan_tblNhanVien]
GO
ALTER TABLE [dbo].[tblThongTinHD]  WITH CHECK ADD  CONSTRAINT [FK_tblThongTinHD_tblHoadonban] FOREIGN KEY([MaHDB])
REFERENCES [dbo].[tblHoadonban] ([MaHDB])
GO
ALTER TABLE [dbo].[tblThongTinHD] CHECK CONSTRAINT [FK_tblThongTinHD_tblHoadonban]
GO
ALTER TABLE [dbo].[tblThongTinHD]  WITH CHECK ADD  CONSTRAINT [FK_tblThongTinHD_tblThongtinMT] FOREIGN KEY([MaMT])
REFERENCES [dbo].[tblThongtinMT] ([MaMT])
GO
ALTER TABLE [dbo].[tblThongTinHD] CHECK CONSTRAINT [FK_tblThongTinHD_tblThongtinMT]
GO
ALTER TABLE [dbo].[tblThongtinMT]  WITH CHECK ADD  CONSTRAINT [FK_tblThongtinMT_tblNhaCC] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[tblNhaCC] ([MaNCC])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblThongtinMT] CHECK CONSTRAINT [FK_tblThongtinMT_tblNhaCC]
GO
USE [master]
GO
ALTER DATABASE [QLCuaHangMayTinh] SET  READ_WRITE 
GO
