USE [UltFamilyBalance]
GO

/****** Object:  View [dbo].[vwOutgoingTotalByMonth]    Script Date: 01/03/2011 12:17:32 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwOutgoingTotalByMonth]'))
DROP VIEW [dbo].[vwOutgoingTotalByMonth]
GO

USE [UltFamilyBalance]
GO


CREATE VIEW [dbo].[vwOutgoingTotalByMonth]
AS

SELECT	[Year]	= EntryYear,
		[Month]	= EntryMonth,
		[Total]	= SUM(EntryAmount)
FROM vwOutgoing
GROUP BY EntryYear, EntryMonth
GO


