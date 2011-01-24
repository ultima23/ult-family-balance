/****** Object:  View [dbo].[vwOutgoingByMonth]    Script Date: 01/21/2011 11:44:11 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwEntriesByYear]'))
DROP VIEW [dbo].[vwEntriesByYear]
GO

CREATE VIEW [dbo].[vwEntriesByYear]
AS

SELECT  [EntryDirectionId],
		[Year]  = [EntryYear],
        [Count] = COUNT(EntryId),
        [Total] = SUM(EntryAmount)
        
FROM [vwEntries]
GROUP BY [EntryDirectionId], [EntryDirectionName], [EntryDirectionDesc], [EntryYear]