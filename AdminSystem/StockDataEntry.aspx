<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
            <style>
html, body, form 
{
    height: 100%;
    margin: 0;
    padding: 0;
    background-color: #00051F;
}
  </style>
</head>
<body style="height: 545px">
    <form id="StockDataEntryPage" runat="server" style="background-color:#00051F; height:126%">
      
        
            <asp:Button ID="btnEntryToMain" runat="server" OnClick="btnEntryToMain_Click" style="z-index: 1; left: 1227px; position: absolute; width: 195px; top: 45px; height: 44px;" Text="Return to main menu" BackColor="#48A388" BorderColor="#48A388" BorderStyle="Double" ForeColor="White" />
      
        
            <asp:Label ID="lblAlbumID" runat="server" style="z-index: 1; left: 538px; top: 274px; position: absolute; width: 134px; right: 806px" Text="AlbumID:" ForeColor="White"></asp:Label>
            <asp:Label ID="lblAlbumArtistID" runat="server" style="z-index: 1; left: 355px; top: 473px; position: absolute; width: 134px; " Text="ArtistID:" height="22px" ForeColor="White"></asp:Label>
            <asp:TextBox ID="txtAlbumEdition" runat="server" style="z-index: 1; left: 855px; top: 411px; position: absolute; height: 25px; margin-bottom: 0px" width="168px" OnTextChanged="txtAlbumEdition_TextChanged"></asp:TextBox>
            
            <asp:TextBox ID="txtAlbumReleaseDate" runat="server" style="z-index: 1; left: 491px; top: 409px; position: absolute; height: 25px; margin-bottom: 0px" width="168px"></asp:TextBox>
            <asp:TextBox ID="txtAlbumID" runat="server" style="z-index: 1; left: 685px; top: 270px; position: absolute; height: 25px; margin-bottom: 0px"></asp:TextBox>
            <asp:TextBox ID="txtAlbumTitle" runat="server" style="z-index: 1; left: 491px; top: 360px; position: absolute; height: 25px; margin-bottom: 0px" width="168px"></asp:TextBox>
            
            <asp:TextBox ID="txtAlbumPrice" runat="server" style="z-index: 1; left: 491px; top: 516px; position: absolute; height: 25px; margin-bottom: 0px" width="168px"></asp:TextBox>
            <asp:TextBox ID="txtAlbumArtistID" runat="server" style="z-index: 1; left: 491px; top: 464px; position: absolute; height: 25px; margin-bottom: 0px" width="168px"></asp:TextBox>
            <asp:TextBox ID="txtAlbumDescription" runat="server" style="z-index: 1; left: 855px; top: 474px; position: absolute; height: 140px; margin-bottom: 0px; width: 426px;"></asp:TextBox>
            <asp:Label ID="lblAlbumDescription" runat="server" style="z-index: 1; left: 740px; top: 470px; position: absolute; width: 108px; " Text="Description:" height="22px" ForeColor="White"></asp:Label>
            <asp:Label ID="lblAlbumPrice" runat="server" style="z-index: 1; left: 355px; top: 522px; position: absolute; width: 134px; " Text="Price:" height="22px" ForeColor="White"></asp:Label>
            <asp:Label ID="lblAlbumReleaseDate" runat="server" style="z-index: 1; left: 355px; top: 413px; position: absolute; width: 134px; " Text="Release Date:" height="22px" ForeColor="White"></asp:Label>
            <asp:Label ID="lblAlbumGenre" runat="server" style="z-index: 1; left: 740px; top: 364px; position: absolute; width: 108px; " Text="Genre:" height="22px" ForeColor="White"></asp:Label>
            <asp:Label ID="lblAlbumEdition" runat="server" style="z-index: 1; left: 740px; top: 411px; position: absolute; width: 108px; " Text="Edition:" height="22px" ForeColor="White"></asp:Label>
         
            
                <asp:Image ID="imgLogo" runat="server" ImageUrl="~/OnTheRocksLogoV4.png" style="z-index: 1; left: 76px; top: 35px; position: absolute; width: 217px; height: 107px" />
         
            
                <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 363px; top: 587px; position: absolute; margin-bottom: 0px; width: 127px;" Text="OK" OnClick="btnOK_Click" BackColor="#48A388" BorderColor="#48A388" BorderStyle="Double" ForeColor="White" />
          

               
          

                <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 582px; top: 588px; position: absolute; height: 29px;" Text="Cancel" BackColor="#48A388" BorderColor="#48A388" BorderStyle="Double" ForeColor="White" width="127px" />
          
          
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 1069px; top: 271px; position: absolute; height: 29px;" ForeColor="White"></asp:Label>
       
            
            <asp:TextBox ID="txtAlbumGenre" runat="server" style="z-index: 1; left: 855px; top: 362px; position: absolute; height: 25px; width: 168px"></asp:TextBox>
       
            
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 898px; top: 270px; position: absolute; width: 131px" Text="Find" BackColor="#48A388" BorderColor="#48A388" BorderStyle="Double" ForeColor="White" />
       
            
            <asp:Panel ID="Panel1" runat="server" style="z-index: 1; left: 0px; top: 0px; position: absolute; height: 22px; width: 1478px">
                <asp:Panel ID="Panel2" runat="server" style="z-index: 1; left: 248px; top: 243px; position: absolute; height: 409px; width: 1192px" BorderColor="White" BorderStyle="Solid" ForeColor="White">
                </asp:Panel>
            </asp:Panel>
            <asp:Label ID="lblAlbumTitle" runat="server" style="z-index: 1; left: 355px; top: 365px; position: absolute; width: 134px; " Text="Title:" height="22px" ForeColor="White"></asp:Label>
            <asp:Label ID="lblUser" runat="server" ForeColor="White" style="z-index: 1; left: 303px; top: 42px; position: absolute; width: 250px"></asp:Label>
            <asp:Label ID="lblPageTitle" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="XX-Large" ForeColor="White" style="z-index: 1; left: 559px; top: 155px; position: absolute; width: 558px; right: 361px" Text="Staff dedicated album editor "></asp:Label>
       
            
    </form>
    &nbsp;
</body>
</html>
