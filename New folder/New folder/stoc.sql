USE [rsk_db]
GO

/****** Object:  Table [dbo].[stock_M]    Script Date: 02/22/2014 20:46:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[stock_M](
	[auto_no] [int] NULL,
	[item_code] [varchar](50) NULL,
	[item_name] [varchar](50) NULL,
	[qty] [int] NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

