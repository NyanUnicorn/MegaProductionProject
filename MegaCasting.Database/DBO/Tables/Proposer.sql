CREATE TABLE [dbo].[Proposer]
(
	[Id]                    INT NOT NULL,
	[Id_ClientCompany]   INT NOT NULL,
	[Id_HeavyUser]          INT NOT NULL,
	CONSTRAINT [PK_Proposer] PRIMARY KEY ([Id],[Id_ClientCompany],[Id_HeavyUser]),
	CONSTRAINT [FK_Proposer_Offer] FOREIGN KEY ([Id]) REFERENCES [dbo].[Offer],
	CONSTRAINT [FK_Proposer_ClientCompany] FOREIGN KEY ([Id_ClientCompany]) REFERENCES [dbo].[ClientCompany],
	CONSTRAINT [FK_Proposer_HeavyUser] FOREIGN KEY ([Id_HeavyUser]) REFERENCES [dbo].[HeavyUser]
)