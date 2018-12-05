CREATE PROCEDURE [dbo].[SP_GetTalents]
AS
	SELECT [Id], [LabelFr], [Description] FROM [Talent]
RETURN 0
