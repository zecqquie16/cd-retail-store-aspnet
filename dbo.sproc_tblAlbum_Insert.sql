CREATE PROCEDURE sproc_tblAlbum_Insert
	@Title varchar(50) ,
	@Genre varchar(50) ,
	@Description varchar(Max) ,
	@Edition varchar(50) ,
	@ArtistID int,
	@ReleaseDate datetime,
	@Price money 
AS
	INSERT INTO tblAlbum (Title,Genre,ReleaseDate,Edition,Description,ArtistID,Price)
	values (@Title,@Genre,@ReleaseDate,@Edition,@Description,@ArtistID,@Price)
RETURN @@IDENTITY
