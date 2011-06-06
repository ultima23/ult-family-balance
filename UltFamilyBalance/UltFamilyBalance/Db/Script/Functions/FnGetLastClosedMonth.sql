/****** Object:  UserDefinedFunction [dbo].[FnGetLastClosedMonth]    Script Date: 02/01/2011 13:12:42 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FnGetLastClosedMonth]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[FnGetLastClosedMonth]
GO

-- =============================================
-- Author:		Name
-- Create date: 
-- Description:	
-- =============================================
CREATE FUNCTION [dbo].[FnGetLastClosedMonth]
(
	@year int
)
RETURNS TABLE
AS
RETURN 
(
	
	SELECT 	[Year],
			[Month]		= [MonthMax],
			[MonthName] = dbo.FnGetMonthName([MonthMax]),
			[MonthCount]
	FROM 
	(
		SELECT	[Year],
				[MonthCount] = COUNT(*),
				[MonthMax]	 = MAX( [Month] )
		FROM vwCreditCountByMonth
		WHERE		[Year] <> DATEPART(YEAR, GETDATE()) 
				OR	
				(
					[Year] = DATEPART(YEAR, GETDATE()) AND
					[Month] < DATEPART(M, GETDATE())
				)
		GROUP BY [Year]
	) x
	WHERE [Year] = @year

)