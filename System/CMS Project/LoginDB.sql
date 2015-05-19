USE [dbcms]
GO

CREATE PROCEDURE [dbo].[InsertAdminSchema]
	@Staff_id smallint,
	@ur_id smallint,
	@username varchar(30),
	@email varchar(100),
	@pass_word varchar(Max),
	@reg_code varchar(30),
	@date_reg date
AS
BEGIN
	SET NOCOUNT ON;
	IF EXISTS(SELECT id FROM tbAdminSchema  WHERE username = @username)
	BEGIN
		SELECT -1 
	END
	ELSE IF EXISTS(SELECT id FROM tbAdminSchema  WHERE email = @email)
	BEGIN
		SELECT -2 
	END
	ELSE
	BEGIN
		INSERT INTO 
		        [tbAdminSchema] 
			   ([Staff_id]
			   ,[ur_id]
			   ,[username]
			   ,[email]
			   ,[pass_word]
			   ,[reg_code]
			   ,[date_reg])
		VALUES
			   (@Staff_id
			   ,@ur_id
			   ,@username 
			   ,@email 
			   ,@pass_word 
			   ,@reg_code
			   ,@date_reg)
		
		SELECT SCOPE_IDENTITY() 		   
     END
END

GO






