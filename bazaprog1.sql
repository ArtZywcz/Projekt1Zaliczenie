USE [master]
GO
/****** Object:  Database [flood]    Script Date: 01/06/2020 10:07:46 ******/
CREATE DATABASE [flood]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'flood', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\flood.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'flood_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\flood_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [flood] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [flood].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [flood] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [flood] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [flood] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [flood] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [flood] SET ARITHABORT OFF 
GO
ALTER DATABASE [flood] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [flood] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [flood] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [flood] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [flood] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [flood] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [flood] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [flood] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [flood] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [flood] SET  DISABLE_BROKER 
GO
ALTER DATABASE [flood] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [flood] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [flood] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [flood] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [flood] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [flood] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [flood] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [flood] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [flood] SET  MULTI_USER 
GO
ALTER DATABASE [flood] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [flood] SET DB_CHAINING OFF 
GO
ALTER DATABASE [flood] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [flood] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [flood] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [flood] SET QUERY_STORE = OFF
GO
USE [flood]
GO
/****** Object:  Table [dbo].[Forecast]    Script Date: 01/06/2020 10:07:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Forecast](
	[ForecastID] [int] NOT NULL,
	[Date] [datetime] NOT NULL,
	[LocationID] [int] NOT NULL,
	[Rainfall] [int] NOT NULL,
	[Temperature] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ForecastID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Location]    Script Date: 01/06/2020 10:07:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Location](
	[LocationID] [int] NOT NULL,
	[PositionX] [int] NOT NULL,
	[PositionY] [int] NOT NULL,
	[Tilt] [int] NULL,
	[TiltDirection] [int] NULL,
	[AbsRate] [int] NOT NULL,
	[AbsCap] [int] NOT NULL,
	[AbsNow] [int] NOT NULL,
	[AbsOut] [int] NOT NULL,
 CONSTRAINT [PK_Location] PRIMARY KEY CLUSTERED 
(
	[LocationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 01/06/2020 10:07:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserID] [int] NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[SecondName] [varchar](50) NOT NULL,
	[LocationID] [int] NOT NULL,
	[Phone] [int] NULL,
	[Email] [nvarchar](50) NULL,
	[MessengerCode] [varchar](50) NULL,
	[PrefMethod] [tinyint] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Forecast] ([ForecastID], [Date], [LocationID], [Rainfall], [Temperature]) VALUES (1, CAST(N'2020-01-01T00:00:00.000' AS DateTime), 1, 500, NULL)
INSERT [dbo].[Forecast] ([ForecastID], [Date], [LocationID], [Rainfall], [Temperature]) VALUES (2, CAST(N'2020-01-01T00:00:00.000' AS DateTime), 2, 500, NULL)
INSERT [dbo].[Forecast] ([ForecastID], [Date], [LocationID], [Rainfall], [Temperature]) VALUES (3, CAST(N'2020-01-01T00:00:00.000' AS DateTime), 3, 500, NULL)
INSERT [dbo].[Forecast] ([ForecastID], [Date], [LocationID], [Rainfall], [Temperature]) VALUES (4, CAST(N'2020-01-01T00:00:00.000' AS DateTime), 4, 500, NULL)
INSERT [dbo].[Forecast] ([ForecastID], [Date], [LocationID], [Rainfall], [Temperature]) VALUES (5, CAST(N'2020-01-01T00:00:00.000' AS DateTime), 16, 200, NULL)
INSERT [dbo].[Forecast] ([ForecastID], [Date], [LocationID], [Rainfall], [Temperature]) VALUES (6, CAST(N'2020-01-01T01:00:00.000' AS DateTime), 1, 500, NULL)
INSERT [dbo].[Forecast] ([ForecastID], [Date], [LocationID], [Rainfall], [Temperature]) VALUES (7, CAST(N'2020-01-01T01:00:00.000' AS DateTime), 2, 500, NULL)
INSERT [dbo].[Forecast] ([ForecastID], [Date], [LocationID], [Rainfall], [Temperature]) VALUES (8, CAST(N'2020-01-01T01:00:00.000' AS DateTime), 3, 500, NULL)
INSERT [dbo].[Forecast] ([ForecastID], [Date], [LocationID], [Rainfall], [Temperature]) VALUES (9, CAST(N'2020-01-01T01:00:00.000' AS DateTime), 4, 500, NULL)
INSERT [dbo].[Forecast] ([ForecastID], [Date], [LocationID], [Rainfall], [Temperature]) VALUES (10, CAST(N'2020-01-01T01:00:00.000' AS DateTime), 16, 200, NULL)
INSERT [dbo].[Forecast] ([ForecastID], [Date], [LocationID], [Rainfall], [Temperature]) VALUES (11, CAST(N'2020-01-01T02:00:00.000' AS DateTime), 1, 500, NULL)
INSERT [dbo].[Forecast] ([ForecastID], [Date], [LocationID], [Rainfall], [Temperature]) VALUES (12, CAST(N'2020-01-01T02:00:00.000' AS DateTime), 2, 500, NULL)
INSERT [dbo].[Forecast] ([ForecastID], [Date], [LocationID], [Rainfall], [Temperature]) VALUES (13, CAST(N'2020-01-01T02:00:00.000' AS DateTime), 3, 500, NULL)
INSERT [dbo].[Forecast] ([ForecastID], [Date], [LocationID], [Rainfall], [Temperature]) VALUES (14, CAST(N'2020-01-01T02:00:00.000' AS DateTime), 4, 500, NULL)
INSERT [dbo].[Forecast] ([ForecastID], [Date], [LocationID], [Rainfall], [Temperature]) VALUES (15, CAST(N'2020-01-01T02:00:00.000' AS DateTime), 16, 200, NULL)
INSERT [dbo].[Forecast] ([ForecastID], [Date], [LocationID], [Rainfall], [Temperature]) VALUES (16, CAST(N'2020-01-01T03:00:00.000' AS DateTime), 1, 500, NULL)
INSERT [dbo].[Forecast] ([ForecastID], [Date], [LocationID], [Rainfall], [Temperature]) VALUES (17, CAST(N'2020-01-01T03:00:00.000' AS DateTime), 2, 500, NULL)
INSERT [dbo].[Forecast] ([ForecastID], [Date], [LocationID], [Rainfall], [Temperature]) VALUES (18, CAST(N'2020-01-01T03:00:00.000' AS DateTime), 3, 500, NULL)
INSERT [dbo].[Forecast] ([ForecastID], [Date], [LocationID], [Rainfall], [Temperature]) VALUES (19, CAST(N'2020-01-01T03:00:00.000' AS DateTime), 4, 500, NULL)
INSERT [dbo].[Forecast] ([ForecastID], [Date], [LocationID], [Rainfall], [Temperature]) VALUES (20, CAST(N'2020-01-01T03:00:00.000' AS DateTime), 16, 200, NULL)
INSERT [dbo].[Forecast] ([ForecastID], [Date], [LocationID], [Rainfall], [Temperature]) VALUES (21, CAST(N'2020-01-01T04:00:00.000' AS DateTime), 1, 500, NULL)
INSERT [dbo].[Forecast] ([ForecastID], [Date], [LocationID], [Rainfall], [Temperature]) VALUES (22, CAST(N'2020-01-01T04:00:00.000' AS DateTime), 2, 500, NULL)
INSERT [dbo].[Forecast] ([ForecastID], [Date], [LocationID], [Rainfall], [Temperature]) VALUES (23, CAST(N'2020-01-01T04:00:00.000' AS DateTime), 3, 500, NULL)
INSERT [dbo].[Forecast] ([ForecastID], [Date], [LocationID], [Rainfall], [Temperature]) VALUES (24, CAST(N'2020-01-01T04:00:00.000' AS DateTime), 4, 300, NULL)
INSERT [dbo].[Forecast] ([ForecastID], [Date], [LocationID], [Rainfall], [Temperature]) VALUES (25, CAST(N'2020-01-01T04:00:00.000' AS DateTime), 16, 200, NULL)
INSERT [dbo].[Location] ([LocationID], [PositionX], [PositionY], [Tilt], [TiltDirection], [AbsRate], [AbsCap], [AbsNow], [AbsOut]) VALUES (1, 0, 0, 20, 270, 200, 1000, 0, 150)
INSERT [dbo].[Location] ([LocationID], [PositionX], [PositionY], [Tilt], [TiltDirection], [AbsRate], [AbsCap], [AbsNow], [AbsOut]) VALUES (2, 1, 0, 20, 270, 200, 1000, 0, 150)
INSERT [dbo].[Location] ([LocationID], [PositionX], [PositionY], [Tilt], [TiltDirection], [AbsRate], [AbsCap], [AbsNow], [AbsOut]) VALUES (3, 2, 0, 20, 270, 200, 1000, 0, 150)
INSERT [dbo].[Location] ([LocationID], [PositionX], [PositionY], [Tilt], [TiltDirection], [AbsRate], [AbsCap], [AbsNow], [AbsOut]) VALUES (4, 3, 0, 20, 270, 200, 1000, 0, 150)
INSERT [dbo].[Location] ([LocationID], [PositionX], [PositionY], [Tilt], [TiltDirection], [AbsRate], [AbsCap], [AbsNow], [AbsOut]) VALUES (5, 0, 1, 20, 315, 200, 1000, 0, 150)
INSERT [dbo].[Location] ([LocationID], [PositionX], [PositionY], [Tilt], [TiltDirection], [AbsRate], [AbsCap], [AbsNow], [AbsOut]) VALUES (6, 1, 1, 15, 315, 200, 1000, 0, 150)
INSERT [dbo].[Location] ([LocationID], [PositionX], [PositionY], [Tilt], [TiltDirection], [AbsRate], [AbsCap], [AbsNow], [AbsOut]) VALUES (7, 2, 1, 15, 270, 200, 1000, 0, 150)
INSERT [dbo].[Location] ([LocationID], [PositionX], [PositionY], [Tilt], [TiltDirection], [AbsRate], [AbsCap], [AbsNow], [AbsOut]) VALUES (8, 3, 1, 10, 270, 200, 1000, 0, 150)
INSERT [dbo].[Location] ([LocationID], [PositionX], [PositionY], [Tilt], [TiltDirection], [AbsRate], [AbsCap], [AbsNow], [AbsOut]) VALUES (9, 0, 2, 10, 180, 200, 1000, 0, 150)
INSERT [dbo].[Location] ([LocationID], [PositionX], [PositionY], [Tilt], [TiltDirection], [AbsRate], [AbsCap], [AbsNow], [AbsOut]) VALUES (10, 1, 2, 5, 180, 200, 1000, 0, 150)
INSERT [dbo].[Location] ([LocationID], [PositionX], [PositionY], [Tilt], [TiltDirection], [AbsRate], [AbsCap], [AbsNow], [AbsOut]) VALUES (11, 2, 2, 0, 0, 200, 1000, 0, 150)
INSERT [dbo].[Location] ([LocationID], [PositionX], [PositionY], [Tilt], [TiltDirection], [AbsRate], [AbsCap], [AbsNow], [AbsOut]) VALUES (12, 3, 2, 0, 0, 200, 1000, 0, 150)
INSERT [dbo].[Location] ([LocationID], [PositionX], [PositionY], [Tilt], [TiltDirection], [AbsRate], [AbsCap], [AbsNow], [AbsOut]) VALUES (13, 0, 3, 5, 180, 200, 1000, 0, 150)
INSERT [dbo].[Location] ([LocationID], [PositionX], [PositionY], [Tilt], [TiltDirection], [AbsRate], [AbsCap], [AbsNow], [AbsOut]) VALUES (14, 1, 3, 5, 180, 200, 1000, 0, 150)
INSERT [dbo].[Location] ([LocationID], [PositionX], [PositionY], [Tilt], [TiltDirection], [AbsRate], [AbsCap], [AbsNow], [AbsOut]) VALUES (15, 2, 3, 0, 0, 200, 1000, 0, 150)
INSERT [dbo].[Location] ([LocationID], [PositionX], [PositionY], [Tilt], [TiltDirection], [AbsRate], [AbsCap], [AbsNow], [AbsOut]) VALUES (16, 3, 3, 20, 90, 200, 1000, 0, 150)
INSERT [dbo].[User] ([UserID], [FirstName], [SecondName], [LocationID], [Phone], [Email], [MessengerCode], [PrefMethod]) VALUES (1, N'Adam', N'Abacki', 13, 888607059, N'webox90804@gmail.com', N'gfdgdfg', 3)
INSERT [dbo].[User] ([UserID], [FirstName], [SecondName], [LocationID], [Phone], [Email], [MessengerCode], [PrefMethod]) VALUES (2, N'Pawel', N'Babacki', 12, NULL, NULL, NULL, 0)
INSERT [dbo].[User] ([UserID], [FirstName], [SecondName], [LocationID], [Phone], [Email], [MessengerCode], [PrefMethod]) VALUES (3, N'Celina', N'Cabacka', 15, NULL, NULL, NULL, 7)
USE [master]
GO
ALTER DATABASE [flood] SET  READ_WRITE 
GO
