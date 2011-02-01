/****** Object:  View [dbo].[vwEntriesByQuarter]    Script Date: 02/01/2011 13:39:38 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwEntriesByQuarter]'))
DROP VIEW [dbo].[vwEntriesByQuarter]
GO

CREATE VIEW [dbo].[vwEntriesByQuarter]
AS

SELECT  [EntryDirectionId],
		[Year]  = [EntryYear],
        [Quarter] = [EntryQuarter],
        [QuarterName] = [EntryQuarterName],
        [Count] = COUNT(EntryId),
        [Total] = SUM(EntryAmount)
        
FROM [vwEntries]
GROUP BY [EntryDirectionId], [EntryDirectionName], [EntryDirectionDesc], [EntryYear], [EntryQuarter], [EntryQuarterName]
GO


