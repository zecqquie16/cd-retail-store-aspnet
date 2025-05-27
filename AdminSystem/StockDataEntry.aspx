<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 532px;
            margin-bottom: 0px;
        }
    </style>
</head>
<body style="height: 538px">
    <form id="form1" runat="server">
      
        
            <asp:Button ID="btnEntryToMain" runat="server" OnClick="btnEntryToMain_Click" style="z-index: 1; left: 984px; position: absolute; width: 177px; top: 465px" Text="Return to main menu" />
      
        
            <asp:Label ID="lblAlbumID" runat="server" style="z-index: 1; left: 60px; top: 115px; position: absolute; width: 134px; right: 1284px" Text="AlbumID"></asp:Label>
            <asp:Label ID="lblAlbumArtistID" runat="server" style="z-index: 1; left: 60px; top: 276px; position: absolute; width: 134px; " Text="ArtistID" height="22px"></asp:Label>
            <asp:Label ID="lblAlbumTitle" runat="server" style="z-index: 1; left: 60px; top: 169px; position: absolute; width: 134px; " Text="Title" height="22px"></asp:Label>
            <asp:TextBox ID="txtAlbumEdition" runat="server" style="z-index: 1; left: 220px; top: 485px; position: absolute; height: 25px; margin-bottom: 0px" width="168px" OnTextChanged="txtAlbumEdition_TextChanged"></asp:TextBox>
            
            <asp:TextBox ID="txtAlbumReleaseDate" runat="server" style="z-index: 1; left: 220px; top: 435px; position: absolute; height: 25px; margin-bottom: 0px" width="168px"></asp:TextBox>
            <asp:TextBox ID="txtAlbumID" runat="server" style="z-index: 1; left: 224px; top: 113px; position: absolute; height: 25px; margin-bottom: 0px"></asp:TextBox>
            <asp:TextBox ID="txtAlbumTitle" runat="server" style="z-index: 1; left: 220px; top: 170px; position: absolute; height: 25px; margin-bottom: 0px" width="168px"></asp:TextBox>
            
            <asp:TextBox ID="txtAlbumPrice" runat="server" style="z-index: 1; left: 220px; top: 330px; position: absolute; height: 25px; margin-bottom: 0px" width="168px"></asp:TextBox>
            <asp:TextBox ID="txtAlbumArtistID" runat="server" style="z-index: 1; left: 220px; top: 279px; position: absolute; height: 25px; margin-bottom: 0px" width="168px"></asp:TextBox>
            <asp:TextBox ID="txtAlbumDescription" runat="server" style="z-index: 1; left: 220px; top: 376px; position: absolute; height: 25px; margin-bottom: 0px" width="168px"></asp:TextBox>
            <asp:Label ID="lblAlbumDescription" runat="server" style="z-index: 1; left: 60px; top: 384px; position: absolute; width: 134px; " Text="Description" height="22px"></asp:Label>
            <asp:Label ID="lblAlbumPrice" runat="server" style="z-index: 1; left: 60px; top: 331px; position: absolute; width: 134px; " Text="Price" height="22px"></asp:Label>
            <asp:Label ID="lblAlbumReleaseDate" runat="server" style="z-index: 1; left: 60px; top: 437px; position: absolute; width: 134px; " Text="Release Date" height="22px"></asp:Label>
            <asp:Label ID="lblAlbumGenre" runat="server" style="z-index: 1; left: 60px; top: 231px; position: absolute; width: 134px; " Text="Genre" height="22px"></asp:Label>
            <asp:Label ID="lblAlbumEdition" runat="server" style="z-index: 1; left: 60px; top: 494px; position: absolute; width: 134px; " Text="Edition" height="22px"></asp:Label>
         
            
                <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 540px; top: 235px; position: absolute; margin-bottom: 0px" Text="OK" OnClick="btnOK_Click" />
          

               
          

                <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 611px; top: 237px; position: absolute; height: 29px;" Text="Cancel" />
          
          
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 46px; top: 572px; position: absolute; height: 29px;"></asp:Label>
       
            
            <asp:TextBox ID="txtAlbumGenre" runat="server" style="z-index: 1; left: 220px; top: 228px; position: absolute; height: 25px; width: 168px"></asp:TextBox>
       
            
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 537px; top: 144px; position: absolute; width: 131px" Text="Find" />
       
            
    </form>
    &nbsp;
</body>
</html>
