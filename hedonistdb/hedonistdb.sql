--USE [master]
--GO
/****** Object:  Database [HedonistDB]    Script Date: 19.01.2019 05:24:11 ******/
CREATE DATABASE [HedonistDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HedonistDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\HedonistDB.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'HedonistDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\HedonistDB_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [HedonistDB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HedonistDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HedonistDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HedonistDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HedonistDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HedonistDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HedonistDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [HedonistDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [HedonistDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HedonistDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HedonistDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HedonistDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HedonistDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HedonistDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HedonistDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HedonistDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HedonistDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [HedonistDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HedonistDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HedonistDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HedonistDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HedonistDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HedonistDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HedonistDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HedonistDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HedonistDB] SET  MULTI_USER 
GO
ALTER DATABASE [HedonistDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HedonistDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HedonistDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HedonistDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [HedonistDB] SET DELAYED_DURABILITY = DISABLED 
GO
USE [HedonistDB]
GO
/****** Object:  Table [dbo].[Admins]    Script Date: 19.01.2019 05:24:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admins](
	[AdminID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](20) NOT NULL,
	[Password] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_Admins] PRIMARY KEY CLUSTERED 
(
	[AdminID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Brands]    Script Date: 19.01.2019 05:24:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brands](
	[BrandID] [int] IDENTITY(1,1) NOT NULL,
	[BrandName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Brands] PRIMARY KEY CLUSTERED 
(
	[BrandID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Categories]    Script Date: 19.01.2019 05:24:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](20) NOT NULL,
	[Description] [nvarchar](200) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 19.01.2019 05:24:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[OrderID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[Quantity] [smallint] NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC,
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Orders]    Script Date: 19.01.2019 05:24:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[ShipperID] [int] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Products]    Script Date: 19.01.2019 05:24:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductsID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](50) NOT NULL,
	[CategoryID] [int] NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[BrandID] [int] NOT NULL,
	[Deleted] [bit] NULL,
	[Picture] [image] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Shippers]    Script Date: 19.01.2019 05:24:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shippers](
	[ShipperID] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](20) NULL,
 CONSTRAINT [PK_Shippers] PRIMARY KEY CLUSTERED 
(
	[ShipperID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users1]    Script Date: 19.01.2019 05:24:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users1](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](20) NOT NULL,
	[Password] [nvarchar](15) NOT NULL,
	[Address] [nvarchar](200) NOT NULL,
	[Email] [nvarchar](30) NOT NULL,
	[FirstName] [nvarchar](20) NULL,
	[LastName] [nvarchar](20) NULL,
 CONSTRAINT [PK_Users1] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Admins] ON 

INSERT [dbo].[Admins] ([AdminID], [UserName], [Password]) VALUES (1, N'cagri', N'bilgeadam')
INSERT [dbo].[Admins] ([AdminID], [UserName], [Password]) VALUES (2, N'omer', N'bilgeadam')
INSERT [dbo].[Admins] ([AdminID], [UserName], [Password]) VALUES (3, N'serkan', N'bilgeadam')
INSERT [dbo].[Admins] ([AdminID], [UserName], [Password]) VALUES (4, N'enes', N'bilgeadam')
SET IDENTITY_INSERT [dbo].[Admins] OFF
SET IDENTITY_INSERT [dbo].[Brands] ON 

INSERT [dbo].[Brands] ([BrandID], [BrandName]) VALUES (1, N'Nike')
INSERT [dbo].[Brands] ([BrandID], [BrandName]) VALUES (2, N'Adidas')
INSERT [dbo].[Brands] ([BrandID], [BrandName]) VALUES (3, N'Puma')
INSERT [dbo].[Brands] ([BrandID], [BrandName]) VALUES (4, N'NewBalance')
INSERT [dbo].[Brands] ([BrandID], [BrandName]) VALUES (5, N'Kemal Tanca')
INSERT [dbo].[Brands] ([BrandID], [BrandName]) VALUES (6, N'Greyder')
INSERT [dbo].[Brands] ([BrandID], [BrandName]) VALUES (7, N'Harley Davidson')
INSERT [dbo].[Brands] ([BrandID], [BrandName]) VALUES (8, N'Scooter')
SET IDENTITY_INSERT [dbo].[Brands] OFF
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description]) VALUES (1, N'spor', NULL)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description]) VALUES (2, N'kundura', NULL)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description]) VALUES (3, N'günlük7', NULL)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description]) VALUES (4, N'Basketbol Ayakkabısı', NULL)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description]) VALUES (5, N'Krampon', NULL)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description]) VALUES (6, N'Terlik', NULL)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description]) VALUES (7, N'Sandalet', NULL)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description]) VALUES (8, N'Bot', NULL)
SET IDENTITY_INSERT [dbo].[Categories] OFF
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity]) VALUES (50, 20, 450.0000, 1)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity]) VALUES (50, 25, 50.0000, 1)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity]) VALUES (50, 26, 120.0000, 1)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity]) VALUES (51, 14, 1000.0000, 2)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity]) VALUES (51, 18, 600.0000, 2)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity]) VALUES (51, 23, 1200.0000, 2)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity]) VALUES (51, 26, 240.0000, 2)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity]) VALUES (52, 20, 450.0000, 1)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity]) VALUES (52, 22, 220.0000, 1)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity]) VALUES (52, 26, 120.0000, 1)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity]) VALUES (53, 21, 370.0000, 1)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity]) VALUES (53, 25, 50.0000, 1)
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (1, 1, CAST(N'2019-01-13 20:12:26.167' AS DateTime), 3)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (2, 1, CAST(N'2019-01-13 20:13:26.163' AS DateTime), 2)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (3, 6, CAST(N'2019-01-13 21:05:04.650' AS DateTime), 1)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (4, 6, CAST(N'2019-01-13 21:06:13.547' AS DateTime), 1)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (5, 6, CAST(N'2019-01-13 21:18:32.097' AS DateTime), 1)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (6, 6, CAST(N'2019-01-13 21:21:03.977' AS DateTime), 1)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (7, 6, CAST(N'2019-01-13 21:23:23.907' AS DateTime), 1)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (8, 6, CAST(N'2019-01-13 21:25:16.803' AS DateTime), 1)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (9, 6, CAST(N'2019-01-13 21:30:09.547' AS DateTime), 1)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (10, 6, CAST(N'2019-01-13 21:32:54.360' AS DateTime), 1)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (11, 6, CAST(N'2019-01-13 21:45:06.293' AS DateTime), 1)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (12, 4, CAST(N'2019-01-18 22:08:47.323' AS DateTime), 2)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (13, 4, CAST(N'2019-01-18 22:23:02.443' AS DateTime), 3)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (14, 4, CAST(N'2019-01-18 22:25:22.340' AS DateTime), 2)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (15, 4, CAST(N'2019-01-18 22:26:13.167' AS DateTime), 2)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (16, 4, CAST(N'2019-01-18 22:40:36.820' AS DateTime), 3)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (17, 4, CAST(N'2019-01-18 22:52:29.797' AS DateTime), 3)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (18, 4, CAST(N'2019-01-18 22:59:59.293' AS DateTime), 2)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (19, 4, CAST(N'2019-01-18 23:01:17.083' AS DateTime), 2)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (20, 4, CAST(N'2019-01-18 23:02:44.020' AS DateTime), 2)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (21, 4, CAST(N'2019-01-18 23:05:20.460' AS DateTime), 2)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (22, 4, CAST(N'2019-01-18 23:07:03.390' AS DateTime), 2)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (23, 4, CAST(N'2019-01-18 23:17:44.603' AS DateTime), 2)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (24, 4, CAST(N'2019-01-18 23:18:20.347' AS DateTime), 2)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (25, 4, CAST(N'2019-01-18 23:20:57.527' AS DateTime), 2)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (26, 4, CAST(N'2019-01-18 23:41:43.403' AS DateTime), 3)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (27, 7, CAST(N'2019-01-18 23:58:17.150' AS DateTime), 2)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (28, 4, CAST(N'2019-01-19 00:01:09.697' AS DateTime), 2)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (29, 7, CAST(N'2019-01-19 00:04:26.040' AS DateTime), 2)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (30, 3, CAST(N'2019-01-19 00:14:25.887' AS DateTime), 2)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (31, 5, CAST(N'2019-01-19 00:21:06.007' AS DateTime), 2)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (32, 4, CAST(N'2019-01-19 00:42:04.863' AS DateTime), 2)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (33, 4, CAST(N'2019-01-19 00:43:41.943' AS DateTime), 3)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (34, 4, CAST(N'2019-01-19 00:46:33.383' AS DateTime), 2)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (35, 4, CAST(N'2019-01-19 00:48:51.563' AS DateTime), 2)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (36, 4, CAST(N'2019-01-19 00:49:36.127' AS DateTime), 2)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (37, 4, CAST(N'2019-01-19 00:53:06.357' AS DateTime), 2)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (38, 4, CAST(N'2019-01-19 00:54:30.013' AS DateTime), 2)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (39, 4, CAST(N'2019-01-19 00:57:36.297' AS DateTime), 2)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (40, 4, CAST(N'2019-01-19 00:58:11.993' AS DateTime), 2)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (41, 4, CAST(N'2019-01-19 01:02:08.143' AS DateTime), 2)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (42, 4, CAST(N'2019-01-19 01:03:08.550' AS DateTime), 2)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (43, 4, CAST(N'2019-01-19 01:05:50.690' AS DateTime), 1)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (44, 4, CAST(N'2019-01-19 01:09:01.767' AS DateTime), 2)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (45, 4, CAST(N'2019-01-19 01:33:11.353' AS DateTime), 2)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (46, 4, CAST(N'2019-01-19 01:39:42.087' AS DateTime), 2)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (47, 4, CAST(N'2019-01-19 01:40:33.610' AS DateTime), 1)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (48, 4, CAST(N'2019-01-19 01:46:08.677' AS DateTime), 2)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (49, 6, CAST(N'2019-01-19 03:47:26.477' AS DateTime), 3)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (50, 6, CAST(N'2019-01-19 04:45:08.113' AS DateTime), 3)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (51, 6, CAST(N'2019-01-19 04:46:16.777' AS DateTime), 2)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (52, 6, CAST(N'2019-01-19 04:57:51.477' AS DateTime), 3)
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [ShipperID]) VALUES (53, 6, CAST(N'2019-01-19 05:08:18.903' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Orders] OFF
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductsID], [ProductName], [CategoryID], [UnitPrice], [BrandID], [Deleted], [Picture]) VALUES (14, N'Orjinal Deri Kundura Ayakkabı', 2, 500.0000, 5, NULL, NULL)
INSERT [dbo].[Products] ([ProductsID], [ProductName], [CategoryID], [UnitPrice], [BrandID], [Deleted], [Picture]) VALUES (15, N'Super Star', 1, 400.0000, 2, NULL, NULL)
INSERT [dbo].[Products] ([ProductsID], [ProductName], [CategoryID], [UnitPrice], [BrandID], [Deleted], [Picture]) VALUES (16, N'Runner', 1, 250.0000, 1, NULL, NULL)
INSERT [dbo].[Products] ([ProductsID], [ProductName], [CategoryID], [UnitPrice], [BrandID], [Deleted], [Picture]) VALUES (17, N'SuperFly CR7', 5, 900.0000, 1, NULL, NULL)
INSERT [dbo].[Products] ([ProductsID], [ProductName], [CategoryID], [UnitPrice], [BrandID], [Deleted], [Picture]) VALUES (18, N'Legend Trainer', 1, 300.0000, 1, NULL, NULL)
INSERT [dbo].[Products] ([ProductsID], [ProductName], [CategoryID], [UnitPrice], [BrandID], [Deleted], [Picture]) VALUES (19, N'Phantom', 5, 750.0000, 1, NULL, NULL)
INSERT [dbo].[Products] ([ProductsID], [ProductName], [CategoryID], [UnitPrice], [BrandID], [Deleted], [Picture]) VALUES (20, N'Roma Basic', 1, 450.0000, 3, NULL, NULL)
INSERT [dbo].[Products] ([ProductsID], [ProductName], [CategoryID], [UnitPrice], [BrandID], [Deleted], [Picture]) VALUES (21, N'Smash', 3, 370.0000, 3, NULL, NULL)
INSERT [dbo].[Products] ([ProductsID], [ProductName], [CategoryID], [UnitPrice], [BrandID], [Deleted], [Picture]) VALUES (22, N'ML370NBW 370', 3, 220.0000, 4, NULL, NULL)
INSERT [dbo].[Products] ([ProductsID], [ProductName], [CategoryID], [UnitPrice], [BrandID], [Deleted], [Picture]) VALUES (23, N'Siyah Deri City Bot', 8, 600.0000, 8, NULL, NULL)
INSERT [dbo].[Products] ([ProductsID], [ProductName], [CategoryID], [UnitPrice], [BrandID], [Deleted], [Picture]) VALUES (24, N'Nike Plaj Terliği', 6, 600.0000, 1, NULL, NULL)
INSERT [dbo].[Products] ([ProductsID], [ProductName], [CategoryID], [UnitPrice], [BrandID], [Deleted], [Picture]) VALUES (25, N'Adidas Terlik', 6, 50.0000, 2, NULL, NULL)
INSERT [dbo].[Products] ([ProductsID], [ProductName], [CategoryID], [UnitPrice], [BrandID], [Deleted], [Picture]) VALUES (26, N'Sandalet', 7, 120.0000, 5, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Products] OFF
SET IDENTITY_INSERT [dbo].[Shippers] ON 

INSERT [dbo].[Shippers] ([ShipperID], [CompanyName], [Phone]) VALUES (1, N'yurt içi', NULL)
INSERT [dbo].[Shippers] ([ShipperID], [CompanyName], [Phone]) VALUES (2, N'mng', NULL)
INSERT [dbo].[Shippers] ([ShipperID], [CompanyName], [Phone]) VALUES (3, N'ptt', NULL)
SET IDENTITY_INSERT [dbo].[Shippers] OFF
SET IDENTITY_INSERT [dbo].[Users1] ON 

INSERT [dbo].[Users1] ([UserID], [UserName], [Password], [Address], [Email], [FirstName], [LastName]) VALUES (1, N'enes11', N'123', N'ABC', N'abc', N'ENES', N'BABAOĞLU')
INSERT [dbo].[Users1] ([UserID], [UserName], [Password], [Address], [Email], [FirstName], [LastName]) VALUES (2, N'omer faruk', N'123', N'skudfgsıf', N'sdfskdfbsfgsudf', N'omer faruk', N'altun')
INSERT [dbo].[Users1] ([UserID], [UserName], [Password], [Address], [Email], [FirstName], [LastName]) VALUES (3, N'enes', N'123', N'asdfad', N'babaoglu_enes@outlook.com', N'enes', N'abab')
INSERT [dbo].[Users1] ([UserID], [UserName], [Password], [Address], [Email], [FirstName], [LastName]) VALUES (4, N'serkan', N'123', N'gdfugsv', N'serkanyurttapan34@hotmail.com', N'serkan', N'yurt')
INSERT [dbo].[Users1] ([UserID], [UserName], [Password], [Address], [Email], [FirstName], [LastName]) VALUES (5, N'', N'123', N'Kadıkoy/ISTANBUL', N'cagri.yolyapar@bilgeadam.com', N'Çağrı', N'Yolyapar')
INSERT [dbo].[Users1] ([UserID], [UserName], [Password], [Address], [Email], [FirstName], [LastName]) VALUES (6, N'fatih', N'123', N'srhtdjdtj', N'jftkfykfgyk', N'fatih', N'terim')
INSERT [dbo].[Users1] ([UserID], [UserName], [Password], [Address], [Email], [FirstName], [LastName]) VALUES (7, N'omer', N'123', N'abcdefg', N'omerfarukaltunn@outlook.com', N'ömer', N'altun')
INSERT [dbo].[Users1] ([UserID], [UserName], [Password], [Address], [Email], [FirstName], [LastName]) VALUES (10, N'enes1', N'babaogl', N'jhfvsd', N'gfnmgxm', N'fgmxfm', N'gfnvm')
INSERT [dbo].[Users1] ([UserID], [UserName], [Password], [Address], [Email], [FirstName], [LastName]) VALUES (11, N'ahmet', N'123', N'asdfghjklş', N'sfsjdgsdv', N'ahmet', N'öz')
SET IDENTITY_INSERT [dbo].[Users1] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [Useers_Email_Unique]    Script Date: 19.01.2019 05:24:11 ******/
ALTER TABLE [dbo].[Users1] ADD  CONSTRAINT [Useers_Email_Unique] UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Orders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Orders]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductsID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Products]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Shippers] FOREIGN KEY([ShipperID])
REFERENCES [dbo].[Shippers] ([ShipperID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Shippers]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Users1] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users1] ([UserID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Users1]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Brands] FOREIGN KEY([BrandID])
REFERENCES [dbo].[Brands] ([BrandID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Brands]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([CategoryID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories]
GO
USE [master]
GO
ALTER DATABASE [HedonistDB] SET  READ_WRITE 
GO
