/****** Object:  View [dbo].[vwReportTypeYear]    Script Date: 01/24/2011 12:02:05 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwReportTypeYear]'))
DROP VIEW [dbo].[vwReportTypeYear]
GO

CREATE VIEW [dbo].[vwReportTypeYear]
AS

SELECT	x.[Year],
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
			[DirectionId]	= b.[EntryDirectionId],
			[Type]			= b.[EntryTypeName],
			[TypeId]		= b.[EntryTypeId],
			[Total]			= c.[Total]

	FROM			vwReportBase			a
	CROSS	JOIN	EntryType				b
	LEFT	JOIN	vwEntriesByMonthAndType	c	ON		c.[Year] = a.[Year] 
													AND	c.[Month] = a.[Month] 
													AND b.[EntryTypeId] = c.[EntryTypeId]

) x
GROUP BY x.[Year], x.[TypeId],x.[Type]



