USE [UltFamilyBalance]
GO

/****** Object:  View [dbo].[vwOutgoingByYearAndTypeGroup]    Script Date: 01/03/2011 12:01:29 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwOutgoingByYearAndTypeGroup]'))
DROP VIEW [dbo].[vwOutgoingByYearAndTypeGroup]
GO

USE [UltFamilyBalance]
GO


CREATE VIEW [dbo].[vwOutgoingByYearAndTypeGroup]
AS

SELECT	[Year]		= a.[Year],
		[TypeGroup] = a.[TypeGroup],
		[Count]		= a.[Count],
		[Total]		= a.[Total],
		[Perc] = CASE WHEN (b.Total > 0) THEN (100 / b.Total) * a.Total ELSE 0 END
FROM
(

	SELECT  [Year]		= [EntryYear],
			[TypeGroup] = [EntryTypeGroupName],
			[Count]		= COUNT(EntryId),
			[Total]		= SUM(EntryAmount)
	FROM [vwOutgoing]
	GROUP BY [EntryYear], [EntryTypeGroupId], [EntryTypeGroupName]

) a
INNER JOIN	[vwOutgoingByYear] b	ON a.Year = b.Year

GO


