USE [rsk_db]
GO

/****** Object:  Table [dbo].[SaleInvoice_D]    Script Date: 02/22/2014 20:46:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[SaleInvoice_D](
	[SInvNo] [int] NULL,
	[ProdTitle] [varchar](50) NULL,
	[Quantity] [int] NULL,
	[UnitPrice] [int] NULL,
	[TotalCost] [float] NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

