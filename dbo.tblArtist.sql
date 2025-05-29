CREATE TABLE [dbo].[tblArtist] (
    [ArtistID]    INT           IDENTITY (1, 1) NOT NULL,
    [Name]        VARCHAR (50)  NOT NULL,
    [Solo]        BIT           NOT NULL,
    [Genre]       VARCHAR (50)  NOT NULL,
    [Nationality] VARCHAR (50)  NOT NULL,
    [Biography]   VARCHAR (MAX) NOT NULL,
    [LabelID]     INT           NULL,
    PRIMARY KEY CLUSTERED ([ArtistID] ASC)
);

