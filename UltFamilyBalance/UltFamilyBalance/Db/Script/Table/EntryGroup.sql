USE [UltFamilyBalance]
GO

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_EntryGroup_EntryDirectionId]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[EntryGroup] DROP CONSTRAINT [DF_EntryGroup_EntryDirectionId]
END

GO

USE [UltFamilyBalance]
GO

/****** Object:  Table [dbo].[EntryGroup]    Script Date: 06/06/2011 11:01:30 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EntryGroup]') AND type in (N'U'))
DROP TABLE [dbo].[EntryGroup]
GO

USE [UltFamilyBalance]
GO

/****** Object:  Table [dbo].[EntryGroup]    Script Date: 06/06/2011 11:01:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[EntryGroup](
	[EntryGroupId] [int] IDENTITY(1,1) NOT NULL,
	[EntryGroupName] [nvarchar](200) NOT NULL,
	[EntryGroupDesc] [nvarchar](max) NOT NULL,
	[EntryDirectionId] [int] NOT NULL,
 CONSTRAINT [PK_EntryTypeGroup] PRIMARY KEY CLUSTERED 
(
	[EntryGroupId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[EntryGroup] ADD  CONSTRAINT [DF_EntryGroup_EntryDirectionId]  DEFAULT ((20)) FOR [EntryDirectionId]
GO


