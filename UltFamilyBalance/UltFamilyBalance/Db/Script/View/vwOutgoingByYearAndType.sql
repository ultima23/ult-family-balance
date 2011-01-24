USE [UltFamilyBalance]
GO

/****** Object:  View [dbo].[vwOutgoingByYearAndType]    Script Date: 01/03/2011 12:00:15 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwOutgoingByYearAndType]'))
DROP VIEW [dbo].[vwOutgoingByYearAndType]
GO

USE [UltFamilyBalance]
GO

CREATE VIEW [dbo].[vwOutgoingByYearAndType]
AS

SELECT	[Year]		= a.[Year],
		[TypeGroup] = a.[Type],
		[Count]		= a.[Count],
		[Total]		= a.[Total],
		[Perc]		= CASE WHEN (b.Total > 0) THEN (100 / b.Total) * a.Total ELSE 0 END
FROM
(

	SELECT  [Year]    = [EntryYear],
			[Type]    = [EntryTypeName],
			[Count]   = COUNT(EntryId),
			[Total]   = SUM(EntryAmount)
	FROM [vwOutgoing]
	GROUP BY [EntryYear], [EntryTypeId], [EntryTypeName]

) a
INNER JOIN	[vwOutgoingByYear] b	ON a.Year = b.Year
GO


