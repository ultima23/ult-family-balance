IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwEntriesByQuarterAndTypeGroup]'))
DROP VIEW [dbo].[vwEntriesByQuarterAndTypeGroup]
GO

CREATE VIEW [dbo].[vwEntriesByQuarterAndTypeGroup]
AS

SELECT	[EntryDirectionId]	= a.[EntryDirectionId],
		[Year]				= a.[Year],
		[Quarter]			= a.[Quarter],
		[QuarterName]		= b.[QuarterName],
		[TypeGroup]			= a.[TypeGroup],
		[Count]				= a.[Count],
		[Total]				= a.[Total],
		[Perc]				= CASE WHEN (b.Total > 0) THEN (100 / b.Total) * a.Total ELSE 0 END
FROM
(

	SELECT  [EntryDirectionId],
			[Year]		= [EntryYear],
			[Quarter]	= EntryQuarter,
			[TypeGroup] = [EntryTypeGroupName],
			[Count]		= COUNT(EntryId),
			[Total]		= SUM(EntryAmount)
	FROM [vwEntries]
	GROUP BY [EntryDirectionId], [EntryYear], [EntryQuarter], [EntryTypeGroupId], [EntryTypeGroupName]

) a
INNER JOIN	[vwEntriesByQuarter] b	ON		a.[EntryDirectionId] = b.[EntryDirectionId] 
										AND	a.[Year] = b.[Year] 
										AND	a.[Quarter] = b.[Quarter]