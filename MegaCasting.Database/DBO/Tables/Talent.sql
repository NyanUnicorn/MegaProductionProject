CREATE TABLE [dbo].[Talent]
(
	[Id]            INT NOT NULL PRIMARY KEY IDENTITY,
	[LabelFr]       NVARCHAR(200) NOT NULL,
	[Description]   NVARCHAR(1000) NOT NULL,
)