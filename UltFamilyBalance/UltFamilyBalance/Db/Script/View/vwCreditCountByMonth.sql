/****** Object:  View [dbo].[vwCreditCountByMonth]    Script Date: 01/24/2011 12:00:40 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwCreditCountByMonth]'))
DROP VIEW [dbo].[vwCreditCountByMonth]
GO

CREATE VIEW [dbo].[vwCreditCountByMonth]
AS

SELECT  [Year]            = [CreditCountYear], 
        [Month]           = [CreditCountMonth],
        [Incoming]        = SUM( CreditCountIncoming ),
        [IncomingCount]   = COUNT( CreditCountId ),
        [Outgoing]        = SUM( CreditCountOutgoing ),
        [OutgoingCount]   = COUNT( CreditCountId ),
        [Delta]           = SUM( CreditCountIncoming ) - SUM( CreditCountOutgoing )
FROM vwCreditCount
GROUP BY [CreditCountYear], [CreditCountMonth]

GO


