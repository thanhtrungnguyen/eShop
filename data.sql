USE [eshop]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 2023-03-16 17:32:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[price] [float] NOT NULL,
	[description] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Product] ON 
GO
INSERT [dbo].[Product] ([id], [name], [price], [description]) VALUES (2, N'Product B', 43, N'fsdagdsfg')
GO
INSERT [dbo].[Product] ([id], [name], [price], [description]) VALUES (3, N'Product C', 45, N'sdgfsdgd')
GO
INSERT [dbo].[Product] ([id], [name], [price], [description]) VALUES (4, N'dsadsad', 1, N'dsadfsdfgsdafasd')
GO
INSERT [dbo].[Product] ([id], [name], [price], [description]) VALUES (5, N'tyittu', 78, N'ghjkgj')
GO
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
