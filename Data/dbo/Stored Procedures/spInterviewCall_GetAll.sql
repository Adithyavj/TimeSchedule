CREATE PROCEDURE [dbo].[spInterviewCall_GetAll]
AS
BEGIN
	set NOCOUNT ON;
	select Id, CallDate, ContactedPerson, PhoneNumber, Company, [Location], IsShortListed, InterviewDate, Remarks
	from InterviewCall
END
