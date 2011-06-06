USE [UltFamilyBalance]
GO

/****** Object:  Table [dbo].[EntryTypeGroup]    Script Date: 05/26/2011 17:41:52 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EntryTypeGroup]') AND type in (N'U'))
DROP TABLE [dbo].[EntryTypeGroup]
GO

USE [UltFamilyBalance]
GO

/****** Object:  Table [dbo].[EntryTypeGroup]    Script Date: 05/26/2011 17:41:52 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[EntryTypeGroup](
	[EntryTypeId] [int] NOT NULL,
	[EntryGroupId] [int] NOT NULL,
 CONSTRAINT [PK_EntryTypeGroup_1] PRIMARY KEY CLUSTERED 
(
	[EntryTypeId] ASC,
	[EntryGroupId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


