USE [Dictionary]
GO
/****** Object:  Table [dbo].[Explanations]    Script Date: 8/20/2014 7:20:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Explanations](
	[ExplanationID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [ntext] NOT NULL,
 CONSTRAINT [PK_Explanations] PRIMARY KEY CLUSTERED 
(
	[ExplanationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Languages]    Script Date: 8/20/2014 7:20:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Languages](
	[LanguageID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Languages] PRIMARY KEY CLUSTERED 
(
	[LanguageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Synonyms]    Script Date: 8/20/2014 7:20:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Synonyms](
	[SynonymID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Synonyms] PRIMARY KEY CLUSTERED 
(
	[SynonymID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Translates]    Script Date: 8/20/2014 7:20:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Translates](
	[TranslateID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[LanguageID] [int] NOT NULL,
 CONSTRAINT [PK_Translates] PRIMARY KEY CLUSTERED 
(
	[TranslateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Words]    Script Date: 8/20/2014 7:20:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Words](
	[WordID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[SynonymID] [int] NULL,
	[ExplanationID] [int] NULL,
 CONSTRAINT [PK_Words] PRIMARY KEY CLUSTERED 
(
	[WordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[WordsTranslates]    Script Date: 8/20/2014 7:20:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WordsTranslates](
	[WordID] [int] NOT NULL,
	[TranslateID] [int] NOT NULL
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Languages] ON 

INSERT [dbo].[Languages] ([LanguageID], [Name]) VALUES (2, N'Bulgarian')
INSERT [dbo].[Languages] ([LanguageID], [Name]) VALUES (1, N'English')
INSERT [dbo].[Languages] ([LanguageID], [Name]) VALUES (3, N'French')
INSERT [dbo].[Languages] ([LanguageID], [Name]) VALUES (4, N'Germany')
INSERT [dbo].[Languages] ([LanguageID], [Name]) VALUES (5, N'Italian')
INSERT [dbo].[Languages] ([LanguageID], [Name]) VALUES (7, N'Russian')
INSERT [dbo].[Languages] ([LanguageID], [Name]) VALUES (6, N'Spanish')
SET IDENTITY_INSERT [dbo].[Languages] OFF
SET IDENTITY_INSERT [dbo].[Translates] ON 

INSERT [dbo].[Translates] ([TranslateID], [Name], [LanguageID]) VALUES (1, N'spider', 1)
INSERT [dbo].[Translates] ([TranslateID], [Name], [LanguageID]) VALUES (2, N'tree', 1)
INSERT [dbo].[Translates] ([TranslateID], [Name], [LanguageID]) VALUES (3, N'board', 1)
INSERT [dbo].[Translates] ([TranslateID], [Name], [LanguageID]) VALUES (4, N'remote', 1)
INSERT [dbo].[Translates] ([TranslateID], [Name], [LanguageID]) VALUES (5, N'chair', 1)
INSERT [dbo].[Translates] ([TranslateID], [Name], [LanguageID]) VALUES (6, N'sofa', 1)
INSERT [dbo].[Translates] ([TranslateID], [Name], [LanguageID]) VALUES (7, N't-shirt', 1)
INSERT [dbo].[Translates] ([TranslateID], [Name], [LanguageID]) VALUES (8, N'run', 1)
INSERT [dbo].[Translates] ([TranslateID], [Name], [LanguageID]) VALUES (9, N'speech', 1)
INSERT [dbo].[Translates] ([TranslateID], [Name], [LanguageID]) VALUES (10, N'have', 1)
INSERT [dbo].[Translates] ([TranslateID], [Name], [LanguageID]) VALUES (11, N'can', 1)
INSERT [dbo].[Translates] ([TranslateID], [Name], [LanguageID]) VALUES (12, N'system', 1)
INSERT [dbo].[Translates] ([TranslateID], [Name], [LanguageID]) VALUES (13, N'achievement', 1)
INSERT [dbo].[Translates] ([TranslateID], [Name], [LanguageID]) VALUES (14, N'award', 1)
SET IDENTITY_INSERT [dbo].[Translates] OFF
SET IDENTITY_INSERT [dbo].[Words] ON 

INSERT [dbo].[Words] ([WordID], [Name], [SynonymID], [ExplanationID]) VALUES (1, N'паяк', NULL, NULL)
INSERT [dbo].[Words] ([WordID], [Name], [SynonymID], [ExplanationID]) VALUES (2, N'дърво', NULL, NULL)
INSERT [dbo].[Words] ([WordID], [Name], [SynonymID], [ExplanationID]) VALUES (3, N'дъска', NULL, NULL)
INSERT [dbo].[Words] ([WordID], [Name], [SynonymID], [ExplanationID]) VALUES (4, N'дистанционно', NULL, NULL)
INSERT [dbo].[Words] ([WordID], [Name], [SynonymID], [ExplanationID]) VALUES (5, N'стол', NULL, NULL)
INSERT [dbo].[Words] ([WordID], [Name], [SynonymID], [ExplanationID]) VALUES (6, N'диван', NULL, NULL)
INSERT [dbo].[Words] ([WordID], [Name], [SynonymID], [ExplanationID]) VALUES (7, N'тениска', NULL, NULL)
INSERT [dbo].[Words] ([WordID], [Name], [SynonymID], [ExplanationID]) VALUES (8, N'тичам', NULL, NULL)
INSERT [dbo].[Words] ([WordID], [Name], [SynonymID], [ExplanationID]) VALUES (9, N'говор', NULL, NULL)
INSERT [dbo].[Words] ([WordID], [Name], [SynonymID], [ExplanationID]) VALUES (10, N'имам', NULL, NULL)
INSERT [dbo].[Words] ([WordID], [Name], [SynonymID], [ExplanationID]) VALUES (11, N'мога', NULL, NULL)
INSERT [dbo].[Words] ([WordID], [Name], [SynonymID], [ExplanationID]) VALUES (12, N'система', NULL, NULL)
INSERT [dbo].[Words] ([WordID], [Name], [SynonymID], [ExplanationID]) VALUES (13, N'постижение', NULL, NULL)
INSERT [dbo].[Words] ([WordID], [Name], [SynonymID], [ExplanationID]) VALUES (14, N'награда', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Words] OFF
INSERT [dbo].[WordsTranslates] ([WordID], [TranslateID]) VALUES (1, 1)
INSERT [dbo].[WordsTranslates] ([WordID], [TranslateID]) VALUES (2, 2)
INSERT [dbo].[WordsTranslates] ([WordID], [TranslateID]) VALUES (3, 3)
INSERT [dbo].[WordsTranslates] ([WordID], [TranslateID]) VALUES (4, 4)
INSERT [dbo].[WordsTranslates] ([WordID], [TranslateID]) VALUES (5, 5)
INSERT [dbo].[WordsTranslates] ([WordID], [TranslateID]) VALUES (6, 6)
INSERT [dbo].[WordsTranslates] ([WordID], [TranslateID]) VALUES (7, 7)
INSERT [dbo].[WordsTranslates] ([WordID], [TranslateID]) VALUES (8, 8)
INSERT [dbo].[WordsTranslates] ([WordID], [TranslateID]) VALUES (9, 9)
INSERT [dbo].[WordsTranslates] ([WordID], [TranslateID]) VALUES (10, 10)
INSERT [dbo].[WordsTranslates] ([WordID], [TranslateID]) VALUES (11, 11)
INSERT [dbo].[WordsTranslates] ([WordID], [TranslateID]) VALUES (12, 12)
INSERT [dbo].[WordsTranslates] ([WordID], [TranslateID]) VALUES (13, 14)
INSERT [dbo].[WordsTranslates] ([WordID], [TranslateID]) VALUES (14, 14)
SET ANSI_PADDING ON

GO
/****** Object:  Index [UK_Languages]    Script Date: 8/20/2014 7:20:43 PM ******/
ALTER TABLE [dbo].[Languages] ADD  CONSTRAINT [UK_Languages] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UK_Translates]    Script Date: 8/20/2014 7:20:43 PM ******/
ALTER TABLE [dbo].[Translates] ADD  CONSTRAINT [UK_Translates] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UK_Words]    Script Date: 8/20/2014 7:20:43 PM ******/
ALTER TABLE [dbo].[Words] ADD  CONSTRAINT [UK_Words] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Translates]  WITH CHECK ADD  CONSTRAINT [FK_Translates_Languages] FOREIGN KEY([LanguageID])
REFERENCES [dbo].[Languages] ([LanguageID])
GO
ALTER TABLE [dbo].[Translates] CHECK CONSTRAINT [FK_Translates_Languages]
GO
ALTER TABLE [dbo].[Words]  WITH CHECK ADD  CONSTRAINT [FK_Words_Explanations] FOREIGN KEY([ExplanationID])
REFERENCES [dbo].[Explanations] ([ExplanationID])
GO
ALTER TABLE [dbo].[Words] CHECK CONSTRAINT [FK_Words_Explanations]
GO
ALTER TABLE [dbo].[Words]  WITH CHECK ADD  CONSTRAINT [FK_Words_Synonyms] FOREIGN KEY([SynonymID])
REFERENCES [dbo].[Synonyms] ([SynonymID])
GO
ALTER TABLE [dbo].[Words] CHECK CONSTRAINT [FK_Words_Synonyms]
GO
ALTER TABLE [dbo].[WordsTranslates]  WITH CHECK ADD  CONSTRAINT [FK_WordsTranslates_Translates] FOREIGN KEY([TranslateID])
REFERENCES [dbo].[Translates] ([TranslateID])
GO
ALTER TABLE [dbo].[WordsTranslates] CHECK CONSTRAINT [FK_WordsTranslates_Translates]
GO
ALTER TABLE [dbo].[WordsTranslates]  WITH CHECK ADD  CONSTRAINT [FK_WordsTranslates_Words] FOREIGN KEY([WordID])
REFERENCES [dbo].[Words] ([WordID])
GO
ALTER TABLE [dbo].[WordsTranslates] CHECK CONSTRAINT [FK_WordsTranslates_Words]
GO
