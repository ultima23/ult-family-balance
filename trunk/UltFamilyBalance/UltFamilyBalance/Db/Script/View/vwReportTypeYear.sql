/****** Object:  View [dbo].[vwReportTypeYear]    Script Date: 01/24/2011 12:02:05 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwReportTypeYear]'))
DROP VIEW [dbo].[vwReportTypeYear]
GO

CREATE VIEW [dbo].[vwReportTypeYear]
AS

SELECT	a.[Year],
		a.[TypeId],
		a.[Type],
		a.[Total],
		a.[Avg],
		a.[Min],
		a.[Max],
		[MonthAvg] = a.[Total] / 12,
		[CurrAvg] = a.[Total] / DATEPART(MM, GETDATE()),
		[Perc] = CASE WHEN (b.[Total] > 0) THEN (100 / b.[Total]) * a.[Total] ELSE 0 END
FROM 
(

	SELECT	a.[Year],
			a.[TypeId],
			a.[Type],
			[Total]		= ISNULL( SUM (a.[Total] ), 0 ),
			[Avg]		= ISNULL( AVG (a.[Total]), 0) ,
			[Min]		= ISNULL( MIN (a.[Total]), 0) ,
			[Max]		= ISNULL( MAX (a.[Total]), 0)			
			
	FROM (

		SELECT	a1.[Year],
				a1.[Quarter],
				a1.[QuarterName],
				a1.[Month],
				a1.[MonthName],
				[Type]			= a2.[EntryTypeName],
				[TypeId]		= a2.[EntryTypeId],
				[Total]			= a3.[Total]

		FROM			vwReportBase			a1
		CROSS	JOIN	EntryType				a2
		LEFT	JOIN	vwEntriesByMonthAndType	a3	ON		a3.[Year] = a1.[Year] 
														AND	a3.[Month] = a1.[Month] 
														AND a2.[EntryTypeId] = a3.[EntryTypeId]
		WHERE a2.[EntryDirectionId] = 20 /* Uscite */

	) a
	GROUP BY a.[Year], a.[TypeId], a.[Type]

) a
INNER JOIN vwEntriesByYear b ON		a.[Year] = b.[Year]
								AND b.[EntryDirectionId] = 20 /* Uscite */