/****** Object:  View [dbo].[vwQuarters]    Script Date: 02/01/2011 13:15:38 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwQuarters]'))
DROP VIEW [dbo].[vwQuarters]
GO

CREATE VIEW [dbo].[vwQuarters]
AS

SELECT	[Quarter] = 1, [QuarterName] = 'Primo Trimestre'
UNION
SELECT	[Quarter] = 2, [QuarterName] = 'Secondo Trimestre'
UNION
SELECT	[Quarter] = 3, [QuarterName] = 'Terzo Trimestre'
UNION
SELECT	[Quarter] = 4, [QuarterName] = 'Quarto Trimestre'
GO


