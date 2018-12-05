CREATE PROCEDURE [dbo].[SP_GetCastingOffers]
AS
	SELECT [Offer].[Id], [Offer].[LibelFr], [Offer].[Publication], [Offer].[Description], [Offer].[StreetName], [Offer].[CityName], [Offer].[PostalCode], 
	[ContractType].[Id], [ContractType].[LabelFr], [ContractType].[LabelShortFr],
	[Talent].[Id], [Talent].[LabelFr], [Talent].[Description],
	[ClientCompany].Id, [ClientCompany].[Name]
	FROM [Offer]
	INNER JOIN [ContractType] ON [ContractType].[Id] = [Offer].[Id_ContractType]
	INNER JOIN [Talent] ON [Talent].[Id] = [Offer].[Id_Talent]
	INNER JOIN [Proposer] ON [Proposer].Id = [Offer].[Id]
	INNER JOIN [ClientCompany] ON [Proposer].[Id_ClientCompany] = [ClientCompany].[Id];
RETURN 0