IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwEntriesByMonthAndTypeGroup]'))
DROP VIEW [dbo].[vwEntriesByMonthAndTypeGroup]
GO

CREATE VIEW [dbo].[vwEntriesByMonthAndTypeGroup]
AS

SELECT	[EntryDirectionId]	= a.[EntryDirectionId],
		[EntryGroupId]		= a.[EntryGroupId],
		[Year]				= a.[Year],
		[Month]				= a.[Month],
		[MonthName]			= b.[MonthName],
		[Group]				= a.[Group],
		[Count]				= a.[Count],
		[Total]				= a.[Total],
		[Perc]				= CASE WHEN (b.Total > 0) THEN (100 / b.Total) * a.Total ELSE 0 END
FROM
(

	SELECT  [EntryDirectionId],
			[EntryGroupId]	= a3.[EntryGroupId],
			[Year]			= [EntryYear],
			[Month]			= EntryMonth,
			[Group]			= a3.[EntryGroupName],
			[Count]			= COUNT(EntryId),
			[Total]			= SUM(EntryAmount)
	FROM		[vwEntries]			a1
	INNER JOIN  [EntryTypeGroup]	a2	ON a2.[EntryTypeId] = a1.[EntryTypeId] 
	INNER JOIN	[EntryGroup]		a3	ON a3.[EntryGroupId] = a2.[EntryGroupId]
	GROUP BY [EntryDirectionId], [EntryYear], [EntryMonth], a3.[EntryGroupId], a3.[EntryGroupName]

) a
INNER JOIN	[vwEntriesByMonth] b	ON		a.[EntryDirectionId] = b.[EntryDirectionId] 
										AND	a.[Year] = b.[Year] 
										AND	a.[Month] = b.[Month]