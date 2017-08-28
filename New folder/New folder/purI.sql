USE [rsk_db]
GO

/****** Object:  Table [dbo].[purchaseInvoice_D]    Script Date: 02/22/2014 20:46:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[purchaseInvoice_D](
	[PInvNo] [varchar](50) NOT NULL,
	[ProdTitle] [varchar](50) NOT NULL,
	[Quantity] [int] NOT NULL,
	[UnitPrice] [int] NOT NULL,
	[TotalCost] [float] NOT NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

