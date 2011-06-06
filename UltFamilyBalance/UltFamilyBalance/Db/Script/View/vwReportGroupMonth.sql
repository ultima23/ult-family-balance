/****** Object:  View [dbo].[vwReportGroupMonth]    Script Date: 01/24/2011 12:02:05 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwReportGroupMonth]'))
DROP VIEW [dbo].[vwReportGroupMonth]
GO

CREATE VIEW [dbo].[vwReportGroupMonth]
AS

SELECT	[Year]			= b.[Year],
		[Month]			= b.[Month],
		[MonthName]		= b.[MonthName],
		[EntryGroupId]	= b.[EntryGroupId],
		[Group]			= b.[EntryGroupName],
		[Total]			= ISNULL( c.[Total], 0 ),
		[Avg]			= ISNULL( c.[Total], 0 )
FROM		vwCreditCountYearLastMonth		a
INNER JOIN
(

	SELECT *
	FROM		vwReportBase	b1
	CROSS JOIN	[EntryGroup]	b2
	WHERE b2.[EntryDirectionId] = 20

)											b	ON	a.[Year] = b.[Year] AND	a.MonthLast >= b.[Month]
LEFT JOIN	vwEntriesByMonthAndTypeGroup	c	ON	c.[Year] = b.[Year] AND c.[Month] = b.[Month] AND c.[EntryGroupId] = b.[EntryGroupId]