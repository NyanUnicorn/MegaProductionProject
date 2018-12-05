CREATE TABLE [dbo].[PackCasting]
(
	[Id]           INT NOT NULL PRIMARY KEY IDENTITY,
	[LabelFr]      NVARCHAR(50) NOT NULL,
	[Quantity]     INT NOT NULL,
	[Tarif]        DECIMAL(10,2) NOT NULL,
	[Id_SiteContent]   INT NOT NULL,
	CONSTRAINT [FK_PackCasting_SiteContent] FOREIGN KEY ([id_SiteContent]) REFERENCES [dbo].[SiteContent]
)