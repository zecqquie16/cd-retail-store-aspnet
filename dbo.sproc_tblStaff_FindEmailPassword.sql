CREATE PROCEDURE sproc_tblStaff_FindEmailPassword
	@Email varchar(50),
	@Password varchar(50)
AS
	SELECT * FROM tblStaff WHERE Email = @Email AND Password = @Password
RETURN 0
