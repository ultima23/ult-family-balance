/****** Object:  View [dbo].[vwMonths]    Script Date: 01/24/2011 12:00:40 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwMonths]'))
DROP VIEW [dbo].[vwMonths]
GO

CREATE VIEW [dbo].[vwMonths]
AS

SELECT	[Month] = 1, [MonthName] = 'Gennaio'
UNION
SELECT	[Month] = 2, [MonthName] = 'Febbraio'
UNION
SELECT	[Month] = 3, [MonthName] = 'Marzo'
UNION
SELECT	[Month] = 4, [MonthName] = 'Aprile'
UNION
SELECT	[Month] = 5, [MonthName] = 'Maggio'
UNION
SELECT	[Month] = 6, [MonthName] = 'Giugno'
UNION
SELECT	[Month] = 7, [MonthName] = 'Luglio'
UNION
SELECT	[Month] = 8, [MonthName] = 'Agosto'
UNION
SELECT	[Month] = 9, [MonthName] = 'Settembre'
UNION
SELECT	[Month] = 10, [MonthName] = 'Ottobre'
UNION
SELECT	[Month] = 11, [MonthName] = 'Novembre'
UNION
SELECT	[Month] = 12, [MonthName] = 'Dicembre'