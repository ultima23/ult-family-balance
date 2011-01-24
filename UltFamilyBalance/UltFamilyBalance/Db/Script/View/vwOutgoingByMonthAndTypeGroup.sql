/****** Object:  View [dbo].[vwOutgoingByMonthAndTypeGroup]    Script Date: 01/03/2011 11:47:02 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwOutgoingByMonthAndTypeGroup]'))
DROP VIEW [dbo].[vwOutgoingByMonthAndTypeGroup]
GO

CREATE VIEW [dbo].[vwOutgoingByMonthAndTypeGroup]
AS

SELECT	[Year]		= a.[Year],
		[Month]		= a.[Month],
		[TypeGroup] = a.[TypeGroup],
		[Count]		= a.[Count],
		[Total]		= a.[Total],
		[Perc] = CASE WHEN (b.Total > 0) THEN (100 / b.Total) * a.Total ELSE 0 END
FROM
(

	SELECT  [Year]		= [EntryYear],
			[Month]		= EntryMonth,
			[TypeGroup] = [EntryTypeGroupName],
			[Count]		= COUNT(EntryId),
			[Total]		= SUM(EntryAmount)
	FROM [vwOutgoing]
	GROUP BY [EntryYear], [EntryMonth], [EntryTypeGroupId], [EntryTypeGroupName]

) a
INNER JOIN	[vwOutgoingByMonth] b	ON a.Year = b.Year AND
                                       a.Month = b.Month

GO


