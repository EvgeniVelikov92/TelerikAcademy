USE [University]
GO
/****** Object:  Table [dbo].[Courses]    Script Date: 8/20/2014 3:19:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[CourseID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[DepartmentID] [int] NOT NULL,
	[ProfessorID] [int] NOT NULL,
 CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED 
(
	[CourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Departments]    Script Date: 8/20/2014 3:19:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departments](
	[DepartmentID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[FacultiesID] [int] NULL,
 CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED 
(
	[DepartmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Faculties]    Script Date: 8/20/2014 3:19:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Faculties](
	[FacultieID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[UniversityID] [int] NOT NULL,
 CONSTRAINT [PK_Faculties] PRIMARY KEY CLUSTERED 
(
	[FacultieID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Professors]    Script Date: 8/20/2014 3:19:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Professors](
	[ProfessorsID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[TitleID] [int] NOT NULL,
	[DepartmentID] [int] NOT NULL,
 CONSTRAINT [PK_Professors] PRIMARY KEY CLUSTERED 
(
	[ProfessorsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Students]    Script Date: 8/20/2014 3:19:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[StudentID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[FacultyNumber] [nvarchar](20) NOT NULL,
	[FacultieID] [int] NOT NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StudentsCourses]    Script Date: 8/20/2014 3:19:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentsCourses](
	[StudentID] [int] NOT NULL,
	[CourseID] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Titles]    Script Date: 8/20/2014 3:19:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Titles](
	[TitleID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Titles] PRIMARY KEY CLUSTERED 
(
	[TitleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Universities]    Script Date: 8/20/2014 3:19:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Universities](
	[UniversityID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Universities] PRIMARY KEY CLUSTERED 
(
	[UniversityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Courses] ON 

INSERT [dbo].[Courses] ([CourseID], [Name], [DepartmentID], [ProfessorID]) VALUES (1, N'Pedagogis', 5, 1)
INSERT [dbo].[Courses] ([CourseID], [Name], [DepartmentID], [ProfessorID]) VALUES (2, N'Automatic Technology Proccess', 2, 6)
INSERT [dbo].[Courses] ([CourseID], [Name], [DepartmentID], [ProfessorID]) VALUES (4, N'Economyc', 6, 10)
INSERT [dbo].[Courses] ([CourseID], [Name], [DepartmentID], [ProfessorID]) VALUES (5, N'English language', 7, 11)
INSERT [dbo].[Courses] ([CourseID], [Name], [DepartmentID], [ProfessorID]) VALUES (6, N'Electrotechnics', 1, 12)
INSERT [dbo].[Courses] ([CourseID], [Name], [DepartmentID], [ProfessorID]) VALUES (7, N'PPE', 2, 8)
INSERT [dbo].[Courses] ([CourseID], [Name], [DepartmentID], [ProfessorID]) VALUES (8, N'MaterialKnowledge', 3, 13)
INSERT [dbo].[Courses] ([CourseID], [Name], [DepartmentID], [ProfessorID]) VALUES (9, N'Mechanics', 4, 14)
SET IDENTITY_INSERT [dbo].[Courses] OFF
SET IDENTITY_INSERT [dbo].[Departments] ON 

INSERT [dbo].[Departments] ([DepartmentID], [Name], [FacultiesID]) VALUES (1, N'Electrical', 1)
INSERT [dbo].[Departments] ([DepartmentID], [Name], [FacultiesID]) VALUES (2, N'Automation and Information Technology', 1)
INSERT [dbo].[Departments] ([DepartmentID], [Name], [FacultiesID]) VALUES (3, N'Heating Technology', 1)
INSERT [dbo].[Departments] ([DepartmentID], [Name], [FacultiesID]) VALUES (4, N'Computers in Engeneering', 1)
INSERT [dbo].[Departments] ([DepartmentID], [Name], [FacultiesID]) VALUES (5, N'Pedagogics
	
', 1)
INSERT [dbo].[Departments] ([DepartmentID], [Name], [FacultiesID]) VALUES (6, N'Economycs', 1)
INSERT [dbo].[Departments] ([DepartmentID], [Name], [FacultiesID]) VALUES (7, N'Languages', 1)
SET IDENTITY_INSERT [dbo].[Departments] OFF
SET IDENTITY_INSERT [dbo].[Faculties] ON 

INSERT [dbo].[Faculties] ([FacultieID], [Name], [UniversityID]) VALUES (1, N'Sliven', 1)
INSERT [dbo].[Faculties] ([FacultieID], [Name], [UniversityID]) VALUES (2, N'Plovdiv', 1)
INSERT [dbo].[Faculties] ([FacultieID], [Name], [UniversityID]) VALUES (3, N'Gabrovo', 1)
SET IDENTITY_INSERT [dbo].[Faculties] OFF
SET IDENTITY_INSERT [dbo].[Professors] ON 

INSERT [dbo].[Professors] ([ProfessorsID], [Name], [TitleID], [DepartmentID]) VALUES (1, N'Yurii Klisarov', 2, 5)
INSERT [dbo].[Professors] ([ProfessorsID], [Name], [TitleID], [DepartmentID]) VALUES (2, N'Vasilev', 2, 2)
INSERT [dbo].[Professors] ([ProfessorsID], [Name], [TitleID], [DepartmentID]) VALUES (3, N'Daskalov', 3, 1)
INSERT [dbo].[Professors] ([ProfessorsID], [Name], [TitleID], [DepartmentID]) VALUES (4, N'Krastev', 2, 3)
INSERT [dbo].[Professors] ([ProfessorsID], [Name], [TitleID], [DepartmentID]) VALUES (5, N'Kukurigov', 4, 2)
INSERT [dbo].[Professors] ([ProfessorsID], [Name], [TitleID], [DepartmentID]) VALUES (6, N'Nyagolov', 2, 2)
INSERT [dbo].[Professors] ([ProfessorsID], [Name], [TitleID], [DepartmentID]) VALUES (7, N'Georgiev', 3, 2)
INSERT [dbo].[Professors] ([ProfessorsID], [Name], [TitleID], [DepartmentID]) VALUES (8, N'Ivancheva', 6, 2)
INSERT [dbo].[Professors] ([ProfessorsID], [Name], [TitleID], [DepartmentID]) VALUES (9, N'Consulova', 1, 5)
INSERT [dbo].[Professors] ([ProfessorsID], [Name], [TitleID], [DepartmentID]) VALUES (10, N'Chobanov', 6, 6)
INSERT [dbo].[Professors] ([ProfessorsID], [Name], [TitleID], [DepartmentID]) VALUES (11, N'Belcheva', 2, 7)
INSERT [dbo].[Professors] ([ProfessorsID], [Name], [TitleID], [DepartmentID]) VALUES (12, N'Chervenkova', 6, 1)
INSERT [dbo].[Professors] ([ProfessorsID], [Name], [TitleID], [DepartmentID]) VALUES (13, N'Keminov', 6, 3)
INSERT [dbo].[Professors] ([ProfessorsID], [Name], [TitleID], [DepartmentID]) VALUES (14, N'Moneva', 6, 4)
SET IDENTITY_INSERT [dbo].[Professors] OFF
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([StudentID], [Name], [FacultyNumber], [FacultieID]) VALUES (1, N'Ivan Georgiev', N'11018005', 1)
INSERT [dbo].[Students] ([StudentID], [Name], [FacultyNumber], [FacultieID]) VALUES (2, N'Simeon Georgiev', N'12005035', 1)
INSERT [dbo].[Students] ([StudentID], [Name], [FacultyNumber], [FacultieID]) VALUES (3, N'Daniel Milanov', N'10101010', 1)
INSERT [dbo].[Students] ([StudentID], [Name], [FacultyNumber], [FacultieID]) VALUES (4, N'Viktor Hristov', N'13055876', 1)
INSERT [dbo].[Students] ([StudentID], [Name], [FacultyNumber], [FacultieID]) VALUES (5, N'Filip Borisov', N'12151820', 1)
SET IDENTITY_INSERT [dbo].[Students] OFF
INSERT [dbo].[StudentsCourses] ([StudentID], [CourseID]) VALUES (1, 2)
INSERT [dbo].[StudentsCourses] ([StudentID], [CourseID]) VALUES (1, 4)
INSERT [dbo].[StudentsCourses] ([StudentID], [CourseID]) VALUES (1, 6)
INSERT [dbo].[StudentsCourses] ([StudentID], [CourseID]) VALUES (1, 5)
INSERT [dbo].[StudentsCourses] ([StudentID], [CourseID]) VALUES (2, 2)
INSERT [dbo].[StudentsCourses] ([StudentID], [CourseID]) VALUES (2, 4)
INSERT [dbo].[StudentsCourses] ([StudentID], [CourseID]) VALUES (2, 5)
INSERT [dbo].[StudentsCourses] ([StudentID], [CourseID]) VALUES (3, 8)
INSERT [dbo].[StudentsCourses] ([StudentID], [CourseID]) VALUES (3, 9)
INSERT [dbo].[StudentsCourses] ([StudentID], [CourseID]) VALUES (4, 5)
INSERT [dbo].[StudentsCourses] ([StudentID], [CourseID]) VALUES (4, 8)
INSERT [dbo].[StudentsCourses] ([StudentID], [CourseID]) VALUES (4, 6)
INSERT [dbo].[StudentsCourses] ([StudentID], [CourseID]) VALUES (5, 7)
INSERT [dbo].[StudentsCourses] ([StudentID], [CourseID]) VALUES (5, 6)
INSERT [dbo].[StudentsCourses] ([StudentID], [CourseID]) VALUES (5, 2)
SET IDENTITY_INSERT [dbo].[Titles] ON 

INSERT [dbo].[Titles] ([TitleID], [Name]) VALUES (1, N'Senior assistant')
INSERT [dbo].[Titles] ([TitleID], [Name]) VALUES (2, N'Dr.')
INSERT [dbo].[Titles] ([TitleID], [Name]) VALUES (3, N'Ph.')
INSERT [dbo].[Titles] ([TitleID], [Name]) VALUES (4, N'Engeneer')
INSERT [dbo].[Titles] ([TitleID], [Name]) VALUES (5, N'Academician')
INSERT [dbo].[Titles] ([TitleID], [Name]) VALUES (6, N'Associate Professor')
SET IDENTITY_INSERT [dbo].[Titles] OFF
SET IDENTITY_INSERT [dbo].[Universities] ON 

INSERT [dbo].[Universities] ([UniversityID], [Name]) VALUES (1, N'Technical')
INSERT [dbo].[Universities] ([UniversityID], [Name]) VALUES (2, N'Medical')
INSERT [dbo].[Universities] ([UniversityID], [Name]) VALUES (3, N'Economycal')
SET IDENTITY_INSERT [dbo].[Universities] OFF
ALTER TABLE [dbo].[Courses]  WITH CHECK ADD  CONSTRAINT [FK_Courses_Departments] FOREIGN KEY([DepartmentID])
REFERENCES [dbo].[Departments] ([DepartmentID])
GO
ALTER TABLE [dbo].[Courses] CHECK CONSTRAINT [FK_Courses_Departments]
GO
ALTER TABLE [dbo].[Courses]  WITH CHECK ADD  CONSTRAINT [FK_Courses_Professors] FOREIGN KEY([ProfessorID])
REFERENCES [dbo].[Professors] ([ProfessorsID])
GO
ALTER TABLE [dbo].[Courses] CHECK CONSTRAINT [FK_Courses_Professors]
GO
ALTER TABLE [dbo].[Departments]  WITH CHECK ADD  CONSTRAINT [FK_Departments_Faculties] FOREIGN KEY([FacultiesID])
REFERENCES [dbo].[Faculties] ([FacultieID])
GO
ALTER TABLE [dbo].[Departments] CHECK CONSTRAINT [FK_Departments_Faculties]
GO
ALTER TABLE [dbo].[Faculties]  WITH CHECK ADD  CONSTRAINT [FK_Faculties_Universities] FOREIGN KEY([UniversityID])
REFERENCES [dbo].[Universities] ([UniversityID])
GO
ALTER TABLE [dbo].[Faculties] CHECK CONSTRAINT [FK_Faculties_Universities]
GO
ALTER TABLE [dbo].[Professors]  WITH CHECK ADD  CONSTRAINT [FK_Professors_Titles] FOREIGN KEY([TitleID])
REFERENCES [dbo].[Titles] ([TitleID])
GO
ALTER TABLE [dbo].[Professors] CHECK CONSTRAINT [FK_Professors_Titles]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Faculties] FOREIGN KEY([FacultieID])
REFERENCES [dbo].[Faculties] ([FacultieID])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Faculties]
GO
ALTER TABLE [dbo].[StudentsCourses]  WITH CHECK ADD  CONSTRAINT [FK_StudentsCourses_Courses] FOREIGN KEY([CourseID])
REFERENCES [dbo].[Courses] ([CourseID])
GO
ALTER TABLE [dbo].[StudentsCourses] CHECK CONSTRAINT [FK_StudentsCourses_Courses]
GO
ALTER TABLE [dbo].[StudentsCourses]  WITH CHECK ADD  CONSTRAINT [FK_StudentsCourses_Students] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Students] ([StudentID])
GO
ALTER TABLE [dbo].[StudentsCourses] CHECK CONSTRAINT [FK_StudentsCourses_Students]
GO
