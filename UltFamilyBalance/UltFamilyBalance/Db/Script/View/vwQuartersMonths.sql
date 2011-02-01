/****** Object:  View [dbo].[vwQuartersMonths]    Script Date: 02/01/2011 13:18:13 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwQuartersMonths]'))
DROP VIEW [dbo].[vwQuartersMonths]
GO

CREATE VIEW [dbo].[vwQuartersMonths]
AS

SELECT	B.*,
		C.*
FROM (

	SELECT	[Quarter] = 1, [Month] = 1
	UNION
	SELECT	[Quarter] = 1, [Month] = 2
	UNION
	SELECT	[Quarter] = 1, [Month] = 3
	UNION
	SELECT	[Quarter] = 2, [Month] = 4
	UNION
	SELECT	[Quarter] = 2, [Month] = 5
	UNION
	SELECT	[Quarter] = 2, [Month] = 6
	UNION
	SELECT	[Quarter] = 3, [Month] = 7
	UNION
	SELECT	[Quarter] = 3, [Month] = 8
	UNION
	SELECT	[Quarter] = 3, [Month] = 9
	UNION
	SELECT	[Quarter] = 4, [Month] = 10
	UNION
	SELECT	[Quarter] = 4, [Month] = 11
	UNION
	SELECT	[Quarter] = 4, [Month] = 12

) A
INNER JOIN vwQuarters B ON A.[Quarter] = B.[Quarter]
INNER JOIN vwMonths C ON A.[Month] = C.[Month]

GO


