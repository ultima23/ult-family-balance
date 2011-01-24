/****** Object:  View [dbo].[vwReportTrendYear]    Script Date: 01/24/2011 12:02:05 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwReportTrendYear]'))
DROP VIEW [dbo].[vwReportTrendYear]
GO


CREATE VIEW [dbo].[vwReportTrendYear]
AS

SELECT	[Year]					= a.[Year],
		[Month]					= a.[Month],
		[MonthName]				= a.[MonthName],
		[EntriesOutgoing]		= b.[Total],
		[EntriesIncoming]		= c.[Total],
		[EntriesDelta]			= c.[Total] - b.[Total],
		[CountBalance]			= d.Balance,
		[CountOutgoing]			= d.Outgoing,
		[CountIncoming]			= d.Incoming,
		[CountDelta]			= d.Delta,

		[MissingIncoming]		= d.Incoming - c.[Total],
		[MissingOutgoing]		= d.Outgoing - b.[Total]
		
FROM		vwReportBase			a
LEFT JOIN	vwEntriesByMonth		b	ON		a.[Year] = b.[Year]
											AND a.[Month] = b.[Month]
											AND	b.EntryDirectionId = 20
LEFT JOIN	vwEntriesByMonth		c	ON		a.[Year] = c.[Year]
											AND a.[Month] = c.[Month]
											AND	c.EntryDirectionId = 10
LEFT JOIN	vwCreditCountByMonth	d	ON		a.[Year] = d.[Year]
											AND a.[Month] = d.[Month]