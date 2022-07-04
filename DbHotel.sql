USE [master]
GO
/****** Object:  Database [DbHotel]    Script Date: 04/07/2022 14:53:58 ******/
CREATE DATABASE [DbHotel]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DbHotel', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DbHotel.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DbHotel_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DbHotel_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DbHotel] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DbHotel].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DbHotel] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DbHotel] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DbHotel] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DbHotel] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DbHotel] SET ARITHABORT OFF 
GO
ALTER DATABASE [DbHotel] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DbHotel] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DbHotel] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DbHotel] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DbHotel] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DbHotel] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DbHotel] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DbHotel] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DbHotel] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DbHotel] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DbHotel] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DbHotel] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DbHotel] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DbHotel] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DbHotel] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DbHotel] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DbHotel] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DbHotel] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DbHotel] SET  MULTI_USER 
GO
ALTER DATABASE [DbHotel] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DbHotel] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DbHotel] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DbHotel] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DbHotel] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DbHotel] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DbHotel] SET QUERY_STORE = OFF
GO
USE [DbHotel]
GO
/****** Object:  Table [dbo].[Job]    Script Date: 04/07/2022 14:53:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Job] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 04/07/2022 14:53:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](100) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Address] [varchar](200) NOT NULL,
	[BirthDate] [date] NOT NULL,
	[JobID] [int] NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ViewEmployee]    Script Date: 04/07/2022 14:53:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViewEmployee]
AS
SELECT dbo.Employee.Username, dbo.Employee.Name, dbo.Employee.Email, dbo.Employee.Address, dbo.Job.Name AS Job, dbo.Employee.ID, dbo.Employee.JobID, dbo.Employee.BirthDate
FROM     dbo.Employee INNER JOIN
                  dbo.Job ON dbo.Employee.JobID = dbo.Job.ID
GO
/****** Object:  Table [dbo].[Room]    Script Date: 04/07/2022 14:53:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[RoomTypeID] [int] NOT NULL,
	[RoomNumber] [int] NOT NULL,
	[RoomFloor] [int] NOT NULL,
	[Description] [text] NULL,
 CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoomType]    Script Date: 04/07/2022 14:53:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoomType](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Capacity] [int] NOT NULL,
	[RoomPrice] [int] NOT NULL,
 CONSTRAINT [PK_RoomType] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ViewRoom]    Script Date: 04/07/2022 14:53:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViewRoom]
AS
SELECT dbo.Room.RoomNumber, dbo.RoomType.Name AS RoomType, dbo.Room.RoomFloor, dbo.Room.Description, dbo.Room.ID, dbo.Room.RoomTypeID, dbo.RoomType.RoomPrice, dbo.RoomType.Capacity
FROM     dbo.Room INNER JOIN
                  dbo.RoomType ON dbo.Room.RoomTypeID = dbo.RoomType.ID
GO
/****** Object:  Table [dbo].[Reservation]    Script Date: 04/07/2022 14:53:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservation](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DateTime] [datetime] NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[CustomerID] [int] NOT NULL,
	[BookingCode] [varchar](6) NOT NULL,
 CONSTRAINT [PK_Reservation] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReservationRoom]    Script Date: 04/07/2022 14:53:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReservationRoom](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ReservationID] [int] NOT NULL,
	[RoomID] [int] NOT NULL,
	[StartDateTime] [date] NOT NULL,
	[DurationNights] [int] NOT NULL,
	[RoomPrice] [int] NOT NULL,
	[CheckinDateTime] [datetime] NOT NULL,
	[CheckoutDateTime] [datetime] NOT NULL,
 CONSTRAINT [PK_ReservationRoom] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ViewRoomCheckin]    Script Date: 04/07/2022 14:53:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViewRoomCheckin]
AS
SELECT dbo.ReservationRoom.ID, dbo.Reservation.BookingCode, dbo.Reservation.CustomerID, dbo.ViewRoom.RoomNumber, dbo.ViewRoom.RoomFloor, dbo.ViewRoom.RoomType, dbo.ReservationRoom.StartDateTime, 
                  dbo.ReservationRoom.CheckinDateTime
FROM     dbo.ReservationRoom LEFT OUTER JOIN
                  dbo.Reservation ON dbo.ReservationRoom.ReservationID = dbo.Reservation.ID INNER JOIN
                  dbo.ViewRoom ON dbo.ReservationRoom.RoomID = dbo.ViewRoom.ID
GO
/****** Object:  View [dbo].[ViewReservationRoom]    Script Date: 04/07/2022 14:53:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViewReservationRoom]
AS
SELECT dbo.ReservationRoom.ID, dbo.ReservationRoom.RoomID, dbo.ReservationRoom.CheckinDateTime, dbo.ReservationRoom.CheckoutDateTime, dbo.Room.RoomNumber
FROM     dbo.ReservationRoom INNER JOIN
                  dbo.Room ON dbo.ReservationRoom.RoomID = dbo.Room.ID
GO
/****** Object:  Table [dbo].[FoodsAndDrinks]    Script Date: 04/07/2022 14:53:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FoodsAndDrinks](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Type] [char](1) NULL,
	[Price] [int] NULL,
 CONSTRAINT [PK_FoodsAndDrinks] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FDCheckOut]    Script Date: 04/07/2022 14:53:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FDCheckOut](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ReservationRoomID] [int] NOT NULL,
	[FDID] [int] NOT NULL,
	[Qty] [int] NULL,
	[TotalPrice] [int] NULL,
	[EmployeeID] [int] NOT NULL,
 CONSTRAINT [PK_FDCheckOut] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ViewFDCheckout]    Script Date: 04/07/2022 14:53:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViewFDCheckout]
AS
SELECT dbo.FDCheckOut.ID, dbo.FDCheckOut.ReservationRoomID, dbo.FDCheckOut.FDID, dbo.FoodsAndDrinks.Name, dbo.FoodsAndDrinks.Type, dbo.FoodsAndDrinks.Price, dbo.FDCheckOut.Qty, dbo.FDCheckOut.TotalPrice
FROM     dbo.FDCheckOut INNER JOIN
                  dbo.FoodsAndDrinks ON dbo.FDCheckOut.FDID = dbo.FoodsAndDrinks.ID
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 04/07/2022 14:53:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[NIK] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Gender] [char](1) NULL,
	[PhoneNumber] [varchar](20) NULL,
	[BirthDate] [date] NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Item]    Script Date: 04/07/2022 14:53:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[RequestPrice] [int] NOT NULL,
	[CompensationFee] [int] NULL,
 CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItemStatus]    Script Date: 04/07/2022 14:53:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemStatus](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ItemStatus] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReservationCheckout]    Script Date: 04/07/2022 14:53:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReservationCheckout](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ReservationRoomID] [int] NOT NULL,
	[ItemID] [int] NOT NULL,
	[ItemStatusID] [int] NOT NULL,
	[Qty] [int] NOT NULL,
	[TotalCharge] [int] NOT NULL,
 CONSTRAINT [PK_ReservationCheckout] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReservationRequestItem]    Script Date: 04/07/2022 14:53:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReservationRequestItem](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ReservationRoomID] [int] NOT NULL,
	[ItemID] [int] NOT NULL,
	[Qty] [int] NOT NULL,
	[TotalPrice] [int] NOT NULL,
 CONSTRAINT [PK_ReservationRequestItem] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([ID], [Name], [NIK], [Email], [Gender], [PhoneNumber], [BirthDate]) VALUES (1, N'Vicky', N'', N'vicky@gmail.com', N'M', N'', CAST(N'2022-07-01' AS Date))
INSERT [dbo].[Customer] ([ID], [Name], [NIK], [Email], [Gender], [PhoneNumber], [BirthDate]) VALUES (2, N'Prya', N'', N'prya@gmail.com', N'M', N'', CAST(N'2022-07-01' AS Date))
INSERT [dbo].[Customer] ([ID], [Name], [NIK], [Email], [Gender], [PhoneNumber], [BirthDate]) VALUES (6, N'Mitra', N'', N'', N'M', N'', CAST(N'2022-07-01' AS Date))
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([ID], [Username], [Password], [Name], [Email], [Address], [BirthDate], [JobID]) VALUES (1, N'admin', N'8C6976E5B5410415BDE908BD4DEE15DFB167A9C873FC4BB8A81F6F2AB448A918', N'Admin', N'admin@admin.com', N'Internet', CAST(N'2001-01-01' AS Date), 2)
INSERT [dbo].[Employee] ([ID], [Username], [Password], [Name], [Email], [Address], [BirthDate], [JobID]) VALUES (2, N'vicky', N'C9805E841751391CA18D1C3508700975438FE0E86161F2D52E5ADE49CBB41776', N'Vicky', N'vicky@gmail.com', N'Tulungagung', CAST(N'2002-02-20' AS Date), 1)
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
SET IDENTITY_INSERT [dbo].[FoodsAndDrinks] ON 

INSERT [dbo].[FoodsAndDrinks] ([ID], [Name], [Type], [Price]) VALUES (1, N'BengBeng', N'F', 1000)
INSERT [dbo].[FoodsAndDrinks] ([ID], [Name], [Type], [Price]) VALUES (2, N'Malkist Abon', N'F', 4500)
INSERT [dbo].[FoodsAndDrinks] ([ID], [Name], [Type], [Price]) VALUES (3, N'Nabati Cheese Wafer', N'F', 10000)
INSERT [dbo].[FoodsAndDrinks] ([ID], [Name], [Type], [Price]) VALUES (4, N'Floridina Orange', N'D', 3000)
INSERT [dbo].[FoodsAndDrinks] ([ID], [Name], [Type], [Price]) VALUES (5, N'Teh Pucuk Harum', N'D', 2000)
SET IDENTITY_INSERT [dbo].[FoodsAndDrinks] OFF
GO
SET IDENTITY_INSERT [dbo].[Item] ON 

INSERT [dbo].[Item] ([ID], [Name], [RequestPrice], [CompensationFee]) VALUES (1, N'Selimut', 50000, 100000)
INSERT [dbo].[Item] ([ID], [Name], [RequestPrice], [CompensationFee]) VALUES (2, N'Bantal', 100000, 200000)
SET IDENTITY_INSERT [dbo].[Item] OFF
GO
SET IDENTITY_INSERT [dbo].[ItemStatus] ON 

INSERT [dbo].[ItemStatus] ([ID], [Name]) VALUES (1, N'NORMAL')
INSERT [dbo].[ItemStatus] ([ID], [Name]) VALUES (2, N'BROKEN')
SET IDENTITY_INSERT [dbo].[ItemStatus] OFF
GO
SET IDENTITY_INSERT [dbo].[Job] ON 

INSERT [dbo].[Job] ([ID], [Name]) VALUES (1, N'Front Office')
INSERT [dbo].[Job] ([ID], [Name]) VALUES (2, N'Admin')
SET IDENTITY_INSERT [dbo].[Job] OFF
GO
SET IDENTITY_INSERT [dbo].[Reservation] ON 

INSERT [dbo].[Reservation] ([ID], [DateTime], [EmployeeID], [CustomerID], [BookingCode]) VALUES (1, CAST(N'2022-07-01T00:00:00.000' AS DateTime), 2, 1, N'')
INSERT [dbo].[Reservation] ([ID], [DateTime], [EmployeeID], [CustomerID], [BookingCode]) VALUES (2, CAST(N'2022-07-01T00:00:00.000' AS DateTime), 2, 1, N'PXLYL8')
INSERT [dbo].[Reservation] ([ID], [DateTime], [EmployeeID], [CustomerID], [BookingCode]) VALUES (3, CAST(N'2022-07-01T00:00:00.000' AS DateTime), 2, 1, N'4V2JKL')
SET IDENTITY_INSERT [dbo].[Reservation] OFF
GO
SET IDENTITY_INSERT [dbo].[ReservationCheckout] ON 

INSERT [dbo].[ReservationCheckout] ([ID], [ReservationRoomID], [ItemID], [ItemStatusID], [Qty], [TotalCharge]) VALUES (1, 1, 1, 1, 1, 50000)
SET IDENTITY_INSERT [dbo].[ReservationCheckout] OFF
GO
SET IDENTITY_INSERT [dbo].[ReservationRequestItem] ON 

INSERT [dbo].[ReservationRequestItem] ([ID], [ReservationRoomID], [ItemID], [Qty], [TotalPrice]) VALUES (1, 1, 1, 1, 50000)
INSERT [dbo].[ReservationRequestItem] ([ID], [ReservationRoomID], [ItemID], [Qty], [TotalPrice]) VALUES (2, 3, 1, 1, 50000)
INSERT [dbo].[ReservationRequestItem] ([ID], [ReservationRoomID], [ItemID], [Qty], [TotalPrice]) VALUES (3, 1, 2, 1, 100000)
INSERT [dbo].[ReservationRequestItem] ([ID], [ReservationRoomID], [ItemID], [Qty], [TotalPrice]) VALUES (4, 1, 2, 1, 100000)
SET IDENTITY_INSERT [dbo].[ReservationRequestItem] OFF
GO
SET IDENTITY_INSERT [dbo].[ReservationRoom] ON 

INSERT [dbo].[ReservationRoom] ([ID], [ReservationID], [RoomID], [StartDateTime], [DurationNights], [RoomPrice], [CheckinDateTime], [CheckoutDateTime]) VALUES (1, 1, 1, CAST(N'2022-07-01' AS Date), 1, 250000, CAST(N'2022-07-01T16:29:25.717' AS DateTime), CAST(N'2022-07-02T16:29:25.667' AS DateTime))
INSERT [dbo].[ReservationRoom] ([ID], [ReservationID], [RoomID], [StartDateTime], [DurationNights], [RoomPrice], [CheckinDateTime], [CheckoutDateTime]) VALUES (2, 2, 1, CAST(N'2022-07-01' AS Date), 2, 500000, CAST(N'2022-07-19T16:59:51.000' AS DateTime), CAST(N'2022-07-21T16:59:51.000' AS DateTime))
INSERT [dbo].[ReservationRoom] ([ID], [ReservationID], [RoomID], [StartDateTime], [DurationNights], [RoomPrice], [CheckinDateTime], [CheckoutDateTime]) VALUES (3, 3, 1, CAST(N'2022-07-02' AS Date), 1, 250000, CAST(N'2022-07-02T19:57:39.000' AS DateTime), CAST(N'2022-07-03T19:57:39.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[ReservationRoom] OFF
GO
SET IDENTITY_INSERT [dbo].[Room] ON 

INSERT [dbo].[Room] ([ID], [RoomTypeID], [RoomNumber], [RoomFloor], [Description]) VALUES (1, 1, 1, 1, N'')
INSERT [dbo].[Room] ([ID], [RoomTypeID], [RoomNumber], [RoomFloor], [Description]) VALUES (3, 1, 2, 1, N'Just normal room')
SET IDENTITY_INSERT [dbo].[Room] OFF
GO
SET IDENTITY_INSERT [dbo].[RoomType] ON 

INSERT [dbo].[RoomType] ([ID], [Name], [Capacity], [RoomPrice]) VALUES (1, N'Standard Single Bed', 1, 250000)
INSERT [dbo].[RoomType] ([ID], [Name], [Capacity], [RoomPrice]) VALUES (2, N'Standard Double Bed', 2, 450000)
INSERT [dbo].[RoomType] ([ID], [Name], [Capacity], [RoomPrice]) VALUES (3, N'Standart Twin Bed', 1, 500000)
INSERT [dbo].[RoomType] ([ID], [Name], [Capacity], [RoomPrice]) VALUES (4, N'Deluxe Single Bed', 1, 700000)
SET IDENTITY_INSERT [dbo].[RoomType] OFF
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Job] FOREIGN KEY([JobID])
REFERENCES [dbo].[Job] ([ID])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Job]
GO
ALTER TABLE [dbo].[FDCheckOut]  WITH CHECK ADD  CONSTRAINT [FK_FDCheckOut_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([ID])
GO
ALTER TABLE [dbo].[FDCheckOut] CHECK CONSTRAINT [FK_FDCheckOut_Employee]
GO
ALTER TABLE [dbo].[FDCheckOut]  WITH CHECK ADD  CONSTRAINT [FK_FDCheckOut_FoodsAndDrinks] FOREIGN KEY([FDID])
REFERENCES [dbo].[FoodsAndDrinks] ([ID])
GO
ALTER TABLE [dbo].[FDCheckOut] CHECK CONSTRAINT [FK_FDCheckOut_FoodsAndDrinks]
GO
ALTER TABLE [dbo].[FDCheckOut]  WITH CHECK ADD  CONSTRAINT [FK_FDCheckOut_ReservationRoom] FOREIGN KEY([ReservationRoomID])
REFERENCES [dbo].[ReservationRoom] ([ID])
GO
ALTER TABLE [dbo].[FDCheckOut] CHECK CONSTRAINT [FK_FDCheckOut_ReservationRoom]
GO
ALTER TABLE [dbo].[Reservation]  WITH CHECK ADD  CONSTRAINT [FK_Reservation_Customer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([ID])
GO
ALTER TABLE [dbo].[Reservation] CHECK CONSTRAINT [FK_Reservation_Customer]
GO
ALTER TABLE [dbo].[Reservation]  WITH CHECK ADD  CONSTRAINT [FK_Reservation_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([ID])
GO
ALTER TABLE [dbo].[Reservation] CHECK CONSTRAINT [FK_Reservation_Employee]
GO
ALTER TABLE [dbo].[ReservationCheckout]  WITH CHECK ADD  CONSTRAINT [FK_ReservationCheckout_Item] FOREIGN KEY([ItemID])
REFERENCES [dbo].[Item] ([ID])
GO
ALTER TABLE [dbo].[ReservationCheckout] CHECK CONSTRAINT [FK_ReservationCheckout_Item]
GO
ALTER TABLE [dbo].[ReservationCheckout]  WITH CHECK ADD  CONSTRAINT [FK_ReservationCheckout_ItemStatus] FOREIGN KEY([ItemStatusID])
REFERENCES [dbo].[ItemStatus] ([ID])
GO
ALTER TABLE [dbo].[ReservationCheckout] CHECK CONSTRAINT [FK_ReservationCheckout_ItemStatus]
GO
ALTER TABLE [dbo].[ReservationCheckout]  WITH CHECK ADD  CONSTRAINT [FK_ReservationCheckout_ReservationRoom] FOREIGN KEY([ReservationRoomID])
REFERENCES [dbo].[ReservationRoom] ([ID])
GO
ALTER TABLE [dbo].[ReservationCheckout] CHECK CONSTRAINT [FK_ReservationCheckout_ReservationRoom]
GO
ALTER TABLE [dbo].[ReservationRequestItem]  WITH CHECK ADD  CONSTRAINT [FK_ReservationRequestItem_Item] FOREIGN KEY([ItemID])
REFERENCES [dbo].[Item] ([ID])
GO
ALTER TABLE [dbo].[ReservationRequestItem] CHECK CONSTRAINT [FK_ReservationRequestItem_Item]
GO
ALTER TABLE [dbo].[ReservationRequestItem]  WITH CHECK ADD  CONSTRAINT [FK_ReservationRequestItem_ReservationRoom] FOREIGN KEY([ReservationRoomID])
REFERENCES [dbo].[ReservationRoom] ([ID])
GO
ALTER TABLE [dbo].[ReservationRequestItem] CHECK CONSTRAINT [FK_ReservationRequestItem_ReservationRoom]
GO
ALTER TABLE [dbo].[ReservationRoom]  WITH CHECK ADD  CONSTRAINT [FK_ReservationRoom_Reservation] FOREIGN KEY([ReservationID])
REFERENCES [dbo].[Reservation] ([ID])
GO
ALTER TABLE [dbo].[ReservationRoom] CHECK CONSTRAINT [FK_ReservationRoom_Reservation]
GO
ALTER TABLE [dbo].[ReservationRoom]  WITH CHECK ADD  CONSTRAINT [FK_ReservationRoom_Room] FOREIGN KEY([RoomID])
REFERENCES [dbo].[Room] ([ID])
GO
ALTER TABLE [dbo].[ReservationRoom] CHECK CONSTRAINT [FK_ReservationRoom_Room]
GO
ALTER TABLE [dbo].[Room]  WITH CHECK ADD  CONSTRAINT [FK_Room_RoomType] FOREIGN KEY([RoomTypeID])
REFERENCES [dbo].[RoomType] ([ID])
GO
ALTER TABLE [dbo].[Room] CHECK CONSTRAINT [FK_Room_RoomType]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Employee"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Job"
            Begin Extent = 
               Top = 7
               Left = 290
               Bottom = 126
               Right = 484
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewEmployee'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewEmployee'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "FDCheckOut"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 275
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "FoodsAndDrinks"
            Begin Extent = 
               Top = 7
               Left = 323
               Bottom = 170
               Right = 517
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewFDCheckout'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewFDCheckout'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ReservationRoom"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 269
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Room"
            Begin Extent = 
               Top = 7
               Left = 317
               Bottom = 170
               Right = 511
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewReservationRoom'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewReservationRoom'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Room"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "RoomType"
            Begin Extent = 
               Top = 7
               Left = 290
               Bottom = 170
               Right = 484
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewRoom'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewRoom'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ReservationRoom"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 269
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "Reservation"
            Begin Extent = 
               Top = 7
               Left = 317
               Bottom = 170
               Right = 511
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "ViewRoom"
            Begin Extent = 
               Top = 7
               Left = 559
               Bottom = 170
               Right = 753
            End
            DisplayFlags = 280
            TopColumn = 4
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewRoomCheckin'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewRoomCheckin'
GO
USE [master]
GO
ALTER DATABASE [DbHotel] SET  READ_WRITE 
GO
