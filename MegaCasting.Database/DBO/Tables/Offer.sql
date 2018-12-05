CREATE TABLE [dbo].[Offer]
(
	[Id]                INT NOT NULL PRIMARY KEY IDENTITY,
	[LibelFr]           NVARCHAR(200) NOT NULL,
	[Publication]       DATETIME NOT NULL,
	[Description]       NVARCHAR(200) NOT NULL,
	[StreetName]        NVARCHAR(200) NOT NULL,
	[CityName]					NVARCHAR(200) NOT NULL,
	[PostalCode]				NVARCHAR(6) NOT NULL,
	[PeriodTokens]      INT NOT NULL,
	[Id_SiteContent]        INT NOT NULL,
	[Id_ContractType]   INT NOT NULL,
	[Id_Talent]         INT NOT NULL,
	CONSTRAINT [FK_Offer_SiteContent] FOREIGN KEY ([id_SiteContent]) REFERENCES [dbo].[SiteContent],
	CONSTRAINT [FK_Offer_ContractType] FOREIGN KEY ([id_ContractType]) REFERENCES [dbo].[ContractType],
	CONSTRAINT [FK_Offer_Talent] FOREIGN KEY ([id_Talent]) REFERENCES [dbo].[Talent]
)