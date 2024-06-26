USE [master]
GO
CREATE DATABASE [WatchDB2024]
GO
USE [WatchDB2024]
GO

CREATE TABLE [dbo].[Brand](
	[BrandId] [nchar](2) NOT NULL,
	[BrandName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Brand] PRIMARY KEY CLUSTERED 
(
	[BrandId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Member]    Script Date: 02/03/2024 10:26:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Member](
	[MemberId] [int] IDENTITY(1,1) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Role] [int] NULL,
 CONSTRAINT [PK_Member] PRIMARY KEY CLUSTERED 
(
	[MemberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Watch]    Script Date: 02/03/2024 10:26:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Watch](
	[WatchId] [int] IDENTITY(1,1) NOT NULL,
	[WatchName] [nvarchar](50) NULL,
	[Price] [int] NULL,
	[Description] [nvarchar](100) NULL,
	[BrandId] [nchar](2) NULL,
 CONSTRAINT [PK_Watch] PRIMARY KEY CLUSTERED 
(
	[WatchId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Brand] ([BrandId], [BrandName]) VALUES (N'CZ', N'Citizen')
INSERT [dbo].[Brand] ([BrandId], [BrandName]) VALUES (N'FC', N'Frederique Constant')
INSERT [dbo].[Brand] ([BrandId], [BrandName]) VALUES (N'FS', N'Fossil')
INSERT [dbo].[Brand] ([BrandId], [BrandName]) VALUES (N'TS', N'Tissot')
GO
SET IDENTITY_INSERT [dbo].[Member] ON 

INSERT [dbo].[Member] ([MemberId], [Email], [Password], [Name], [Role]) VALUES (1, N'admin@watch.com.vn', N'admin@@', N'Bum X iTrum', 1)
INSERT [dbo].[Member] ([MemberId], [Email], [Password], [Name], [Role]) VALUES (2, N'staff@watch.com.vn', N'staff@@', N'My Sumo', 2)
INSERT [dbo].[Member] ([MemberId], [Email], [Password], [Name], [Role]) VALUES (3, N'manager@watch.com.vn', N'manager@@', N'Joe Den', 3)
SET IDENTITY_INSERT [dbo].[Member] OFF
GO
SET IDENTITY_INSERT [dbo].[Watch] ON 

INSERT [dbo].[Watch] ([WatchId], [WatchName], [Price], [Description], [BrandId]) VALUES (3, N'Small Seconds Blue Mother of Pearl', 89, N'Stainless steel case with a navy leather strap. Fixed stainless steel bezel. ', N'FC')
INSERT [dbo].[Watch] ([WatchId], [WatchName], [Price], [Description], [BrandId]) VALUES (4, N'Quartz Silver Dial Men', 79, N'Rose gold-plated stainless steel case with a brown leather strap. Fixed rose gold-plated bezel.', N'FC')
INSERT [dbo].[Watch] ([WatchId], [WatchName], [Price], [Description], [BrandId]) VALUES (5, N'Townsman Chronograph Brown Satin', 59, N'Black ion-plated stainless steel case with a brown leather strap. Fixed black ion-plated bezel.', N'FS')
INSERT [dbo].[Watch] ([WatchId], [WatchName], [Price], [Description], [BrandId]) VALUES (6, N'Le Locle Powermatic 80 Automatic', 48, N'Stainless steel case with a black leather strap. Fixed stainless steel bezel.', N'TS')
INSERT [dbo].[Watch] ([WatchId], [WatchName], [Price], [Description], [BrandId]) VALUES (8, N'Eco Drive Blue Angels Chronograph', 36, N'Soft Stuffed Toy Gift for Little Girls, Baby.', N'CZ')
INSERT [dbo].[Watch] ([WatchId], [WatchName], [Price], [Description], [BrandId]) VALUES (9, N'Promaster Sea Automatic Black Dial', 29, N'ilver-tone stainless steel case with a black rubber strap. Silver-tone stainless steel bezel.', N'CZ')
INSERT [dbo].[Watch] ([WatchId], [WatchName], [Price], [Description], [BrandId]) VALUES (10, N'Chemin Des Tourelles Automatic', 42, N'Rose gold PVD stainless steel case with a brown leather strap. Fixed rose gold PVD bezel. ', N'TS')
SET IDENTITY_INSERT [dbo].[Watch] OFF
GO
 