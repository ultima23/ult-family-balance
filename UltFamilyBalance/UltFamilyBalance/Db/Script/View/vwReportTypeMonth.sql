/****** Object:  View [dbo].[vwReportTypeMonth]    Script Date: 01/24/2011 12:02:05 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwReportTypeMonth]'))
DROP VIEW [dbo].[vwReportTypeMonth]
GO

CREATE VIEW [dbo].[vwReportTypeMonth]
AS

SELECT	a.[Year],
		a.[Month],
		a.[MonthName],
		[Type]			= b.[EntryTypeName],
		[TypeId]		= b.[EntryTypeId],
		[Total]			= ISNULL(c.[Total], 0)

FROM			vwReportBase			a
CROSS	JOIN	EntryType				b
LEFT	JOIN	vwEntriesByMonthAndType	c	ON		c.[Year] = a.[Year] 
												AND	c.[Month] = a.[Month] 
												AND b.[EntryTypeId] = c.[EntryTypeId]