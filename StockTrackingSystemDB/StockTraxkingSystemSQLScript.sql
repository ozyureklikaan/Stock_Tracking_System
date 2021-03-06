USE [master]
GO
/****** Object:  Database [stockTrackingSystem]    Script Date: 27.12.2018 16:13:08 ******/
CREATE DATABASE [stockTrackingSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'stockTrackingSystem', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\stockTrackingSystem.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'stockTrackingSystem_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\stockTrackingSystem_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [stockTrackingSystem] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [stockTrackingSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [stockTrackingSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [stockTrackingSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [stockTrackingSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [stockTrackingSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [stockTrackingSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [stockTrackingSystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [stockTrackingSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [stockTrackingSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [stockTrackingSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [stockTrackingSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [stockTrackingSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [stockTrackingSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [stockTrackingSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [stockTrackingSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [stockTrackingSystem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [stockTrackingSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [stockTrackingSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [stockTrackingSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [stockTrackingSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [stockTrackingSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [stockTrackingSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [stockTrackingSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [stockTrackingSystem] SET RECOVERY FULL 
GO
ALTER DATABASE [stockTrackingSystem] SET  MULTI_USER 
GO
ALTER DATABASE [stockTrackingSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [stockTrackingSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [stockTrackingSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [stockTrackingSystem] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [stockTrackingSystem] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'stockTrackingSystem', N'ON'
GO
USE [stockTrackingSystem]
GO
/****** Object:  UserDefinedFunction [dbo].[fc_Encryption]    Script Date: 27.12.2018 16:13:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[fc_Encryption]
(
	@password nvarchar(16)
)
RETURNS nvarchar(16)
AS
BEGIN
	DECLARE @encryptedPassword nvarchar(16)
	SET @encryptedPassword = CONVERT(nvarchar(16), HashBytes('MD5', @password))
	RETURN @encryptedPassword
END

GO
/****** Object:  Table [dbo].[tblDebit]    Script Date: 27.12.2018 16:13:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDebit](
	[debitID] [int] IDENTITY(1,1) NOT NULL,
	[productID] [int] NULL,
	[personID] [int] NULL,
	[departmentID] [int] NULL,
 CONSTRAINT [PK_tblDebit] PRIMARY KEY CLUSTERED 
(
	[debitID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblDebitedStock]    Script Date: 27.12.2018 16:13:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDebitedStock](
	[debitedStockID] [int] IDENTITY(1,1) NOT NULL,
	[debitID] [int] NOT NULL,
	[debitedQuantity] [int] NULL,
 CONSTRAINT [PK_tblDebitedStock] PRIMARY KEY CLUSTERED 
(
	[debitedStockID] ASC,
	[debitID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblDepartment]    Script Date: 27.12.2018 16:13:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDepartment](
	[departmentID] [int] IDENTITY(1,1) NOT NULL,
	[departmentName] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblDepartment] PRIMARY KEY CLUSTERED 
(
	[departmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblPersons]    Script Date: 27.12.2018 16:13:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPersons](
	[personID] [int] IDENTITY(1,1) NOT NULL,
	[personName] [nvarchar](50) NULL,
	[personLastName] [nvarchar](50) NULL,
	[personBirthDate] [date] NULL,
	[dateOfStart] [date] NULL,
	[activityStatus] [bit] NULL,
	[userID] [int] NULL,
	[departmentID] [int] NULL,
 CONSTRAINT [PK_tblPersons] PRIMARY KEY CLUSTERED 
(
	[personID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblProducts]    Script Date: 27.12.2018 16:13:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblProducts](
	[productID] [int] IDENTITY(1,1) NOT NULL,
	[productName] [nvarchar](50) NULL,
	[productPurchasePrice] [money] NULL,
	[productPurchaseDate] [date] NULL,
	[productType] [nvarchar](50) NULL,
	[productActivity] [bit] NULL,
	[purchasedCompany] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblProducts] PRIMARY KEY CLUSTERED 
(
	[productID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblStock]    Script Date: 27.12.2018 16:13:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblStock](
	[stockID] [int] IDENTITY(1,1) NOT NULL,
	[productID] [int] NOT NULL,
	[quantity] [int] NULL,
 CONSTRAINT [PK_tblStock] PRIMARY KEY CLUSTERED 
(
	[stockID] ASC,
	[productID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblTypes]    Script Date: 27.12.2018 16:13:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTypes](
	[typeID] [int] IDENTITY(1,1) NOT NULL,
	[type] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblTypes] PRIMARY KEY CLUSTERED 
(
	[typeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblUsers]    Script Date: 27.12.2018 16:13:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUsers](
	[userID] [int] IDENTITY(1,1) NOT NULL,
	[userName] [nvarchar](50) NULL,
	[password] [nvarchar](16) NULL,
 CONSTRAINT [PK_tblUsers] PRIMARY KEY CLUSTERED 
(
	[userID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblUserType]    Script Date: 27.12.2018 16:13:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUserType](
	[userTypeID] [int] IDENTITY(1,1) NOT NULL,
	[userID] [int] NOT NULL,
	[typeID] [int] NOT NULL,
 CONSTRAINT [PK_tblUserTypes] PRIMARY KEY CLUSTERED 
(
	[userTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[tblDepartment] ON
	INSERT [dbo].[tblDepartment] ([departmentID], [departmentName]) VALUES (1, 'YÖNETİM')
	INSERT [dbo].[tblDepartment] ([departmentID], [departmentName]) VALUES (2, 'YAZILIM')
	INSERT [dbo].[tblDepartment] ([departmentID], [departmentName]) VALUES (3, 'AR-GE')
	INSERT [dbo].[tblDepartment] ([departmentID], [departmentName]) VALUES (4, 'ÜRETİM')
	INSERT [dbo].[tblDepartment] ([departmentID], [departmentName]) VALUES (5, 'PAZARLAMA')
SET IDENTITY_INSERT [dbo].[tblDepartment] OFF

SET IDENTITY_INSERT [dbo].[tblPersons] ON
	INSERT [dbo].[tblPersons] ([personID], [personName], [personLastName], [personBirthDate], [dateOfStart], [activityStatus], [userID], [departmentID]) VALUES (1, 'Buse', 'İÇTEN', '1993-09-27', '2018-01-01', 1, 1, 1)
	INSERT [dbo].[tblPersons] ([personID], [personName], [personLastName], [personBirthDate], [dateOfStart], [activityStatus], [userID], [departmentID]) VALUES (2, 'Kaan', 'ÖZYÜREKLİ', '1993-02-05', '2018-01-01', 1, 2, 1)
	INSERT [dbo].[tblPersons] ([personID], [personName], [personLastName], [personBirthDate], [dateOfStart], [activityStatus], [userID], [departmentID]) VALUES (3, 'Eylül', 'ATAN', '1993-07-08', '', 1, 3, 2)
	INSERT [dbo].[tblPersons] ([personID], [personName], [personLastName], [personBirthDate], [dateOfStart], [activityStatus], [userID], [departmentID]) VALUES (4, 'Yağmur', 'YILDIRIM', '1993-02-15', '2018-01-01', 1, 4, 2)
	INSERT [dbo].[tblPersons] ([personID], [personName], [personLastName], [personBirthDate], [dateOfStart], [activityStatus], [userID], [departmentID]) VALUES (5, 'Damla', 'ÇEVİK', '1995-04-11', '2018-05-04', 1, 5, 2)
	INSERT [dbo].[tblPersons] ([personID], [personName], [personLastName], [personBirthDate], [dateOfStart], [activityStatus], [userID], [departmentID]) VALUES (6, 'Arya', 'KAYA', '1996-03-12', '2018-03-25', 1, 6, 3)
	INSERT [dbo].[tblPersons] ([personID], [personName], [personLastName], [personBirthDate], [dateOfStart], [activityStatus], [userID], [departmentID]) VALUES (7, 'Ece', 'DAL', '1994-02-16', '2018-06-10', 1, 7, 3)
	INSERT [dbo].[tblPersons] ([personID], [personName], [personLastName], [personBirthDate], [dateOfStart], [activityStatus], [userID], [departmentID]) VALUES (8, 'Su', 'TAŞKIN', '1995-07-19', '2018-02-05', 1, 8, 3)
	INSERT [dbo].[tblPersons] ([personID], [personName], [personLastName], [personBirthDate], [dateOfStart], [activityStatus], [userID], [departmentID]) VALUES (9, 'Melisa', 'ESER', '1995-01-26', '2018-02-10', 1, 9, 4)
	INSERT [dbo].[tblPersons] ([personID], [personName], [personLastName], [personBirthDate], [dateOfStart], [activityStatus], [userID], [departmentID]) VALUES (10, 'Eyüp', 'BAŞLI', '1993-08-19', '2018-06-25', 1, 10, 4)
	INSERT [dbo].[tblPersons] ([personID], [personName], [personLastName], [personBirthDate], [dateOfStart], [activityStatus], [userID], [departmentID]) VALUES (11, 'Alihan', 'LAÇİN', '1993-05-20', '2018-01-01', 1, 11, 4)
	INSERT [dbo].[tblPersons] ([personID], [personName], [personLastName], [personBirthDate], [dateOfStart], [activityStatus], [userID], [departmentID]) VALUES (12, 'Süleyman', 'ERMİL', '1993-03-09', '2018-01-01', 1, 12, 5)
	INSERT [dbo].[tblPersons] ([personID], [personName], [personLastName], [personBirthDate], [dateOfStart], [activityStatus], [userID], [departmentID]) VALUES (13, 'OKAN', 'ÖZYÜREKLİ', '1995-11-28', '2018-01-01', 1, 13, 5)
	INSERT [dbo].[tblPersons] ([personID], [personName], [personLastName], [personBirthDate], [dateOfStart], [activityStatus], [userID], [departmentID]) VALUES (14, 'DURUKAN', 'İÇTEN', '1996-06-24', '2018-01-01', 1, 14, 5)
SET IDENTITY_INSERT [dbo].[tblPersons] OFF

SET IDENTITY_INSERT [dbo].[tblUsers] ON
	DECLARE @encryptedAdminPassword nvarchar(16)
	SET @encryptedAdminPassword = ([dbo].[fc_Encryption]('123456789'))
	DECLARE @encryptedPersonnelPassword nvarchar(16)
	SET @encryptedPersonnelPassword = ([dbo].[fc_Encryption]('123456'))
	INSERT [dbo].[tblUsers] ([userID], [userName], [password]) VALUES (1, 'buseicten', @encryptedAdminPassword)
	INSERT [dbo].[tblUsers] ([userID], [userName], [password]) VALUES (2, 'kaanozyurekli', @encryptedAdminPassword)
	INSERT [dbo].[tblUsers] ([userID], [userName], [password]) VALUES (3, 'eylulatan', @encryptedPersonnelPassword)
	INSERT [dbo].[tblUsers] ([userID], [userName], [password]) VALUES (4, 'yagmuryildirim', @encryptedPersonnelPassword)
	INSERT [dbo].[tblUsers] ([userID], [userName], [password]) VALUES (5, 'damlacevik', @encryptedPersonnelPassword)
	INSERT [dbo].[tblUsers] ([userID], [userName], [password]) VALUES (6, 'aryakaya', @encryptedPersonnelPassword)
	INSERT [dbo].[tblUsers] ([userID], [userName], [password]) VALUES (7, 'ecedal', @encryptedPersonnelPassword)
	INSERT [dbo].[tblUsers] ([userID], [userName], [password]) VALUES (8, 'sutaskin', @encryptedPersonnelPassword)
	INSERT [dbo].[tblUsers] ([userID], [userName], [password]) VALUES (9, 'melisaeser', @encryptedPersonnelPassword)
	INSERT [dbo].[tblUsers] ([userID], [userName], [password]) VALUES (10, 'eyupbasli', @encryptedPersonnelPassword)
	INSERT [dbo].[tblUsers] ([userID], [userName], [password]) VALUES (11, 'alihanlacin', @encryptedPersonnelPassword)
	INSERT [dbo].[tblUsers] ([userID], [userName], [password]) VALUES (12, 'suleymanermil', @encryptedPersonnelPassword)
	INSERT [dbo].[tblUsers] ([userID], [userName], [password]) VALUES (13, 'okanozyurekli', @encryptedPersonnelPassword)
	INSERT [dbo].[tblUsers] ([userID], [userName], [password]) VALUES (14, 'durukanicten', @encryptedPersonnelPassword)
SET IDENTITY_INSERT [dbo].[tblUsers] OFF

SET IDENTITY_INSERT [dbo].[tblUserType] ON
	INSERT [dbo].[tblUserType] ([userTypeID], [userID], [typeID]) VALUES (1, 1, 1)
	INSERT [dbo].[tblUserType] ([userTypeID], [userID], [typeID]) VALUES (2, 2, 1)
	INSERT [dbo].[tblUserType] ([userTypeID], [userID], [typeID]) VALUES (3, 3, 3)
	INSERT [dbo].[tblUserType] ([userTypeID], [userID], [typeID]) VALUES (4, 4, 3)
	INSERT [dbo].[tblUserType] ([userTypeID], [userID], [typeID]) VALUES (5, 5, 2)
	INSERT [dbo].[tblUserType] ([userTypeID], [userID], [typeID]) VALUES (6, 6, 2)
	INSERT [dbo].[tblUserType] ([userTypeID], [userID], [typeID]) VALUES (7, 7, 3)
	INSERT [dbo].[tblUserType] ([userTypeID], [userID], [typeID]) VALUES (8, 8, 3)
	INSERT [dbo].[tblUserType] ([userTypeID], [userID], [typeID]) VALUES (9, 9, 2)
	INSERT [dbo].[tblUserType] ([userTypeID], [userID], [typeID]) VALUES (10, 10, 3)
	INSERT [dbo].[tblUserType] ([userTypeID], [userID], [typeID]) VALUES (11, 11, 3)
	INSERT [dbo].[tblUserType] ([userTypeID], [userID], [typeID]) VALUES (12, 12, 2)
	INSERT [dbo].[tblUserType] ([userTypeID], [userID], [typeID]) VALUES (13, 13, 3)
	INSERT [dbo].[tblUserType] ([userTypeID], [userID], [typeID]) VALUES (14, 14, 3)
SET IDENTITY_INSERT [dbo].[tblUserType] OFF

SET IDENTITY_INSERT [dbo].[tblTypes] ON
	INSERT [dbo].[tblTypes] ([typeID], [type]) VALUES (1, 'administrator')
	INSERT [dbo].[tblTypes] ([typeID], [type]) VALUES (2, 'unit_authority')
	INSERT [dbo].[tblTypes] ([typeID], [type]) VALUES (3, 'personnel')
SET IDENTITY_INSERT [dbo].[tblUserType] OFF
ALTER TABLE [dbo].[tblDebit]  WITH CHECK ADD  CONSTRAINT [FK_tblDebit_tblDepartment] FOREIGN KEY([departmentID])
REFERENCES [dbo].[tblDepartment] ([departmentID])
GO
ALTER TABLE [dbo].[tblDebit] CHECK CONSTRAINT [FK_tblDebit_tblDepartment]
GO
ALTER TABLE [dbo].[tblDebit]  WITH CHECK ADD  CONSTRAINT [FK_tblDebit_tblPersons] FOREIGN KEY([personID])
REFERENCES [dbo].[tblPersons] ([personID])
GO
ALTER TABLE [dbo].[tblDebit] CHECK CONSTRAINT [FK_tblDebit_tblPersons]
GO
ALTER TABLE [dbo].[tblDebit]  WITH CHECK ADD  CONSTRAINT [FK_tblDebit_tblProducts] FOREIGN KEY([productID])
REFERENCES [dbo].[tblProducts] ([productID])
GO
ALTER TABLE [dbo].[tblDebit] CHECK CONSTRAINT [FK_tblDebit_tblProducts]
GO
ALTER TABLE [dbo].[tblDebitedStock]  WITH CHECK ADD  CONSTRAINT [FK_tblDebitedStock_tblDebit] FOREIGN KEY([debitID])
REFERENCES [dbo].[tblDebit] ([debitID])
GO
ALTER TABLE [dbo].[tblDebitedStock] CHECK CONSTRAINT [FK_tblDebitedStock_tblDebit]
GO
ALTER TABLE [dbo].[tblPersons]  WITH CHECK ADD  CONSTRAINT [FK_tblPersons_tblDepartment] FOREIGN KEY([departmentID])
REFERENCES [dbo].[tblDepartment] ([departmentID])
GO
ALTER TABLE [dbo].[tblPersons] CHECK CONSTRAINT [FK_tblPersons_tblDepartment]
GO
ALTER TABLE [dbo].[tblStock]  WITH CHECK ADD  CONSTRAINT [FK_tblStock_tblProducts] FOREIGN KEY([productID])
REFERENCES [dbo].[tblProducts] ([productID])
GO
ALTER TABLE [dbo].[tblStock] CHECK CONSTRAINT [FK_tblStock_tblProducts]
GO
ALTER TABLE [dbo].[tblUsers]  WITH CHECK ADD  CONSTRAINT [FK_tblUsers_tblPersons] FOREIGN KEY([userID])
REFERENCES [dbo].[tblPersons] ([personID])
GO
ALTER TABLE [dbo].[tblUsers] CHECK CONSTRAINT [FK_tblUsers_tblPersons]
GO
ALTER TABLE [dbo].[tblUserType]  WITH CHECK ADD  CONSTRAINT [FK_tblUserType_tblTypes] FOREIGN KEY([typeID])
REFERENCES [dbo].[tblTypes] ([typeID])
GO
ALTER TABLE [dbo].[tblUserType] CHECK CONSTRAINT [FK_tblUserType_tblTypes]
GO
ALTER TABLE [dbo].[tblUserType]  WITH CHECK ADD  CONSTRAINT [FK_tblUserType_tblUsers] FOREIGN KEY([userID])
REFERENCES [dbo].[tblUsers] ([userID])
GO
ALTER TABLE [dbo].[tblUserType] CHECK CONSTRAINT [FK_tblUserType_tblUsers]
GO
/****** Object:  StoredProcedure [dbo].[sp_AddDebit]    Script Date: 27.12.2018 16:13:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_AddDebit]
(
@productID int,
@personID int,
@quantity int
)
AS
DECLARE @departmentID int
SET @departmentID = (SELECT departmentID FROM tblPersons WHERE personID = @personID)
INSERT INTO tblDebit(productID, personID, departmentID) VALUES (@productID, @personID, @departmentID)
DECLARE @debitID int
SET @debitID = (SELECT TOP(1) debitID FROM tblDebit WHERE personID = @personID)
INSERT INTO tblDebitedStock (debitID, debitedQuantity) VALUES (@debitID, @quantity)
UPDATE tblStock SET quantity -= @quantity WHERE productID = @productID


GO
/****** Object:  StoredProcedure [dbo].[sp_AddProduct]    Script Date: 27.12.2018 16:13:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_AddProduct]
(
@productName nvarchar(50),
@purchasedPrice money,
@purchasedDate date,
@productType nvarchar(50),
@quantity int,
@purchasedCompany nvarchar(50)
)
AS
INSERT INTO [dbo].[tblProducts] (productName, productPurchasePrice, productPurchaseDate, productType, productActivity, purchasedCompany) VALUES (@productName, @purchasedPrice, @purchasedDate, @productType, 1, @purchasedCompany)
DECLARE @productID int
SET @productID = (SELECT TOP(1) productID FROM tblProducts ORDER BY productID DESC)
INSERT INTO tblStock(quantity, productID) VALUES(@quantity, @productID)


GO
/****** Object:  StoredProcedure [dbo].[sp_AddStock]    Script Date: 27.12.2018 16:13:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_AddStock]
(
	@productID int,
	@amountToAdd int
)
AS
if(@amountToAdd > 0)
BEGIN
	UPDATE tblStock SET quantity += @amountToAdd WHERE productID = @productID
	UPDATE tblProducts SET productActivity = 1 WHERE productID = @productID
END

GO
/****** Object:  StoredProcedure [dbo].[sp_ChangePassword]    Script Date: 27.12.2018 16:13:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ChangePassword]
(
	@personID int,
	@newPassword nvarchar(16)
)
AS
DECLARE @userID int
SET @userID = (SELECT userID FROM tblPersons WHERE personID = @personID)
UPDATE tblUsers SET password = @newPassword WHERE userID = @userID

GO
/****** Object:  StoredProcedure [dbo].[sp_DebitDeletion]    Script Date: 27.12.2018 16:13:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_DebitDeletion]
(
	@debitID int
)
AS
DECLARE @productID int
SET @productID = (SELECT productID FROM tblDebit WHERE debitID = @debitID)
DECLARE @quantity int
SET @quantity = (SELECT debitedQuantity FROM tblDebitedStock WHERE debitID = @debitID)
UPDATE tblStock SET quantity += @quantity WHERE productID = @productID
UPDATE tblProducts SET productActivity = 1 WHERE productID = @productID
DELETE FROM tblDebitedStock WHERE debitID = @debitID
DELETE FROM tblDebit WHERE debitID = @debitID


GO
/****** Object:  StoredProcedure [dbo].[sp_DebitedListOfDepartment]    Script Date: 27.12.2018 16:13:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_DebitedListOfDepartment]
(
@departmentID int
)
AS
DECLARE @debitedProductID int
SET @debitedProductID = (SELECT debit.productID FROM tblDepartment department INNER JOIN tblDebit debit ON(department.departmentID = debit.departmentID) WHERE department.departmentID = @departmentID)
DECLARE @departmentName nvarchar(50)
SET @departmentName = (SELECT departmentName FROM tblDepartment WHERE departmentID = @departmentID)
SELECT @departmentName AS 'Department', * FROM tblProducts WHERE productID = @debitedProductID


GO
/****** Object:  StoredProcedure [dbo].[sp_DebitedListOfPerson]    Script Date: 27.12.2018 16:13:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_DebitedListOfPerson]
(
@personID int
)
AS
DECLARE @debitedProductID int
SET @debitedProductID = (SELECT d.productID FROM tblPersons p INNER JOIN tblDebit d ON(p.personID = d.personID) WHERE p.personID = @personID)
DECLARE @debitedPersonFullName nvarchar(100)
SET @debitedPersonFullName = (SELECT personName FROM tblPersons WHERE personID = @personID) + ' ' + (SELECT personLastName FROM tblPersons WHERE personID = @personID)
SELECT @debitedPersonFullName AS 'Person Name', * FROM tblProducts WHERE productID = @debitedProductID


GO
/****** Object:  StoredProcedure [dbo].[sp_EditDebit]    Script Date: 27.12.2018 16:13:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_EditDebit]
(
	@debitID int,
	@productID int,
	@personID int,
	@quantity int
)
AS
DECLARE @oldProductID int
SET @oldProductID = (SELECT p.productID FROM tblDebit d INNER JOIN tblProducts p ON(d.productID = p.productID) WHERE d.debitID = @debitID)
DECLARE @oldDebitedQuantity int
SET @oldDebitedQuantity = (SELECT ds.debitedQuantity FROM tblDebit d INNER JOIN tblDebitedStock ds ON(d.debitID = ds.debitID) WHERE d.debitID = @debitID)
/*UPDATE tblStock SET quantity += @oldDebitedQuantity WHERE productID = @oldProductID*/
EXEC sp_AddStock @oldProductID, @oldDebitedQuantity
DECLARE @newDepartmentID int
SET @newDepartmentID = (SELECT departmentID FROM tblPersons WHERE personID = @personID)
UPDATE tblDebit SET productID = @productID, personID = @personID, departmentID = @newDepartmentID WHERE debitID = @debitID
UPDATE tblDebitedStock SET debitedQuantity = @quantity WHERE debitID = @debitID
UPDATE tblStock SET quantity -= @quantity WHERE productID = @productID

GO
/****** Object:  StoredProcedure [dbo].[sp_EditProduct]    Script Date: 27.12.2018 16:13:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_EditProduct]
(
@productID int,
@productName nvarchar(50),
@productPurchasePrice money,
@productPurchaseDate date,
@productType nvarchar(50),
@purchasedCompany nvarchar(50),
@quantity int
)
AS
UPDATE tblProducts SET productName = @productName, productPurchasePrice = @productPurchasePrice, productPurchaseDate = @productPurchaseDate, productType = @productType, purchasedCompany = @purchasedCompany WHERE productID = @productID
UPDATE tblStock SET quantity = @quantity WHERE productID = @productID


GO
/****** Object:  StoredProcedure [dbo].[sp_Encoder]    Script Date: 27.12.2018 16:13:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Encoder]
(
	@password nvarchar(16)
)
AS
DECLARE @encryptedPassword nvarchar(16)
SET @encryptedPassword = CONVERT(nvarchar(16), HashBytes('MD5', @password))
SELECT @encryptedPassword
GO
/****** Object:  StoredProcedure [dbo].[sp_ListAllProducts]    Script Date: 27.12.2018 16:13:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ListAllProducts]
AS
SELECT p.productID, p.productName, p.productPurchasePrice, p.productPurchaseDate, p.productType, p.productActivity, p.purchasedCompany, s.stockID, s.quantity FROM tblProducts p INNER JOIN tblStock s ON(p.productID = s.productID)

GO
/****** Object:  StoredProcedure [dbo].[sp_ListDebit]    Script Date: 27.12.2018 16:13:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ListDebit]
AS
SELECT product.productID, product.productName, product.productPurchasePrice, product.productPurchaseDate, product.productType, product.purchasedCompany, person.personID, person.personName, person.personLastName, person.departmentID, d.debitID, ds.debitedStockID, ds.debitedQuantity FROM tblDebit d INNER JOIN tblProducts product ON(d.productID = product.productID) INNER JOIN tblPersons person ON(d.personID = person.personID) INNER JOIN tblDebitedStock ds ON(d.debitID = ds.debitID)
GO
/****** Object:  StoredProcedure [dbo].[sp_ListDepartment]    Script Date: 27.12.2018 16:13:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ListDepartment]
AS
SELECT * FROM tblDepartment

GO
/****** Object:  StoredProcedure [dbo].[sp_ListMyProducts]    Script Date: 27.12.2018 16:13:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ListMyProducts]
(
	@personID int
)
AS
SELECT p.productID, p.productName, p.productPurchasePrice, p.productPurchaseDate, p.productType, p.productActivity, p.purchasedCompany, d.debitID, person.personID, person.personName, person.personLastName, person.personBirthDate, person.dateOfStart, person.activityStatus, person.departmentID, ds.debitedStockID, ds.debitedQuantity FROM tblProducts p INNER JOIN tblDebit d ON(p.productID = d.productID) INNER JOIN tblPersons person ON(d.personID = person.personID) INNER JOIN tblDebitedStock ds ON(ds.debitID = d.debitID) WHERE person.personID = @personID

GO
/****** Object:  StoredProcedure [dbo].[sp_ListPersonnel]    Script Date: 27.12.2018 16:13:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ListPersonnel]
AS
SELECT p.personID, p.personName, p.personLastName, p.personBirthDate, p.dateOfStart, p.activityStatus, d.departmentName FROM tblPersons p INNER JOIN tblDepartment d ON(p.departmentID = d.departmentID)

GO
/****** Object:  StoredProcedure [dbo].[sp_ListProducts]    Script Date: 27.12.2018 16:13:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ListProducts]
AS
SELECT p.productID, p.productName, p.productPurchasePrice, p.productPurchaseDate, p.productType, p.productActivity, p.purchasedCompany, s.stockID, s.quantity FROM tblProducts p INNER JOIN tblStock s ON(p.productID = s.productID) WHERE productActivity = 1

GO
/****** Object:  StoredProcedure [dbo].[sp_PersonnelDetail]    Script Date: 27.12.2018 16:13:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_PersonnelDetail]
(
	@personID int
)
AS
SELECT p.personID, p.personName, p.personLastName, p.personBirthDate, p.dateOfStart, p.activityStatus, d.departmentName FROM tblPersons p INNER JOIN tblDepartment d ON(p.departmentID = d.departmentID) WHERE p.personID = @personID

GO
/****** Object:  StoredProcedure [dbo].[sp_ProductDeletion]    Script Date: 27.12.2018 16:13:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ProductDeletion]
(
	@productID int
)
AS
UPDATE tblStock SET quantity = 0 WHERE productID = @productID
UPDATE tblProducts SET productActivity = 0 WHERE productID = @productID

GO
USE [master]
GO
ALTER DATABASE [stockTrackingSystem] SET  READ_WRITE 
GO
