CREATE TABLE [dbo].[Education]
(
	[Id]          INT NOT NULL PRIMARY KEY IDENTITY,
	[School]      NVARCHAR(200) NOT NULL,
	[Curiculum]   NVARCHAR(400) NOT NULL,
	[StartYear]   INT NOT NULL,
	[EndYear]     INT NOT NULL,
	[Id_Artist]   INT NOT NULL,
	CONSTRAINT [FK_Education_Artist] FOREIGN KEY ([id_Artist]) REFERENCES [dbo].[Artist]
)