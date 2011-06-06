IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwEntriesByYearAndTypeGroup]'))
DROP VIEW [dbo].[vwEntriesByYearAndTypeGroup]
GO

CREATE VIEW [dbo].[vwEntriesByYearAndTypeGroup]
AS

SELECT	[EntryDirectionId]	= a.[EntryDirectionId],
		[Year]				= a.[Year],
		[TypeGroup]			= a.[Group],
		[Count]				= a.[Count],
		[Total]				= a.[Total],
		[Perc]				= CASE WHEN (b.[Total] > 0) THEN (100 / b.[Total]) * a.Total ELSE 0 END
FROM
(

	SELECT  [EntryDirectionId]	= a3.[EntryDirectionId],
			[EntryGroupId]		= a3.[EntryGroupId],
			[Year]				= [EntryYear],
			[Group]				= [EntryGroupName],
			[Count]				= COUNT(EntryId),
			[Total]				= SUM(EntryAmount)
	FROM		[vwEntries]			a1
	INNER JOIN  [EntryTypeGroup]	a2	ON a2.[EntryTypeId] = a1.[EntryTypeId] 
	INNER JOIN	[EntryGroup]		a3	ON a3.[EntryGroupId] = a2.[EntryGroupId]
	GROUP BY [EntryYear], a3.[EntryGroupId], a3.[EntryDirectionId], a3.[EntryGroupName]

) a
INNER JOIN	[vwEntriesByYear] b	ON		a.[EntryDirectionId] = b.[EntryDirectionId] 
									AND	a.[Year] = b.[Year] 