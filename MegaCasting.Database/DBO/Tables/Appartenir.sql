CREATE TABLE [dbo].[Appartenir]
(
	[Id]        INT NOT NULL,
	[Id_SitePage]   INT NOT NULL,
	CONSTRAINT [PK_Appartenir] PRIMARY KEY ([Id],[Id_SitePage]),
	CONSTRAINT [FK_Appartenir_SiteContent] FOREIGN KEY ([Id]) REFERENCES [dbo].[SiteContent],
	CONSTRAINT [FK_Appartenir_SitePage] FOREIGN KEY ([Id_SitePage]) REFERENCES [dbo].[SitePage]
)