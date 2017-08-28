USE [rsk_db]
GO

/****** Object:  Table [dbo].[supplier_master_tb]    Script Date: 02/22/2014 20:47:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[supplier_master_tb](
	[auto_no] [int] IDENTITY(1,1) NOT NULL,
	[supplier_code] [varchar](50) NOT NULL,
	[supplier_name] [varchar](50) NOT NULL,
	[phone_number] [bigint] NULL,
	[address] [text] NULL,
 CONSTRAINT [PK_supplier_master_tb] PRIMARY KEY CLUSTERED 
(
	[auto_no] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

