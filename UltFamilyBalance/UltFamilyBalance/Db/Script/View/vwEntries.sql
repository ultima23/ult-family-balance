/****** Object:  View [dbo].[vwEntries]    Script Date: 01/21/2011 11:45:52 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwEntries]'))
DROP VIEW [dbo].[vwEntries]
GO

CREATE VIEW [dbo].[vwEntries]
AS

SELECT  a.[EntryId],
        a.[EntryAmount],
          [EntryAmountCalc] = [EntryAmount] * [EntryDirectionMultiplier],
        a.[EntryNote],
        a.[EntryYear],
        a.[EntryMonth],
        a.[EntryDay],
        a.[EntryDate],
        b.[EntryTypeId],
        b.[EntryTypeName],
        b.[EntryTypeDesc],
        b.[EntryTypeRequireNote],
        c.EntryTypeGroupId,
        c.EntryTypeGroupName,
        c.EntryTypeGroupDesc,
        d.[EntryDirectionId],
        d.[EntryDirectionName],
        d.[EntryDirectionDesc],
        d.[EntryDirectionMultiplier],
        e.[UserId],
        e.[UserName],
        e.[UserSurname],
        e.[UserUsername],
		[EntryMonthName] = f.[MonthName],
		[EntryQuarter] = f.[Quarter],
		[EntryQuarterName] = f.[QuarterName]
        
FROM        [dbo].[Entry]           a
INNER JOIN  [dbo].[EntryType]       b ON a.EntryTypeId = b.EntryTypeId 
INNER JOIN  [dbo].[EntryTypeGroup]  c ON b.EntryTypeGroupId = c.EntryTypeGroupId
INNER JOIN  [dbo].[EntryDirection]  d ON b.EntryDirectionId = d.EntryDirectionId
INNER JOIN  [dbo].[User]			e ON a.UserId = e.UserId
INNER JOIN  [vwQuartersMonths]		f ON a.EntryMonth = f.[Month]

GO


