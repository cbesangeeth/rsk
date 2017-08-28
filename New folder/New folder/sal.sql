USE [rsk_db]
GO

/****** Object:  Table [dbo].[sales_invoice_M]    Script Date: 02/22/2014 20:46:24 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[sales_invoice_M](
	[auto_no] [int] IDENTITY(1,1) NOT NULL,
	[SInvNo] [varchar](50) NOT NULL,
	[date] [varchar](50) NOT NULL,
	[customer_code] [varchar](50) NOT NULL,
	[total_amount] [float] NOT NULL,
 CONSTRAINT [PK_sales_invoice_M] PRIMARY KEY CLUSTERED 
(
	[auto_no] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

