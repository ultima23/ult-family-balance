/****** Object:  View [dbo].[vwCreditCount]    Script Date: 01/24/2011 12:02:05 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwCreditCount]'))
DROP VIEW [dbo].[vwCreditCount]
GO


CREATE VIEW [dbo].[vwCreditCount]
AS

SELECT	CreditCountId,
		CreditCountYear,
		CreditCountMonth,
		CreditCountIncoming,
		CreditCountOutgoing,
		UserId
FROM CreditCount a

GO


