/****** Object:  View [dbo].[vwReportGroupMonth]    Script Date: 01/24/2011 12:02:05 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwCreditCountYearLastMonth]'))
DROP VIEW [dbo].[vwCreditCountYearLastMonth]
GO

CREATE VIEW [dbo].[vwCreditCountYearLastMonth]
AS

SELECT	[Year],
		[MonthCount] = COUNT(*),
		[MonthLast]	 = MAX( [Month] )
FROM vwCreditCountByMonth
WHERE		[Year] <> DATEPART(YEAR, GETDATE()) 
		OR	
		(
			[Year] = DATEPART(YEAR, GETDATE()) AND
			[Month] < DATEPART(M, GETDATE())
		)
GROUP BY [Year]