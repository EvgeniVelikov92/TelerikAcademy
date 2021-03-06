USE [Population]
GO
/****** Object:  Table [dbo].[Addresses]    Script Date: 8/20/2014 12:36:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Addresses](
	[AddressID] [int] IDENTITY(1,1) NOT NULL,
	[Address] [ntext] NOT NULL,
	[TownID] [int] NOT NULL,
 CONSTRAINT [PK_Addresses] PRIMARY KEY CLUSTERED 
(
	[AddressID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Continents]    Script Date: 8/20/2014 12:36:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Continents](
	[ContinentID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Continents] PRIMARY KEY CLUSTERED 
(
	[ContinentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Countries]    Script Date: 8/20/2014 12:36:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[CountryID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[ContinentID] [int] NOT NULL,
 CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED 
(
	[CountryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[People]    Script Date: 8/20/2014 12:36:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[People](
	[PersonID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[AddressID] [int] NOT NULL,
 CONSTRAINT [PK_People] PRIMARY KEY CLUSTERED 
(
	[PersonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Towns]    Script Date: 8/20/2014 12:36:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Towns](
	[TownID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[CountryID] [int] NOT NULL,
 CONSTRAINT [PK_Towns] PRIMARY KEY CLUSTERED 
(
	[TownID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Addresses] ON 

INSERT [dbo].[Addresses] ([AddressID], [Address], [TownID]) VALUES (1, N'601 Biscayne Boulevard', 5)
INSERT [dbo].[Addresses] ([AddressID], [Address], [TownID]) VALUES (2, N'Stoyan Zaimov 79', 3)
INSERT [dbo].[Addresses] ([AddressID], [Address], [TownID]) VALUES (3, N'Nadejda 125', 1)
INSERT [dbo].[Addresses] ([AddressID], [Address], [TownID]) VALUES (4, N'40 Bay Street', 7)
INSERT [dbo].[Addresses] ([AddressID], [Address], [TownID]) VALUES (5, N'Viale dello Stadio Olimpico
Foro Italico
I-00135 Roma', 2)
INSERT [dbo].[Addresses] ([AddressID], [Address], [TownID]) VALUES (6, N'Ovcha kupel 123', 1)
INSERT [dbo].[Addresses] ([AddressID], [Address], [TownID]) VALUES (7, N'Mladost 5', 3)
INSERT [dbo].[Addresses] ([AddressID], [Address], [TownID]) VALUES (8, N'Mladost 30', 1)
INSERT [dbo].[Addresses] ([AddressID], [Address], [TownID]) VALUES (9, N'Westend, Charlottenburg-Wilmersdorf', 4)
SET IDENTITY_INSERT [dbo].[Addresses] OFF
SET IDENTITY_INSERT [dbo].[Continents] ON 

INSERT [dbo].[Continents] ([ContinentID], [Name]) VALUES (1, N'Asia')
INSERT [dbo].[Continents] ([ContinentID], [Name]) VALUES (2, N'Africa')
INSERT [dbo].[Continents] ([ContinentID], [Name]) VALUES (3, N'South America')
INSERT [dbo].[Continents] ([ContinentID], [Name]) VALUES (4, N'North America')
INSERT [dbo].[Continents] ([ContinentID], [Name]) VALUES (5, N'Europa')
INSERT [dbo].[Continents] ([ContinentID], [Name]) VALUES (6, N'Australia')
SET IDENTITY_INSERT [dbo].[Continents] OFF
SET IDENTITY_INSERT [dbo].[Countries] ON 

INSERT [dbo].[Countries] ([CountryID], [Name], [ContinentID]) VALUES (1, N'Bulgaria', 5)
INSERT [dbo].[Countries] ([CountryID], [Name], [ContinentID]) VALUES (2, N'Algeria', 2)
INSERT [dbo].[Countries] ([CountryID], [Name], [ContinentID]) VALUES (3, N'Brazil', 3)
INSERT [dbo].[Countries] ([CountryID], [Name], [ContinentID]) VALUES (4, N'USA', 4)
INSERT [dbo].[Countries] ([CountryID], [Name], [ContinentID]) VALUES (5, N'Canada', 4)
INSERT [dbo].[Countries] ([CountryID], [Name], [ContinentID]) VALUES (6, N'Australia', 6)
INSERT [dbo].[Countries] ([CountryID], [Name], [ContinentID]) VALUES (7, N'China', 1)
INSERT [dbo].[Countries] ([CountryID], [Name], [ContinentID]) VALUES (8, N'Italy', 5)
INSERT [dbo].[Countries] ([CountryID], [Name], [ContinentID]) VALUES (9, N'Morroco', 2)
INSERT [dbo].[Countries] ([CountryID], [Name], [ContinentID]) VALUES (10, N'Germany', 5)
SET IDENTITY_INSERT [dbo].[Countries] OFF
SET IDENTITY_INSERT [dbo].[People] ON 

INSERT [dbo].[People] ([PersonID], [FirstName], [LastName], [AddressID]) VALUES (1, N'James', N'Garcia', 1)
INSERT [dbo].[People] ([PersonID], [FirstName], [LastName], [AddressID]) VALUES (2, N'Filip', N'Filipov', 3)
INSERT [dbo].[People] ([PersonID], [FirstName], [LastName], [AddressID]) VALUES (4, N'Adolf', N'Reiners', 9)
INSERT [dbo].[People] ([PersonID], [FirstName], [LastName], [AddressID]) VALUES (5, N'Milen', N'Vitanov', 8)
INSERT [dbo].[People] ([PersonID], [FirstName], [LastName], [AddressID]) VALUES (6, N'Georgi', N'Borisov', 6)
INSERT [dbo].[People] ([PersonID], [FirstName], [LastName], [AddressID]) VALUES (7, N'Blagoy', N'Hristov', 7)
INSERT [dbo].[People] ([PersonID], [FirstName], [LastName], [AddressID]) VALUES (8, N'Hristo', N'Simeonov', 2)
INSERT [dbo].[People] ([PersonID], [FirstName], [LastName], [AddressID]) VALUES (9, N'Arthur', N'Williams', 1)
INSERT [dbo].[People] ([PersonID], [FirstName], [LastName], [AddressID]) VALUES (10, N'Vitino', N'Chicherito', 5)
SET IDENTITY_INSERT [dbo].[People] OFF
SET IDENTITY_INSERT [dbo].[Towns] ON 

INSERT [dbo].[Towns] ([TownID], [Name], [CountryID]) VALUES (1, N'Sofia', 1)
INSERT [dbo].[Towns] ([TownID], [Name], [CountryID]) VALUES (2, N'Roma', 5)
INSERT [dbo].[Towns] ([TownID], [Name], [CountryID]) VALUES (3, N'Sliven', 1)
INSERT [dbo].[Towns] ([TownID], [Name], [CountryID]) VALUES (4, N'Berlin', 10)
INSERT [dbo].[Towns] ([TownID], [Name], [CountryID]) VALUES (5, N'Miami', 4)
INSERT [dbo].[Towns] ([TownID], [Name], [CountryID]) VALUES (6, N'Plovdiv', 1)
INSERT [dbo].[Towns] ([TownID], [Name], [CountryID]) VALUES (7, N'Toronto', 5)
INSERT [dbo].[Towns] ([TownID], [Name], [CountryID]) VALUES (8, N'Rio de Janeiro', 3)
INSERT [dbo].[Towns] ([TownID], [Name], [CountryID]) VALUES (9, N'Sidney', 6)
INSERT [dbo].[Towns] ([TownID], [Name], [CountryID]) VALUES (10, N'Bourgas', 1)
SET IDENTITY_INSERT [dbo].[Towns] OFF
ALTER TABLE [dbo].[Addresses]  WITH CHECK ADD  CONSTRAINT [FK_Addresses_Towns] FOREIGN KEY([TownID])
REFERENCES [dbo].[Towns] ([TownID])
GO
ALTER TABLE [dbo].[Addresses] CHECK CONSTRAINT [FK_Addresses_Towns]
GO
ALTER TABLE [dbo].[Countries]  WITH CHECK ADD  CONSTRAINT [FK_Countries_Continents] FOREIGN KEY([ContinentID])
REFERENCES [dbo].[Continents] ([ContinentID])
GO
ALTER TABLE [dbo].[Countries] CHECK CONSTRAINT [FK_Countries_Continents]
GO
ALTER TABLE [dbo].[People]  WITH CHECK ADD  CONSTRAINT [FK_People_Addresses] FOREIGN KEY([AddressID])
REFERENCES [dbo].[Addresses] ([AddressID])
GO
ALTER TABLE [dbo].[People] CHECK CONSTRAINT [FK_People_Addresses]
GO
ALTER TABLE [dbo].[Towns]  WITH CHECK ADD  CONSTRAINT [FK_Towns_Countries] FOREIGN KEY([CountryID])
REFERENCES [dbo].[Countries] ([CountryID])
GO
ALTER TABLE [dbo].[Towns] CHECK CONSTRAINT [FK_Towns_Countries]
GO
