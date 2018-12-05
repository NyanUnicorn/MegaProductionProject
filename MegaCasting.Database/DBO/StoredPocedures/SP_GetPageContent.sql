CREATE PROCEDURE [dbo].[SP_GetPageContent]
	@pageId INT = 0
AS
	SELECT [SiteContent].[Id], [SiteContent].[LabelFr], [SiteContent].[LastUpdt] 
	,[Paragraph].[Id], [Paragraph].[LabelFr], [Paragraph].[ParagText]
	,[Offer].[Id], [Offer].[LibelFr], [Offer].[Publication], [Offer].[Description], [Offer].[StreetName], [Offer].[CityName], [Offer].[PostalCode], [Offer].[PeriodTokens]
	,[Talent].[Id], [Talent].[LabelFr]
	,[ContractType].[Id], [ContractType].[LabelShortFr]
	FROM [dbo].[SitePage]
	INNER JOIN [Appartenir] ON [Appartenir].[Id_SitePage] = [SitePage].[Id]
	INNER JOIN [SiteContent] ON [SiteContent].[Id] = [Appartenir].[Id]
	INNER JOIN [Paragraph] ON [Paragraph].[Id_SiteContent] = [SiteContent].[Id]
	INNER JOIN [Offer] ON [Offer].[Id_SiteContent] = [SiteContent].[Id]
	INNER JOIN [Talent] ON [Talent].[Id] = [Offer].[Id_Talent]
	INNER JOIN [ContractType] ON [ContractType].[Id] = [Offer].[Id_ContractType]
	WHERE [SitePage].[Id] = @pageId;
RETURN 0