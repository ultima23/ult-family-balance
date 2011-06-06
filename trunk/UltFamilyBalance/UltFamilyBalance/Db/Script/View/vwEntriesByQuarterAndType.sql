/****** Object:  View [dbo].[vwEntriesByQuarterAndType]    Script Date: 01/03/2011 11:44:31 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwEntriesByQuarterAndType]'))
DROP VIEW [dbo].[vwEntriesByQuarterAndType]
GO

USE [UltFamilyBalance]
GO

CREATE VIEW [dbo].[vwEntriesByQuarterAndType]
AS

SELECT	[EntryDirectionId]	= a.[EntryDirectionId],
		[Year]				= a.[Year],
		[Quarter]			= a.[Quarter],
		[QuarterName]		= b.[QuarterName],
		[Type]				= a.[Type],
		[Count]				= a.[Count],
		[Total]				= a.[Total],
		[Avg]				= a.[Avg],
		[Min]				= a.[Min],
		[Max]				= a.[Max],
		[Perc]				= CASE WHEN (b.Total > 0) THEN (100 / b.Total) * a.Total ELSE 0 END
FROM
(

	SELECT  [EntryDirectionId]	= [EntryDirectionId],
			[Year]				= [EntryYear],
			[Quarter]				= [EntryQuarter],
			[Type]				= [EntryTypeName],
			[Count]				= COUNT(EntryId),
			[Total]				= SUM( EntryAmount ),
			[Avg]				= AVG( EntryAmount ),
			[Min]				= MIN( EntryAmount ),
			[Max]				= MAX( EntryAmount )
	FROM		[vwEntries]		a
	GROUP BY [EntryDirectionId], [EntryYear], [EntryQuarter], [EntryTypeId], [EntryTypeName]

) a
INNER JOIN	[vwEntriesByQuarter] b	ON		a.[EntryDirectionId] = b.[EntryDirectionId] 
										AND	a.[Year] = b.[Year] 
										AND	a.[Quarter] = b.[Quarter]