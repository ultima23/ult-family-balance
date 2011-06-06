USE [UltFamilyBalance]
GO

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EntryType_EntryDirection]') AND parent_object_id = OBJECT_ID(N'[dbo].[EntryType]'))
ALTER TABLE [dbo].[EntryType] DROP CONSTRAINT [FK_EntryType_EntryDirection]
GO

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_EntryType_EntryNotesRequired]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[EntryType] DROP CONSTRAINT [DF_EntryType_EntryNotesRequired]
END

GO

USE [UltFamilyBalance]
GO

/****** Object:  Table [dbo].[EntryType]    Script Date: 05/26/2011 17:40:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EntryType]') AND type in (N'U'))
DROP TABLE [dbo].[EntryType]
GO

USE [UltFamilyBalance]
GO

/****** Object:  Table [dbo].[EntryType]    Script Date: 05/26/2011 17:40:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[EntryType](
	[EntryTypeId] [int] NOT NULL,
	[EntryTypeName] [nvarchar](200) NOT NULL,
	[EntryTypeDesc] [nvarchar](max) NULL,
	[EntryDirectionId] [int] NOT NULL,
	[EntryTypeRequireNote] [tinyint] NOT NULL,
 CONSTRAINT [PK_EntryType] PRIMARY KEY CLUSTERED 
(
	[EntryTypeId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Indica se è necessario inserire le note per una entry di questo tipo. 1: Required, 2: Not Required' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EntryType', @level2type=N'COLUMN',@level2name=N'EntryTypeRequireNote'
GO

ALTER TABLE [dbo].[EntryType]  WITH CHECK ADD  CONSTRAINT [FK_EntryType_EntryDirection] FOREIGN KEY([EntryDirectionId])
REFERENCES [dbo].[EntryDirection] ([EntryDirectionId])
GO

ALTER TABLE [dbo].[EntryType] CHECK CONSTRAINT [FK_EntryType_EntryDirection]
GO

ALTER TABLE [dbo].[EntryType] ADD  CONSTRAINT [DF_EntryType_EntryNotesRequired]  DEFAULT ((0)) FOR [EntryTypeRequireNote]
GO


