CREATE PROCEDURE [dbo].[spInterviewCall_Delete]
	@Id int
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM InterviewCall where Id = @Id
END
	
