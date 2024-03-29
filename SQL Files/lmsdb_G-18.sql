USE [master]
GO
/****** Object:  Database [lmsdbo]    Script Date: 1/4/2021 8:03:25 PM ******/
CREATE DATABASE [lmsdbo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'lmsdbo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\lmsdbo.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 4096KB )
 LOG ON 
( NAME = N'lmsdbo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\lmsdbo_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [lmsdbo] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [lmsdbo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [lmsdbo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [lmsdbo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [lmsdbo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [lmsdbo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [lmsdbo] SET ARITHABORT OFF 
GO
ALTER DATABASE [lmsdbo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [lmsdbo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [lmsdbo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [lmsdbo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [lmsdbo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [lmsdbo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [lmsdbo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [lmsdbo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [lmsdbo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [lmsdbo] SET  DISABLE_BROKER 
GO
ALTER DATABASE [lmsdbo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [lmsdbo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [lmsdbo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [lmsdbo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [lmsdbo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [lmsdbo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [lmsdbo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [lmsdbo] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [lmsdbo] SET  MULTI_USER 
GO
ALTER DATABASE [lmsdbo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [lmsdbo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [lmsdbo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [lmsdbo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [lmsdbo] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [lmsdbo] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [lmsdbo] SET QUERY_STORE = OFF
GO
USE [lmsdbo]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 1/4/2021 8:03:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeID] [varchar](8) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Designation] [varchar](15) NOT NULL,
	[JoinDate] [date] NOT NULL,
	[Salary] [bigint] NULL,
	[Address] [varchar](50) NULL,
	[MobileNo] [varchar](15) NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inventory]    Script Date: 1/4/2021 8:03:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventory](
	[BookName] [varchar](50) NOT NULL,
	[Author] [varchar](50) NOT NULL,
	[PublishedYear] [numeric](4, 0) NOT NULL,
	[Publication] [varchar](50) NOT NULL,
	[Category] [varchar](50) NOT NULL,
	[Price] [bigint] NOT NULL,
	[Quantity] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_Inventory] PRIMARY KEY CLUSTERED 
(
	[BookName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IssueBook]    Script Date: 1/4/2021 8:03:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IssueBook](
	[MemberID] [varchar](8) NOT NULL,
	[MemberName] [varchar](50) NOT NULL,
	[BookName] [varchar](50) NOT NULL,
	[Author] [varchar](50) NOT NULL,
	[IssueDate] [varchar](50) NOT NULL,
	[Duration] [varchar](50) NOT NULL,
 CONSTRAINT [PK_IssueBook] PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Member]    Script Date: 1/4/2021 8:03:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Member](
	[MemberID] [varchar](8) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Profession] [varchar](20) NOT NULL,
	[DateofBirth] [date] NULL,
	[Address] [varchar](50) NULL,
	[MobileNo] [varchar](15) NULL,
 CONSTRAINT [PK_Member] PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PenaltyStatus]    Script Date: 1/4/2021 8:03:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PenaltyStatus](
	[MemberID] [varchar](8) NOT NULL,
	[MemberName] [varchar](50) NOT NULL,
	[DurationExceed] [varchar](50) NOT NULL,
	[BookName] [varchar](50) NOT NULL,
	[PenaltyAmount] [int] NOT NULL,
 CONSTRAINT [PK_PenaltyStatus] PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserLogin]    Script Date: 1/4/2021 8:03:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserLogin](
	[UserID] [varchar](8) NOT NULL,
	[Password] [varchar](20) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[UserType] [varchar](15) NOT NULL,
 CONSTRAINT [PK_UserLogin] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Employee] ([EmployeeID], [Name], [Designation], [JoinDate], [Salary], [Address], [MobileNo]) VALUES (N'E-101', N'Muzakker', N'Admin', CAST(N'2020-01-01' AS Date), 20000, N'Kotowali', N'01611111111')
INSERT [dbo].[Employee] ([EmployeeID], [Name], [Designation], [JoinDate], [Salary], [Address], [MobileNo]) VALUES (N'E-102', N'Ashiqur', N'Librarian', CAST(N'2020-10-01' AS Date), 10000, N'Agrabad', N'01811111111')
INSERT [dbo].[Employee] ([EmployeeID], [Name], [Designation], [JoinDate], [Salary], [Address], [MobileNo]) VALUES (N'E-103', N'Saif', N'Librarian', CAST(N'2020-01-15' AS Date), 10000, N'Khulshi', N'01711111111')
INSERT [dbo].[Employee] ([EmployeeID], [Name], [Designation], [JoinDate], [Salary], [Address], [MobileNo]) VALUES (N'E-104', N'Reza', N'Librarian', CAST(N'2002-01-02' AS Date), 9000, N'Dewan Bazar', N'01921402132')
INSERT [dbo].[Employee] ([EmployeeID], [Name], [Designation], [JoinDate], [Salary], [Address], [MobileNo]) VALUES (N'E-105', N'Jasun', N'Librarian', CAST(N'2021-04-01' AS Date), 5000, N'Taltola', N'019213421412')
GO
INSERT [dbo].[Inventory] ([BookName], [Author], [PublishedYear], [Publication], [Category], [Price], [Quantity]) VALUES (N'ABC of Biology', N'Dr. B.B. Arora & A.K. Sabharwal', CAST(2017 AS Numeric(4, 0)), N'Modern Publishers', N'Biology', 1800, CAST(20 AS Numeric(18, 0)))
INSERT [dbo].[Inventory] ([BookName], [Author], [PublishedYear], [Publication], [Category], [Price], [Quantity]) VALUES (N'ABC of Chemistry', N'S.P. Jauhar', CAST(2014 AS Numeric(4, 0)), N'Modern Publishers', N'Chemistry', 2000, CAST(13 AS Numeric(18, 0)))
INSERT [dbo].[Inventory] ([BookName], [Author], [PublishedYear], [Publication], [Category], [Price], [Quantity]) VALUES (N'Fundamentals of Physics', N'Halliday & Resnick', CAST(2013 AS Numeric(4, 0)), N'Wiley and Inc', N'Physics', 45000, CAST(4 AS Numeric(18, 0)))
INSERT [dbo].[Inventory] ([BookName], [Author], [PublishedYear], [Publication], [Category], [Price], [Quantity]) VALUES (N'Programming C# 8.0
', N'Ian Griffiths', CAST(2019 AS Numeric(4, 0)), N'O''Reilly', N'Computer Science', 4000, CAST(10 AS Numeric(18, 0)))
INSERT [dbo].[Inventory] ([BookName], [Author], [PublishedYear], [Publication], [Category], [Price], [Quantity]) VALUES (N'The Power of Habit', N'Charles Duhigg', CAST(2013 AS Numeric(4, 0)), N'Random House Books', N'Self Improvement', 250, CAST(20 AS Numeric(18, 0)))
GO
INSERT [dbo].[IssueBook] ([MemberID], [MemberName], [BookName], [Author], [IssueDate], [Duration]) VALUES (N'M-101', N'Mina', N'Fundamentals of Physics', N'Halliday & Resnick', N'      04/01/2021', N'7')
INSERT [dbo].[IssueBook] ([MemberID], [MemberName], [BookName], [Author], [IssueDate], [Duration]) VALUES (N'M-102', N'Riaz', N'ABC of Chemistry', N'S.P. Jauhar', N'      01/01/2021', N'1')
GO
INSERT [dbo].[Member] ([MemberID], [Name], [Profession], [DateofBirth], [Address], [MobileNo]) VALUES (N'M-101', N'Mina', N'Student', CAST(N'1998-01-01' AS Date), N'Patharghata', N'01911111111')
INSERT [dbo].[Member] ([MemberID], [Name], [Profession], [DateofBirth], [Address], [MobileNo]) VALUES (N'M-102', N'Riaz', N'Teacher', CAST(N'1990-01-02' AS Date), N'Jamal Khan', N'01311111111')
INSERT [dbo].[Member] ([MemberID], [Name], [Profession], [DateofBirth], [Address], [MobileNo]) VALUES (N'M-103', N'Arif', N'Service Holder', CAST(N'1994-01-03' AS Date), N'Chawk Bazar', N'01411111111')
INSERT [dbo].[Member] ([MemberID], [Name], [Profession], [DateofBirth], [Address], [MobileNo]) VALUES (N'M-104', N'Jamil', N'Teacher', CAST(N'1995-02-11' AS Date), N'Amtol', N'01931421321')
GO
INSERT [dbo].[UserLogin] ([UserID], [Password], [UserName], [UserType]) VALUES (N'E-101', N'123', N'Muzakker', N'Admin')
INSERT [dbo].[UserLogin] ([UserID], [Password], [UserName], [UserType]) VALUES (N'E-102', N'456', N'Ashiqur', N'Librarian')
INSERT [dbo].[UserLogin] ([UserID], [Password], [UserName], [UserType]) VALUES (N'E-103', N'789', N'Saif', N'Librarian')
INSERT [dbo].[UserLogin] ([UserID], [Password], [UserName], [UserType]) VALUES (N'E-105', N'123', N'Jasun', N'Librarian')
INSERT [dbo].[UserLogin] ([UserID], [Password], [UserName], [UserType]) VALUES (N'M-101', N'123', N'Mina', N'Member')
INSERT [dbo].[UserLogin] ([UserID], [Password], [UserName], [UserType]) VALUES (N'M-102', N'456', N'Riaz', N'Member')
INSERT [dbo].[UserLogin] ([UserID], [Password], [UserName], [UserType]) VALUES (N'M-103', N'789', N'Arif', N'Member')
INSERT [dbo].[UserLogin] ([UserID], [Password], [UserName], [UserType]) VALUES (N'M-104', N'123', N'Jamil', N'Member')
GO
USE [master]
GO
ALTER DATABASE [lmsdbo] SET  READ_WRITE 
GO
