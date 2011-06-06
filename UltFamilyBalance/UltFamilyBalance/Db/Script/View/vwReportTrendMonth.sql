IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwReportTrendMonth]'))
DROP VIEW [dbo].[vwReportTrendMonth]
GO

CREATE VIEW [dbo].[vwReportTrendMonth]
AS

SELECT	x.[Year],
		x.[MonthCount],
		x.[MonthLast],
		[MonthLastName] = dbo.FnGetMonthName(x.[MonthLast]),
		x.BalanceCurrent,
		x.BalanceMin,
		x.BalanceMax,
		x.BalanceCurrentNoExtra,
		x.BalanceMinNoExtra,
		x.BalanceMaxNoExtra,
		x.IncomingTotal,
		x.IncomingMin,
		x.IncomingMax,
		x.IncomingAvg,
		x.OutgoingTotal,
		x.OutgoingMin,
		x.OutgoingMax,
		x.OutgoingAvg,
		x.OutgoingTotalNoExtra,
		x.OutgoingMinNoExtra,
		x.OutgoingMaxNoExtra,
		x.OutgoingAvgNoExtra,		
		x.DeltaTotal,
		x.DeltaMin,
		x.DeltaMax,
		x.DeltaAvg,
		x.DeltaTotalNoExtra,
		x.DeltaMinNoExtra,
		x.DeltaMaxNoExtra,
		x.DeltaAvgNoExtra,
		x.ExtraTotal,
		x.ExtraMin,
		x.ExtraMax,
		x.ExtraAvg
		
FROM
(

	SELECT	[Year]				= a.[Year],
			MonthCount,
			MonthLast,
			BalanceCurrent,
			BalanceMin,
			BalanceMax,
			BalanceCurrentNoExtra,
			BalanceMinNoExtra,
			BalanceMaxNoExtra,
			IncomingTotal,
			IncomingCount,
			IncomingMin,
			IncomingMax,
			IncomingAvg,
			OutgoingTotal,
			OutgoingCount,
			OutgoingMin,
			OutgoingMax,
			OutgoingAvg,
			OutgoingTotalNoExtra,
			OutgoingMinNoExtra,
			OutgoingMaxNoExtra,
			OutgoingAvgNoExtra,
			DeltaTotal,
			DeltaMin,
			DeltaMax,
			DeltaAvg,
			DeltaTotalNoExtra,
			DeltaMinNoExtra,
			DeltaMaxNoExtra,
			DeltaAvgNoExtra,
			ExtraTotal,
			ExtraMin,
			ExtraMax,
			ExtraAvg
			
			
	FROM
	(
	
		SELECT	[Year],
				MonthCount			= COUNT(*),
				MonthLast			= MAX([Month]),
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
				
		FROM vwCreditCountByMonth
		WHERE		[Year] <> DATEPART(YEAR, GETDATE()) 
				OR	
				(
					[Year] = DATEPART(YEAR, GETDATE()) AND
					[Month] < DATEPART(M, GETDATE())
				)
		GROUP BY [Year]
	
	) a
	INNER JOIN 
	(
	
		SELECT	[Year],
				BalanceCurrentNoExtra	= SUM ( CASE WHEN [Month] = (DATEPART(M, GETDATE()) - 1) THEN [Balance] ELSE 0 END ),
				BalanceMinNoExtra		= MIN ( [Balance] ),
				BalanceMaxNoExtra		= MAX ( [Balance] ),
				OutgoingTotalNoExtra	= SUM ( [Outgoing] ),		
				OutgoingMinNoExtra		= MIN ( [Outgoing] ),
				OutgoingMaxNoExtra		= MAX ( [Outgoing] ),
				OutgoingAvgNoExtra		= AVG ( [Outgoing] ),
				ExtraTotal				= SUM ( [OutgoingExtra] ),
				ExtraMin				= MIN ( [OutgoingExtra] ),
				ExtraMax				= MAX ( [OutgoingExtra] ),
				ExtraAvg				= AVG ( [OutgoingExtra] ),
				DeltaTotalNoExtra		= SUM ( [Delta] ),
				DeltaMinNoExtra			= MIN ( [Delta] ),
				DeltaMaxNoExtra			= MAX ( [Delta] ),
				DeltaAvgNoExtra			= AVG ( [Delta] )

		FROM
		(
			
			SELECT	[Year]				= b1_1.[Year],
					[Month]				= b1_1.[Month],
					[Balance]			= b1_1.[Balance] + ISNULL( [OutgoingExtra], 0 ),
					[Outgoing]			= b1_1.[Outgoing] - ISNULL( [OutgoingExtra], 0 ),
					[Delta]				= b1_1.[Delta] + ISNULL( [OutgoingExtra], 0 ),
					[OutgoingExtra]		= b1_2.OutgoingExtra

			FROM vwCreditCountByMonth b1_1
			LEFT JOIN 
			(
			
				SELECT	[Year]			= [Year],
						[Month]			= [Month],
						[OutgoingExtra] = [Total]
				FROM vwEntriesByMonthAndTypeGroup 
				WHERE [EntryGroupId] IN (4 /* Straordinarie */ )
				
			) b1_2		ON		b1_1.[Year] = b1_2.[Year]
							AND	b1_1.[Month] = b1_2.[Month]
			WHERE		b1_1.[Year] <> DATEPART(YEAR, GETDATE()) 
					OR	
					(
						b1_1.[Year] = DATEPART(YEAR, GETDATE()) AND
						b1_1.[Month] < DATEPART(M, GETDATE())
					)	
		
		) b1
		GROUP BY [Year]
		
	) b		ON a.[Year] = b.[Year]

) x

/*
SELECT *
FROM vwCreditCountByMonth
WHERE [Year] = 2011
*/