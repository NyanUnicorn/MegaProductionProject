CREATE PROCEDURE [dbo].[SP_CreateCastingOffer]
	@Label NVARCHAR(200),
	@Description NVARCHAR(200),
	@Street NVARCHAR(200),
	@City NVARCHAR(200),
	@PostalCode NVARCHAR(200),
	@ContractId INT,
	@ClientId NVARCHAR(200),
	@TalentId INT,
	@UserId INT
AS
	DECLARE @OfferId INT;
	INSERT INTO [dbo].[Offer]([LibelFr],[Publication],[Description],[StreetName],[CityName],[PostalCode],[PeriodTokens],[Id_SiteContent],[Id_ContractType],[Id_Talent])
	VALUES(@Label, GETDATE(), @Description, @Street, @City, @PostalCode, 1, 2, @ContractId, @TalentId);
	SELECT @OfferId = SCOPE_IDENTITY();
	INSERT INTO [dbo].[Proposer]([Id], [Id_ClientCompany], [Id_HeavyUser])
	VALUES(@OfferId,@ClientId,@userId);
RETURN 0