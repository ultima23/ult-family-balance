/****** Object:  View [dbo].[vwYears]    Script Date: 01/24/2011 12:00:40 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwYears]'))
DROP VIEW [dbo].[vwYears]
GO

CREATE VIEW [dbo].[vwYears]
AS

SELECT	[Year] = 2008
UNION
SELECT	[Year] = 2009
UNION
SELECT	[Year] = 2010
UNION
SELECT	[Year] = 2011
UNION
SELECT	[Year] = 2012
UNION
SELECT	[Year] = 2013
UNION
SELECT	[Year] = 2014
