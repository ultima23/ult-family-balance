IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwEntriesByYearAndTypeGroup]'))
DROP VIEW [dbo].[vwEntriesByYearAndTypeGroup]
GO

CREATE VIEW [dbo].[vwEntriesByYearAndTypeGroup]
AS

SELECT	[EntryDirectionId]	= a.[EntryDirectionId],
		[Year]				= a.[Year],
		[TypeGroup]			= a.[TypeGroup],
		[Count]				= a.[Count],
		[Total]				= a.[Total],
		[Perc]				= CASE WHEN (b.[Total] > 0) THEN (100 / b.[Total]) * a.Total ELSE 0 END
FROM
(

	SELECT  [EntryDirectionId],
			[Year]		= [EntryYear],
			[TypeGroup] = [EntryTypeGroupName],
			[Count]		= COUNT(EntryId),
			[Total]		= SUM(EntryAmount)
	FROM [vwEntries]
	GROUP BY [EntryDirectionId], [EntryYear], [EntryTypeGroupId], [EntryTypeGroupName]

) a
INNER JOIN	[vwEntriesByYear] b	ON		a.[EntryDirectionId] = b.[EntryDirectionId] 
									AND	a.[Year] = b.[Year] 