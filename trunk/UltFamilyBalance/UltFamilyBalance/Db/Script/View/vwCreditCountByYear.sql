/****** Object:  View [dbo].[vwCreditCountByYear]    Script Date: 01/24/2011 12:02:23 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwCreditCountByYear]'))
DROP VIEW [dbo].[vwCreditCountByYear]
GO

CREATE VIEW [dbo].[vwCreditCountByYear]
AS

SELECT  [Year]            = [CreditCountYear], 
        [Incoming]        = SUM( CreditCountIncoming ),
        [IncomingCount]   = COUNT( CreditCountId ),
        [Outgoing]        = SUM( CreditCountOutgoing ),
        [OutgoingCount]   = COUNT( CreditCountId ),
        [Delta]           = SUM( CreditCountIncoming ) - SUM( CreditCountOutgoing )
FROM vwCreditCount
GROUP BY [CreditCountYear]

GO


