CREATE PROCEDURE [dbo].[spInterviewCall_Insert]
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
	INSERT INTO InterviewCall(CallDate, ContactedPerson, PhoneNumber, Company, [Location], IsShortListed, InterviewDate, Remarks)
	VALUES (@CallDate, @ContactedPerson, @PhoneNumber, @Company, @Location, @IsShortListed, @InterviewDate, @Remarks)
END
