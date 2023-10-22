use master 
go

CREATE database [QLNH]
go
USE [QLNH]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: Thu, 19 Oct 2023 10:12:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[phonenumber] [varchar](10) NULL,
	[fullname] [nvarchar](50) NULL,
	[id] [int] NULL,
	[address] [nvarchar](50) NULL,
	[email] [varchar](50) NULL,
	[cccd] [varchar](12) NULL,
	[dateofbirth] [date] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Customer] ([phonenumber], [fullname], [id], [address], [email], [cccd], [dateofbirth]) VALUES (N'0843345868', N'Trịnh Đăng Quang', 1, N'Hưng Lợi, Hưng Nguyên, Nghệ An', N'quangviphungloi@gmail.com', N'040203010919', CAST(N'2003-12-26' AS Date))
GO
