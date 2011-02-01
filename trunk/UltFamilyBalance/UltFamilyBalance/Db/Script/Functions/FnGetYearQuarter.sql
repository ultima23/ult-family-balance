/****** Object:  UserDefinedFunction [dbo].[FnGetYearQuarter]    Script Date: 02/01/2011 13:12:42 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FnGetYearQuarter]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[FnGetYearQuarter]
GO

-- =============================================
-- Author:		Name
-- Create date: 
-- Description:	
-- =============================================
CREATE FUNCTION [dbo].[FnGetYearQuarter]
(
	@Month int
)
RETURNS int
AS
BEGIN

	-- Year quarter
	DECLARE @Result int
	
	-- 	
	SELECT @Result =	CASE @Month	WHEN 1	THEN 1
									WHEN 2	THEN 1
									WHEN 3	THEN 1
									WHEN 4	THEN 2
									WHEN 5	THEN 2
									WHEN 6	THEN 2
									WHEN 7	THEN 3
									WHEN 8	THEN 3
									WHEN 9	THEN 3
									WHEN 10 THEN 4
									WHEN 11 THEN 4
									WHEN 12	THEN 4
						END
						
	-- Return the result of the function
	RETURN @Result

END

GO


