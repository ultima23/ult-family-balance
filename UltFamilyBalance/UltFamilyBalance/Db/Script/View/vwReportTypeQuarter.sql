/****** Object:  View [dbo].[vwReportTypeQuarter]    Script Date: 01/24/2011 12:02:05 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwReportTypeQuarter]'))
DROP VIEW [dbo].[vwReportTypeQuarter]
GO

CREATE VIEW [dbo].[vwReportTypeQuarter]
AS

SELECT	x.[Year],
		x.[Quarter],
		x.[QuarterName],
		x.[TypeId],
		x.[Type],
		[Avg] = CONVERT ( DECIMAL(12, 2), ISNULL( AVG (x.Total), 0) ),
		[Min] = ISNULL( MIN (x.Total), 0) ,
		[Max] = ISNULL( MAX (x.Total), 0)
		
FROM (

	SELECT	a.[Year],
			a.[Quarter],
			a.[QuarterName],
			a.[Month],
			a.[MonthName],
			[Type]			= b.[EntryTypeName],
			[TypeId]		= b.[EntryTypeId],
			[Total]			= c.[Total]

	FROM			vwReportBase			a
	CROSS	JOIN	EntryType				b
	LEFT	JOIN	vwEntriesByMonthAndType	c	ON		c.[Year] = a.[Year] 
													AND	c.[Month] = a.[Month] 
													AND b.[EntryTypeId] = c.[EntryTypeId]
	WHERE b.[EntryDirectionId] = 20 /* Uscite */

) x
GROUP BY x.[Year], x.[Quarter], x.[QuarterName], x.[TypeId],x.[Type]

