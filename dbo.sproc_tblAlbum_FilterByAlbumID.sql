CREATE PROCEDURE sproc_tblAlbum_FilterByAlbumID_test
    @AlbumID INT
AS
BEGIN
    PRINT 'Base de données utilisée : ' + DB_NAME();

    SELECT * 
    FROM tblAlbum 
    WHERE AlbumID = @AlbumID;

    RETURN 0;
END