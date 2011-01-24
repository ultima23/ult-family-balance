/****** Object:  View [dbo].[vwEntriesByYearAndType]    Script Date: 01/03/2011 11:44:31 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwEntriesByYearAndType]'))
DROP VIEW [dbo].[vwEntriesByYearAndType]
GO

CREATE VIEW [dbo].[vwEntriesByYearAndType]
AS

SELECT	[EntryDirectionId]	= a.[EntryDirectionId],
		[Year]				= a.[Year],
		[Type]				= a.[Type],
		[Count]				= a.[Count],
		[Total]				= a.[Total],
		[Perc]				= CASE WHEN (b.[Total] > 0) THEN (100 / b.[Total]) * a.Total ELSE 0 END
FROM
(

	SELECT  [EntryDirectionId]	= [EntryDirectionId],
			[Year]				= [EntryYear],
			[Type]				= [EntryTypeName],
			[Count]				= COUNT(EntryId),
			[Total]				= SUM(EntryAmount)
	FROM		[vwEntries]		a
	GROUP BY [EntryDirectionId], [EntryYear], [EntryTypeId], [EntryTypeName]

) a
INNER JOIN	[vwEntriesByYear] b	ON		a.[EntryDirectionId] = b.[EntryDirectionId] 
										AND	a.[Year] = b.[Year] 