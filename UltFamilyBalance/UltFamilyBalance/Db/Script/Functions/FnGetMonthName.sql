IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FnGetMonthName]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[FnGetMonthName]
GO

-- =============================================
-- Author:		Name
-- Create date: 
-- Description:	
-- =============================================
CREATE FUNCTION FnGetMonthName
(
	@Month int
)
RETURNS nvarchar(25)
AS
BEGIN

	-- Month name
	DECLARE @Result nvarchar(25)
	
	SELECT @Result = [MonthName]
	FROM vwMonths
	WHERE [Month] = @Month

	-- Return the result of the function
	RETURN @Result

	/*

	-- Declare the return variable here
	DECLARE @Result nvarchar(25)
	-- 	
	SELECT @Result =	CASE @Month	WHEN 1	THEN 'Gennaio'
									WHEN 2	THEN 'Febbraio'
									WHEN 3	THEN 'Marzo'
									WHEN 4	THEN 'Aprile'
									WHEN 5	THEN 'Maggio'
									WHEN 6	THEN 'Giugno'
									WHEN 7	THEN 'Luglio'
									WHEN 8	THEN 'Agosto'
									WHEN 9	THEN 'Settembre'
									WHEN 10 THEN 'Ottobre'
									WHEN 11 THEN 'Novembre'
									WHEN 12	THEN 'Dicembre'
						END
						
	-- Return the result of the function
	RETURN @Result
	
	*/

END
GO

