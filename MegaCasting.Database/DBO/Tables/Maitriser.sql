CREATE TABLE [dbo].[Maitriser]
(
	[Id]          INT NOT NULL,
	[Id_Artist]   INT NOT NULL,
	CONSTRAINT [PK_Maitriser] PRIMARY KEY ([Id],[Id_Artist]),
	CONSTRAINT [FK_Maitriser_Talent] FOREIGN KEY ([Id]) REFERENCES [dbo].[Talent],
	CONSTRAINT [FK_Maitriser_Artist] FOREIGN KEY ([Id_Artist]) REFERENCES [dbo].[Artist]
)