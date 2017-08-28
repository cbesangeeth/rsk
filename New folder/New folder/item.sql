USE [rsk_db]
GO

/****** Object:  Table [dbo].[item_master_tb]    Script Date: 02/22/2014 20:45:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[item_master_tb](
	[auto_no] [int] IDENTITY(1,1) NOT NULL,
	[item_code] [varchar](50) NOT NULL,
	[item_name] [varchar](50) NOT NULL,
	[group_name] [varchar](50) NOT NULL,
	[descripition] [text] NULL,
	[rate] [float] NOT NULL,
	[tax] [float] NOT NULL,
	[purchase_price] [float] NOT NULL,
	[selling_price] [float] NOT NULL,
	[reorder_qty] [int] NOT NULL,
	[minimum_qty] [int] NOT NULL,
 CONSTRAINT [PK_item_master_tb] PRIMARY KEY CLUSTERED 
(
	[auto_no] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[item_master_tb]  WITH CHECK ADD  CONSTRAINT [FK_item_master_tb_item_master_tb] FOREIGN KEY([auto_no])
REFERENCES [dbo].[item_master_tb] ([auto_no])
GO

ALTER TABLE [dbo].[item_master_tb] CHECK CONSTRAINT [FK_item_master_tb_item_master_tb]
GO

