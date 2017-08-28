USE [rsk_db]
GO

/****** Object:  Table [dbo].[tax_master_tb]    Script Date: 02/22/2014 20:47:17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tax_master_tb](
	[auto_no] [int] IDENTITY(1,1) NOT NULL,
	[tax_percentage] [float] NOT NULL,
	[tax_describtion] [text] NULL,
 CONSTRAINT [PK_tax_master_tb] PRIMARY KEY CLUSTERED 
(
	[auto_no] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

