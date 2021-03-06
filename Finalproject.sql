Create Database FINALPROJECT
GO

USE [FINALPROJECT]
GO

/****** Object:  Table [dbo].[Account]    Script Date: 7/13/2020 8:27:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[USERNAME] [varchar](50) NOT NULL,
	[PASSWORD] [nvarchar](200) NOT NULL,
	[Pos] [int] NOT NULL,
	[IDEm] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[USERNAME] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bill_In]    Script Date: 7/13/2020 8:27:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill_In](
	[IDB_I] [int] IDENTITY(1,1) NOT NULL,
	[IDC] [int] NOT NULL,
	[IDEm] [int] NOT NULL,
	[DateIN] [datetime] NULL,
	[Checkout] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDB_I] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bill_Info_In]    Script Date: 7/13/2020 8:27:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill_Info_In](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDB_In] [int] NOT NULL,
	[IDPro] [int] NOT NULL,
	[CountIn] [int] NOT NULL,
	[PriceIn] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bill_Info_Out]    Script Date: 7/13/2020 8:27:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill_Info_Out](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDB_Out] [int] NOT NULL,
	[IDPro] [int] NOT NULL,
	[CountOut] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bill_Out]    Script Date: 7/13/2020 8:27:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill_Out](
	[IDB_O] [int] IDENTITY(1,1) NOT NULL,
	[IDCus] [int] NOT NULL,
	[IDEm] [int] NOT NULL,
	[DateOut] [datetime] NULL,
	[Discount] [int] NULL,
	[Checkout] [int] NULL,
	[PriceOut] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDB_O] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Brand]    Script Date: 7/13/2020 8:27:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brand](
	[NameBr] [nvarchar](50) NOT NULL,
	[IDBr] [int] IDENTITY(1,1) NOT NULL,
	[IDCate] [int] NOT NULL,
	[DesBr] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDBr] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 7/13/2020 8:27:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[NameCate] [nvarchar](50) NOT NULL,
	[IDCate] [int] IDENTITY(1,1) NOT NULL,
	[DesCate] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDCate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Company]    Script Date: 7/13/2020 8:27:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Company](
	[NameC] [nvarchar](50) NOT NULL,
	[IDC] [int] IDENTITY(1,1) NOT NULL,
	[AddressC] [nvarchar](50) NOT NULL,
	[PhoneC] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 7/13/2020 8:27:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[IDCus] [int] IDENTITY(1,1) NOT NULL,
	[FirstN] [nvarchar](50) NOT NULL,
	[LastN] [nvarchar](50) NOT NULL,
	[Birthday] [datetime] NOT NULL,
	[Gender] [varchar](50) NOT NULL,
	[Phone] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDCus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 7/13/2020 8:27:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[IDEm] [int] IDENTITY(1,1) NOT NULL,
	[FirstN] [nvarchar](50) NOT NULL,
	[LastN] [nvarchar](50) NOT NULL,
	[Birthday] [datetime] NULL,
	[Gender] [varchar](50) NOT NULL,
	[Phone] [int] NOT NULL,
	[AddressEm] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDEm] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 7/13/2020 8:27:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[IDPro] [int] IDENTITY(1,1) NOT NULL,
	[IDBr] [int] NOT NULL,
	[NamePro] [nvarchar](50) NULL,
	[PricePro] [float] NOT NULL,
	[DiscountPro] [int] NOT NULL,
	[Warranty] [int] NULL,
	[Origin] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDPro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Warehouse]    Script Date: 7/13/2020 8:27:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Warehouse](
	[IDWa] [int] IDENTITY(1,1) NOT NULL,
	[IDPro] [int] NOT NULL,
	[AddressWa] [nvarchar](50) NOT NULL,
	[Quantity] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDWa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([USERNAME], [PASSWORD], [Pos], [IDEm]) VALUES (N'dungcute', N'1', 2, 4)
INSERT [dbo].[Account] ([USERNAME], [PASSWORD], [Pos], [IDEm]) VALUES (N'fd', N'1', 3, 9)
INSERT [dbo].[Account] ([USERNAME], [PASSWORD], [Pos], [IDEm]) VALUES (N'trung1', N'1', 1, 11)
INSERT [dbo].[Account] ([USERNAME], [PASSWORD], [Pos], [IDEm]) VALUES (N'wrf', N'1', 3, 8)
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([NameCate], [IDCate], [DesCate]) VALUES (N' Lap tốp như cc', 7, N' cùi xịn')
INSERT [dbo].[Category] ([NameCate], [IDCate], [DesCate]) VALUES (N'Tai nghe', 9, N'để nghe')
INSERT [dbo].[Category] ([NameCate], [IDCate], [DesCate]) VALUES (N'ergsgevsfet', 11, N' cùi xịnsfv')
INSERT [dbo].[Category] ([NameCate], [IDCate], [DesCate]) VALUES (N'chó trung', 13, N' cùi xịnsfv')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([IDEm], [FirstN], [LastN], [Birthday], [Gender], [Phone], [AddressEm]) VALUES (4, N'Nguyễn Thị Chó', N'Hùng Duy', CAST(N'1989-01-08T00:00:00.000' AS DateTime), N'Female', 6543, N'Xóm đĩ')
INSERT [dbo].[Employee] ([IDEm], [FirstN], [LastN], [Birthday], [Gender], [Phone], [AddressEm]) VALUES (5, N'Đỗ Phi ', N'Hùng', CAST(N'1989-01-01T10:25:22.000' AS DateTime), N'Female', 6543, N'Xóm dú')
INSERT [dbo].[Employee] ([IDEm], [FirstN], [LastN], [Birthday], [Gender], [Phone], [AddressEm]) VALUES (7, N'Đỗ Phi ', N'Dao', CAST(N'1989-01-01T10:25:22.000' AS DateTime), N'Female', 6543, N'Xóm dú')
INSERT [dbo].[Employee] ([IDEm], [FirstN], [LastN], [Birthday], [Gender], [Phone], [AddressEm]) VALUES (8, N'Lê', N'Thị Liên', CAST(N'1988-12-25T17:01:37.000' AS DateTime), N'Female', 9090990, N'Ngã 5 chuồng tró')
INSERT [dbo].[Employee] ([IDEm], [FirstN], [LastN], [Birthday], [Gender], [Phone], [AddressEm]) VALUES (9, N'Nguyễn Thị Chó Đẻ', N'Hùng Duy', CAST(N'1989-01-08T00:00:00.000' AS DateTime), N'Female', 6543, N'Xóm đĩ')
INSERT [dbo].[Employee] ([IDEm], [FirstN], [LastN], [Birthday], [Gender], [Phone], [AddressEm]) VALUES (11, N'Phan Đăng', N'Trung', CAST(N'1989-01-01T11:20:28.000' AS DateTime), N'Female', 9876543, N'Ngã Năm chuồng chó')
INSERT [dbo].[Employee] ([IDEm], [FirstN], [LastN], [Birthday], [Gender], [Phone], [AddressEm]) VALUES (15, N'Lê', N'Nguyễn hùng duy', CAST(N'1988-12-25T17:01:37.000' AS DateTime), N'Female', 9090990, N'Ngã 5 chuồng tró')
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD FOREIGN KEY([IDEm])
REFERENCES [dbo].[Employee] ([IDEm])
GO
ALTER TABLE [dbo].[Bill_In]  WITH CHECK ADD FOREIGN KEY([IDC])
REFERENCES [dbo].[Company] ([IDC])
GO
ALTER TABLE [dbo].[Bill_In]  WITH CHECK ADD FOREIGN KEY([IDEm])
REFERENCES [dbo].[Employee] ([IDEm])
GO
ALTER TABLE [dbo].[Bill_Info_In]  WITH CHECK ADD FOREIGN KEY([IDB_In])
REFERENCES [dbo].[Bill_In] ([IDB_I])
GO
ALTER TABLE [dbo].[Bill_Info_In]  WITH CHECK ADD FOREIGN KEY([IDPro])
REFERENCES [dbo].[Product] ([IDPro])
GO
ALTER TABLE [dbo].[Bill_Info_Out]  WITH CHECK ADD FOREIGN KEY([IDB_Out])
REFERENCES [dbo].[Bill_Out] ([IDB_O])
GO
ALTER TABLE [dbo].[Bill_Info_Out]  WITH CHECK ADD FOREIGN KEY([IDPro])
REFERENCES [dbo].[Product] ([IDPro])
GO
ALTER TABLE [dbo].[Bill_Out]  WITH CHECK ADD FOREIGN KEY([IDCus])
REFERENCES [dbo].[Customer] ([IDCus])
GO
ALTER TABLE [dbo].[Bill_Out]  WITH CHECK ADD FOREIGN KEY([IDEm])
REFERENCES [dbo].[Employee] ([IDEm])
GO
ALTER TABLE [dbo].[Brand]  WITH CHECK ADD FOREIGN KEY([IDCate])
REFERENCES [dbo].[Category] ([IDCate])
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD FOREIGN KEY([IDBr])
REFERENCES [dbo].[Brand] ([IDBr])
GO
ALTER TABLE [dbo].[Warehouse]  WITH CHECK ADD FOREIGN KEY([IDPro])
REFERENCES [dbo].[Product] ([IDPro])
GO
/****** Object:  StoredProcedure [dbo].[USP_INSERTACCOUNT]    Script Date: 7/13/2020 8:27:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_INSERTACCOUNT]
@idem int, @username varchar(50), @pos int
as 
begin 
declare @id nvarchar(50)
SELECT @id = username FROM dbo.Account WHERE idem=@idem
if(@id is null)
insert dbo.Account (USERNAME,PASSWORD,Pos,IDEm) values (@username,'1',@pos,@idem)
else
print 'da'
end 
GO
