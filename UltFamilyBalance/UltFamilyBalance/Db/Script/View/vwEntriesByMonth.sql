/****** Object:  View [dbo].[vwOutgoingByMonth]    Script Date: 01/21/2011 11:44:11 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwEntriesByMonth]'))
DROP VIEW [dbo].[vwEntriesByMonth]
GO

CREATE VIEW [dbo].[vwEntriesByMonth]
AS

SELECT  [EntryDirectionId],
		[Year]  = [EntryYear],
        [Month] = [EntryMonth],
        [MonthName] = [EntryMonthName],
        [Count] = COUNT(EntryId),
        [Total] = SUM(EntryAmount)
        
FROM [vwEntries]
GROUP BY [EntryDirectionId], [EntryDirectionName], [EntryDirectionDesc], [EntryYear], [EntryMonth], [EntryMonthName]



