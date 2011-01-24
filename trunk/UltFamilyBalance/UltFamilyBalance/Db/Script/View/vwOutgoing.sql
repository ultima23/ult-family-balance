USE [UltFamilyBalance]
GO

/****** Object:  View [dbo].[vwOutgoing]    Script Date: 01/03/2011 11:42:13 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwOutgoing]'))
DROP VIEW [dbo].[vwOutgoing]
GO

USE [UltFamilyBalance]
GO

CREATE VIEW [dbo].[vwOutgoing]
AS

SELECT *
FROM [vwEntries]
WHERE [EntryDirectionId] = 20

GO


