CREATE TABLE [dbo].[HeavyUser]
(
	[Id]           INT NOT NULL PRIMARY KEY IDENTITY,
	[FirstName]    NVARCHAR(200) NOT NULL,
	[SecondName]   NVARCHAR(200) NOT NULL,
	[UserName]     NVARCHAR(200) NOT NULL,
	[Email]        NVARCHAR(200) NOT NULL,
	[Password]     NVARCHAR(200) NOT NULL,
	[Id_Company]   INT NOT NULL,
	CONSTRAINT [FK_HeavyUser_Company] FOREIGN KEY ([id_Company]) REFERENCES [dbo].[Company]
)