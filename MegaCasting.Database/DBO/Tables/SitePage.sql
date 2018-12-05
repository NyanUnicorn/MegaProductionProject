CREATE TABLE [dbo].[SitePage]
(
	[Id]        INT NOT NULL PRIMARY KEY IDENTITY,
	[LabelFr]   NVARCHAR(200) NOT NULL,
	[Id_Site]   INT NOT NULL,
	CONSTRAINT [FK_SitePage_Site] FOREIGN KEY ([id_Site]) REFERENCES [dbo].[Site]
)