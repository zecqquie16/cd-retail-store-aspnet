CREATE PROCEDURE sproc_tblArtist_Insert
	@Name varchar(50) ,
	@Genre varchar(50) ,
	@Biography varchar(Max) ,
	@Nationality varchar(50) ,
	@Solo bit,
	@LabelID int
	
AS
	INSERT INTO tblArtist (Name,Genre,Biography,Nationality,Solo,LabelID)
	values (@Name,@Genre,@Biography,@Nationality,@Solo,@LabelID)
RETURN @@IDENTITY