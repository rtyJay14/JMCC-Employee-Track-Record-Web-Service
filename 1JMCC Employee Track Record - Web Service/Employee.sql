USE [Employee]
GO

/****** Object:  Table [dbo].[Employees]    Script Date: 7/20/2013 1:03:37 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Employees](
	[Id] [int] NOT NULL,
	[Full_Name] [nvarchar](50) NOT NULL,
	[Login_Date] [datetime] NOT NULL,
	[Logout_Date] [datetime] NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


