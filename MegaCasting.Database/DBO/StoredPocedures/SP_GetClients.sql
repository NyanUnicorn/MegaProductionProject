CREATE PROCEDURE [dbo].[SP_GetClients]
AS
	SELECT [ClientCompany].[id], [ClientCompany].[Name], [ClientCompany].[TelNumApplication], [ClientCompany].[TelNumContact], [ClientCompany].[StreetName], [ClientCompany].[CityName], [ClientCompany].[PostalCode], [ClientCompany].[TokenRestant] FROM [ClientCompany];
RETURN 0

