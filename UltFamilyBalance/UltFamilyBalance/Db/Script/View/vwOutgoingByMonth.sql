USE [UltFamilyBalance]
GO

/****** Object:  View [dbo].[vwOutgoingByMonth]    Script Date: 01/03/2011 11:43:05 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwOutgoingByMonth]'))
DROP VIEW [dbo].[vwOutgoingByMonth]
GO

USE [UltFamilyBalance]
GO

CREATE VIEW [dbo].[vwOutgoingByMonth]
AS

SELECT  [Year]  = [EntryYear],
        [Month] = EntryMonth,
        [Count] = COUNT(EntryId),
        [Total] = SUM(EntryAmount)
FROM [vwOutgoing]
GROUP BY [EntryYear], [EntryMonth]

GO


