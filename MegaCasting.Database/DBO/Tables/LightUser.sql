CREATE TABLE [dbo].[LightUser]
(
	[Id]           INT NOT NULL PRIMARY KEY IDENTITY,
	[FirstName]    NVARCHAR(200) NOT NULL,
	[SecondName]   NVARCHAR(200) NOT NULL,
	[UserName]     NVARCHAR(200) NOT NULL,
	[Email]        NVARCHAR(200) NOT NULL,
	[Password]     NVARCHAR(200) NOT NULL,
	[BirthDate]    DATETIME NOT NULL,
)