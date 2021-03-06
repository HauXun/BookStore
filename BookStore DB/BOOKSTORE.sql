USE [master]
GO
/****** Object:  Database [BookStore]    Script Date: 6/5/2022 7:15:32 PM ******/
CREATE DATABASE [BookStore]
GO
ALTER DATABASE [BookStore] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BookStore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BookStore] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BookStore] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BookStore] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BookStore] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BookStore] SET ARITHABORT OFF 
GO
ALTER DATABASE [BookStore] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [BookStore] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BookStore] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BookStore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BookStore] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BookStore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BookStore] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BookStore] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BookStore] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BookStore] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BookStore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BookStore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BookStore] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BookStore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BookStore] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BookStore] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BookStore] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BookStore] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BookStore] SET  MULTI_USER 
GO
ALTER DATABASE [BookStore] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BookStore] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BookStore] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BookStore] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BookStore] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BookStore] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [BookStore] SET QUERY_STORE = OFF
GO
USE [BookStore]
GO

/****** Object:  UserDefinedTableType [dbo].[ProductFilterType]    Script Date: 6/5/2022 7:15:32 PM ******/
CREATE TYPE [dbo].[ProductFilterType] AS TABLE(
	[Attribute] [nvarchar](100) NOT NULL,
	[Value] [nvarchar](100) NOT NULL,
	[Attributename] [nvarchar](100) NOT NULL
)
GO
/****** Object:  UserDefinedFunction [dbo].[fuConvertToUnsign]    Script Date: 6/5/2022 7:15:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[fuConvertToUnsign] 
( @strInput NVARCHAR(4000) ) 
RETURNS
NVARCHAR(4000) 
AS
BEGIN 
	IF (@strInput IS NULL)
	RETURN @strInput 
	
	IF (@strInput = '')
	RETURN @strInput 
	
	DECLARE @RT NVARCHAR(4000)
	DECLARE @SIGN_CHARS NCHAR(136) 
	DECLARE @UNSIGN_CHARS NCHAR (136) 
	
	SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' + NCHAR(272) + NCHAR(208)
	SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD'

	DECLARE @COUNTER INT 
	DECLARE @COUNTER1 INT

	SET @COUNTER = 1 
	WHILE (@COUNTER <= LEN(@strInput)) 
	BEGIN 
		SET @COUNTER1 = 1 
		WHILE (@COUNTER1 <= LEN(@SIGN_CHARS) + 1) 
		BEGIN 
			IF (UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1, 1)) = UNICODE(SUBSTRING(@strInput, @COUNTER, 1) )) 
			BEGIN 
				IF (@COUNTER = 1)
					SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1, 1) + SUBSTRING(@strInput, @COUNTER + 1, LEN(@strInput) - 1) 
				ELSE 
					SET @strInput = SUBSTRING(@strInput, 1, @COUNTER - 1) + SUBSTRING(@UNSIGN_CHARS, @COUNTER1, 1) + SUBSTRING(@strInput, @COUNTER + 1, LEN(@strInput) - @COUNTER)
					BREAK
			END 
			SET @COUNTER1 += 1 
		END 
		SET @COUNTER += 1 
	END
	SET @strInput = REPLACE(@strInput, ' ', '-') 
	RETURN @strInput 
END
GO
/****** Object:  UserDefinedFunction [dbo].[Func_NextAdminID]    Script Date: 6/5/2022 7:15:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[Func_NextAdminID]()
RETURNS VARCHAR(100)
AS
BEGIN
    -- Declare
	DECLARE @IDAccount VARCHAR(10) = 'A0001'
	DECLARE @Idx INT
	SET @Idx = 1

	WHILE EXISTS (SELECT IDAccount FROM dbo.Taikhoan WHERE IDAccount = @IDAccount)
	BEGIN
	    SET @Idx += 1
		SET @IDAccount = 'A' + REPLICATE('0', 4 - LEN(CAST(@Idx AS VARCHAR))) + CAST(@Idx AS VARCHAR)
	END
	RETURN @IDAccount
END
GO
/****** Object:  UserDefinedFunction [dbo].[Func_NextKhachHangID]    Script Date: 6/5/2022 7:15:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[Func_NextKhachHangID]()
RETURNS VARCHAR(100)
AS
BEGIN
    -- Declare
	DECLARE @MaDT VARCHAR(10) = 'K0001'
	DECLARE @Idx INT
	SET @Idx = 1

	WHILE EXISTS (SELECT MaDT FROM dbo.DoiTac WHERE MaDT = @MaDT)
	BEGIN
	    SET @Idx += 1
		SET @MaDT = 'K' + REPLICATE('0', 4 - LEN(CAST(@Idx AS VARCHAR))) + CAST(@Idx AS VARCHAR)
	END
	RETURN @MaDT
END
GO
/****** Object:  UserDefinedFunction [dbo].[Func_NextNCCID]    Script Date: 6/5/2022 7:15:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[Func_NextNCCID]()
RETURNS VARCHAR(100)
AS
BEGIN
    -- Declare
	DECLARE @MaDT VARCHAR(10) = 'CC001'
	DECLARE @Idx INT
	SET @Idx = 1

	WHILE EXISTS (SELECT MaDT FROM dbo.DoiTac WHERE MaDT = @MaDT)
	BEGIN
	    SET @Idx += 1
		SET @MaDT = 'CC' + REPLICATE('0', 3 - LEN(CAST(@Idx AS VARCHAR))) + CAST(@Idx AS VARCHAR)
	END
	RETURN @MaDT
END
GO
/****** Object:  UserDefinedFunction [dbo].[Func_NextStaffID]    Script Date: 6/5/2022 7:15:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[Func_NextStaffID]()
RETURNS VARCHAR(100)
AS
BEGIN
    -- Declare
	DECLARE @IDAccount VARCHAR(10) = 'S0001'
	DECLARE @Idx INT
	SET @Idx = 1

	WHILE EXISTS (SELECT IDAccount FROM dbo.Taikhoan WHERE IDAccount = @IDAccount)
	BEGIN
	    SET @Idx += 1
		SET @IDAccount = 'S' + REPLICATE('0', 4 - LEN(CAST(@Idx AS VARCHAR))) + CAST(@Idx AS VARCHAR)
	END
	RETURN @IDAccount
END
GO
/****** Object:  Table [dbo].[But]    Script Date: 6/5/2022 7:15:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[But](
	[MaSP] [int] NOT NULL,
	[MauSac] [nvarchar](20) NOT NULL,
	[ChatLieu] [nvarchar](20) NOT NULL,
	[MauMuc] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 6/5/2022 7:15:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaHoaDon] [int] NOT NULL,
	[MaSP] [int] NOT NULL,
	[SoLuong] [smallint] NOT NULL,
	[Gia] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ColumnName]    Script Date: 6/5/2022 7:15:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ColumnName](
	[COLUMN_NAME] [sysname] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DoiTac]    Script Date: 6/5/2022 7:15:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoiTac](
	[MaDT] [varchar](100) NOT NULL,
	[TenDT] [nvarchar](100) NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[SDT] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 6/5/2022 7:15:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] [int] IDENTITY(1,1) NOT NULL,
	[NguoiBan] [varchar](20) NOT NULL,
	[NgayGiaoDich] [datetime] NOT NULL,
	[MaDT] [varchar](100) NOT NULL,
	[LoaiHoaDon] [varchar](10) NOT NULL,
	[GiamGia] [float] NOT NULL,
	[TongTien] [float] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK__HoaDon__835ED13BAA4B9767] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiHoaDon]    Script Date: 6/5/2022 7:15:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiHoaDon](
	[MaLoaiHD] [varchar](10) NOT NULL,
	[TenLoaiHD] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__LoaiHoaD__122768D2F862272C] PRIMARY KEY CLUSTERED 
(
	[MaLoaiHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 6/5/2022 7:15:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[MaSP] [int] NOT NULL,
	[TacGia] [nvarchar](100) NOT NULL,
	[NamXB] [varchar](10) NOT NULL,
	[NhaXB] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK__Sach__2725081C298FCEC6] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 6/5/2022 7:15:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [int] IDENTITY(1,1) NOT NULL,
	[TenSP] [nvarchar](100) NOT NULL,
	[DVT] [nvarchar](100) NOT NULL,
	[Gia] [float] NOT NULL,
	[SoLuongTon] [int] NOT NULL,
	[ThuongHieu] [nvarchar](100) NOT NULL,
	[Cancellation] [bit] NOT NULL,
 CONSTRAINT [PK__SanPham__2725081C7B57884C] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Taikhoan]    Script Date: 6/5/2022 7:15:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Taikhoan](
	[IDAccount] [varchar](20) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[HoTen] [nvarchar](30) NOT NULL,
	[DiaChi] [nvarchar](200) NOT NULL,
	[SDT] [varchar](20) NOT NULL,
	[Active] [bit] NOT NULL,
	[RoleID] [char](5) NOT NULL,
 CONSTRAINT [PK__Taikhoan__1D323F90FFEF1D42] PRIMARY KEY CLUSTERED 
(
	[IDAccount] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThietBiDienTu]    Script Date: 6/5/2022 7:15:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThietBiDienTu](
	[MaSP] [int] NOT NULL,
	[MauSac] [nvarchar](20) NOT NULL,
	[ChatLieu] [nvarchar](20) NOT NULL,
	[BaoHanh] [nvarchar](100) NOT NULL,
	[ThongSoKiThuat] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK__ThietBiD__2725081C085B398F] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserRole]    Script Date: 6/5/2022 7:15:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRole](
	[RoleID] [char](5) NOT NULL,
	[RoleName] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[But] ([MaSP], [MauSac], [ChatLieu], [MauMuc]) VALUES (21, N'Xanh Nước Biển ', N'Nhựa', N'Xanh Nước Biển')
INSERT [dbo].[But] ([MaSP], [MauSac], [ChatLieu], [MauMuc]) VALUES (22, N'Xanh Lá ', N'Nhựa', N'Xanh Lá')
INSERT [dbo].[But] ([MaSP], [MauSac], [ChatLieu], [MauMuc]) VALUES (23, N'Trắng ', N'Nhựa', N'Xanh Nước Biển')
INSERT [dbo].[But] ([MaSP], [MauSac], [ChatLieu], [MauMuc]) VALUES (24, N'Vàng ', N'Nhựa', N'Xanh Nước Biển')
INSERT [dbo].[But] ([MaSP], [MauSac], [ChatLieu], [MauMuc]) VALUES (25, N'Đỏ ', N'Nhựa', N'Đỏ')
INSERT [dbo].[But] ([MaSP], [MauSac], [ChatLieu], [MauMuc]) VALUES (26, N'Trắng Đỏ', N'Nhựa', N'Đỏ')
INSERT [dbo].[But] ([MaSP], [MauSac], [ChatLieu], [MauMuc]) VALUES (27, N'Đen ', N'Nhựa', N'Đen')
INSERT [dbo].[But] ([MaSP], [MauSac], [ChatLieu], [MauMuc]) VALUES (28, N'Cam', N'Nhựa', N'Cam')
INSERT [dbo].[But] ([MaSP], [MauSac], [ChatLieu], [MauMuc]) VALUES (29, N'Xanh Lá ', N'Nhựa', N'Trắng')
INSERT [dbo].[But] ([MaSP], [MauSac], [ChatLieu], [MauMuc]) VALUES (30, N'Bạc ', N'Sắt', N'Xanh Nước Biển')
INSERT [dbo].[But] ([MaSP], [MauSac], [ChatLieu], [MauMuc]) VALUES (31, N'Xanh Đen ', N'Nhựa', N'Xanh Đậm')
INSERT [dbo].[But] ([MaSP], [MauSac], [ChatLieu], [MauMuc]) VALUES (32, N'Đen', N'Nhựa', N'Hồng')
INSERT [dbo].[But] ([MaSP], [MauSac], [ChatLieu], [MauMuc]) VALUES (63, N'Thêm thử', N'Thêm thử', N'Thêm thử')
GO
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (2, 16, 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (2, 17, 1, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (2, 18, 1, 30000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (2, 19, 3, 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (2, 20, 1, 25000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (3, 2, 1, 56000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (3, 7, 1, 52000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (3, 19, 1, 42000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (3, 21, 3, 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (4, 16, 2, 20000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (4, 17, 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (4, 18, 1, 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (5, 1, 1, 27000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (5, 12, 1, 23000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (5, 18, 1, 42000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (6, 16, 2, 55000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (6, 17, 1, 25000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (6, 18, 2, 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (6, 19, 1, 12500)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (6, 20, 1, 12500)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (7, 3, 2, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (7, 9, 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (7, 15, 1, 35000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (8, 6, 1, 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (8, 7, 1, 52000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (8, 8, 1, 42000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (9, 8, 1, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (9, 16, 2, 30000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (9, 17, 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (10, 16, 2, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (10, 17, 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (10, 18, 1, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (10, 29, 1, 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (10, 30, 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (11, 4, 1, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (11, 6, 2, 25000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (11, 7, 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (11, 17, 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (11, 22, 5, 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (12, 1, 2, 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (12, 7, 1, 30000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (12, 18, 1, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (12, 29, 2, 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (13, 15, 2, 20000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (13, 27, 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (13, 28, 1, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (14, 8, 2, 5000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (14, 9, 1, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (14, 11, 1, 20000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (15, 6, 2, 56000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (15, 7, 1, 52000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (15, 8, 1, 42000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (15, 19, 3, 16000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (16, 1, 2, 56000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (16, 2, 1, 52000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (16, 3, 1, 42000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (16, 4, 3, 16000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (17, 16, 2, 55000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (17, 17, 1, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (17, 19, 1, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (18, 6, 5, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (18, 10, 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (18, 18, 1, 45000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (19, 1, 2, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (19, 3, 1, 20000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (19, 5, 2, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (19, 19, 3, 15000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (20, 7, 2, 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (20, 10, 1, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (20, 18, 1, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (20, 29, 3, 15000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (21, 3, 2, 55000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (21, 6, 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (21, 9, 1, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (22, 2, 2, 45000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (22, 4, 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (22, 6, 2, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (23, 9, 4, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (23, 11, 2, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (23, 18, 1, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (23, 19, 3, 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (23, 30, 1, 30000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (24, 10, 2, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (24, 14, 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (24, 18, 1, 30000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (25, 1, 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (25, 5, 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (25, 9, 1, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (25, 19, 3, 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (26, 1, 2, 20000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (26, 7, 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (26, 31, 2, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (27, 16, 1, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (27, 17, 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (27, 18, 1, 60000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (27, 19, 1, 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (27, 20, 1, 20000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (28, 2, 2, 20000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (28, 3, 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (28, 18, 1, 40000)
GO
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (29, 3, 2, 30000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (29, 7, 1, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (29, 11, 1, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (29, 19, 4, 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (30, 1, 2, 15000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (30, 5, 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (30, 10, 1, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (31, 7, 2, 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (31, 9, 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (31, 11, 1, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (31, 13, 3, 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (31, 20, 2, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (32, 4, 1, 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (32, 6, 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (32, 7, 1, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (32, 8, 4, 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (32, 9, 1, 60000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (33, 16, 2, 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (33, 17, 1, 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (33, 18, 1, 25000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (34, 1, 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (34, 2, 1, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (34, 3, 1, 25000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (34, 4, 3, 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (34, 25, 1, 55000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (35, 2, 1, 56000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (35, 7, 1, 52000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (35, 19, 1, 42000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (35, 31, 3, 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (36, 16, 2, 20000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (36, 27, 1, 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (36, 28, 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (37, 10, 1, 27000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (37, 12, 1, 23000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (37, 18, 1, 42000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (38, 6, 2, 55000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (38, 17, 1, 25000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (38, 18, 2, 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (38, 29, 2, 15000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (38, 30, 1, 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (39, 3, 2, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (39, 9, 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (39, 25, 1, 35000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (40, 6, 1, 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (40, 17, 1, 52000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (40, 28, 1, 42000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (41, 16, 2, 30000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (41, 17, 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (41, 28, 1, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (42, 16, 2, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (42, 17, 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (42, 18, 1, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (42, 29, 1, 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (42, 30, 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (43, 6, 4, 25000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (43, 17, 2, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (43, 20, 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (44, 1, 2, 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (44, 7, 1, 30000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (44, 8, 1, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (44, 29, 2, 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (45, 15, 2, 20000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (45, 17, 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (45, 28, 1, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (46, 8, 2, 5000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (46, 9, 1, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (46, 21, 1, 20000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (47, 6, 2, 56000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (47, 7, 1, 52000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (47, 18, 1, 42000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (47, 19, 3, 16000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (48, 1, 2, 56000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (48, 2, 1, 52000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (48, 3, 1, 42000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (48, 4, 3, 16000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (49, 16, 2, 55000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (49, 17, 1, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (49, 19, 1, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (50, 6, 5, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (50, 10, 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (50, 18, 1, 45000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (50, 19, 3, 15000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (51, 1, 2, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (51, 3, 1, 20000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (51, 25, 2, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (52, 7, 2, 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (52, 10, 1, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (52, 28, 1, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (52, 29, 3, 15000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (53, 3, 2, 55000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (53, 6, 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (53, 19, 1, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (54, 2, 2, 45000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (54, 4, 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (54, 6, 2, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (55, 9, 4, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (55, 11, 2, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (55, 18, 1, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (55, 19, 3, 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (55, 30, 1, 30000)
GO
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (56, 10, 2, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (56, 14, 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (56, 18, 1, 30000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (57, 1, 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (57, 5, 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (57, 9, 1, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (57, 19, 3, 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (58, 1, 2, 20000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (58, 17, 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (58, 31, 2, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (59, 16, 1, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (59, 17, 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (59, 18, 1, 60000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (59, 19, 1, 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (59, 20, 1, 20000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (60, 2, 2, 20000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (60, 3, 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (60, 18, 1, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (61, 3, 2, 30000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (61, 7, 1, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (61, 11, 1, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (61, 19, 4, 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (62, 1, 2, 15000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (62, 5, 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (62, 10, 1, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (63, 7, 2, 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (63, 9, 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (63, 11, 1, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (63, 13, 3, 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (63, 20, 2, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (64, 4, 1, 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (64, 6, 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (64, 7, 1, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (64, 8, 4, 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (64, 9, 1, 60000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (65, 16, 2, 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (65, 17, 1, 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (65, 18, 1, 25000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (66, 1, 1, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (66, 2, 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (66, 3, 1, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (66, 4, 5, 10000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (67, 1, 1, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (67, 2, 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (67, 3, 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (68, 1, 1, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (68, 2, 2, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (68, 3, 3, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (207, 3, 2, 80852)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSP], [SoLuong], [Gia]) VALUES (207, 7, 1, 163181)
GO
INSERT [dbo].[ColumnName] ([COLUMN_NAME]) VALUES (N'MaSP')
INSERT [dbo].[ColumnName] ([COLUMN_NAME]) VALUES (N'TacGia')
INSERT [dbo].[ColumnName] ([COLUMN_NAME]) VALUES (N'NamXB')
INSERT [dbo].[ColumnName] ([COLUMN_NAME]) VALUES (N'NhaXB')
GO
INSERT [dbo].[DoiTac] ([MaDT], [TenDT], [DiaChi], [SDT]) VALUES (N'CC001', N'Nhà Xuất Bản Thuận Hóa Huế', N'33 Chu Văn An, Phường Phú Hội, Thừa Thiên Huế', N'08.8250259')
INSERT [dbo].[DoiTac] ([MaDT], [TenDT], [DiaChi], [SDT]) VALUES (N'CC002', N'Công Ty Cổ Phần Phát Hành Sách Tp. HCM', N'60-62 Lê Lợi, P. Bến Nghé, Q. 1, Tp. Hồ Chí Minh', N'08.8250898')
INSERT [dbo].[DoiTac] ([MaDT], [TenDT], [DiaChi], [SDT]) VALUES (N'CC003', N'Trí Tuệ - Công Ty Cổ Phần Sách & Thiết Bị Giáo Dục Trí Tuệ', N'187 Giảng Võ, Q. Đống Đa, Hà Nội', N'08.8252376')
INSERT [dbo].[DoiTac] ([MaDT], [TenDT], [DiaChi], [SDT]) VALUES (N'CC004', N'Công Ty TNHH Văn Hóa Việt Long', N'14/35, Đào Duy Anh, P.9, Q. Phú Nhuận, Tp. Hồ Chí Minh', N'08.8252375')
INSERT [dbo].[DoiTac] ([MaDT], [TenDT], [DiaChi], [SDT]) VALUES (N'CC005', N'Công Ty Cổ Phần Sách Mcbooks', N'Lô 34E, Khu Đấu Giá 3ha, P. Phúc Diễm, Q. Bắc Từ Liêm, Hà Nội', N'08.8252374')
INSERT [dbo].[DoiTac] ([MaDT], [TenDT], [DiaChi], [SDT]) VALUES (N'CC006', N'Công Ty TNHH Đăng Nguyên', N'Thôn Đức Mỹ, X. Suối Nghệ, H. Châu Đức, Bà Rịa-Vũng Tàu', N'08.8252373')
INSERT [dbo].[DoiTac] ([MaDT], [TenDT], [DiaChi], [SDT]) VALUES (N'CC007', N'Nhà Sách Trực Tuyến BOOKBUY.VN', N'147 Pasteur, P. 6, Q. 3, Tp. Hồ Chí Minh', N'08.8252372')
INSERT [dbo].[DoiTac] ([MaDT], [TenDT], [DiaChi], [SDT]) VALUES (N'CC008', N'Công Ty Cổ Phần Sách Giáo Dục Tại Thành Phố Hà Nội', N'289A Khuất Duy Tiến, P. Trung Hòa, Q. Cầu Giấy, Hà Nội', N'08.8252371')
INSERT [dbo].[DoiTac] ([MaDT], [TenDT], [DiaChi], [SDT]) VALUES (N'CC009', N'Công Ty CP Sách Và Thiết Bị Trường Học Đà Nẵng', N'76-78 Bạch Đằng, Q. Hải Châu, Tp. Đà Nẵng', N'08.8252377')
INSERT [dbo].[DoiTac] ([MaDT], [TenDT], [DiaChi], [SDT]) VALUES (N'CC010', N'Công Ty Cổ Phần Sách & Thiết Bị Trường Học Kiên Giang', N'Lô E16, Số 30, 31, 32 Đường 3 Tháng 2, P. Vĩnh Lạc, TP Rạch', N'08.8252378')
INSERT [dbo].[DoiTac] ([MaDT], [TenDT], [DiaChi], [SDT]) VALUES (N'CC011', N'DaNaBook - Công Ty Cổ Phần Sách & Thiết Bị Trường Học Đà Nẵng', N'78 Bạch Đằng, Q. Hải Châu, Tp. Đà Nẵng', N'08.8252379')
INSERT [dbo].[DoiTac] ([MaDT], [TenDT], [DiaChi], [SDT]) VALUES (N'CC012', N'Công Ty Cổ Phần Dịch Vụ Xuất Bản Giáo Dục Hà Nội', N'Tầng 4 Tòa Nhà Diamond Flower Tower 48 Lê Văn Lương, P. Nhân Chính, Q. Thanh Xuân Hà Nội', N'08.8252366')
INSERT [dbo].[DoiTac] ([MaDT], [TenDT], [DiaChi], [SDT]) VALUES (N'CC013', N'Cty 2 thành viên duy nhất trên thế giới', N'Đà Lạt Hills', N'1900123456')
INSERT [dbo].[DoiTac] ([MaDT], [TenDT], [DiaChi], [SDT]) VALUES (N'K0001', N'Nguyễn Minh Hải', N'91 Nguyễn Văn Trỗi Tp. Đà Lạt', N'063.831129')
INSERT [dbo].[DoiTac] ([MaDT], [TenDT], [DiaChi], [SDT]) VALUES (N'K0002', N'Như Quỳnh', N'21 Điện Biên Phủ. N.Trang', N'058.590270')
INSERT [dbo].[DoiTac] ([MaDT], [TenDT], [DiaChi], [SDT]) VALUES (N'K0003', N'Trần Nhật Duật', N'Lê Lợi TP. Huế', N'054.848376')
INSERT [dbo].[DoiTac] ([MaDT], [TenDT], [DiaChi], [SDT]) VALUES (N'K0004', N'Phan Nguyễn Hùng Anh', N'11 Nam Kỳ Khởi nghĩa- TP. Đà lạt', N'063.823409')
GO
SET IDENTITY_INSERT [dbo].[HoaDon] ON 

INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (2, N'admin', CAST(N'2022-04-01T06:44:00.000' AS DateTime), N'K0003', N'XBill', 10000, 165000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (3, N'admin', CAST(N'2022-04-02T14:43:00.000' AS DateTime), N'K0002', N'XBill', 16000, 220000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (4, N'admin', CAST(N'2022-04-02T07:46:00.000' AS DateTime), N'CC002', N'NBill', 0, 100000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (5, N'admin', CAST(N'2022-04-03T20:28:00.000' AS DateTime), N'K0001', N'XBill', 0, 92000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (6, N'admin', CAST(N'2022-04-04T18:26:00.000' AS DateTime), N'K0004', N'XBill', 1000, 125000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (7, N'admin', CAST(N'2022-04-05T06:21:00.000' AS DateTime), N'K0001', N'XBill', 10000, 185000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (8, N'admin', CAST(N'2022-04-06T12:42:00.000' AS DateTime), N'K0002', N'XBill', 0, 109000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (9, N'admin', CAST(N'2022-04-08T21:45:00.000' AS DateTime), N'K0002', N'XBill', 0, 150000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (10, N'admin', CAST(N'2022-04-09T16:26:00.000' AS DateTime), N'CC008', N'NBill', 0, 250000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (11, N'admin', CAST(N'2022-04-09T18:26:00.000' AS DateTime), N'K0004', N'XBill', 10000, 230000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (12, N'admin', CAST(N'2022-04-10T06:39:00.000' AS DateTime), N'K0003', N'XBill', 0, 110000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (13, N'admin', CAST(N'2022-04-11T12:49:00.000' AS DateTime), N'K0002', N'XBill', 0, 130000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (14, N'admin', CAST(N'2022-04-12T14:06:00.000' AS DateTime), N'K0001', N'XBill', 0, 70000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (15, N'admin', CAST(N'2022-04-13T22:09:00.000' AS DateTime), N'K0002', N'XBill', 0, 1400000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (16, N'admin', CAST(N'2022-04-14T15:46:00.000' AS DateTime), N'K0002', N'XBill', 10000, 260000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (17, N'admin', CAST(N'2022-04-15T11:33:00.000' AS DateTime), N'K0003', N'XBill', 20000, 270000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (18, N'admin', CAST(N'2022-04-16T09:41:00.000' AS DateTime), N'K0002', N'XBill', 0, 390000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (19, N'admin', CAST(N'2022-04-16T20:21:00.000' AS DateTime), N'CC007', N'NBill', 0, 200000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (20, N'admin', CAST(N'2022-04-17T18:19:00.000' AS DateTime), N'K0004', N'XBill', 25000, 120000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (21, N'admin', CAST(N'2022-04-18T08:22:00.000' AS DateTime), N'K0003', N'XBill', 10000, 190000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (22, N'admin', CAST(N'2022-04-19T17:45:00.000' AS DateTime), N'K0003', N'XBill', 0, 220000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (23, N'admin', CAST(N'2022-04-20T13:13:00.000' AS DateTime), N'K0003', N'XBill', 10000, 390000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (24, N'admin', CAST(N'2022-04-21T19:48:00.000' AS DateTime), N'K0003', N'XBill', 15000, 165000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (25, N'admin', CAST(N'2022-04-23T10:47:00.000' AS DateTime), N'CC002', N'NBill', 0, 170000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (26, N'admin', CAST(N'2022-04-23T16:50:00.000' AS DateTime), N'K0003', N'XBill', 0, 170000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (27, N'admin', CAST(N'2022-04-24T21:27:00.000' AS DateTime), N'K0004', N'XBill', 20000, 160000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (28, N'admin', CAST(N'2022-04-25T06:54:00.000' AS DateTime), N'K0003', N'XBill', 10000, 120000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (29, N'admin', CAST(N'2022-04-26T12:44:00.000' AS DateTime), N'K0003', N'XBill', 0, 180000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (30, N'admin', CAST(N'2022-04-27T14:46:00.000' AS DateTime), N'K0003', N'XBill', 5000, 115000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (31, N'admin', CAST(N'2022-04-28T17:45:00.000' AS DateTime), N'K0003', N'XBill', 0, 240000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (32, N'admin', CAST(N'2022-04-29T06:50:00.000' AS DateTime), N'K0002', N'XBill', 0, 200000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (33, N'admin', CAST(N'2022-04-30T16:17:00.000' AS DateTime), N'K0003', N'XBill', 0, 55000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (34, N'admin', CAST(N'2022-04-30T20:22:00.000' AS DateTime), N'CC001', N'NBill', 0, 180000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (35, N'admin', CAST(N'2022-05-01T17:46:00.000' AS DateTime), N'K0001', N'XBill', 20000, 155000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (36, N'admin', CAST(N'2022-05-02T22:43:00.000' AS DateTime), N'K0004', N'XBill', 26000, 210000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (37, N'admin', CAST(N'2022-05-03T07:46:00.000' AS DateTime), N'CC001', N'NBill', 0, 100000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (38, N'S0001', CAST(N'2022-05-03T20:28:00.000' AS DateTime), N'K0001', N'XBill', 0, 195000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (39, N'admin', CAST(N'2022-05-05T18:26:00.000' AS DateTime), N'K0004', N'XBill', 1000, 125000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (40, N'admin', CAST(N'2022-05-06T06:21:00.000' AS DateTime), N'K0001', N'XBill', 10000, 185000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (41, N'admin', CAST(N'2022-05-07T12:42:00.000' AS DateTime), N'K0002', N'XBill', 0, 109000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (42, N'admin', CAST(N'2022-05-08T21:45:00.000' AS DateTime), N'K0002', N'XBill', 0, 150000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (43, N'admin', CAST(N'2022-05-09T16:26:00.000' AS DateTime), N'CC008', N'XBill', 0, 250000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (44, N'admin', CAST(N'2022-05-10T18:26:00.000' AS DateTime), N'K0004', N'XBill', 0, 250000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (45, N'admin', CAST(N'2022-05-10T06:39:00.000' AS DateTime), N'K0003', N'XBill', 0, 110000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (46, N'admin', CAST(N'2022-05-11T12:49:00.000' AS DateTime), N'K0002', N'XBill', 0, 130000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (47, N'admin', CAST(N'2022-05-12T14:06:00.000' AS DateTime), N'K0001', N'XBill', 0, 70000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (48, N'admin', CAST(N'2022-05-13T15:26:00.000' AS DateTime), N'K0002', N'XBill', 0, 1400000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (49, N'admin', CAST(N'2022-05-14T15:46:00.000' AS DateTime), N'K0002', N'XBill', 10000, 260000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (50, N'admin', CAST(N'2022-05-15T11:33:00.000' AS DateTime), N'K0003', N'XBill', 20000, 270000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (51, N'admin', CAST(N'2022-05-16T09:41:00.000' AS DateTime), N'K0002', N'XBill', 0, 390000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (52, N'admin', CAST(N'2022-05-17T20:21:00.000' AS DateTime), N'CC007', N'NBill', 0, 200000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (53, N'admin', CAST(N'2022-05-17T18:19:00.000' AS DateTime), N'K0004', N'XBill', 25000, 120000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (54, N'admin', CAST(N'2022-05-18T08:22:00.000' AS DateTime), N'K0003', N'XBill', 10000, 190000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (55, N'admin', CAST(N'2022-05-19T17:45:00.000' AS DateTime), N'K0003', N'XBill', 0, 220000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (56, N'admin', CAST(N'2022-05-20T13:13:00.000' AS DateTime), N'K0003', N'XBill', 10000, 390000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (57, N'admin', CAST(N'2022-05-21T19:48:00.000' AS DateTime), N'K0003', N'XBill', 15000, 165000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (58, N'admin', CAST(N'2022-05-22T20:47:00.000' AS DateTime), N'CC002', N'XBill', 0, 170000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (59, N'admin', CAST(N'2022-05-23T16:50:00.000' AS DateTime), N'K0003', N'XBill', 0, 170000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (60, N'admin', CAST(N'2022-05-24T20:27:00.000' AS DateTime), N'K0004', N'NBill', 20000, 160000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (61, N'admin', CAST(N'2022-05-24T06:54:00.000' AS DateTime), N'K0003', N'XBill', 10000, 120000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (62, N'admin', CAST(N'2022-05-26T12:44:00.000' AS DateTime), N'K0003', N'XBill', 0, 180000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (63, N'admin', CAST(N'2022-05-27T14:46:00.000' AS DateTime), N'K0003', N'XBill', 5000, 115000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (64, N'admin', CAST(N'2022-05-28T17:45:00.000' AS DateTime), N'K0003', N'XBill', 0, 240000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (65, N'admin', CAST(N'2022-05-29T06:50:00.000' AS DateTime), N'K0002', N'XBill', 0, 200000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (66, N'admin', CAST(N'2022-05-30T16:17:00.000' AS DateTime), N'K0003', N'XBill', 0, 55000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (67, N'admin', CAST(N'2022-05-30T20:22:00.000' AS DateTime), N'CC001', N'NBill', 0, 180000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (68, N'admin', CAST(N'2022-05-31T20:22:00.000' AS DateTime), N'CC001', N'XBill', 0, 140000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (69, N'admin', CAST(N'2022-05-31T20:22:00.000' AS DateTime), N'CC002', N'NBill', 0, 260000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (70, N'admin', CAST(N'2022-04-01T06:44:00.000' AS DateTime), N'K0003', N'XBill', 10000, 165000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (71, N'admin', CAST(N'2022-04-02T14:43:00.000' AS DateTime), N'K0002', N'XBill', 16000, 220000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (72, N'admin', CAST(N'2022-04-02T07:46:00.000' AS DateTime), N'CC002', N'NBill', 0, 100000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (73, N'admin', CAST(N'2022-04-03T20:28:00.000' AS DateTime), N'K0001', N'XBill', 0, 92000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (74, N'admin', CAST(N'2022-04-04T18:26:00.000' AS DateTime), N'K0004', N'XBill', 1000, 125000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (75, N'admin', CAST(N'2022-04-05T06:21:00.000' AS DateTime), N'K0001', N'XBill', 10000, 185000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (76, N'admin', CAST(N'2022-04-06T12:42:00.000' AS DateTime), N'K0002', N'XBill', 0, 109000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (77, N'admin', CAST(N'2022-04-08T21:45:00.000' AS DateTime), N'K0002', N'XBill', 0, 150000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (78, N'admin', CAST(N'2022-04-09T16:26:00.000' AS DateTime), N'CC008', N'NBill', 0, 250000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (79, N'admin', CAST(N'2022-04-09T18:26:00.000' AS DateTime), N'K0004', N'XBill', 10000, 230000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (80, N'admin', CAST(N'2022-04-10T06:39:00.000' AS DateTime), N'K0003', N'XBill', 0, 110000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (81, N'admin', CAST(N'2022-04-11T12:49:00.000' AS DateTime), N'K0002', N'XBill', 0, 130000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (82, N'admin', CAST(N'2022-04-12T14:06:00.000' AS DateTime), N'K0001', N'XBill', 0, 70000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (83, N'admin', CAST(N'2022-04-13T15:26:00.000' AS DateTime), N'K0002', N'XBill', 0, 1400000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (84, N'admin', CAST(N'2022-04-14T15:46:00.000' AS DateTime), N'K0002', N'XBill', 10000, 260000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (85, N'admin', CAST(N'2022-04-15T11:33:00.000' AS DateTime), N'K0003', N'XBill', 20000, 270000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (86, N'admin', CAST(N'2022-04-16T09:41:00.000' AS DateTime), N'K0002', N'XBill', 0, 390000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (87, N'admin', CAST(N'2022-04-16T20:21:00.000' AS DateTime), N'CC007', N'NBill', 0, 200000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (88, N'admin', CAST(N'2022-04-17T18:19:00.000' AS DateTime), N'K0004', N'XBill', 25000, 120000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (89, N'admin', CAST(N'2022-04-18T08:22:00.000' AS DateTime), N'K0003', N'XBill', 10000, 190000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (90, N'admin', CAST(N'2022-04-19T17:45:00.000' AS DateTime), N'K0003', N'XBill', 0, 220000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (91, N'admin', CAST(N'2022-04-20T13:13:00.000' AS DateTime), N'K0003', N'XBill', 10000, 390000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (92, N'admin', CAST(N'2022-04-21T19:48:00.000' AS DateTime), N'K0003', N'XBill', 15000, 165000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (93, N'admin', CAST(N'2022-04-23T10:47:00.000' AS DateTime), N'CC002', N'NBill', 0, 170000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (94, N'admin', CAST(N'2022-04-23T16:50:00.000' AS DateTime), N'K0003', N'XBill', 0, 170000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (95, N'admin', CAST(N'2022-04-24T21:27:00.000' AS DateTime), N'K0004', N'XBill', 20000, 160000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (96, N'admin', CAST(N'2022-04-25T06:54:00.000' AS DateTime), N'K0003', N'XBill', 10000, 120000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (97, N'admin', CAST(N'2022-04-26T12:44:00.000' AS DateTime), N'K0003', N'XBill', 0, 180000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (98, N'admin', CAST(N'2022-04-27T14:46:00.000' AS DateTime), N'K0003', N'XBill', 5000, 115000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (99, N'admin', CAST(N'2022-04-28T17:45:00.000' AS DateTime), N'K0003', N'XBill', 0, 240000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (100, N'admin', CAST(N'2022-04-29T06:50:00.000' AS DateTime), N'K0002', N'XBill', 0, 200000, 1)
GO
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (101, N'admin', CAST(N'2022-04-30T16:17:00.000' AS DateTime), N'K0003', N'XBill', 0, 55000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (102, N'admin', CAST(N'2022-04-30T20:22:00.000' AS DateTime), N'CC001', N'NBill', 0, 180000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (103, N'admin', CAST(N'2022-05-01T17:46:00.000' AS DateTime), N'K0001', N'XBill', 20000, 155000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (104, N'admin', CAST(N'2022-05-02T22:43:00.000' AS DateTime), N'K0004', N'XBill', 26000, 210000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (105, N'admin', CAST(N'2022-05-03T07:46:00.000' AS DateTime), N'CC001', N'NBill', 0, 100000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (106, N'admin', CAST(N'2022-05-03T20:28:00.000' AS DateTime), N'K0001', N'XBill', 0, 92000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (107, N'admin', CAST(N'2022-05-05T18:26:00.000' AS DateTime), N'K0004', N'XBill', 1000, 125000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (108, N'admin', CAST(N'2022-05-06T06:21:00.000' AS DateTime), N'K0001', N'XBill', 10000, 185000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (109, N'admin', CAST(N'2022-05-07T12:42:00.000' AS DateTime), N'K0002', N'XBill', 0, 109000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (110, N'admin', CAST(N'2022-05-08T21:45:00.000' AS DateTime), N'K0002', N'XBill', 0, 150000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (111, N'admin', CAST(N'2022-05-09T16:26:00.000' AS DateTime), N'CC008', N'XBill', 0, 250000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (112, N'admin', CAST(N'2022-05-10T18:26:00.000' AS DateTime), N'K0004', N'XBill', 0, 250000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (113, N'admin', CAST(N'2022-05-10T06:39:00.000' AS DateTime), N'K0003', N'XBill', 0, 110000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (114, N'admin', CAST(N'2022-05-11T12:49:00.000' AS DateTime), N'K0002', N'XBill', 0, 130000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (115, N'admin', CAST(N'2022-05-12T14:06:00.000' AS DateTime), N'K0001', N'XBill', 0, 70000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (116, N'admin', CAST(N'2022-05-13T15:26:00.000' AS DateTime), N'K0002', N'XBill', 0, 1400000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (117, N'admin', CAST(N'2022-05-14T15:46:00.000' AS DateTime), N'K0002', N'XBill', 10000, 260000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (118, N'admin', CAST(N'2022-05-15T11:33:00.000' AS DateTime), N'K0003', N'XBill', 20000, 270000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (119, N'admin', CAST(N'2022-05-16T09:41:00.000' AS DateTime), N'K0002', N'XBill', 0, 390000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (120, N'admin', CAST(N'2022-05-17T20:21:00.000' AS DateTime), N'CC007', N'NBill', 0, 200000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (121, N'admin', CAST(N'2022-05-17T18:19:00.000' AS DateTime), N'K0004', N'XBill', 25000, 120000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (122, N'admin', CAST(N'2022-05-18T08:22:00.000' AS DateTime), N'K0003', N'XBill', 10000, 190000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (123, N'admin', CAST(N'2022-05-19T17:45:00.000' AS DateTime), N'K0003', N'XBill', 0, 220000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (124, N'admin', CAST(N'2022-05-20T13:13:00.000' AS DateTime), N'K0003', N'XBill', 10000, 390000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (125, N'admin', CAST(N'2022-05-21T19:48:00.000' AS DateTime), N'K0003', N'XBill', 15000, 165000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (126, N'admin', CAST(N'2022-05-22T20:47:00.000' AS DateTime), N'CC002', N'XBill', 0, 170000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (127, N'admin', CAST(N'2022-05-23T16:50:00.000' AS DateTime), N'K0003', N'XBill', 0, 170000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (128, N'admin', CAST(N'2022-05-24T20:27:00.000' AS DateTime), N'K0004', N'NBill', 20000, 160000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (129, N'admin', CAST(N'2022-05-24T06:54:00.000' AS DateTime), N'K0003', N'XBill', 10000, 120000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (130, N'admin', CAST(N'2022-05-26T12:44:00.000' AS DateTime), N'K0003', N'XBill', 0, 180000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (131, N'admin', CAST(N'2022-05-27T14:46:00.000' AS DateTime), N'K0003', N'XBill', 5000, 115000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (132, N'admin', CAST(N'2022-05-28T17:45:00.000' AS DateTime), N'K0003', N'XBill', 0, 240000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (133, N'admin', CAST(N'2022-05-29T06:50:00.000' AS DateTime), N'K0002', N'XBill', 0, 200000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (134, N'admin', CAST(N'2022-05-30T16:17:00.000' AS DateTime), N'K0003', N'XBill', 0, 55000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (135, N'admin', CAST(N'2022-05-30T20:22:00.000' AS DateTime), N'CC001', N'NBill', 0, 180000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (136, N'admin', CAST(N'2022-05-31T20:22:00.000' AS DateTime), N'CC001', N'XBill', 0, 140000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (137, N'admin', CAST(N'2022-05-31T20:22:00.000' AS DateTime), N'CC002', N'NBill', 0, 260000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (138, N'admin', CAST(N'2022-04-01T06:44:00.000' AS DateTime), N'K0003', N'XBill', 10000, 165000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (139, N'admin', CAST(N'2022-04-02T14:43:00.000' AS DateTime), N'K0002', N'XBill', 16000, 220000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (140, N'admin', CAST(N'2022-04-02T07:46:00.000' AS DateTime), N'CC002', N'NBill', 0, 100000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (141, N'admin', CAST(N'2022-04-03T20:28:00.000' AS DateTime), N'K0001', N'XBill', 0, 92000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (142, N'admin', CAST(N'2022-04-04T18:26:00.000' AS DateTime), N'K0004', N'XBill', 1000, 125000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (143, N'admin', CAST(N'2022-04-05T06:21:00.000' AS DateTime), N'K0001', N'XBill', 10000, 185000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (144, N'admin', CAST(N'2022-04-06T12:42:00.000' AS DateTime), N'K0002', N'XBill', 0, 109000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (145, N'admin', CAST(N'2022-04-08T21:45:00.000' AS DateTime), N'K0002', N'XBill', 0, 150000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (146, N'admin', CAST(N'2022-04-09T16:26:00.000' AS DateTime), N'CC008', N'NBill', 0, 250000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (147, N'admin', CAST(N'2022-04-09T18:26:00.000' AS DateTime), N'K0004', N'XBill', 10000, 230000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (148, N'admin', CAST(N'2022-04-10T06:39:00.000' AS DateTime), N'K0003', N'XBill', 0, 110000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (149, N'admin', CAST(N'2022-04-11T12:49:00.000' AS DateTime), N'K0002', N'XBill', 0, 130000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (150, N'admin', CAST(N'2022-04-12T14:06:00.000' AS DateTime), N'K0001', N'XBill', 0, 70000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (151, N'admin', CAST(N'2022-04-13T15:26:00.000' AS DateTime), N'K0002', N'XBill', 0, 1400000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (152, N'admin', CAST(N'2022-04-14T15:46:00.000' AS DateTime), N'K0002', N'XBill', 10000, 260000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (153, N'admin', CAST(N'2022-04-15T11:33:00.000' AS DateTime), N'K0003', N'XBill', 20000, 270000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (154, N'admin', CAST(N'2022-04-16T09:41:00.000' AS DateTime), N'K0002', N'XBill', 0, 390000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (155, N'admin', CAST(N'2022-04-16T20:21:00.000' AS DateTime), N'CC007', N'NBill', 0, 200000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (156, N'admin', CAST(N'2022-04-17T18:19:00.000' AS DateTime), N'K0004', N'XBill', 25000, 120000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (157, N'admin', CAST(N'2022-04-18T08:22:00.000' AS DateTime), N'K0003', N'XBill', 10000, 190000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (158, N'admin', CAST(N'2022-04-19T17:45:00.000' AS DateTime), N'K0003', N'XBill', 0, 220000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (159, N'admin', CAST(N'2022-04-20T13:13:00.000' AS DateTime), N'K0003', N'XBill', 10000, 390000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (160, N'admin', CAST(N'2022-04-21T19:48:00.000' AS DateTime), N'K0003', N'XBill', 15000, 165000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (161, N'admin', CAST(N'2022-04-23T10:47:00.000' AS DateTime), N'CC002', N'NBill', 0, 170000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (162, N'admin', CAST(N'2022-04-23T16:50:00.000' AS DateTime), N'K0003', N'XBill', 0, 170000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (163, N'admin', CAST(N'2022-04-24T21:27:00.000' AS DateTime), N'K0004', N'XBill', 20000, 160000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (164, N'admin', CAST(N'2022-04-25T06:54:00.000' AS DateTime), N'K0003', N'XBill', 10000, 120000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (165, N'admin', CAST(N'2022-04-26T12:44:00.000' AS DateTime), N'K0003', N'XBill', 0, 180000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (166, N'admin', CAST(N'2022-04-27T14:46:00.000' AS DateTime), N'K0003', N'XBill', 5000, 115000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (167, N'admin', CAST(N'2022-04-28T17:45:00.000' AS DateTime), N'K0003', N'XBill', 0, 240000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (168, N'admin', CAST(N'2022-04-29T06:50:00.000' AS DateTime), N'K0002', N'XBill', 0, 200000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (169, N'admin', CAST(N'2022-04-30T16:17:00.000' AS DateTime), N'K0003', N'XBill', 0, 55000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (170, N'admin', CAST(N'2022-04-30T20:22:00.000' AS DateTime), N'CC001', N'NBill', 0, 180000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (171, N'admin', CAST(N'2022-05-01T17:46:00.000' AS DateTime), N'K0001', N'XBill', 20000, 155000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (172, N'admin', CAST(N'2022-05-02T22:43:00.000' AS DateTime), N'K0004', N'XBill', 26000, 210000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (173, N'admin', CAST(N'2022-05-03T07:46:00.000' AS DateTime), N'CC001', N'NBill', 0, 100000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (174, N'admin', CAST(N'2022-05-03T20:28:00.000' AS DateTime), N'K0001', N'XBill', 0, 92000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (175, N'admin', CAST(N'2022-05-05T18:26:00.000' AS DateTime), N'K0004', N'XBill', 1000, 125000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (176, N'admin', CAST(N'2022-05-06T06:21:00.000' AS DateTime), N'K0001', N'XBill', 10000, 185000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (177, N'admin', CAST(N'2022-05-07T12:42:00.000' AS DateTime), N'K0002', N'XBill', 0, 109000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (178, N'admin', CAST(N'2022-05-08T21:45:00.000' AS DateTime), N'K0002', N'XBill', 0, 150000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (179, N'admin', CAST(N'2022-05-09T16:26:00.000' AS DateTime), N'CC008', N'XBill', 0, 250000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (180, N'admin', CAST(N'2022-05-10T18:26:00.000' AS DateTime), N'K0004', N'XBill', 0, 250000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (181, N'admin', CAST(N'2022-05-10T06:39:00.000' AS DateTime), N'K0003', N'XBill', 0, 110000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (182, N'admin', CAST(N'2022-05-11T12:49:00.000' AS DateTime), N'K0002', N'XBill', 0, 130000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (183, N'admin', CAST(N'2022-05-12T14:06:00.000' AS DateTime), N'K0001', N'XBill', 0, 70000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (184, N'admin', CAST(N'2022-05-13T15:26:00.000' AS DateTime), N'K0002', N'XBill', 0, 1400000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (185, N'admin', CAST(N'2022-05-14T15:46:00.000' AS DateTime), N'K0002', N'XBill', 10000, 260000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (186, N'admin', CAST(N'2022-05-15T11:33:00.000' AS DateTime), N'K0003', N'XBill', 20000, 270000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (187, N'admin', CAST(N'2022-05-16T09:41:00.000' AS DateTime), N'K0002', N'XBill', 0, 390000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (188, N'admin', CAST(N'2022-05-17T20:21:00.000' AS DateTime), N'CC007', N'NBill', 0, 200000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (189, N'admin', CAST(N'2022-05-17T18:19:00.000' AS DateTime), N'K0004', N'XBill', 25000, 120000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (190, N'admin', CAST(N'2022-05-18T08:22:00.000' AS DateTime), N'K0003', N'XBill', 10000, 190000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (191, N'admin', CAST(N'2022-05-19T17:45:00.000' AS DateTime), N'K0003', N'XBill', 0, 220000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (192, N'admin', CAST(N'2022-05-20T13:13:00.000' AS DateTime), N'K0003', N'XBill', 10000, 390000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (193, N'admin', CAST(N'2022-05-21T19:48:00.000' AS DateTime), N'K0003', N'XBill', 15000, 165000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (194, N'admin', CAST(N'2022-05-22T20:47:00.000' AS DateTime), N'CC002', N'XBill', 0, 170000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (195, N'admin', CAST(N'2022-05-23T16:50:00.000' AS DateTime), N'K0003', N'XBill', 0, 170000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (196, N'admin', CAST(N'2022-05-24T20:27:00.000' AS DateTime), N'K0004', N'NBill', 20000, 160000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (197, N'admin', CAST(N'2022-05-24T06:54:00.000' AS DateTime), N'K0003', N'XBill', 10000, 120000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (198, N'admin', CAST(N'2022-05-26T12:44:00.000' AS DateTime), N'K0003', N'XBill', 0, 180000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (199, N'admin', CAST(N'2022-05-27T14:46:00.000' AS DateTime), N'K0003', N'XBill', 5000, 115000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (200, N'admin', CAST(N'2022-05-28T17:45:00.000' AS DateTime), N'K0003', N'XBill', 0, 240000, 1)
GO
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (201, N'admin', CAST(N'2022-05-29T06:50:00.000' AS DateTime), N'K0002', N'XBill', 0, 200000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (202, N'admin', CAST(N'2022-05-30T16:17:00.000' AS DateTime), N'K0003', N'XBill', 0, 55000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (203, N'admin', CAST(N'2022-05-30T20:22:00.000' AS DateTime), N'CC001', N'NBill', 0, 180000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (204, N'admin', CAST(N'2022-05-31T20:22:00.000' AS DateTime), N'CC001', N'XBill', 0, 140000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (205, N'admin', CAST(N'2022-05-31T20:22:00.000' AS DateTime), N'CC002', N'NBill', 0, 260000, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (206, N'admin', CAST(N'2022-04-27T21:33:40.000' AS DateTime), N'K0003', N'XBill', 0, 224170, 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NguoiBan], [NgayGiaoDich], [MaDT], [LoaiHoaDon], [GiamGia], [TongTien], [Status]) VALUES (207, N'S0001', CAST(N'2022-05-16T21:58:45.543' AS DateTime), N'K0001', N'XBill', 0, 324885, 1)
SET IDENTITY_INSERT [dbo].[HoaDon] OFF
GO
INSERT [dbo].[LoaiHoaDon] ([MaLoaiHD], [TenLoaiHD]) VALUES (N'XBill', N'Hóa đơn bán hàng')
INSERT [dbo].[LoaiHoaDon] ([MaLoaiHD], [TenLoaiHD]) VALUES (N'NBill', N'Hóa đơn nhập hàng')
GO
INSERT [dbo].[Sach] ([MaSP], [TacGia], [NamXB], [NhaXB]) VALUES (1, N'Mặc Hương Đồng Khứu ', N'2003 ', N'NXB Kinh tế thành phố Hồ Chí Minh')
INSERT [dbo].[Sach] ([MaSP], [TacGia], [NamXB], [NhaXB]) VALUES (2, N'Nguyễn Nhật Ánh', N'2022 ', N'Nhà Xuất Bản Kim Đồng')
INSERT [dbo].[Sach] ([MaSP], [TacGia], [NamXB], [NhaXB]) VALUES (3, N'Nguyễn Nhật Ánh ', N'2022 ', N'Nhà Xuất Bản Kim Đồng')
INSERT [dbo].[Sach] ([MaSP], [TacGia], [NamXB], [NhaXB]) VALUES (4, N'Trang Hạ ', N'2022 ', N'Nhà Xuất Bản Kim Đồng')
INSERT [dbo].[Sach] ([MaSP], [TacGia], [NamXB], [NhaXB]) VALUES (5, N'Nguyễn Phong Việt ', N'2022 ', N'Nhà Xuất Bản Kim Đồng')
INSERT [dbo].[Sach] ([MaSP], [TacGia], [NamXB], [NhaXB]) VALUES (6, N'Anh Khang ', N'2021 ', N'NXB Hội Nhà Văn')
INSERT [dbo].[Sach] ([MaSP], [TacGia], [NamXB], [NhaXB]) VALUES (7, N'Nguyễn Ngọc Thạch', N'2021 ', N'NXB Hội Nhà Văn')
INSERT [dbo].[Sach] ([MaSP], [TacGia], [NamXB], [NhaXB]) VALUES (8, N'Nguyễn Ngọc Thạch', N'2017 ', N'NXB Hội Nhà Văn')
INSERT [dbo].[Sach] ([MaSP], [TacGia], [NamXB], [NhaXB]) VALUES (9, N'Hamlet Trương', N'2017 ', N'	NXB Văn Học')
INSERT [dbo].[Sach] ([MaSP], [TacGia], [NamXB], [NhaXB]) VALUES (10, N'Đỗ Nhật Nam', N'2022 ', N'NXB Văn Học')
INSERT [dbo].[Sach] ([MaSP], [TacGia], [NamXB], [NhaXB]) VALUES (11, N'Diệp Lạc Vô Tâm ', N'2022 ', N'NXB Văn Học')
INSERT [dbo].[Sach] ([MaSP], [TacGia], [NamXB], [NhaXB]) VALUES (12, N'Tâm Di Ổ', N'2021 ', N'NXB Mỹ Thuật')
INSERT [dbo].[Sach] ([MaSP], [TacGia], [NamXB], [NhaXB]) VALUES (13, N'Cố Mạn ', N'2021 ', N'NXB Đại Học Sư Phạm')
INSERT [dbo].[Sach] ([MaSP], [TacGia], [NamXB], [NhaXB]) VALUES (14, N'Cửu Lộ Phi Hương', N'2020 ', N'NXB Mỹ Thuật')
INSERT [dbo].[Sach] ([MaSP], [TacGia], [NamXB], [NhaXB]) VALUES (15, N'Nguyễn Ngọc Sơn', N'2019 ', N'NXB Mỹ Thuật')
INSERT [dbo].[Sach] ([MaSP], [TacGia], [NamXB], [NhaXB]) VALUES (16, N'Chu Ngọc', N'2020 ', N'NXB Lao Động')
INSERT [dbo].[Sach] ([MaSP], [TacGia], [NamXB], [NhaXB]) VALUES (17, N'Diệp Tử', N'2022 ', N'NXB Thanh Niên')
INSERT [dbo].[Sach] ([MaSP], [TacGia], [NamXB], [NhaXB]) VALUES (18, N'Ân Tầm', N'2019 ', N'NXB Kinh tế thành phố Hồ Chí Minh')
INSERT [dbo].[Sach] ([MaSP], [TacGia], [NamXB], [NhaXB]) VALUES (19, N'Tiên Chanh', N'2017 ', N'NXB Kinh tế thành phố Hồ Chí Minh')
INSERT [dbo].[Sach] ([MaSP], [TacGia], [NamXB], [NhaXB]) VALUES (20, N'Đường Thất Công Tử', N'2017 ', N'NXB Thông Tấn')
INSERT [dbo].[Sach] ([MaSP], [TacGia], [NamXB], [NhaXB]) VALUES (62, N'Thêm thử', N'2002', N'Thêm thử')
GO
SET IDENTITY_INSERT [dbo].[SanPham] ON 

INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (1, N'Truyện Ngôn Tình Con Chim Và Đàn Lợn', N'Quyển', 252153, 474, N'FAHASA', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (2, N'Sách Tập Viết Lớp 1', N'Bộ', 208430, 343, N'Giáo Dục', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (3, N'Truyện Tranh Cho Người Già ', N'Quyển', 80852, 4736, N'Nhã Nam', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (4, N'Hai Số Phận - Bìa Cứng', N'Quyển', 288653, 45, N'AZ Việt Nam', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (5, N'Bước Chậm Lại Giữa Thế Gian Vội Vã (Tái Bản 2018)', N'Quyển', 21962, 736, N'New Shop', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (6, N'Lá Nằm Trong Lá - Tái Bản 2022', N'Quyển', 131589, 64, N'Minh Long Book', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (7, N'Loạn 12 Sứ Quân - Tập 3: Hoa Lư Anh Hùng Tụ Nghĩa + Tập 4: Khói Lửa Kinh Kỳ (1 Cuốn)', N'Quyển', 163181, 72, N'Nhân Văn', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (8, N'Ngày Tháng Năm', N'Quyển', 136534, 27, N'1980 Books', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (9, N'Thay Đổi Cuộc Sống Với Nhân Số Học', N'Quyển', 209237, 45, N'ALPHABOOKS', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (10, N'Rèn Luyện Tư Duy Phản Biện', N'Quyển', 124502, 51215, N'BIZBOOKS', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (11, N'Chủ Nghĩa Khắc Kỷ - Phong Cách Sống Bản Lĩnh Và Bình Thản', N'Quyển', 217811, 72, N'Thái Hà Books', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (12, N'Giành Phiếu Bầu Bằng Mọi Giá', N'Quyển', 237215, 7368, N'Trí Việt', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (13, N'Con Tàu Ma Của Thế Chiến II', N'Quyển', 265249, 43, N'Tân Việt', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (14, N'Giới Tinh Hoa Quyền Lực', N'Quyển', 225527, 7273, N'Nhà sách Minh Thắng', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (15, N'Gia Tộc Morgan', N'Quyển', 127749, 3756, N'MCBOOKS', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (16, N'Titan - Gia tộc Rockefeller', N'Quyển', 109463, 736, N'IPM Việt Nam', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (17, N'Elon Musk - Đặt Cả Thế Giới Lên Bốn Bánh Xe Điện', N'Quyển', 92090, 1994, N'SkyBooks', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (18, N'Chấn Hưng Nhật Bản', N'Quyển', 61257, 736859, N'Khang Việt', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (19, N'Developing Skills For The Toeic Test', N'Quyển', 183970, 0, N'FIRST NEWS', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (20, N'Very Easy Toeic - Second Edition', N'Quyển', 97574, 673, N'FIRST NEWS', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (21, N'Bút Mực', N'Cái', 225211, 76837, N'Thiên Long', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (22, N'Bút Dạ Quang', N'Cái', 111681, 0, N'Thăng Long', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (23, N'Bút Máy Bơm Mực', N'Cái', 190675, 73, N'Thăng Long', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (24, N'Bút Mực Đỏ', N'Cái', 267565, 3464, N'Thiên Long', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (25, N'Bút Mực Trendoee', N'Cái', 246089, 0, N'Thăng Long', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (26, N'Bút Chì Vĩnh Cửu', N'Cái', 260908, 634, N'Bioples', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (27, N'Bút Gel 0.5 mm Extreme', N'Cái', 149337, 0, N'SCM', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (28, N'Hộp 48 Bút Lông Màu 2 Đầu', N'Hộp', 299031, 7368, N'Stacom', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (29, N'Bút Lông Kim 4600', N'Cái', 287057, 1986, N'Marvy', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (30, N'Bút Vẽ Kĩ Thuật Marvy 4600', N'Cái', 101140, 8630, N'Marvy', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (31, N'Bút Chì Kỹ Thuật 4B', N'Cái', 295161, 2342, N'Stacom', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (32, N'Vỉ 2 Ruột Bút Gel Xóa Được 0.5 mm', N'Cái', 250562, 0, N'Thiên Long', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (33, N'Máy Tính Cầm Tay', N'Cái', 104185, 73867, N'Casio', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (34, N'Máy Tính Casio FX-570ES PLUS NEW', N'Cái', 27540, 34, N'Casio', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (35, N'Máy Tính 8 Số Stacom EC203', N'Cái', 167413, 736, N'Stacom', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (36, N'Máy Tính Văn Phòng Casio GR-12C-LB', N'Cái', 217863, 0, N'Casio', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (37, N'Máy Tính Văn Phòng Casio DM-1400F', N'Cái', 299811, 783, N'Stacom', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (38, N'Máy Tính Casio FX580VN X-BU', N'Cái', 148134, 2, N'Casio', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (39, N'Máy Tính Casio FX-9860GIII', N'Cái', 27256, 0, N'Casio', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (40, N'Máy Tính Vinacal 680EX Plus', N'Cái', 253662, 7368, N'Casio', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (41, N'Máy Tính Văn Phòng Casio SL-300NC-BYW', N'Cái', 97084, 0, N'Casio', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (42, N'Máy Tính Văn Phòng Casio SL 310UC - PK', N'Cái', 93203, 783752, N'Casio', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (43, N'Lội - Bản Mở Rộng ', N'Bộ', 28925, 0, N'Board Game VN', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (44, N'Sổ Bìa Da Kẻ Ngang ', N'Cái', 8100, 837, N'Hải Tiến', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (45, N'Thanh Đường Đua Hot Wheels 600mm', N'Cái', 23758, 37, N'Hot Wheels', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (46, N'Đèn Bàn Siêu Sáng ', N'Cái', 112723, 254, N'XiaoFen', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (47, N'Ruột Chì 2B 0.5 mm Gold XQ 502 ', N'Cái', 167632, 6, N'OEM', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (48, N'Bài Tỷ Phú Board Game VN ', N'Bộ', 99839, 483, N'Board Game VN', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (49, N'Bộ Cờ Bóng Chuyền Haikyu!! Bộ Cờ Mở Rộng Đợt 5', N'Bộ', 8573, 74257, N'BRAIN NAVI', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (50, N'Vợt Bắt Muỗi ', N'Cái', 224728, 434, N'Cty Thu Trang', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (51, N'Đèn Sạc Siêu Cấp', N'Cái', 228672, 502, N'SupperFlash', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (52, N'Đèn Pin Năng Lượng Mặt Trời', N'Cái', 87708, 483, N'ChayNha', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (53, N'Ổ Điện', N'Cái', 4774, 86, N'Điện Quang', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (54, N'Đèn Bàn', N'Cái', 241992, 248737, N'Ya Se Craft', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (55, N'Bộ Cờ Bóng Chuyền Haikyu!! Bộ Cờ Mở Rộng Đợt 4', N'Bộ', 146986, 4483, N'BRAIN NAVI', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (56, N'Đồ Chơi Hộp Bí Mật Của Peppa', N'Bộ', 58749, 483, N'Peppa Pig', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (57, N'Quạt Điện', N'Cái', 260089, 438, N'Akifan', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (58, N'Phích Cắm', N'Cái', 106894, 56, N'Tuna', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (59, N'Hộp Bột Nặn Playdoh', N'Bộ', 58153, 483, N'Play-Doh', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (60, N'123', N'123', 123, 0, N'123', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (61, N'Chuột công thái học Delux M618G', N'Cái', 368000, 0, N'Delux', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (62, N'Thêm thử sách', N'Thêm thử', 100000, 0, N'Thêm thử', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (63, N'Thêm thử bút', N'Thêm thử', 100000, 0, N'Thêm thử', 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DVT], [Gia], [SoLuongTon], [ThuongHieu], [Cancellation]) VALUES (64, N'Thêm thử văn phòng phẩm', N'Thêm thử', 100000, 0, N'Thêm thử', 0)
SET IDENTITY_INSERT [dbo].[SanPham] OFF
GO
INSERT [dbo].[Taikhoan] ([IDAccount], [Password], [HoTen], [DiaChi], [SDT], [Active], [RoleID]) VALUES (N'admin', N'20720532132149213101239102231223249249135100218', N'Sòu đời 123', N'83 Nguyễn Công Trứ, Phường 2, TP.Đà Lạt, Lâm Đồng', N'0852987191', 1, N'admin')
INSERT [dbo].[Taikhoan] ([IDAccount], [Password], [HoTen], [DiaChi], [SDT], [Active], [RoleID]) VALUES (N'S0001', N'20720532132149213101239102231223249249135100218', N'Triệu Trọng Hậu', N'83 Nguyễn Công Trứ, Phường 2, TP Đà Lạt, Lâm Đồng', N'0852987191', 0, N'staff')
GO
INSERT [dbo].[ThietBiDienTu] ([MaSP], [MauSac], [ChatLieu], [BaoHanh], [ThongSoKiThuat]) VALUES (33, N'Đen', N'Nhựa', N'6 tháng', N'Chuyên dụng với 417 chức năng')
INSERT [dbo].[ThietBiDienTu] ([MaSP], [MauSac], [ChatLieu], [BaoHanh], [ThongSoKiThuat]) VALUES (34, N'Đỏ', N'Sắt', N'12 tháng', N'Chuyên dụng với 521 tính năng')
INSERT [dbo].[ThietBiDienTu] ([MaSP], [MauSac], [ChatLieu], [BaoHanh], [ThongSoKiThuat]) VALUES (35, N'Trắng', N'Nhựa', N'8 tháng', N'Sạc pin có thể tháo rời hay gắn liền vợt tùy ý người sử dụng')
INSERT [dbo].[ThietBiDienTu] ([MaSP], [MauSac], [ChatLieu], [BaoHanh], [ThongSoKiThuat]) VALUES (36, N'Bạc', N'Nhôm', N'2 tháng', N'Có led báo khi vợt đang hoạt động và led báo khi sạc điện.')
INSERT [dbo].[ThietBiDienTu] ([MaSP], [MauSac], [ChatLieu], [BaoHanh], [ThongSoKiThuat]) VALUES (37, N'Nâu', N'Nhựa', N'36 tháng', N'Hai chế độ ánh sáng, dễ dàng điều chỉnh độ sáng hoặc tối dần của đèn')
INSERT [dbo].[ThietBiDienTu] ([MaSP], [MauSac], [ChatLieu], [BaoHanh], [ThongSoKiThuat]) VALUES (38, N'Đỏ', N'Nhựa', N'1 năm', N'Thiết kế tay cầm nhỏ gọn, chắc chắn, rất tiện lợi')
INSERT [dbo].[ThietBiDienTu] ([MaSP], [MauSac], [ChatLieu], [BaoHanh], [ThongSoKiThuat]) VALUES (39, N'Cam', N'Nhôm', N'6 tháng', N'Thời gian thắp sáng liên tục trong 4 tiếng')
INSERT [dbo].[ThietBiDienTu] ([MaSP], [MauSac], [ChatLieu], [BaoHanh], [ThongSoKiThuat]) VALUES (40, N'Hồng', N'Nhựa', N'9 tháng', N'Mắt ổ chế tạo bằng vật liệu Polycarbonate chịu nhiệt, chống cháy')
INSERT [dbo].[ThietBiDienTu] ([MaSP], [MauSac], [ChatLieu], [BaoHanh], [ThongSoKiThuat]) VALUES (41, N'Tím', N'Nhựa', N'18 tháng', N'Công suất: 5W')
INSERT [dbo].[ThietBiDienTu] ([MaSP], [MauSac], [ChatLieu], [BaoHanh], [ThongSoKiThuat]) VALUES (42, N'Xanh Dương', N'Nhựa', N'6 tháng', N'Sạc 30 phút dùng 12 tiếng')
INSERT [dbo].[ThietBiDienTu] ([MaSP], [MauSac], [ChatLieu], [BaoHanh], [ThongSoKiThuat]) VALUES (60, N'123', N'123', N'123', N'123')
INSERT [dbo].[ThietBiDienTu] ([MaSP], [MauSac], [ChatLieu], [BaoHanh], [ThongSoKiThuat]) VALUES (61, N'Đen', N'Nhựa', N'6 tháng', N'Lưu lượng pin liên tục trong 1 tháng')
GO
INSERT [dbo].[UserRole] ([RoleID], [RoleName]) VALUES (N'staff', N'Nhân viên')
INSERT [dbo].[UserRole] ([RoleID], [RoleName]) VALUES (N'admin', N'Quản lý')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__DoiTac__4CF965621630EFB6]    Script Date: 6/5/2022 7:15:33 PM ******/
ALTER TABLE [dbo].[DoiTac] ADD UNIQUE NONCLUSTERED 
(
	[TenDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__DoiTac__CA1930A5E13EB917]    Script Date: 6/5/2022 7:15:33 PM ******/
ALTER TABLE [dbo].[DoiTac] ADD UNIQUE NONCLUSTERED 
(
	[SDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__LoaiHoaD__F435126070E9D385]    Script Date: 6/5/2022 7:15:33 PM ******/
ALTER TABLE [dbo].[LoaiHoaDon] ADD  CONSTRAINT [UQ__LoaiHoaD__F435126070E9D385] UNIQUE NONCLUSTERED 
(
	[TenLoaiHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__SanPham__4CF9DC1466DC9F69]    Script Date: 6/5/2022 7:15:33 PM ******/
ALTER TABLE [dbo].[SanPham] ADD  CONSTRAINT [UQ__SanPham__4CF9DC1466DC9F69] UNIQUE NONCLUSTERED 
(
	[TenSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__UserRole__8A2B61602B34401F]    Script Date: 6/5/2022 7:15:33 PM ******/
ALTER TABLE [dbo].[UserRole] ADD UNIQUE NONCLUSTERED 
(
	[RoleName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[HoaDon] ADD  CONSTRAINT [DF__HoaDon__NguoiBan__0169315C]  DEFAULT ('admin') FOR [NguoiBan]
GO
ALTER TABLE [dbo].[HoaDon] ADD  CONSTRAINT [DF__HoaDon__Status__45544755]  DEFAULT ((0)) FOR [Status]
GO
ALTER TABLE [dbo].[SanPham] ADD  CONSTRAINT [DF__SanPham__Gia__6B79F03D]  DEFAULT (abs(checksum(newid()))%(300.000)+(1)) FOR [Gia]
GO
ALTER TABLE [dbo].[SanPham] ADD  CONSTRAINT [df_SLT]  DEFAULT ((0)) FOR [SoLuongTon]
GO
ALTER TABLE [dbo].[SanPham] ADD  CONSTRAINT [DF__SanPham__Cancell__0A688BB1]  DEFAULT ((0)) FOR [Cancellation]
GO
ALTER TABLE [dbo].[But]  WITH CHECK ADD  CONSTRAINT [FK__But__MaSP__36B12243] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[But] CHECK CONSTRAINT [FK__But__MaSP__36B12243]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK__ChiTietHo__MaHoa__4AB81AF0] FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HoaDon] ([MaHoaDon])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK__ChiTietHo__MaHoa__4AB81AF0]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK__ChiTietHoa__MaSP__4BAC3F29] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK__ChiTietHoa__MaSP__4BAC3F29]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK__HoaDon__LoaiHoaD__44FF419A] FOREIGN KEY([LoaiHoaDon])
REFERENCES [dbo].[LoaiHoaDon] ([MaLoaiHD])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK__HoaDon__LoaiHoaD__44FF419A]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK__HoaDon__MaDT__45F365D3] FOREIGN KEY([MaDT])
REFERENCES [dbo].[DoiTac] ([MaDT])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK__HoaDon__MaDT__45F365D3]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK__HoaDon__NguoiBan__025D5595] FOREIGN KEY([NguoiBan])
REFERENCES [dbo].[Taikhoan] ([IDAccount])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK__HoaDon__NguoiBan__025D5595]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK__Sach__MaSP__33D4B598] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK__Sach__MaSP__33D4B598]
GO
ALTER TABLE [dbo].[Taikhoan]  WITH CHECK ADD  CONSTRAINT [FK__Taikhoan__RoleID__29572725] FOREIGN KEY([RoleID])
REFERENCES [dbo].[UserRole] ([RoleID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Taikhoan] CHECK CONSTRAINT [FK__Taikhoan__RoleID__29572725]
GO
ALTER TABLE [dbo].[ThietBiDienTu]  WITH CHECK ADD  CONSTRAINT [FK__ThietBiDie__MaSP__398D8EEE] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ThietBiDienTu] CHECK CONSTRAINT [FK__ThietBiDie__MaSP__398D8EEE]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD CHECK  (([SoLuong]>(0)))
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD CHECK  (([Gia]>(0)))
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [CK__HoaDon__GiamGia__4316F928] CHECK  (([GiamGia]>=(0)))
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [CK__HoaDon__GiamGia__4316F928]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [CK__HoaDon__TongTien__440B1D61] CHECK  (([TongTien]>=(0)))
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [CK__HoaDon__TongTien__440B1D61]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [CK__SanPham__SoLuong__300424B4] CHECK  (([SoLuongTon]>=(0)))
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [CK__SanPham__SoLuong__300424B4]
GO
/****** Object:  StoredProcedure [dbo].[USP_Bestseller]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_Bestseller]
@StartDate AS DATE = NULL,
@EndDate AS DATE = NULL
AS
BEGIN
	IF (@StartDate IS NOT NULL AND @EndDate IS NOT NULL)
	BEGIN
		SELECT CT.MaSP, S.TenSP, SUM(CT.SoLuong) AS SoLuong
		FROM dbo.HoaDon H JOIN dbo.ChiTietHoaDon CT
		ON CT.MaHoaDon = H.MaHoaDon
		JOIN dbo.SanPham S
		ON S.MaSP = CT.MaSP
		WHERE H.NgayGiaoDich BETWEEN @StartDate AND @EndDate
		GROUP BY CT.MaSP, S.TenSP
		HAVING SUM(CT.SoLuong) >= 
		(SELECT CAST(SUM(T.SoLuong) / COUNT(*) AS FLOAT) GiaTriTrungBinh 
		FROM (SELECT SUM(CT.SoLuong) AS SoLuong
		FROM dbo.HoaDon H JOIN dbo.ChiTietHoaDon CT
		ON CT.MaHoaDon = H.MaHoaDon
		JOIN dbo.SanPham S
		ON S.MaSP = CT.MaSP
		WHERE H.NgayGiaoDich BETWEEN @StartDate AND @EndDate
		GROUP BY CT.MaSP, S.TenSP) AS T)
	END

	IF (@StartDate IS NULL AND @EndDate IS NULL)
	BEGIN
		SELECT CT.MaSP, S.TenSP, SUM(CT.SoLuong) AS SoLuong
		FROM dbo.HoaDon H JOIN dbo.ChiTietHoaDon CT
		ON CT.MaHoaDon = H.MaHoaDon
		JOIN dbo.SanPham S
		ON S.MaSP = CT.MaSP
		GROUP BY CT.MaSP, S.TenSP
		HAVING SUM(CT.SoLuong) >= 
		(SELECT CAST(SUM(T.SoLuong) / COUNT(*) AS FLOAT) GiaTriTrungBinh 
		FROM (SELECT SUM(CT.SoLuong) AS SoLuong
		FROM dbo.HoaDon H JOIN dbo.ChiTietHoaDon CT
		ON CT.MaHoaDon = H.MaHoaDon
		JOIN dbo.SanPham S
		ON S.MaSP = CT.MaSP
		GROUP BY CT.MaSP, S.TenSP) AS T)
	END
END
GO
/****** Object:  StoredProcedure [dbo].[USP_BillRate]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_BillRate]
@StartDate AS DATE = NULL,
@EndDate AS DATE = NULL
AS
BEGIN
	DECLARE @SLHoaDonTuanNay INT
	DECLARE @SLHoaDonTuantruoc INT
	DECLARE @TiLe FLOAT
	DECLARE @TongHoaDon FLOAT
	DECLARE @RatioOnTotal FLOAT

	IF (@StartDate IS NOT NULL AND @EndDate IS NOT NULL)
	BEGIN
		DECLARE @DiffDate INT

		SELECT @DiffDate = (DATEDIFF(DAY, @StartDate, @EndDate) + 1) * -1

	    SELECT @SLHoaDonTuanNay = COUNT(*)
		FROM dbo.HoaDon H WHERE
		H.NgayGiaoDich BETWEEN @StartDate AND @EndDate

		SELECT @SLHoaDonTuantruoc = COUNT(*)
		FROM dbo.HoaDon H WHERE
		H.NgayGiaoDich BETWEEN DATEADD(DAY, @DiffDate, @StartDate) AND DATEADD(DAY, -1, @StartDate)
	END
	
	IF (@StartDate IS NULL AND @EndDate IS NULL)
	BEGIN
	    SELECT @SLHoaDonTuanNay = COUNT(*)
		FROM dbo.HoaDon H WHERE
		H.NgayGiaoDich BETWEEN DATEADD(WEEK, DATEDIFF(WEEK, 0, GETDATE()), 0) AND DATEADD(WEEK, DATEDIFF(WEEK, 0, GETDATE()), 6)

		SELECT @SLHoaDonTuantruoc = COUNT(*)
		FROM dbo.HoaDon H WHERE
		H.NgayGiaoDich BETWEEN DATEADD(WEEK, DATEDIFF(WEEK, 6, GETDATE()), 0) AND DATEADD(WEEK, DATEDIFF(WEEK, 6, GETDATE()), 6)
	END

	SELECT @TiLe =
	ISNULL(ROUND(NULLIF(CAST((@SLHoaDonTuanNay - @SLHoaDonTuantruoc) AS FLOAT), 0) / NULLIF(@SLHoaDonTuantruoc, 0) * 100, 1), 0)

	SELECT @TongHoaDon = COUNT(*) FROM dbo.HoaDon

	SELECT @RatioOnTotal =
	ISNULL(ROUND(NULLIF(@SLHoaDonTuanNay, 0) / NULLIF(@TongHoaDon, 1) * 100, 1), 0)
	
	SELECT @SLHoaDonTuanNay AS SLHoaDonTuanNay, @SLHoaDonTuantruoc AS SLHoaDonTuantruoc, @TiLe AS TiLe, @RatioOnTotal AS RatioOnTotal
END
GO
/****** Object:  StoredProcedure [dbo].[USP_CancleAccount]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_CancleAccount]
@Name NVARCHAR(100),
@SDT VARCHAR(20)
AS
BEGIN
	DECLARE @isActive BIT
	SELECT @isActive = Active FROM dbo.Taikhoan WHERE HoTen = @Name AND SDT = @SDT

	IF (@isActive = 1)
    UPDATE dbo.Taikhoan SET Active = 0
	WHERE HoTen = @Name AND SDT = @SDT
	ELSE
    UPDATE dbo.Taikhoan SET Active = 1
	WHERE HoTen = @Name AND SDT = @SDT
END
GO
/****** Object:  StoredProcedure [dbo].[USP_CancleProductByID]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_CancleProductByID]
@MaSP INT
AS
BEGIN
    UPDATE dbo.SanPham SET Cancellation = 1 WHERE MaSP = @MaSP
END
GO
/****** Object:  StoredProcedure [dbo].[USP_CreateAccount]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_CreateAccount]
@HoTen NVARCHAR(100),
@DiaChi NVARCHAR(200),
@SDT VARCHAR(20),
@RoleID VARCHAR(10)
AS
BEGIN
	DECLARE @IDAccount VARCHAR(100)

	IF (@RoleID = 'staff')
		SELECT @IDAccount = dbo.Func_NextStaffID()
	ELSE
		SELECT @IDAccount = dbo.Func_NextAdminID()

    INSERT dbo.Taikhoan
    (
        IDAccount,
        Password,
        HoTen,
        DiaChi,
        SDT,
        Active,
        RoleID
    )
    VALUES
    (   @IDAccount,   -- IDAccount - varchar(20)
        '20720532132149213101239102231223249249135100218',   -- Password - varchar(50)
        @HoTen,  -- HoTen - nvarchar(30)
        @DiaChi,  -- DiaChi - nvarchar(200)
        @SDT,   -- SDT - varchar(20)
        1, -- Active - bit
        @RoleID    -- RoleID - char(5)
        )
END
GO
/****** Object:  StoredProcedure [dbo].[USP_CustomerRate]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_CustomerRate]
AS
BEGIN
	DECLARE @SLKhachHangTuanNay INT
	DECLARE @SLKhachHangTuanTruoc INT
	DECLARE @TiLe FLOAT

	SELECT @SLKhachHangTuanNay = COUNT(DISTINCT MaDT)
	FROM dbo.HoaDon
	WHERE MaDT LIKE 'K%' AND 
	NgayGiaoDich BETWEEN DATEADD(WEEK, DATEDIFF(WEEK, 0, GETDATE()), 0) AND DATEADD(WEEK, DATEDIFF(WEEK, 0, GETDATE()), 6)

	SELECT @SLKhachHangTuanTruoc = COUNT(DISTINCT MaDT)
	FROM dbo.HoaDon
	WHERE MaDT LIKE 'K%' AND 
	NgayGiaoDich BETWEEN DATEADD(WEEK, DATEDIFF(WEEK, 6, GETDATE()), 0) AND DATEADD(WEEK, DATEDIFF(WEEK, 6, GETDATE()), 6)

    SELECT @TiLe =
	ISNULL(ROUND(NULLIF(CAST((@SLKhachHangTuanNay - @SLKhachHangTuanTruoc) AS FLOAT), 0) / NULLIF(@SLKhachHangTuanTruoc, 0) * 100, 1), 0)

	SELECT @SLKhachHangTuanNay AS SLKhachHangTuanNay, @SLKhachHangTuanTruoc AS SLKhachHangTuanTruoc, @TiLe AS TiLe
END
GO
/****** Object:  StoredProcedure [dbo].[USP_DeleteBillDetail]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_DeleteBillDetail]
@MaHoaDon INT
AS
BEGIN

	DECLARE AmountChange CURSOR FOR SELECT MaSP, SoLuong FROM dbo.ChiTietHoaDon WHERE MaHoaDon = @MaHoaDon

	OPEN AmountChange
	
	DECLARE @MaSP INT
	DECLARE @SoLuong INT

	FETCH NEXT FROM AmountChange INTO @MaSP, @SoLuong
	
	WHILE @@FETCH_STATUS = 0
	BEGIN
		UPDATE dbo.SanPham SET SoLuongTon = SoLuongTon + @SoLuong WHERE MaSP = @MaSP
		
		FETCH NEXT FROM AmountChange INTO @MaSP, @SoLuong
	END

	CLOSE AmountChange
	DEALLOCATE AmountChange

    DELETE dbo.ChiTietHoaDon WHERE MaHoaDon = @MaHoaDon
END
GO
/****** Object:  StoredProcedure [dbo].[USP_EditBill]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_EditBill]
@MaHoaDon INT,
@NguoiBan VARCHAR(20),
@MaDT VARCHAR(100),
@GiamGia FLOAT,
@TongTien FLOAT,
@Status BIT
AS
BEGIN
    UPDATE dbo.HoaDon SET NguoiBan = @NguoiBan, MaDT = @MaDT, GiamGia = @GiamGia, TongTien = @TongTien, Status = @Status
	WHERE MaHoaDon = @MaHoaDon
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetAccount]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetAccount]
@IDAccount VARCHAR(20),
@Password varchar(50)
AS
BEGIN
    SELECT * FROM dbo.Taikhoan
	WHERE @IDAccount = IDAccount AND @Password = Password
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetAllProduct]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_GetAllProduct]
AS
BEGIN
    SELECT * FROM dbo.SanPham
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetBillDetailByID]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROC [dbo].[USP_GetBillDetailByID]
@MaHoaDon INT
AS
BEGIN
	SELECT SP.MaSP, SP.TenSP, CT.Gia, CT.SoLuong, HD.GiamGia, (CT.SoLuong * CT.Gia) AS ThanhTien, SP.SoLuongTon
	FROM dbo.HoaDon HD JOIN dbo.ChiTietHoaDon CT
	ON CT.MaHoaDon = HD.MaHoaDon
	JOIN dbo.SanPham SP
	ON SP.MaSP = CT.MaSP
	WHERE HD.MaHoaDon = @MaHoaDon
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetBillProductByID]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_GetBillProductByID]
@MaSP INT,
@StartDate AS DATE = NULL,
@EndDate AS DATE = NULL
AS
BEGIN
	IF (@StartDate IS NULL AND @EndDate IS NULL)
	BEGIN
		SELECT HD.MaHoaDon, HD.NgayGiaoDich, HD.MaDT, HD.LoaiHoaDon, HD.GiamGia, HD.TongTien FROM dbo.HoaDon HD
		JOIN dbo.ChiTietHoaDon CT
		ON CT.MaHoaDon = HD.MaHoaDon
		WHERE CT.MaSP = @MaSP
	END
	
	IF (@StartDate IS NOT NULL AND @EndDate IS NOT NULL)
	BEGIN
		SELECT HD.MaHoaDon, HD.NgayGiaoDich, HD.MaDT, HD.LoaiHoaDon, HD.GiamGia, HD.TongTien FROM dbo.HoaDon HD
		JOIN dbo.ChiTietHoaDon CT
		ON CT.MaHoaDon = HD.MaHoaDon
		WHERE CT.MaSP = @MaSP AND HD.NgayGiaoDich BETWEEN @StartDate AND @EndDate
	END
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetColumnProductName]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetColumnProductName]
@Table_Name AS NVARCHAR(100)
AS
BEGIN
	DECLARE @ColumnName NVARCHAR(MAX)
	SELECT @ColumnName = N'Giá'

	IF (@Table_Name = 'Sach')
	BEGIN
		SELECT @ColumnName = N'Giá,Tác giả,Năm xuất bản,Nhà xuất bản'
	END

	IF (@Table_Name = 'But')
	BEGIN
		SELECT @ColumnName = N'Giá,Màu sắc,Chất liệu,Màu mực'
	END

	IF (@Table_Name = 'ThietBiDienTu')
	BEGIN
		SELECT @ColumnName = N'Giá,Màu sắc,Chất liệu,Bảo hành,Thông số kĩ thuật'
	END

	SELECT @ColumnName
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetDoiTacByInfo]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetDoiTacByInfo]
@TenDT NVARCHAR(MAX),
@DiaChi NVARCHAR(200),
@SDT VARCHAR(20)
AS
BEGIN
    SELECT * FROM dbo.DoiTac
	WHERE TenDT = @TenDT AND @DiaChi = DiaChi AND SDT = @SDT
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetInfoProductFilter]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_GetInfoProductFilter]
@Table_Name AS NVARCHAR(100)
AS
BEGIN
	IF (@Table_Name = 'Sach')
	BEGIN
		SELECT SP.DVT, SP.ThuongHieu AS N'Thương hiệu,ThuongHieu',
		S.TacGia AS N'Tác giả,TacGia', 
		S.NamXB AS N'Năm xuất bản,NamXB', 
		S.NhaXB AS N'Nhà xuất bản,NhaXB' FROM dbo.SanPham SP JOIN dbo.Sach S
		ON S.MaSP = SP.MaSP
	END

	IF (@Table_Name = 'But')
	BEGIN
		SELECT SP.DVT, SP.ThuongHieu AS N'Thương hiệu,ThuongHieu',
		B.MauSac AS N'Màu sắc,MauSac',
		B.ChatLieu AS N'Chất liệu,ChatLieu',
		B.MauMuc AS N'Màu mực,MauMuc' FROM dbo.SanPham SP JOIN dbo.But B
		ON B.MaSP = SP.MaSP
	END

	IF (@Table_Name = 'ThietBiDienTu')
	BEGIN
		SELECT SP.DVT, SP.ThuongHieu AS N'Thương hiệu,ThuongHieu',
		TBDT.MauSac AS N'Màu sắc,MauSac',
		TBDT.ChatLieu AS N'Chất liệu,ChatLieu',
		TBDT.BaoHanh AS N'Bảo hành,BaoHanh',
		TBDT.ThongSoKiThuat AS N'Thông số kĩ thuật,ThongSoKiThuat'
		FROM dbo.SanPham SP JOIN dbo.ThietBiDienTu TBDT
		ON TBDT.MaSP = SP.MaSP
	END

	IF (@Table_Name = 'SanPham' OR @Table_Name = 'VanPhongPham')
	BEGIN
		SELECT SP.DVT, SP.ThuongHieu AS N'Thương hiệu,ThuongHieu'
		FROM dbo.SanPham SP 
		WHERE SP.MaSP NOT IN (SELECT MaSP FROM dbo.Sach) AND	
		SP.MaSP NOT IN (SELECT MaSP FROM dbo.ThietBiDienTu) AND	
		SP.MaSP NOT IN (SELECT MaSP FROM dbo.But)
	END
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetInvoiceDetail]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetInvoiceDetail]
@MaHoaDon INT
AS
BEGIN
	SELECT HD.MaHoaDon,
	DT.TenDT AS TenKhachHang, 
	DT.DiaChi,
	DT.SDT, 
	TK.HoTen,
	HD.LoaiHoaDon,
	HD.NgayGiaoDich AS ThoiGian, 
	HD.TongTien AS TongTienHang, 
	HD.GiamGia,
	(HD.TongTien - HD.GiamGia) AS TongThanhToan,
	HD.Status
	FROM dbo.HoaDon HD 
	JOIN dbo.DoiTac DT
	ON DT.MaDT = HD.MaDT
	JOIN dbo.Taikhoan TK
	ON TK.IDAccount = HD.NguoiBan
	WHERE HD.MaHoaDon = @MaHoaDon
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetProductByID]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetProductByID]
@MaSP INT
AS
BEGIN
    IF EXISTS (SELECT * FROM dbo.Sach WHERE MaSP = @MaSP)
	BEGIN
		SELECT SP.MaSP, 
		SP.TenSP, 
		SP.DVT, 
		SP.Gia,
		SP.ThuongHieu,
		SP.SoLuongTon,
		S.TacGia AS N'Tác giả,TacGia', 
		S.NamXB AS N'Năm xuất bản,NamXB', 
		S.NhaXB AS N'Nhà xuất bản,NhaXB' 
		FROM dbo.SanPham SP JOIN dbo.Sach S
		ON S.MaSP = SP.MaSP
		WHERE SP.MaSP = @MaSP
	END
	ELSE IF EXISTS (SELECT * FROM dbo.But WHERE MaSP = @MaSP)
	BEGIN
		SELECT SP.MaSP, 
		SP.TenSP, 
		SP.DVT, 
		SP.Gia,
		SP.ThuongHieu,
		SP.SoLuongTon,
		B.MauSac AS N'Màu sắc,MauSac',
		B.ChatLieu AS N'Chất liệu,ChatLieu',
		B.MauMuc AS N'Màu mực,MauMuc' FROM dbo.SanPham SP JOIN dbo.But B
		ON B.MaSP = SP.MaSP
		WHERE SP.MaSP = @MaSP
	END
	ELSE IF EXISTS (SELECT * FROM dbo.ThietBiDienTu WHERE MaSP = @MaSP)
	BEGIN
		SELECT SP.MaSP, 
		SP.TenSP, 
		SP.DVT, 
		SP.Gia,
		SP.ThuongHieu,
		SP.SoLuongTon,
		TBDT.MauSac AS N'Màu sắc,MauSac',
		TBDT.ChatLieu AS N'Chất liệu,ChatLieu',
		TBDT.BaoHanh AS N'Bảo hành,BaoHanh',
		TBDT.ThongSoKiThuat AS N'Thông số kĩ thuật,ThongSoKiThuat'
		FROM dbo.SanPham SP JOIN dbo.ThietBiDienTu TBDT
		ON TBDT.MaSP = SP.MaSP
		WHERE SP.MaSP = @MaSP
	END
	ELSE
	BEGIN
		SELECT SP.MaSP, 
		SP.TenSP, 
		SP.DVT, 
		SP.Gia,
		SP.ThuongHieu,
		SP.SoLuongTon
		FROM dbo.SanPham SP 
		WHERE SP.MaSP NOT IN (SELECT MaSP FROM dbo.Sach) AND	
		SP.MaSP NOT IN (SELECT MaSP FROM dbo.ThietBiDienTu) AND	
		SP.MaSP NOT IN (SELECT MaSP FROM dbo.But) AND
		SP.MaSP = @MaSP
	END
END
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBill]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_InsertBill]
@NguoiBan VARCHAR(20),
@NgayGiaoDich DATETIME,
@MaDT VARCHAR(100),
@LoaiHoaDon VARCHAR(10),
@GiamGia FLOAT,
@TongTien FLOAT,
@Status BIT
AS
BEGIN
	DECLARE @error NVARCHAR(150)

    IF NOT EXISTS (SELECT * FROM dbo.LoaiHoaDon WHERE MaLoaiHD = @LoaiHoaDon)
	BEGIN
		SELECT @error = N'Vui lòng chọn loại hóa đơn nhập hoặc hóa đơn bán hàng';
		RAISERROR (@error, 16, 1)
		ROLLBACK TRAN
	END
    ELSE IF NOT EXISTS (SELECT * FROM dbo.DoiTac WHERE MaDT = @MaDT)
	BEGIN
		SELECT @error = N'Thông tin Khách hàng/ Đối tác không đúng vui lòng kiểm tra lại';
		RAISERROR (@error, 16, 1)
		ROLLBACK TRAN
	END
	ELSE IF NOT EXISTS (SELECT * FROM dbo.Taikhoan WHERE IDAccount = @NguoiBan)
	BEGIN
		SELECT @error = N'Thông tin người bán không đúng vui lòng kiểm tra lại';
		RAISERROR (@error, 16, 1)
		ROLLBACK TRAN
	END
	ELSE
	BEGIN
	    INSERT dbo.HoaDon VALUES
	    (@NguoiBan, @NgayGiaoDich, @MaDT, @LoaiHoaDon, @GiamGia, @TongTien, @Status)

		SELECT MaHoaDon FROM dbo.HoaDon
		WHERE NguoiBan = @NguoiBan AND NgayGiaoDich = @NgayGiaoDich AND MaDT = @MaDT AND LoaiHoaDon = @LoaiHoaDon AND GiamGia = @GiamGia AND TongTien = @TongTien
	END
END
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBillDetail]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_InsertBillDetail]
@MaHoaDon INT,
@MaSP INT,
@SoLuong SMALLINT,
@Gia FLOAT
AS
BEGIN
    INSERT dbo.ChiTietHoaDon ( MaHoaDon, MaSP, SoLuong, Gia )
    VALUES ( @MaHoaDon, @MaSP, @SoLuong, @Gia  )
END
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBut]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_InsertBut]
@Tensanpham NVARCHAR(100),
@Thuonghieu NVARCHAR(100),
@Donvitinh NVARCHAR(100),
@Gia FLOAT,
@Mausac NVARCHAR(20),
@Chatlieu NVARCHAR(20),
@Maumuc NVARCHAR(20)
AS
BEGIN
    INSERT dbo.SanPham
    (
        TenSP,
        DVT,
		Gia,
        ThuongHieu
    )
    VALUES
    (   @Tensanpham, -- TenSP - nvarchar(100)
        @Donvitinh, -- DVT - nvarchar(15)
		@Gia,
        @Thuonghieu -- ThuongHieu - nvarchar(50)
        )

	DECLARE @MaSP INT
	SET @MaSP = @@IDENTITY

	INSERT dbo.But
	(
	    MaSP,
	    MauSac,
	    ChatLieu,
	    MauMuc
	)
	VALUES
	(   @MaSP,   -- MaSP - int
	    @Mausac, -- MauSac - nvarchar(20)
	    @Chatlieu, -- ChatLieu - nvarchar(20)
	    @Maumuc  -- MauMuc - nvarchar(20)
	    )
END
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertDoiTac]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_InsertDoiTac]
@TenDT NVARCHAR(100),
@DiaChi NVARCHAR(100),
@SDT VARCHAR(20),
@isCustomer BIT
AS
BEGIN
	IF EXISTS (SELECT * FROM dbo.DoiTac
	WHERE TenDT = @TenDT AND DiaChi = @DiaChi AND SDT = @SDT)
	BEGIN
		SELECT * FROM dbo.DoiTac
		WHERE TenDT = @TenDT AND DiaChi = @DiaChi AND SDT = @SDT
	END
	ELSE
	BEGIN
		DECLARE @MaDT VARCHAR(100)

		IF (@isCustomer = 1)
			SELECT @MaDT = dbo.Func_NextNCCID()
		ELSE
			SELECT @MaDT = dbo.Func_NextKhachHangID()

		INSERT dbo.DoiTac VALUES
		(@MaDT, @TenDT, @DiaChi, @SDT)
		SELECT * FROM dbo.DoiTac WHERE MaDT = @MaDT
	END
END
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertSach]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_InsertSach]
@Tensanpham NVARCHAR(100),
@Thuonghieu NVARCHAR(100),
@Donvitinh NVARCHAR(100),
@Gia FLOAT,
@Tacgia NVARCHAR(100),
@Namxuatban VARCHAR(10),
@Nhaxuatban NVARCHAR(100)
AS
BEGIN
    INSERT dbo.SanPham
    (
        TenSP,
        DVT,
		Gia,
        ThuongHieu
    )
    VALUES
    (   @Tensanpham, -- TenSP - nvarchar(100)
        @Donvitinh, -- DVT - nvarchar(15)
		@Gia,
        @Thuonghieu -- ThuongHieu - nvarchar(50)
        )

	DECLARE @MaSP INT
	SET @MaSP = @@IDENTITY

	INSERT dbo.Sach
	(
	    MaSP,
	    TacGia,
	    NamXB,
	    NhaXB
	)
	VALUES
	(   @MaSP,   -- MaSP - int
	    @Tacgia, -- TacGia - nvarchar(50)
	    @Namxuatban,  -- NamXB - char(5)
	    @Nhaxuatban  -- NhaXB - nvarchar(100)
	    )
END
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertTBDT]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_InsertTBDT]
@Tensanpham NVARCHAR(100),
@Thuonghieu NVARCHAR(100),
@Donvitinh NVARCHAR(100),
@Gia FLOAT,
@Mausac NVARCHAR(20),
@Chatlieu NVARCHAR(20),
@Baohanh NVARCHAR(100),
@Thongsokithuat NVARCHAR(200)
AS
BEGIN
    INSERT dbo.SanPham
    (
        TenSP,
        DVT,
		Gia,
        ThuongHieu
    )
    VALUES
    (   @Tensanpham, -- TenSP - nvarchar(100)
        @Donvitinh, -- DVT - nvarchar(15)
		@Gia,
        @Thuonghieu -- ThuongHieu - nvarchar(50)
        )

	DECLARE @MaSP INT
	SET @MaSP = @@IDENTITY
	
	INSERT dbo.ThietBiDienTu
	(
	    MaSP,
	    MauSac,
	    ChatLieu,
	    BaoHanh,
	    ThongSoKiThuat
	)
	VALUES
	(   @MaSP,   -- MaSP - int
	    @Mausac, -- MauSac - nvarchar(20)
	    @Chatlieu, -- ChatLieu - nvarchar(20)
	    @Baohanh, -- BaoHanh - nvarchar(10)
	    @Thongsokithuat  -- ThongSoKiThuat - nvarchar(200)
	    )
END
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertVPP]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_InsertVPP]
@Tensanpham NVARCHAR(100),
@Thuonghieu NVARCHAR(100),
@Donvitinh NVARCHAR(100),
@Gia FLOAT
AS
BEGIN
    INSERT dbo.SanPham
    (
        TenSP,
        DVT,
		Gia,
        ThuongHieu
    )
    VALUES
    (   @Tensanpham, -- TenSP - nvarchar(100)
        @Donvitinh, -- DVT - nvarchar(15)
		@Gia,
        @Thuonghieu -- ThuongHieu - nvarchar(50)
        )
END
GO
/****** Object:  StoredProcedure [dbo].[USP_InvoiceDetails]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_InvoiceDetails]
@LoaiHoaDon AS VARCHAR(10) = NULL,
@StartDate AS DATE = NULL,
@EndDate AS DATE = NULL
AS
BEGIN
	IF (@LoaiHoaDon IS NOT NULL)
	BEGIN
		IF (@StartDate IS NOT NULL AND @EndDate IS NOT NULL)
		BEGIN
			SELECT * FROM dbo.HoaDon WHERE LoaiHoaDon = @LoaiHoaDon AND
			NgayGiaoDich BETWEEN @StartDate AND DATEADD(DAY, 1, @EndDate)
		END
		
		IF (@StartDate IS NULL AND @EndDate IS NULL)
		BEGIN
			SELECT * FROM dbo.HoaDon WHERE LoaiHoaDon = @LoaiHoaDon
		END
	END
	
	ELSE IF (@LoaiHoaDon IS NULL)
	BEGIN
		IF (@StartDate IS NOT NULL AND @EndDate IS NOT NULL)
		BEGIN
			SELECT * FROM dbo.HoaDon
			WHERE NgayGiaoDich BETWEEN @StartDate AND DATEADD(DAY, 1, @EndDate)
		END
		
		IF (@StartDate IS NULL AND @EndDate IS NULL)
		BEGIN
			SELECT * FROM dbo.HoaDon
		END
	END
END
GO
/****** Object:  StoredProcedure [dbo].[USP_InvoiceDetailsByPeriodPrice]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[USP_InvoiceDetailsByPeriodPrice]
@StartPrice AS FLOAT,
@EndPrice AS FLOAT
AS
BEGIN
	SELECT * FROM dbo.HoaDon
	WHERE TongTien BETWEEN @StartPrice AND @EndPrice
END
GO
/****** Object:  StoredProcedure [dbo].[USP_InvoiceDetailsByRole]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_InvoiceDetailsByRole]
@LoaiHoaDon AS VARCHAR(10)
AS
BEGIN
	IF (@LoaiHoaDon = 'NULL')
	BEGIN
	    SELECT * FROM dbo.HoaDon
		RETURN
	END

	SELECT * FROM dbo.HoaDon WHERE LoaiHoaDon = @LoaiHoaDon
END
GO
/****** Object:  StoredProcedure [dbo].[USP_InvoiceDetailsByStages]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_InvoiceDetailsByStages]
@StartDate AS DATE,
@EndDate AS DATE
AS
BEGIN
	SELECT * FROM dbo.HoaDon
	WHERE NgayGiaoDich BETWEEN @StartDate AND @EndDate
END
GO
/****** Object:  StoredProcedure [dbo].[USP_InvoiceStatisticalAnalysis]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_InvoiceStatisticalAnalysis]
@StartDate AS DATETIME = NULL,
@EndDate AS DATETIME = NULL
AS
BEGIN
	IF (@StartDate IS NOT NULL AND @EndDate IS NOT NULL)
	BEGIN
		WITH CTE_TEST AS (SELECT CT.MaHoaDon, COUNT(CT.MaHoaDon) AS MucHoaDon, SUM(CT.SoLuong) AS TongSoLuongSP FROM dbo.HoaDon H JOIN dbo.ChiTietHoaDon CT
		ON CT.MaHoaDon = H.MaHoaDon
		WHERE H.NgayGiaoDich BETWEEN @StartDate AND @EndDate AND H.LoaiHoaDon = 'XBill'
		GROUP BY CT.MaHoaDon)
		SELECT (CASE
			  WHEN DATENAME(dw, H.NgayGiaoDich) = 'Monday' THEN 0
			  WHEN DATENAME(dw, H.NgayGiaoDich) = 'Tuesday' THEN 1
			  WHEN DATENAME(dw, H.NgayGiaoDich) = 'Wednesday' THEN 2
			  WHEN DATENAME(dw, H.NgayGiaoDich) = 'Thursday' THEN 3
			  WHEN DATENAME(dw, H.NgayGiaoDich) = 'Friday' THEN 4
			  WHEN DATENAME(dw, H.NgayGiaoDich) = 'Saturday' THEN 5
			  WHEN DATENAME(dw, H.NgayGiaoDich) = 'Sunday' THEN 6
		 END) AS NgayThu, DATENAME(dw, H.NgayGiaoDich) AS Thu,
		 ('Day ' + CAST(DAY(H.NgayGiaoDich) AS VARCHAR) +  '/' + CAST(MONTH(H.NgayGiaoDich) AS VARCHAR)) AS NgayGiaoDich,
		 CTE_TEST.MucHoaDon, CTE_TEST.TongSoLuongSP
		FROM CTE_TEST JOIN dbo.HoaDon H
		ON H.MaHoaDon = CTE_TEST.MaHoaDon AND H.LoaiHoaDon = 'XBill'
	END
END
GO
/****** Object:  StoredProcedure [dbo].[USP_ProductFilter]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_ProductFilter]
@Table_Name AS NVARCHAR(100),
@Table ProductFilterType READONLY
AS
BEGIN
	DECLARE @SelectTableQuery NVARCHAR(MAX)
	DECLARE @fromSubQuery NVARCHAR(MAX)

	IF NOT EXISTS (SELECT * FROM @Table)
	BEGIN
	    SELECT * FROM dbo.SanPham
		RETURN
	END

	IF (@Table_Name = 'Sach')
	BEGIN
		SET @SelectTableQuery = '
		SELECT * FROM ( SELECT SP.MaSP, SP.TenSP, SP.ThuongHieu, SP.SoLuongTon, SP.DVT, SP.Cancellation, S.TacGia, CONVERT(NVARCHAR(MAX), S.NamXB) AS NamXB, S.NhaXB 
		FROM dbo.SanPham SP JOIN dbo.Sach S
		ON S.MaSP = SP.MaSP ) AS Sach'
		SET @fromSubQuery = 'SELECT SP.MaSP
		FROM dbo.SanPham SP JOIN dbo.Sach S
		ON S.MaSP = SP.MaSP'
	END

	IF (@Table_Name = 'But')
	BEGIN
		SET @SelectTableQuery = '
		SELECT * FROM ( SELECT SP.MaSP, SP.TenSP, SP.ThuongHieu, SP.SoLuongTon, SP.DVT, SP.Cancellation, B.MauSac, B.ChatLieu, B.MauMuc 
		FROM dbo.SanPham SP JOIN dbo.But B
		ON B.MaSP = SP.MaSP ) AS But'
		SET @fromSubQuery = 'SELECT SP.MaSP
		FROM dbo.SanPham SP JOIN dbo.But B
		ON B.MaSP = SP.MaSP'
	END

	IF (@Table_Name = 'ThietBiDienTu')
	BEGIN
		SET @SelectTableQuery = '
		SELECT * FROM ( SELECT SP.MaSP, SP.TenSP, SP.ThuongHieu, SP.SoLuongTon, SP.DVT, SP.Cancellation, TBDT.MauSac, TBDT.ChatLieu, TBDT.BaoHanh, TBDT.ThongSoKiThuat
		FROM dbo.SanPham SP JOIN dbo.ThietBiDienTu TBDT
		ON TBDT.MaSP = SP.MaSP ) AS ThietBiDienTu'
		SET @fromSubQuery = 'SELECT SP.MaSP
		FROM dbo.SanPham SP JOIN dbo.ThietBiDienTu TBDT
		ON TBDT.MaSP = SP.MaSP'
	END

	IF (@Table_Name = 'SanPham' OR @Table_Name = 'VanPhongPham')
	BEGIN
		SET @SelectTableQuery = '
		SELECT * FROM ( SELECT SP.MaSP, SP.TenSP, SP.ThuongHieu, SP.SoLuongTon, SP.DVT, SP.Cancellation
		FROM dbo.SanPham SP 
		WHERE SP.MaSP NOT IN (SELECT MaSP FROM dbo.Sach) AND	
		SP.MaSP NOT IN (SELECT MaSP FROM dbo.ThietBiDienTu) AND	
		SP.MaSP NOT IN (SELECT MaSP FROM dbo.But) ) AS VanPhongPham'
		SET @fromSubQuery = 'SELECT SP.MaSP
		FROM dbo.SanPham SP 
		WHERE SP.MaSP NOT IN (SELECT MaSP FROM dbo.Sach) AND	
		SP.MaSP NOT IN (SELECT MaSP FROM dbo.ThietBiDienTu) AND	
		SP.MaSP NOT IN (SELECT MaSP FROM dbo.But)'
		SET @Table_Name = 'VanPhongPham'
	END
	DECLARE AttributeCursor CURSOR FOR SELECT Attribute, Value FROM @Table ProductFilterType

	OPEN AttributeCursor

	DECLARE @Attribute NVARCHAR(100)
	DECLARE @Value NVARCHAR(100)
	DECLARE @NewConditionQuery NVARCHAR(10)
	DECLARE @i INT
	DECLARE @queryOutput NVARCHAR(MAX)

	SET @i = 0
	SET @NewConditionQuery  = ' WHERE '

	FETCH NEXT FROM AttributeCursor INTO @Attribute, @Value
	
	WHILE @@FETCH_STATUS = 0
	BEGIN
		IF (@i <= 0)
		BEGIN
			--SET @SelectTableQuery = @SelectTableQuery + @NewConditionQuery +
			--@Table_Name + '.' + @Attribute + ' = N''' + @Value + ''''
			SET @queryOutput = @SelectTableQuery + @NewConditionQuery +
			@Table_Name + '.MaSP' + ' IN ( ' + @fromSubQuery + ' AND ' + @Attribute + ' = N''' + @Value + ''' )'
			SET @i = @i + 1
		END
		ELSE
		BEGIN
			--SET @queryOutput = @SelectTableQuery + ' AND ' +
			--@Table_Name + '.' + @Attribute + ' = N''' + @Value + ''''
			SET @queryOutput = @queryOutput + ' AND ' +
			@Table_Name + '.MaSP' + ' IN ( ' + @fromSubQuery + ' AND ' +  @Attribute + ' = N''' + @Value + ''' )'
		END

		FETCH NEXT FROM AttributeCursor INTO @Attribute, @Value
	END

	CLOSE AttributeCursor
	DEALLOCATE AttributeCursor

	SET @SelectTableQuery = 'SELECT MaSP, TenSP, ThuongHieu, SoLuongTon, DVT, Cancellation FROM ( ' + @queryOutput + ' ) AS T'
	EXEC (@SelectTableQuery)
	--SELECT @SelectTableQuery
END
GO
/****** Object:  StoredProcedure [dbo].[USP_ProductImportedRate]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_ProductImportedRate]
@StartDate AS DATE = NULL,
@EndDate AS DATE = NULL
AS
BEGIN
	DECLARE @SLSPTuanNay INT
	DECLARE @SLSPTuanTruoc INT
	DECLARE @TiLe FLOAT
	DECLARE @TongSLSP FLOAT
	DECLARE @RatioOnTotal FLOAT

	IF (@StartDate IS NOT NULL AND @EndDate IS NOT NULL)
	BEGIN
		DECLARE @DiffDate INT

		SELECT @DiffDate = (DATEDIFF(DAY, @StartDate, @EndDate) + 1) * -1

	    SELECT @SLSPTuanNay = SUM(CT.SoLuong)
		FROM dbo.HoaDon H JOIN dbo.ChiTietHoaDon CT
		ON CT.MaHoaDon = H.MaHoaDon
		WHERE H.MaDT LIKE 'CC%' AND 
		H.NgayGiaoDich BETWEEN @StartDate AND DATEADD(DAY, 1, @EndDate)

		SELECT @SLSPTuanTruoc = SUM(CT.SoLuong)
		FROM dbo.HoaDon H JOIN dbo.ChiTietHoaDon CT
		ON CT.MaHoaDon = H.MaHoaDon
		WHERE H.MaDT LIKE 'CC%' AND 
		H.NgayGiaoDich BETWEEN DATEADD(DAY, @DiffDate, @StartDate) AND @StartDate
	END

	IF (@StartDate IS NULL AND @EndDate IS NULL)
	BEGIN
		SELECT @SLSPTuanNay = SUM(CT.SoLuong)
		FROM dbo.HoaDon H JOIN dbo.ChiTietHoaDon CT
		ON CT.MaHoaDon = H.MaHoaDon
		WHERE H.MaDT LIKE 'CC%' AND 
		H.NgayGiaoDich BETWEEN DATEADD(WEEK, DATEDIFF(WEEK, 0, GETDATE()), 0) AND DATEADD(WEEK, DATEDIFF(WEEK, 0, GETDATE()), 6)

		SELECT @SLSPTuanTruoc = SUM(CT.SoLuong)
		FROM dbo.HoaDon H JOIN dbo.ChiTietHoaDon CT
		ON CT.MaHoaDon = H.MaHoaDon
		WHERE H.MaDT LIKE 'CC%' AND 
		H.NgayGiaoDich BETWEEN DATEADD(WEEK, DATEDIFF(WEEK, 6, GETDATE()), 0) AND DATEADD(WEEK, DATEDIFF(WEEK, 6, GETDATE()), 6)
	END

    SELECT @TiLe =
	ISNULL(ROUND(NULLIF(CAST((@SLSPTuanNay - @SLSPTuanTruoc) AS FLOAT), 0) / NULLIF(@SLSPTuanTruoc, 0) * 100, 1), 0)

	SELECT @TongSLSP = SUM(SoLuongTon) FROM dbo.SanPham 
	WHERE SoLuongTon > 0 AND Cancellation = 0

	SELECT @RatioOnTotal =
	ISNULL(ROUND(NULLIF(@SLSPTuanNay, 0) / NULLIF(@TongSLSP, 1) * 100, 1), 0)

	SELECT @SLSPTuanNay AS SLSPTuanNay, @SLSPTuanTruoc AS SLSPTuanTruoc, @TiLe AS TiLe, @RatioOnTotal AS RatioOnTotal
END
GO
/****** Object:  StoredProcedure [dbo].[USP_ProductSoldRate]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_ProductSoldRate]
@StartDate AS DATE = NULL,
@EndDate AS DATE = NULL
AS
BEGIN
	DECLARE @SLSPTuanNay INT
	DECLARE @SLSPTuanTruoc INT
	DECLARE @TiLe FLOAT
	DECLARE @TongSLSP FLOAT
	DECLARE @RatioOnTotal FLOAT

	IF (@StartDate IS NOT NULL AND @EndDate IS NOT NULL)
	BEGIN
		DECLARE @DiffDate INT

		SELECT @DiffDate = (DATEDIFF(DAY, @StartDate, @EndDate) + 1) * -1

	    SELECT @SLSPTuanNay = SUM(CT.SoLuong)
		FROM dbo.HoaDon H JOIN dbo.ChiTietHoaDon CT
		ON CT.MaHoaDon = H.MaHoaDon
		WHERE H.MaDT LIKE 'K%' AND 
		H.NgayGiaoDich BETWEEN @StartDate AND DATEADD(DAY, 1, @EndDate)

		SELECT @SLSPTuanTruoc = SUM(CT.SoLuong)
		FROM dbo.HoaDon H JOIN dbo.ChiTietHoaDon CT
		ON CT.MaHoaDon = H.MaHoaDon
		WHERE H.MaDT LIKE 'K%' AND 
		H.NgayGiaoDich BETWEEN DATEADD(DAY, @DiffDate, @StartDate) AND @StartDate
	END

	IF (@StartDate IS NULL AND @EndDate IS NULL)
	BEGIN
		SELECT @SLSPTuanNay = SUM(CT.SoLuong)
		FROM dbo.HoaDon H JOIN dbo.ChiTietHoaDon CT
		ON CT.MaHoaDon = H.MaHoaDon
		WHERE H.MaDT LIKE 'K%' AND 
		H.NgayGiaoDich BETWEEN DATEADD(WEEK, DATEDIFF(WEEK, 0, GETDATE()), 0) AND DATEADD(WEEK, DATEDIFF(WEEK, 0, GETDATE()), 6)

		SELECT @SLSPTuanTruoc = SUM(CT.SoLuong)
		FROM dbo.HoaDon H JOIN dbo.ChiTietHoaDon CT
		ON CT.MaHoaDon = H.MaHoaDon
		WHERE H.MaDT LIKE 'K%' AND 
		H.NgayGiaoDich BETWEEN DATEADD(WEEK, DATEDIFF(WEEK, 6, GETDATE()), 0) AND DATEADD(WEEK, DATEDIFF(WEEK, 6, GETDATE()), 6)
	END

    SELECT @TiLe =
	ISNULL(ROUND(NULLIF(CAST((@SLSPTuanNay - @SLSPTuanTruoc) AS FLOAT), 0) / NULLIF(@SLSPTuanTruoc, 0) * 100, 1), 0)
	
	SELECT @TongSLSP = SUM(SoLuongTon) FROM dbo.SanPham 
	WHERE SoLuongTon > 0 AND Cancellation = 0

	SELECT @RatioOnTotal =
	ISNULL(ROUND(NULLIF(@SLSPTuanNay, 0) / NULLIF(@TongSLSP, 1) * 100, 1), 0)

	SELECT @SLSPTuanNay AS SLSPTuanNay, @SLSPTuanTruoc AS SLSPTuanTruoc, @TiLe AS TiLe, @RatioOnTotal AS RatioOnTotal
END
GO
/****** Object:  StoredProcedure [dbo].[USP_ProductStock]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_ProductStock]
AS
BEGIN
	DECLARE @Sach INT
	DECLARE @ThietBiDienTu INT
	DECLARE @VanPhongPham INT

	SELECT @Sach = SUM(SoLuongTon) FROM dbo.SanPham JOIN dbo.Sach
	ON Sach.MaSP = SanPham.MaSP AND SoLuongTon > 0 AND Cancellation = 0

	SELECT @ThietBiDienTu = SUM(SoLuongTon)  FROM dbo.SanPham JOIN dbo.ThietBiDienTu
	ON ThietBiDienTu.MaSP = SanPham.MaSP  AND SoLuongTon > 0 AND Cancellation = 0
    
	SELECT @VanPhongPham = SUM(SoLuongTon)  FROM dbo.SanPham S
	WHERE S.MaSP NOT IN (SELECT MaSP FROM dbo.Sach) AND	
	S.MaSP NOT IN (SELECT MaSP FROM dbo.ThietBiDienTu) AND	
	S.MaSP NOT IN (SELECT MaSP FROM dbo.But)  AND SoLuongTon > 0 AND Cancellation = 0

	SELECT @Sach AS Sach, @ThietBiDienTu AS ThietBiDienTu, @VanPhongPham AS VanPhongPham
END
GO
/****** Object:  StoredProcedure [dbo].[USP_ResetPassword]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_ResetPassword]
@IDAccount VARCHAR(100)
AS
BEGIN
    UPDATE dbo.Taikhoan SET Password = '20720532132149213101239102231223249249135100218'
	WHERE IDAccount = @IDAccount
END
GO
/****** Object:  StoredProcedure [dbo].[USP_RevenueByProduct]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_RevenueByProduct]
@StartDate AS DATE = NULL,
@EndDate AS DATE = NULL
AS
BEGIN
	IF (@StartDate IS NOT NULL AND @EndDate IS NOT NULL)
	BEGIN
		SELECT T.MaSP, S.TenSP, SUM(T.SoLuong) AS SoLuong, SUM(T.TongTien) AS TongTien
		FROM (SELECT CT.MaSP, CT.SoLuong, CT.Gia, (CT.SoLuong * CT.Gia) AS TongTien 
		FROM dbo.HoaDon H JOIN dbo.ChiTietHoaDon CT
		ON CT.MaHoaDon = H.MaHoaDon
		WHERE H.NgayGiaoDich BETWEEN @StartDate AND @EndDate) AS T JOIN dbo.SanPham S
		ON S.MaSP = T.MaSP
		GROUP BY T.MaSP, S.TenSP
	END

	IF (@StartDate IS NULL AND @EndDate IS NULL)
	BEGIN
		SELECT T.MaSP, S.TenSP, SUM(T.SoLuong) AS TongSoLuong, SUM(T.TongTien) AS TongTien
		FROM (SELECT CT.MaSP, CT.SoLuong, CT.Gia, (CT.SoLuong * CT.Gia) AS TongTien 
		FROM dbo.HoaDon H JOIN dbo.ChiTietHoaDon CT
		ON CT.MaHoaDon = H.MaHoaDon) AS T JOIN dbo.SanPham S
		ON S.MaSP = T.MaSP
		GROUP BY T.MaSP, S.TenSP
	END
END
GO
/****** Object:  StoredProcedure [dbo].[USP_RevenueRate]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_RevenueRate]
@StartDate AS DATE = NULL,
@EndDate AS DATE = NULL
AS
BEGIN
	DECLARE @DoanhThuTuanNay INT
	DECLARE @DoanhThuTuanTruoc INT
	DECLARE @TiLe FLOAT
	DECLARE @TongDoanhThu FLOAT
	DECLARE @RatioOnTotal FLOAT

	IF (@StartDate IS NOT NULL AND @EndDate IS NOT NULL)
	BEGIN
		DECLARE @DiffDate INT

		SELECT @DiffDate = (DATEDIFF(DAY, @StartDate, @EndDate) + 1) * -1

	    SELECT @DoanhThuTuanNay = SUM(TongTien)
		FROM dbo.HoaDon H WHERE
		H.NgayGiaoDich BETWEEN @StartDate AND DATEADD(DAY, 1, @EndDate)

		SELECT @DoanhThuTuanTruoc = SUM(TongTien)
		FROM dbo.HoaDon H WHERE
		H.NgayGiaoDich BETWEEN DATEADD(DAY, @DiffDate, @StartDate) AND @StartDate
	END

	IF (@StartDate IS NULL AND @EndDate IS NULL)
	BEGIN
		SELECT @DoanhThuTuanNay = SUM(TongTien)
		FROM dbo.HoaDon 
		WHERE
		NgayGiaoDich BETWEEN DATEADD(WEEK, DATEDIFF(WEEK, 0, GETDATE()), 0) AND DATEADD(WEEK, DATEDIFF(WEEK, 0, GETDATE()), 6)

		SELECT @DoanhThuTuanTruoc = SUM(TongTien)
		FROM dbo.HoaDon 
		WHERE
		NgayGiaoDich BETWEEN DATEADD(WEEK, DATEDIFF(WEEK, 6, GETDATE()), 0) AND DATEADD(WEEK, DATEDIFF(WEEK, 6, GETDATE()), 6)
	END

    SELECT @TiLe =
	ISNULL(ROUND(NULLIF(CAST((@DoanhThuTuanNay - @DoanhThuTuanTruoc) AS FLOAT), 0) / NULLIF(@DoanhThuTuanTruoc, 0) * 100, 1), 0)

	SELECT @TongDoanhThu = SUM(TongTien) FROM dbo.HoaDon

	SELECT @RatioOnTotal =
	ISNULL(ROUND(NULLIF(@DoanhThuTuanNay, 0) / NULLIF(@TongDoanhThu, 1) * 100, 1), 0)

	SELECT @DoanhThuTuanNay AS DoanhThuTuanNay, @DoanhThuTuanTruoc AS DoanhThuTuanTruoc, @TiLe AS TiLe, @RatioOnTotal AS RatioOnTotal
END
GO
/****** Object:  StoredProcedure [dbo].[USP_RevenueStatisticsInPreviousStages]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_RevenueStatisticsInPreviousStages]
@StartDate AS DATE = NULL,
@EndDate AS DATE = NULL
AS
BEGIN
	IF (@StartDate IS NOT NULL AND @EndDate IS NOT NULL)
	BEGIN
		DECLARE @DiffDate INT

		SELECT @DiffDate = (DATEDIFF(DAY, @StartDate, @EndDate) + 1) * -1

		;WITH CTE_TEST AS (SELECT CAST(NgayGiaoDich AS DATE) AS NgayGiaoDich, SUM(TongTien) AS TongTien
		FROM dbo.HoaDon 
		WHERE NgayGiaoDich BETWEEN DATEADD(DAY, @DiffDate, @StartDate) AND @StartDate
		GROUP BY CAST(NgayGiaoDich AS DATE))
		SELECT (CASE
			  WHEN DATENAME(dw, H.NgayGiaoDich) = 'Monday' THEN 0
			  WHEN DATENAME(dw, H.NgayGiaoDich) = 'Tuesday' THEN 1
			  WHEN DATENAME(dw, H.NgayGiaoDich) = 'Wednesday' THEN 2
			  WHEN DATENAME(dw, H.NgayGiaoDich) = 'Thursday' THEN 3
			  WHEN DATENAME(dw, H.NgayGiaoDich) = 'Friday' THEN 4
			  WHEN DATENAME(dw, H.NgayGiaoDich) = 'Saturday' THEN 5
			  WHEN DATENAME(dw, H.NgayGiaoDich) = 'Sunday' THEN 6
		 END) AS NgayThu, DATENAME(dw, H.NgayGiaoDich) AS Thu, H.NgayGiaoDich, CTE_TEST.TongTien
		FROM (SELECT DISTINCT (CAST(NgayGiaoDich AS DATE)) AS NgayGiaoDich FROM dbo.HoaDon) AS H JOIN CTE_TEST
		ON H.NgayGiaoDich = CTE_TEST.NgayGiaoDich AND
		H.NgayGiaoDich BETWEEN DATEADD(DAY, @DiffDate, @StartDate) AND DATEADD(DAY, -1, @StartDate)
	END
END
GO
/****** Object:  StoredProcedure [dbo].[USP_RevenueStatisticsInThisStages]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_RevenueStatisticsInThisStages]
@StartDate AS DATE = NULL,
@EndDate AS DATE = NULL
AS
BEGIN
	IF (@StartDate IS NOT NULL AND @EndDate IS NOT NULL)
	BEGIN
		DECLARE @DiffDate INT

		SELECT @DiffDate = (DATEDIFF(DAY, @StartDate, @EndDate) + 1) * -1

		;WITH CTE_TEST AS (SELECT CAST(NgayGiaoDich AS DATE) AS NgayGiaoDich, SUM(TongTien) AS TongTien
		FROM dbo.HoaDon 
		WHERE NgayGiaoDich BETWEEN @StartDate AND DATEADD(DAY, 1, @EndDate)
		GROUP BY CAST(NgayGiaoDich AS DATE))
		SELECT (CASE
			  WHEN DATENAME(dw, H.NgayGiaoDich) = 'Monday' THEN 0
			  WHEN DATENAME(dw, H.NgayGiaoDich) = 'Tuesday' THEN 1
			  WHEN DATENAME(dw, H.NgayGiaoDich) = 'Wednesday' THEN 2
			  WHEN DATENAME(dw, H.NgayGiaoDich) = 'Thursday' THEN 3
			  WHEN DATENAME(dw, H.NgayGiaoDich) = 'Friday' THEN 4
			  WHEN DATENAME(dw, H.NgayGiaoDich) = 'Saturday' THEN 5
			  WHEN DATENAME(dw, H.NgayGiaoDich) = 'Sunday' THEN 6
		 END) AS NgayThu, DATENAME(dw, H.NgayGiaoDich) AS Thu, H.NgayGiaoDich, CTE_TEST.TongTien
		FROM (SELECT DISTINCT (CAST(NgayGiaoDich AS DATE)) AS NgayGiaoDich FROM dbo.HoaDon) AS H JOIN CTE_TEST
		ON H.NgayGiaoDich = CTE_TEST.NgayGiaoDich AND
		H.NgayGiaoDich BETWEEN @StartDate AND DATEADD(DAY, 1, @EndDate)
	END
END
GO
/****** Object:  StoredProcedure [dbo].[USP_RevenueStatisticsInWeek]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_RevenueStatisticsInWeek] 
AS
BEGIN
	WITH CTE_TEST AS (SELECT CAST(NgayGiaoDich AS DATE) AS NgayGiaoDich, SUM(TongTien) AS TongTien
	FROM dbo.HoaDon 
	WHERE NgayGiaoDich BETWEEN DATEADD(WEEK, DATEDIFF(WEEK, 0, GETDATE()), 0) AND DATEADD(WEEK, DATEDIFF(WEEK, 0, GETDATE()), 6)
	GROUP BY CAST(NgayGiaoDich AS DATE))
	SELECT (CASE
          WHEN DATENAME(dw, H.NgayGiaoDich) = 'Monday' THEN 0
          WHEN DATENAME(dw, H.NgayGiaoDich) = 'Tuesday' THEN 1
          WHEN DATENAME(dw, H.NgayGiaoDich) = 'Wednesday' THEN 2
          WHEN DATENAME(dw, H.NgayGiaoDich) = 'Thursday' THEN 3
          WHEN DATENAME(dw, H.NgayGiaoDich) = 'Friday' THEN 4
          WHEN DATENAME(dw, H.NgayGiaoDich) = 'Saturday' THEN 5
          WHEN DATENAME(dw, H.NgayGiaoDich) = 'Sunday' THEN 6
     END) AS NgayThu, DATENAME(dw, H.NgayGiaoDich) AS Thu, H.NgayGiaoDich, CTE_TEST.TongTien
	FROM (SELECT DISTINCT (CAST(NgayGiaoDich AS DATE)) AS NgayGiaoDich FROM dbo.HoaDon) AS H JOIN CTE_TEST
	ON H.NgayGiaoDich = CTE_TEST.NgayGiaoDich AND
    H.NgayGiaoDich BETWEEN DATEADD(WEEK, DATEDIFF(WEEK, 0, GETDATE()), 0) AND DATEADD(WEEK, DATEDIFF(WEEK, 0, GETDATE()), 6)
END
GO
/****** Object:  StoredProcedure [dbo].[USP_SalesInWeek]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_SalesInWeek]
AS
BEGIN
	DECLARE @Sach INT
	DECLARE @But INT
	DECLARE @ThietBiDienTu INT
	DECLARE @VanPhongPham INT

	SELECT @Sach = COUNT(SP.MaSP) FROM dbo.HoaDon H JOIN dbo.ChiTietHoaDon CT 
	ON H.MaHoaDon = CT.MaHoaDon
	JOIN dbo.SanPham SP
	ON SP.MaSP = CT.MaSP
	JOIN dbo.Sach S
	ON S.MaSP = SP.MaSP
	
	SELECT @But = COUNT(SP.MaSP) FROM dbo.HoaDon H JOIN dbo.ChiTietHoaDon CT 
	ON H.MaHoaDon = CT.MaHoaDon
	JOIN dbo.SanPham SP
	ON SP.MaSP = CT.MaSP
	JOIN dbo.But B
	ON B.MaSP = SP.MaSP

	SELECT @ThietBiDienTu = COUNT(SP.MaSP) FROM dbo.HoaDon H JOIN dbo.ChiTietHoaDon CT 
	ON H.MaHoaDon = CT.MaHoaDon
	JOIN dbo.SanPham SP
	ON SP.MaSP = CT.MaSP
	JOIN dbo.ThietBiDienTu TBDT
	ON TBDT.MaSP = SP.MaSP
    
	SELECT @VanPhongPham = COUNT(SP.MaSP) FROM dbo.HoaDon H JOIN dbo.ChiTietHoaDon CT 
	ON H.MaHoaDon = CT.MaHoaDon
	JOIN dbo.SanPham SP
	ON SP.MaSP = CT.MaSP
	WHERE SP.MaSP NOT IN (SELECT MaSP FROM dbo.Sach) AND	
	SP.MaSP NOT IN (SELECT MaSP FROM dbo.ThietBiDienTu) AND	
	SP.MaSP NOT IN (SELECT MaSP FROM dbo.But)

	SELECT @Sach AS Sach, @But AS But, @ThietBiDienTu AS ThietBiDienTu, @VanPhongPham AS VanPhongPham
END
GO
/****** Object:  StoredProcedure [dbo].[USP_SearchBill]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_SearchBill]
@keyword NVARCHAR(200)
AS 
BEGIN
    SELECT HD.MaHoaDon, HD.NguoiBan, HD.NgayGiaoDich, DT.MaDT, HD.LoaiHoaDon, HD.GiamGia, HD.TongTien FROM dbo.HoaDon HD
	JOIN dbo.DoiTac DT
	ON DT.MaDT = HD.MaDT
	WHERE ([dbo].[fuConvertToUnsign](DT.TenDT) LIKE N'%' + [dbo].[fuConvertToUnsign](@keyword) + '%'
	OR DT.SDT LIKE N'%' + @keyword + '%'
	OR HD.MaHoaDon LIKE @keyword)
END
GO
/****** Object:  StoredProcedure [dbo].[USP_SearchDoiTac]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_SearchDoiTac]
@keyword NVARCHAR(200),
@isCustomer BIT
AS 
BEGIN
	IF (@isCustomer = 1)
    SELECT * FROM dbo.DoiTac 
	WHERE (SDT LIKE N'%' + @keyword + '%'
	OR [dbo].[fuConvertToUnsign](TenDT) LIKE N'%' + [dbo].[fuConvertToUnsign](@keyword) + '%') AND MaDT LIKE 'C%'
	ELSE
    SELECT * FROM dbo.DoiTac 
	WHERE (SDT LIKE N'%' + @keyword + '%'
	OR [dbo].[fuConvertToUnsign](TenDT) LIKE N'%' + [dbo].[fuConvertToUnsign](@keyword) + '%') AND MaDT LIKE 'K%'
END
GO
/****** Object:  StoredProcedure [dbo].[USP_SearchProduct]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_SearchProduct]
@keyword NVARCHAR(200)
AS 
BEGIN
	IF (@keyword IS NULL OR @keyword = N'')
	BEGIN
	    SELECT * FROM dbo.SanPham
		RETURN
	END

	IF EXISTS (
	SELECT * FROM dbo.SanPham SP JOIN dbo.Sach S
	ON S.MaSP = SP.MaSP
	WHERE [dbo].[fuConvertToUnsign](SP.TenSP) LIKE N'%' + [dbo].[fuConvertToUnsign](@keyword) + '%'
	OR [dbo].[fuConvertToUnsign](SP.ThuongHieu) LIKE N'%' + [dbo].[fuConvertToUnsign](@keyword) + '%'
	OR [dbo].[fuConvertToUnsign](S.TacGia) LIKE N'%' + [dbo].[fuConvertToUnsign](@keyword) + '%'
	OR [dbo].[fuConvertToUnsign](S.NamXB) LIKE N'%' + [dbo].[fuConvertToUnsign](@keyword) + '%'
	OR [dbo].[fuConvertToUnsign](S.NhaXB) LIKE N'%' + [dbo].[fuConvertToUnsign](@keyword) + '%'
	)
	BEGIN
	    SELECT SP.MaSP, 
		SP.TenSP, 
		SP.DVT, 
		SP.Gia,
		SP.ThuongHieu,
		SP.SoLuongTon,
		SP.Cancellation
		FROM dbo.SanPham SP JOIN dbo.Sach S
		ON S.MaSP = SP.MaSP
		WHERE [dbo].[fuConvertToUnsign](SP.TenSP) LIKE N'%' + [dbo].[fuConvertToUnsign](@keyword) + '%'
		OR [dbo].[fuConvertToUnsign](SP.ThuongHieu) LIKE N'%' + [dbo].[fuConvertToUnsign](@keyword) + '%'
		OR [dbo].[fuConvertToUnsign](S.TacGia) LIKE N'%' + [dbo].[fuConvertToUnsign](@keyword) + '%'
		OR [dbo].[fuConvertToUnsign](S.NamXB) LIKE N'%' + [dbo].[fuConvertToUnsign](@keyword) + '%'
		OR [dbo].[fuConvertToUnsign](S.NhaXB) LIKE N'%' + [dbo].[fuConvertToUnsign](@keyword) + '%'
		RETURN
	END

	IF EXISTS (
	SELECT * FROM dbo.SanPham SP JOIN dbo.But B
	ON B.MaSP = SP.MaSP
	WHERE [dbo].[fuConvertToUnsign](SP.TenSP) LIKE N'%' + [dbo].[fuConvertToUnsign](@keyword) + '%'
	OR [dbo].[fuConvertToUnsign](SP.ThuongHieu) LIKE N'%' + [dbo].[fuConvertToUnsign](@keyword) + '%'
	OR [dbo].[fuConvertToUnsign](B.MauSac) LIKE N'%' + [dbo].[fuConvertToUnsign](@keyword) + '%'
	OR [dbo].[fuConvertToUnsign](B.ChatLieu) LIKE N'%' + [dbo].[fuConvertToUnsign](@keyword) + '%'
	OR [dbo].[fuConvertToUnsign](B.MauMuc) LIKE N'%' + [dbo].[fuConvertToUnsign](@keyword) + '%'
	)
	BEGIN
	    SELECT SP.MaSP, 
		SP.TenSP, 
		SP.DVT, 
		SP.Gia,
		SP.ThuongHieu,
		SP.SoLuongTon,
		SP.Cancellation
		FROM dbo.SanPham SP JOIN dbo.But B
		ON B.MaSP = SP.MaSP
		WHERE [dbo].[fuConvertToUnsign](SP.TenSP) LIKE N'%' + [dbo].[fuConvertToUnsign](@keyword) + '%'
		OR [dbo].[fuConvertToUnsign](SP.ThuongHieu) LIKE N'%' + [dbo].[fuConvertToUnsign](@keyword) + '%'
		OR [dbo].[fuConvertToUnsign](B.MauSac) LIKE N'%' + [dbo].[fuConvertToUnsign](@keyword) + '%'
		OR [dbo].[fuConvertToUnsign](B.ChatLieu) LIKE N'%' + [dbo].[fuConvertToUnsign](@keyword) + '%'
		OR [dbo].[fuConvertToUnsign](B.MauMuc) LIKE N'%' + [dbo].[fuConvertToUnsign](@keyword) + '%'
		RETURN
	END

	IF EXISTS (
	SELECT * FROM dbo.SanPham SP JOIN dbo.ThietBiDienTu TBDT
	ON TBDT.MaSP = SP.MaSP
	WHERE [dbo].[fuConvertToUnsign](SP.TenSP) LIKE N'%' + [dbo].[fuConvertToUnsign](@keyword) + '%'
	OR [dbo].[fuConvertToUnsign](SP.ThuongHieu) LIKE N'%' + [dbo].[fuConvertToUnsign](@keyword) + '%'
	OR [dbo].[fuConvertToUnsign](TBDT.MauSac) LIKE N'%' + [dbo].[fuConvertToUnsign](@keyword) + '%'
	OR [dbo].[fuConvertToUnsign](TBDT.ChatLieu) LIKE N'%' + [dbo].[fuConvertToUnsign](@keyword) + '%'
	OR [dbo].[fuConvertToUnsign](TBDT.ThongSoKiThuat) LIKE N'%' + [dbo].[fuConvertToUnsign](@keyword) + '%'
	)
	BEGIN
	    SELECT SP.MaSP, 
		SP.TenSP, 
		SP.DVT, 
		SP.Gia,
		SP.ThuongHieu,
		SP.SoLuongTon,
		SP.Cancellation
		FROM dbo.SanPham SP JOIN dbo.ThietBiDienTu TBDT
		ON TBDT.MaSP = SP.MaSP
		WHERE [dbo].[fuConvertToUnsign](SP.TenSP) LIKE N'%' + [dbo].[fuConvertToUnsign](@keyword) + '%'
		OR [dbo].[fuConvertToUnsign](SP.ThuongHieu) LIKE N'%' + [dbo].[fuConvertToUnsign](@keyword) + '%'
		OR [dbo].[fuConvertToUnsign](TBDT.MauSac) LIKE N'%' + [dbo].[fuConvertToUnsign](@keyword) + '%'
		OR [dbo].[fuConvertToUnsign](TBDT.ChatLieu) LIKE N'%' + [dbo].[fuConvertToUnsign](@keyword) + '%'
		OR [dbo].[fuConvertToUnsign](TBDT.ThongSoKiThuat) LIKE N'%' + [dbo].[fuConvertToUnsign](@keyword) + '%'
		RETURN
	END

	IF EXISTS (
	SELECT * FROM dbo.SanPham SP 
	WHERE SP.MaSP NOT IN (SELECT MaSP FROM dbo.Sach) AND	
	SP.MaSP NOT IN (SELECT MaSP FROM dbo.ThietBiDienTu) AND	
	SP.MaSP NOT IN (SELECT MaSP FROM dbo.But)
	AND [dbo].[fuConvertToUnsign](SP.TenSP) LIKE N'%' + [dbo].[fuConvertToUnsign](@keyword) + '%'
	OR [dbo].[fuConvertToUnsign](SP.ThuongHieu) LIKE N'%' + [dbo].[fuConvertToUnsign](@keyword) + '%'
	)
	BEGIN
	    SELECT SP.MaSP, 
		SP.TenSP, 
		SP.DVT, 
		SP.Gia,
		SP.ThuongHieu,
		SP.SoLuongTon,
		SP.Cancellation
		FROM dbo.SanPham SP 
		WHERE SP.MaSP NOT IN (SELECT MaSP FROM dbo.Sach) AND	
		SP.MaSP NOT IN (SELECT MaSP FROM dbo.ThietBiDienTu) AND	
		SP.MaSP NOT IN (SELECT MaSP FROM dbo.But)
		AND [dbo].[fuConvertToUnsign](SP.TenSP) LIKE N'%' + [dbo].[fuConvertToUnsign](@keyword) + '%'
		OR [dbo].[fuConvertToUnsign](SP.ThuongHieu) LIKE N'%' + [dbo].[fuConvertToUnsign](@keyword) + '%'
		RETURN
	END
END
GO
/****** Object:  StoredProcedure [dbo].[USP_Sellslowly]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_Sellslowly]
@StartDate AS DATE = NULL,
@EndDate AS DATE = NULL
AS
BEGIN
	IF (@StartDate IS NOT NULL AND @EndDate IS NOT NULL)
	BEGIN
		SELECT CT.MaSP, S.TenSP, SUM(CT.SoLuong) AS SoLuong
		FROM dbo.HoaDon H JOIN dbo.ChiTietHoaDon CT
		ON CT.MaHoaDon = H.MaHoaDon
		JOIN dbo.SanPham S
		ON S.MaSP = CT.MaSP
		WHERE H.NgayGiaoDich BETWEEN @StartDate AND @EndDate
		GROUP BY CT.MaSP, S.TenSP
		HAVING SUM(CT.SoLuong) > 0 AND SUM(CT.SoLuong) <
		(SELECT CAST(SUM(T.SoLuong) / COUNT(*) AS FLOAT) GiaTriTrungBinh 
		FROM (SELECT SUM(CT.SoLuong) AS SoLuong
		FROM dbo.HoaDon H JOIN dbo.ChiTietHoaDon CT
		ON CT.MaHoaDon = H.MaHoaDon
		JOIN dbo.SanPham S
		ON S.MaSP = CT.MaSP
		WHERE H.NgayGiaoDich BETWEEN @StartDate AND @EndDate
		GROUP BY CT.MaSP, S.TenSP) AS T)
	END

	IF (@StartDate IS NULL AND @EndDate IS NULL)
	BEGIN
		SELECT CT.MaSP, S.TenSP, SUM(CT.SoLuong) AS SoLuong
		FROM dbo.HoaDon H JOIN dbo.ChiTietHoaDon CT
		ON CT.MaHoaDon = H.MaHoaDon
		JOIN dbo.SanPham S
		ON S.MaSP = CT.MaSP
		GROUP BY CT.MaSP, S.TenSP
		HAVING SUM(CT.SoLuong) > 0 AND SUM(CT.SoLuong) <
		(SELECT CAST(SUM(T.SoLuong) / COUNT(*) AS FLOAT) GiaTriTrungBinh 
		FROM (SELECT SUM(CT.SoLuong) AS SoLuong
		FROM dbo.HoaDon H JOIN dbo.ChiTietHoaDon CT
		ON CT.MaHoaDon = H.MaHoaDon
		JOIN dbo.SanPham S
		ON S.MaSP = CT.MaSP
		GROUP BY CT.MaSP, S.TenSP) AS T)
	END
END
GO
/****** Object:  StoredProcedure [dbo].[USP_TableProductName]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_TableProductName]
AS
BEGIN
	SELECT (CASE
		WHEN T.TABLE_NAME = 'Sach' THEN N'Sách'
		WHEN T.TABLE_NAME = 'But' THEN N'Bút'
		WHEN T.TABLE_NAME = 'ThietBiDienTu' THEN N'Thiết bị điện tử'
		ELSE N'Văn phòng phẩm'
	END) AS Table_Display, T.TABLE_NAME AS Table_Name FROM (SELECT
  	TABLE_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE COLUMN_NAME = 'MaSP' AND TABLE_NAME <> 'ChiTietHoaDon') AS T
END
GO
/****** Object:  StoredProcedure [dbo].[USP_TheBestSellter]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_TheBestSellter]
AS
BEGIN
	SELECT ROW_NUMBER() OVER (ORDER BY NEWID()) AS rownumber, * FROM (SELECT TOP 9 CT.MaSP, S.TenSP, SUM(CT.SoLuong) AS SoLuongBan 
	FROM dbo.HoaDon H JOIN dbo.ChiTietHoaDon CT
	ON CT.MaHoaDon = H.MaHoaDon
	JOIN dbo.SanPham S
	ON S.MaSP = CT.MaSP
	WHERE H.NgayGiaoDich BETWEEN  CONVERT(DATE, CONCAT(YEAR(GETDATE()), RIGHT('0' + RTRIM(MONTH(GETDATE())), 2), '01')) AND EOMONTH(GETDATE())		
	GROUP BY CT.MaSP, S.TenSP ORDER BY SoLuongBan DESC) AS T
END
GO
/****** Object:  StoredProcedure [dbo].[USP_TheMostTransaction]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_TheMostTransaction]
AS
BEGIN
	SELECT * FROM (SELECT ROW_NUMBER() OVER (ORDER BY TongTien DESC) AS rownumber, * FROM dbo.HoaDon) AS T
	WHERE rownumber <= 2
END
GO
/****** Object:  StoredProcedure [dbo].[USP_Unsold]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_Unsold]
@StartDate AS DATE = NULL,
@EndDate AS DATE = NULL
AS
BEGIN
	IF (@StartDate IS NOT NULL AND @EndDate IS NOT NULL)
	BEGIN
		SELECT MaSP, TenSP, 0 AS SoLuong FROM dbo.SanPham
		WHERE MaSP NOT IN (
		SELECT CT.MaSP
		FROM dbo.HoaDon H JOIN dbo.ChiTietHoaDon CT
		ON CT.MaHoaDon = H.MaHoaDon
		JOIN dbo.SanPham S
		ON S.MaSP = CT.MaSP
		WHERE H.NgayGiaoDich BETWEEN @StartDate AND @EndDate
		GROUP BY CT.MaSP, S.TenSP)
	END

	IF (@StartDate IS NULL AND @EndDate IS NULL)
	BEGIN
		SELECT MaSP, TenSP, 0 AS SoLuong FROM dbo.SanPham
		WHERE MaSP NOT IN (
		SELECT CT.MaSP
		FROM dbo.HoaDon H JOIN dbo.ChiTietHoaDon CT
		ON CT.MaHoaDon = H.MaHoaDon
		JOIN dbo.SanPham S
		ON S.MaSP = CT.MaSP
		GROUP BY CT.MaSP, S.TenSP)
	END
END
GO
/****** Object:  Trigger [dbo].[TG_Bill]    Script Date: 6/5/2022 7:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TG_Bill] ON [dbo].[ChiTietHoaDon]
FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @LoaiHoaDon VARCHAR(10)
	DECLARE @MaSP INT
	DECLARE @SoLuong INT
	
	SET NOCOUNT ON;

	IF EXISTS(SELECT * FROM Inserted) AND NOT EXISTS (SELECT * FROM Deleted)
	BEGIN

		SELECT @LoaiHoaDon = HD.LoaiHoaDon, @MaSP = I.MaSP, @SoLuong = I.SoLuong FROM Inserted I
		JOIN dbo.HoaDon HD
		ON HD.MaHoaDon = I.MaHoaDon

		IF (@LoaiHoaDon = 'NBill')
		BEGIN
		    UPDATE dbo.SanPham SET SoLuongTon = SoLuongTon + @SoLuong WHERE MaSP = @MaSP
		END
		ELSE IF (@LoaiHoaDon = 'XBill')
		BEGIN
		    UPDATE dbo.SanPham SET SoLuongTon = SoLuongTon - @SoLuong WHERE MaSP = @MaSP
		END

	END
	ELSE IF EXISTS (SELECT * FROM Inserted) AND EXISTS (SELECT * FROM Deleted)
	BEGIN
		DECLARE @InsertSoLuong INT
		DECLARE @AfterSoluong INT

		SELECT @LoaiHoaDon = HD.LoaiHoaDon, @MaSP = I.MaSP, @AfterSoluong = I.SoLuong FROM Inserted I
		JOIN dbo.HoaDon HD
		ON HD.MaHoaDon = I.MaHoaDon

		SELECT @SoLuong = D.SoLuong FROM Deleted D
		SELECT @InsertSoLuong = @AfterSoluong - @SoLuong

		UPDATE dbo.SanPham SET SoLuongTon = SoLuongTon + @InsertSoLuong WHERE MaSP = @MaSP
	END
END
GO
ALTER TABLE [dbo].[ChiTietHoaDon] ENABLE TRIGGER [TG_Bill]
GO
USE [master]
GO
ALTER DATABASE [BookStore] SET  READ_WRITE 
GO
