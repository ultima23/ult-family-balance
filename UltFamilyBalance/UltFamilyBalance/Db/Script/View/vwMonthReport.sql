USE [UltFamilyBalance]
GO

/****** Object:  View [dbo].[vwMonthReport]    Script Date: 01/03/2011 12:20:23 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwMonthReport]'))
DROP VIEW [dbo].[vwMonthReport]
GO

USE [UltFamilyBalance]
GO

CREATE VIEW [dbo].[vwMonthReport]
AS

SELECT  [Year],
        [Month],
        [EntriesIncoming],
        [CreditCountIncoming],
        [IncomingMissing]       = CreditCountIncoming - EntriesIncoming,
        [IncomingMissingPerc]   = 100 - (CASE WHEN (CreditCountIncoming > 0) THEN (100 / CreditCountIncoming) * EntriesIncoming ELSE 0 END),
        [EntriesIncomingCount],
        [CreditCountIncomingCount],
        [EntriesOutgoing],
        [CreditCountOutgoing],
        [OutgoingMissing]       = CreditCountOutgoing - EntriesOutgoing,
        [OutgoingMissingPerc]   = 100 - (CASE WHEN (CreditCountOutgoing > 0) THEN (100 / CreditCountOutgoing) * EntriesOutgoing ELSE 0 END),
        [EntriesOutgoingCount],
        [CreditCountOutgoingCount],
        [EntriesDelta],
        [CreditCountDelta]
FROM
(

  SELECT  [Year]                      = a.[Year],
          [Month]                     = a.[Month],
          [EntriesIncoming]           = a.[Incoming],
          [EntriesIncomingCount]      = a.[IncomingCount],
          [EntriesOutgoing]           = a.[Outgoing],
          [EntriesOutgoingCount]      = a.[OutgoingCount],
          [EntriesDelta]              = a.[Delta],
          [CreditCountIncoming]       = ISNULL( b.[Incoming], 0),
          [CreditCountIncomingCount]  = ISNULL( b.[IncomingCount], 0),
          [CreditCountOutgoing]       = ISNULL( b.[Outgoing], 0),
          [CreditCountOutgoingCount]  = ISNULL( b.[OutgoingCount], 0),
          [CreditCountDelta]          = ISNULL( b.[Delta], 0 )

  FROM        vwEntriesByMonth      a
  LEFT JOIN   vwCreditCountByMonth  b ON  a.[Year]  = b.[Year] AND a.[Month] = b.[Month] 
) Z

GO


