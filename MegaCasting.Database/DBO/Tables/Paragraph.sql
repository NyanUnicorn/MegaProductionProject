CREATE TABLE [dbo].[Paragraph]
(
	[Id]				INT NOT NULL PRIMARY KEY IDENTITY,
	[LabelFr]			NVARCHAR(200) NOT NULL,
	[ParagText]			NVARCHAR(4000) NOT NULL,
	[Id_SiteContent]	INT NOT NULL,
	CONSTRAINT [FK_Paragraph_SiteContent] FOREIGN KEY ([id_SiteContent]) REFERENCES [dbo].[SiteContent]
)