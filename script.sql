USE [ql]
GO
/****** Object:  Table [dbo].[Xe]    Script Date: 09/19/2021 22:19:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Xe](
	[ID] [int] NOT NULL,
	[Capacity] [int] NULL,
	[Status] [nvarchar](20) NULL,
	[Price] [int] NULL,
	[Model] [nchar](20) NULL,
 CONSTRAINT [PK_Xe] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TTXeDangThue]    Script Date: 09/19/2021 22:19:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TTXeDangThue](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[idXe] [int] NULL,
	[CMND] [nvarchar](10) NULL,
	[TênKH] [nvarchar](20) NULL,
	[TimeStart] [datetime] NULL,
	[SoNguoi] [int] NULL,
	[ThoiGianThue] [int] NULL,
	[PhuThuCheckIn] [int] NULL,
	[PhuThuCheckOut] [int] NULL,
	[GiaXe] [int] NULL,
	[PhuThuThem] [int] NULL,
	[Total] [int] NULL,
 CONSTRAINT [PK_TTXeDangThue] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 09/19/2021 22:19:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](20) NULL,
	[DoB] [datetime] NOT NULL,
	[Phone] [nvarchar](10) NULL,
	[Sex] [nchar](10) NULL,
	[Role] [nchar](20) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichSuDangNhap]    Script Date: 09/19/2021 22:19:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichSuDangNhap](
	[idLogin] [int] IDENTITY(1,1) NOT NULL,
	[idNhanVien] [int] NOT NULL,
	[TimeLogin] [datetime] NULL,
 CONSTRAINT [PK_LichSuDangNhap] PRIMARY KEY CLUSTERED 
(
	[idLogin] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 09/19/2021 22:19:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[CMND] [nvarchar](10) NOT NULL,
	[Name] [nvarchar](20) NULL,
	[Phone] [nvarchar](20) NULL,
	[Address] [nchar](10) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[CMND] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 09/19/2021 22:19:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[idHoadon] [int] IDENTITY(1,1) NOT NULL,
	[idPhong] [int] NOT NULL,
	[TenKH] [nvarchar](20) NOT NULL,
	[CMND] [nvarchar](10) NOT NULL,
	[NgayLapHD] [datetime] NULL,
	[PhuThuCI] [int] NULL,
	[PhuThuCO] [int] NULL,
	[GiaPhongNiemYet] [int] NULL,
	[SoNgayThue] [int] NULL,
	[PhuThu] [int] NULL,
	[TongCong] [int] NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[idHoadon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[xoaNhanVien]    Script Date: 09/19/2021 22:19:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[xoaNhanVien] @id int
as
delete from NhanVien
where ID = @id
GO
