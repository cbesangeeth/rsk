USE [rsk_db]
GO

/****** Object:  Table [dbo].[sub_group_tb]    Script Date: 02/22/2014 20:46:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[sub_group_tb](
	[auto_no] [int] IDENTITY(1,1) NOT NULL,
	[group_name] [varchar](50) NOT NULL,
	[description] [text] NULL,
 CONSTRAINT [PK_sub_group_tb] PRIMARY KEY CLUSTERED 
(
	[auto_no] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

