USE [UltFamilyBalance]
GO

/****** Object:  View [dbo].[vwOutgoingByMonthAndType]    Script Date: 01/03/2011 11:44:31 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwOutgoingByMonthAndType]'))
DROP VIEW [dbo].[vwOutgoingByMonthAndType]
GO

USE [UltFamilyBalance]
GO

CREATE VIEW [dbo].[vwOutgoingByMonthAndType]
AS

SELECT	[Year]    = a.[Year],
		[Month]   = a.[Month],
		[Type]    = a.[Type],
		[Count]   = a.[Count],
		[Total]   = a.[Total],
		[Perc] = CASE WHEN (b.Total > 0) THEN (100 / b.Total) * a.Total ELSE 0 END
FROM
(

	SELECT  [Year]    = [EntryYear],
			[Month]   = [EntryMonth],
			[Type]    = [EntryTypeName],
			[Count]   = COUNT(EntryId),
			[Total]   = SUM(EntryAmount)
	FROM		[vwOutgoing]		a
	GROUP BY [EntryYear], [EntryMonth], [EntryTypeId], [EntryTypeName]

) a
INNER JOIN	[vwOutgoingByMonth] b	ON a.Year = b.Year AND
                                       a.Month = b.Month

/*
SELECT  a.[Year],
        a.[Month],
        a.[Type],
        a.[Total] ,
        [Perc]    = CASE WHEN b.[Outgoing] > 0 THEN (100 / b.[Outgoing]) * a.[Total] ELSE 0 END 
FROM
(

  SELECT  [Year]    = [EntryYear],
          [Month]   = [EntryMonth],
          [Type]    = [EntryTypeName],
          [Total]   = SUM(EntryAmount)
  FROM [vwOutgoing]
  GROUP BY [EntryYear], [EntryMonth], [EntryTypeId], [EntryTypeName]

) a
 LEFT  JOIN  [vwCreditCountByMonth]  b ON a.[Year] = b.[Year] AND a.[Month] = b.[Month] */

GO


