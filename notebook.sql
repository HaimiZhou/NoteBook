USE [notebook]
GO
/****** Object:  Table [dbo].[tbl_user]    Script Date: 03/21/2017 16:01:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_user](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nchar](10) NULL,
	[password] [nchar](10) NULL,
	[logintime] [datetime] NULL,
 CONSTRAINT [PK_tbl_user] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_user] ON
INSERT [dbo].[tbl_user] ([id], [username], [password], [logintime]) VALUES (45, N'1         ', N'1         ', CAST(0x0000A6F20135D530 AS DateTime))
SET IDENTITY_INSERT [dbo].[tbl_user] OFF
/****** Object:  Table [dbo].[tbl_rabbish]    Script Date: 03/21/2017 16:01:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_rabbish](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[rtitle] [nchar](10) NULL,
	[rcontent] [text] NULL,
	[rtime] [datetime] NULL,
 CONSTRAINT [PK_tbl_rabbish] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_person_info]    Script Date: 03/21/2017 16:01:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_person_info](
	[username] [nchar](10) NULL,
	[realname] [nchar](10) NULL,
	[phone] [text] NULL,
	[deacription] [nchar](10) NULL,
	[province] [nchar](10) NULL,
	[county] [nchar](10) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_note]    Script Date: 03/21/2017 16:01:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_note](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [nchar](10) NULL,
	[content] [text] NULL,
	[time] [datetime] NULL,
	[foldername] [nchar](10) NULL,
 CONSTRAINT [PK_tbl_note] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_folder]    Script Date: 03/21/2017 16:01:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_folder](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[foldername] [nchar](10) NULL,
	[buildtime] [datetime] NULL,
 CONSTRAINT [PK_tbl_file] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_folder] ON
INSERT [dbo].[tbl_folder] ([id], [foldername], [buildtime]) VALUES (119, N'学习        ', CAST(0x0000A6EA00937DD0 AS DateTime))
INSERT [dbo].[tbl_folder] ([id], [foldername], [buildtime]) VALUES (120, N'工作        ', CAST(0x0000A6EA00938F64 AS DateTime))
INSERT [dbo].[tbl_folder] ([id], [foldername], [buildtime]) VALUES (121, N'娱乐        ', CAST(0x0000A6EA00939798 AS DateTime))
INSERT [dbo].[tbl_folder] ([id], [foldername], [buildtime]) VALUES (122, N'美食        ', CAST(0x0000A6EA0093A350 AS DateTime))
SET IDENTITY_INSERT [dbo].[tbl_folder] OFF
