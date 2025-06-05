CREATE PROCEDURE sproc_tblArtist_Insert
	@Name varchar(50) ,
	@Genre varchar(50) ,
	@Biography varchar(Max) ,
	@Nationality varchar(50) ,
	@Solo bit,
	
	@Image varchar(255)
	
AS
	INSERT INTO tblArtist (Name,Genre,Biography,Nationality,Solo,Image)
	values (@Name,@Genre,@Biography,@Nationality,@Solo,@Image)
RETURN @@IDENTITY
