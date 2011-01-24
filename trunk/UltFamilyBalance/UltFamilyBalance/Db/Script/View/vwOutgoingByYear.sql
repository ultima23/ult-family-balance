USE [UltFamilyBalance]
GO

/****** Object:  View [dbo].[vwOutgoingByYear]    Script Date: 01/03/2011 11:48:03 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwOutgoingByYear]'))
DROP VIEW [dbo].[vwOutgoingByYear]
GO

USE [UltFamilyBalance]
GO


CREATE VIEW [dbo].[vwOutgoingByYear]
AS

SELECT  [Year],
        [MonthsCount]	= COUNT([Month]),
        [Complete]		= CASE WHEN COUNT([Month]) = 12 THEN 1 ELSE 0 END,
        [Count]			= SUM([Count]),
        [Total]			= SUM([Total])
        
FROM [vwOutgoingByMonth]
GROUP BY [Year]
GO


