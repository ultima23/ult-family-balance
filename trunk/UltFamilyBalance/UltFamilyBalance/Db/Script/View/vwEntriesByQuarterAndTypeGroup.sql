IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwEntriesByQuarterAndTypeGroup]'))
DROP VIEW [dbo].[vwEntriesByQuarterAndTypeGroup]
GO

CREATE VIEW [dbo].[vwEntriesByQuarterAndTypeGroup]
AS

SELECT	[EntryDirectionId]	= a.[EntryDirectionId],
		[EntryGroupId]		= a.[EntryGroupId],
		[Year]				= a.[Year],
		[Quarter]			= a.[Quarter],
		[QuarterName]		= b.[QuarterName],
		[Group]				= a.[Group],
		[Count]				= a.[Count],
		[Total]				= a.[Total],
		[Perc]				= CASE WHEN (b.Total > 0) THEN (100 / b.Total) * a.Total ELSE 0 END
FROM
(

	SELECT  [EntryDirectionId],
			[EntryGroupId]	= a3.[EntryGroupId],
			[Year]			= [EntryYear],
			[Quarter]		= EntryQuarter,
			[Group]			= [EntryGroupName],
			[Count]			= COUNT(EntryId),
			[Total]			= SUM(EntryAmount)
	FROM		[vwEntries]			a1
	INNER JOIN  [EntryTypeGroup]	a2	ON a2.[EntryTypeId] = a1.[EntryTypeId] 
	INNER JOIN	[EntryGroup]		a3	ON a3.[EntryGroupId] = a2.[EntryGroupId]
	GROUP BY [EntryDirectionId], [EntryYear], [EntryQuarter], a3.[EntryGroupId], a3.[EntryGroupName]

) a
INNER JOIN	[vwEntriesByQuarter] b	ON		a.[EntryDirectionId] = b.[EntryDirectionId] 
										AND	a.[Year] = b.[Year] 
										AND	a.[Quarter] = b.[Quarter]