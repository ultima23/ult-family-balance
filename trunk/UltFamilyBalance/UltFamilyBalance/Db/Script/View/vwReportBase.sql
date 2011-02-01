/****** Object:  View [dbo].[vwReportBase]    Script Date: 02/01/2011 13:44:36 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwReportBase]'))
DROP VIEW [dbo].[vwReportBase]
GO

CREATE VIEW [dbo].[vwReportBase]
AS

SELECT	[Year],
		[Month],
		[MonthName],
		[Quarter],
		[QuarterName]
FROM vwYears, vwQuartersMonths



