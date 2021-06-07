CREATE PROCEDURE [dbo].[spInterviewCall_Update]
	@Id int,
	@CallDate datetime2,
	@ContactedPerson nvarchar(50),
	@PhoneNumber nvarchar(12),
	@Company nvarchar(50),
	@Location nvarchar(50),
	@IsShortListed bit,
	@InterviewDate datetime2,
	@Remarks nvarchar(max)
AS
BEGIN
	set NOCOUNT ON;
	UPDATE InterviewCall set CallDate=@CallDate, ContactedPerson=@ContactedPerson, PhoneNumber=@PhoneNumber, 
	Company=@Company, [Location]=@Location, IsShortListed=@IsShortListed, InterviewDate=@InterviewDate, Remarks=@Remarks
	WHERE Id = @Id
END
