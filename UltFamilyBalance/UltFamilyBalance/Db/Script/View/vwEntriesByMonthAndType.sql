/****** Object:  View [dbo].[vwEntriesByMonthAndType]    Script Date: 01/03/2011 11:44:31 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwEntriesByMonthAndType]'))
DROP VIEW [dbo].[vwEntriesByMonthAndType]
GO

USE [UltFamilyBalance]
GO

CREATE VIEW [dbo].[vwEntriesByMonthAndType]
AS

SELECT	[EntryDirectionId]	= a.[EntryDirectionId],
		[EntryTypeId]		= a.[EntryTypeId],
		[Year]				= a.[Year],
		[Month]				= a.[Month],
		[MonthName]			= b.[MonthName],
		[Type]				= a.[Type],
		[Count]				= a.[Count],
		[Total]				= a.[Total],
		[Avg]				= a.[Avg],
		[Min]				= a.[Min],
		[Max]				= a.[Max],
		[Perc]				= CASE WHEN (b.Total > 0) THEN (100 / b.Total) * a.Total ELSE 0 END
FROM
(

	SELECT  [EntryDirectionId],
			[EntryTypeId],
			[Year]				= [EntryYear],
			[Month]				= [EntryMonth],
			[Type]				= [EntryTypeName],
			[Count]				= COUNT(EntryId),
			[Total]				= SUM(EntryAmount),
			[Avg]				= AVG(EntryAmount),
			[Min]				= MIN(EntryAmount),
			[Max]				= MAX(EntryAmount)
			
	FROM		[vwEntries]		a
	GROUP BY [EntryDirectionId], [EntryYear], [EntryMonth], [EntryTypeId], [EntryTypeName]

) a
INNER JOIN	[vwEntriesByMonth] b	ON		a.[EntryDirectionId] = b.[EntryDirectionId] 
										AND	a.[Year] = b.[Year] 
										AND	a.[Month] = b.[Month]