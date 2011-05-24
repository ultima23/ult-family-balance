IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwReportTrendMonth]'))
DROP VIEW [dbo].[vwReportTrendMonth]
GO

CREATE VIEW [dbo].[vwReportTrendMonth]
AS

SELECT	a.[Year],
		a.[MonthCount],
		a.[MonthLast],
		[MonthLastName] = dbo.FnGetMonthName(a.[MonthLast]),
		a.BalanceCurrent,
		a.BalanceMin,
		a.BalanceMax,
		a.IncomingTotal,
		a.IncomingMin,
		a.IncomingMax,
		a.IncomingAvg,
		a.OutgoingTotal,
		a.OutgoingMin,
		a.OutgoingMax,
		a.OutgoingAvg,
		a.DeltaTotal,
		a.DeltaMin,
		a.DeltaMax,
		a.DeltaAvg
		
FROM
(

	SELECT	[Year],
			MonthCount			= COUNT(*),
			MonthLast			= MAX([Month]),
			BalanceCurrent		= SUM( CASE WHEN [Month] = (DATEPART(M, GETDATE()) - 1) THEN [Balance] ELSE 0 END ),
			BalanceMin			= MIN( [Balance] ),
			BalanceMax			= MAX( [Balance] ),
			IncomingTotal		= SUM( [Incoming] ),
			IncomingCount		= SUM( [IncomingCount] ),
			IncomingMin			= MIN ([Incoming]),
			IncomingMax			= MAX ([Incoming]),
			IncomingAvg			= AVG ([Incoming]),
			OutgoingTotal		= SUM( [Outgoing] ),
			OutgoingCount		= SUM( [OutgoingCount] ),			
			OutgoingMin			= MIN ([Outgoing]),
			OutgoingMax			= MAX ([Outgoing]),
			OutgoingAvg			= AVG ([Outgoing]),
			DeltaTotal			= SUM ([Delta]),
			DeltaMin			= MIN ([Delta]),
			DeltaMax			= MAX ([Delta]),
			DeltaAvg			= AVG ([Delta])
			
	FROM vwCreditCountByMonth a1
	WHERE		a1.[Year] <> DATEPART(YEAR, GETDATE()) 
			OR	
			(
				a1.[Year] = DATEPART(YEAR, GETDATE()) AND
				a1.[Month] < DATEPART(M, GETDATE())
			)
	GROUP BY [Year]

) a

/*
SELECT *
FROM vwCreditCountByMonth
WHERE [Year] = 2011
*/