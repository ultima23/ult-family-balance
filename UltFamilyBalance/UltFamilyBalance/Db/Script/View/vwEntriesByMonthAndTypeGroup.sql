IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwEntriesByMonthAndTypeGroup]'))
DROP VIEW [dbo].[vwEntriesByMonthAndTypeGroup]
GO

CREATE VIEW [dbo].[vwEntriesByMonthAndTypeGroup]
AS

SELECT	[EntryDirectionId]	= a.[EntryDirectionId],
		[Year]				= a.[Year],
		[Month]				= a.[Month],
		[MonthName]			= b.[MonthName],
		[TypeGroup]			= a.[TypeGroup],
		[Count]				= a.[Count],
		[Total]				= a.[Total],
		[Perc]				= CASE WHEN (b.Total > 0) THEN (100 / b.Total) * a.Total ELSE 0 END
FROM
(

	SELECT  [EntryDirectionId],
			[Year]		= [EntryYear],
			[Month]		= EntryMonth,
			[TypeGroup] = [EntryTypeGroupName],
			[Count]		= COUNT(EntryId),
			[Total]		= SUM(EntryAmount)
	FROM [vwEntries]
	GROUP BY [EntryDirectionId], [EntryYear], [EntryMonth], [EntryTypeGroupId], [EntryTypeGroupName]

) a
INNER JOIN	[vwEntriesByMonth] b	ON		a.[EntryDirectionId] = b.[EntryDirectionId] 
										AND	a.[Year] = b.[Year] 
										AND	a.[Month] = b.[Month]