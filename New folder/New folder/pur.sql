USE [rsk_db]
GO

/****** Object:  Table [dbo].[purchase_invoice_M]    Script Date: 02/22/2014 20:45:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[purchase_invoice_M](
	[auto_no] [int] IDENTITY(1,1) NOT NULL,
	[PInvNo] [varchar](50) NULL,
	[date] [varchar](50) NULL,
	[supplier_code] [varchar](50) NULL,
	[total_amount] [float] NULL,
	[bill_no] [varchar](50) NULL,
	[bill_date] [datetime] NULL,
 CONSTRAINT [PK_purchase_invoice_M] PRIMARY KEY CLUSTERED 
(
	[auto_no] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

