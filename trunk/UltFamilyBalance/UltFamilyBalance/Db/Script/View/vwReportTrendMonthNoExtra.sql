IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwReportTrendMonthNoExtra]'))
DROP VIEW [dbo].[vwReportTrendMonthNoExtra]
GO

CREATE VIEW [dbo].[vwReportTrendMonthNoExtra]
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
			MonthLast			= MAX ( [Month] ),
			BalanceCurrent		= SUM ( CASE WHEN [Month] = (DATEPART(M, GETDATE()) - 1) THEN [Balance] ELSE 0 END ),
			BalanceMin			= MIN ( [Balance] ),
			BalanceMax			= MAX ( [Balance] ),
			IncomingTotal		= SUM ( [Incoming] ),
			IncomingCount		= SUM ( [IncomingCount] ),
			IncomingMin			= MIN ( [Incoming] ),
			IncomingMax			= MAX ( [Incoming] ),
			IncomingAvg			= AVG ( [Incoming] ),
			OutgoingTotal		= SUM ( [Outgoing] ),
			OutgoingCount		= SUM ( [OutgoingCount] ),			
			OutgoingMin			= MIN ( [Outgoing] ),
			OutgoingMax			= MAX ( [Outgoing] ),
			OutgoingAvg			= AVG ( [Outgoing] ),
			DeltaTotal			= SUM ( [Delta] ),
			DeltaMin			= MIN ( [Delta] ),
			DeltaMax			= MAX ( [Delta] ),
			DeltaAvg			= AVG ( [Delta] )

	FROM
	(
		
		SELECT	[Year]				= a1.[Year],
				[Month]				= a1.[Month],
				[Balance]			= a1.[Balance] + ISNULL( [OutgoingExtra], 0 ),
				[Incoming]			= a1.[Incoming],
				[IncomingCount]		= a1.[IncomingCount],
				[Outgoing]			= a1.[Outgoing] - ISNULL( [OutgoingExtra], 0 ),
				[OutgoingCount]		= a1.[OutgoingCount],
				[OutgoingReal]		= a1.[Outgoing],
				[OutgoingExtra]		= ISNULL( a2.[OutgoingExtra], 0 ),
				[Delta]				= a1.[Delta] + ISNULL( [OutgoingExtra], 0 ),
				[DeltaReal]			= a1.[Delta]

		FROM vwCreditCountByMonth a1
		LEFT JOIN 
		(
		
			SELECT	[Year]			= [Year],
					[Month]			= [Month],
					[OutgoingExtra] = [Total]
			FROM vwEntriesByMonthAndTypeGroup 
			WHERE [EntryGroupId] IN (4 /* Straordinarie */ )
			
		) a2		ON		a1.[Year] = a2.[Year]
						AND	a1.[Month] = a2.[Month]
		WHERE		a1.[Year] <> DATEPART(YEAR, GETDATE()) 
				OR	
				(
					a1.[Year] = DATEPART(YEAR, GETDATE()) AND
					a1.[Month] < DATEPART(M, GETDATE())
				)	
	
	) b
	GROUP BY [Year]

) a