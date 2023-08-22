USE [BelgiumCampus]
GO

/****** Object:  Table [dbo].[Employees]    Script Date: 2023/05/25 23:08:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Employees](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [text] NOT NULL,
	[LastName] [text] NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

INSERT INTO [dbo].[Employees]
           ([FirstName]
           ,[LastName])
     VALUES
           ('Nicolas', 'Buys'),
		   ('Raymond', 'Hood'),
		   ('Lawernce', 'Mothabela'),
		   ('Neo', 'Amese'),
		   ('Andre', 'Viviers'),
		   ('Lehlohonolo', 'Maleka');
GO

