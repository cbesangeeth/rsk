USE [rsk_db]
GO

/****** Object:  Table [dbo].[sales_invoice_tb]    Script Date: 02/22/2014 20:46:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[sales_invoice_tb](
	[auto_no] [int] IDENTITY(1,1) NOT NULL,
	[sales_invoice_no] [varchar](50) NOT NULL,
	[date] [varchar](50) NOT NULL,
	[customer_code] [varchar](50) NULL,
	[item_code] [varchar](50) NOT NULL,
	[quantity] [int] NOT NULL,
	[total_amount] [float] NOT NULL,
 CONSTRAINT [PK_sales_invoice_tb] PRIMARY KEY CLUSTERED 
(
	[auto_no] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

