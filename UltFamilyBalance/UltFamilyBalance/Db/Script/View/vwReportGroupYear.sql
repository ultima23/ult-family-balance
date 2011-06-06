IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwReportGroupYear]'))
DROP VIEW [dbo].[vwReportGroupYear]
GO

CREATE VIEW [dbo].[vwReportGroupYear]
AS

SELECT	[Year]			= b.[Year],
		[EntryGroupId]	= b.[EntryGroupId],
		[Group]			= b.[EntryGroupName],
		[Total]			= SUM ( ISNULL( c.[Total], 0 ) ),
		[Avg]			= AVG ( ISNULL( c.[Total], 0 ) )
FROM		vwCreditCountYearLastMonth		a
INNER JOIN
(

	SELECT *
	FROM		vwReportBase	b1
	CROSS JOIN	[EntryGroup]	b2
	WHERE b2.[EntryDirectionId] = 20

)											b	ON	a.[Year] = b.[Year] AND	a.MonthLast >= b.[Month]
LEFT JOIN	vwEntriesByMonthAndTypeGroup	c	ON	c.[Year] = b.[Year] AND c.[Month] = b.[Month] AND c.[EntryGroupId] = b.[EntryGroupId]

GROUP BY b.[Year], b.[EntryGroupId], b.[EntryGroupName]

/*
SELECT	[Selected]		= 0,
		[Year]			= a1.[Year],
		[MonthCount]	= COUNT ( a1.[Month] ) ,
		[MonthLast]		= MAX ( a1.[Month] ),
		[EntryGroupId]	= a3.[EntryGroupId],
		[Group]			= a3.[EntryGroupName],
		[Total]			= SUM ( ISNULL( a2.[Total], 0 ) ),
		[Avg]			= AVG ( ISNULL( a2.[Total], 0 ) )

FROM		vwReportBase	a1
CROSS JOIN	[EntryGroup]	a3
LEFT JOIN	vwEntriesByMonthAndTypeGroup	a2	ON		a1.[Year] = a2.[YEAR] 
													AND a1.[Month] = a2.[Month] 
													AND a3.[EntryGroupId] = a2.[EntryGroupId]
WHERE		a1.[Year] <> DATEPART(YEAR, GETDATE()) 
		OR	
		(
			a1.[Year] = DATEPART(YEAR, GETDATE()) AND
			a1.[Month] < DATEPART(M, GETDATE())
		)
GROUP BY a1.[Year], a3.[EntryGroupId], a3.[EntryGroupName]
*/