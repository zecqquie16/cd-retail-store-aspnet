<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockArtistDataEntry.aspx.cs" Inherits="_1Viewer" %>

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
<body>
     <form id="StockArtistDataEntryPage" runat="server" style="background-color:#00051F; height:817px">
           <asp:TextBox ID="txtArtistBiography" runat="server" style="z-index: 1; left: 883px; top: 470px; position: absolute; height: 181px; width: 490px" TextMode="MultiLine"></asp:TextBox>
           <asp:TextBox ID="txtArtistID" runat="server" style="z-index: 1; left: 633px; top: 273px; position: absolute"></asp:TextBox>
           <asp:Button ID="btnFind" runat="server" style="z-index: 1; left: 876px; top: 270px; position: absolute; width: 101px;" Text="Find" BackColor="#48A388" BorderColor="#48A388" BorderStyle="Double" ForeColor="White" OnClick="btnFind_Click" />
           <asp:Button ID="btnMainMenu" runat="server" style="z-index: 1; left: 1277px; top: 31px; position: absolute" Text="Main Menu" BackColor="#48A388" BorderColor="#48A388" BorderStyle="Double" ForeColor="White" OnClick="btnMainMenu_Click" />
           <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 530px; top: 549px; position: absolute; height: 43px; width: 124px;" Text="Cancel" BackColor="#48A388" BorderColor="#48A388" BorderStyle="Double" ForeColor="White" OnClick="btnCancel_Click" />
           <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 387px; top: 549px; position: absolute; right: 989px; height: 43px; width: 124px;" Text="OK" BackColor="#48A388" BorderColor="#48A388" BorderStyle="Double" ForeColor="White" OnClick="btnOK_Click" />
           <asp:TextBox ID="txtArtistName" runat="server" style="z-index: 1; left: 461px; top: 367px; position: absolute"></asp:TextBox>
           <asp:TextBox ID="txtArtistGenre" runat="server" style="z-index: 1; left: 883px; top: 367px; position: absolute"></asp:TextBox>
           <asp:TextBox ID="txtArtistImagePath" runat="server" style="z-index: 1; left: 883px; top: 412px; position: absolute"></asp:TextBox>
           <asp:TextBox ID="txtArtistNationality" runat="server" style="z-index: 1; left: 461px; top: 472px; position: absolute"></asp:TextBox>
      
        
  <asp:Label ID="lblArtistID" runat="server" style="z-index: 1; left: 471px; top: 274px; position: absolute; width: 134px; right: 873px" Text="ArtistID:" ForeColor="White"></asp:Label>
  <asp:Label ID="lblArtistNationality" runat="server" style="z-index: 1; left: 366px; top: 473px; position: absolute; width: 93px; " Text="Nationality:" height="22px" ForeColor="White"></asp:Label>
  
           <asp:CheckBox ID="checkIsSolo" runat="server" BorderStyle="None" ForeColor="White" style="z-index: 1; left: 509px; top: 413px; position: absolute; width: 72px;" Text="Yes" />
  <asp:Label ID="lblArtistBiography" runat="server" style="z-index: 1; left: 740px; top: 473px; position: absolute; width: 108px; " Text="Biography:" height="22px" ForeColor="White"></asp:Label>
  <asp:Label ID="lblArtistIsSolo" runat="server" style="z-index: 1; left: 366px; top: 413px; position: absolute; width: 75px; " Text="Is solo ?:" height="22px" ForeColor="White"></asp:Label>
  <asp:Label ID="lblArtistGenre" runat="server" style="z-index: 1; left: 740px; top: 368px; position: absolute; width: 108px; " Text="Genre:" height="22px" ForeColor="White"></asp:Label>
  <asp:Label ID="lblArtistImage" runat="server" style="z-index: 1; left: 740px; top: 413px; position: absolute; width: 108px; " Text="Image path:" height="22px" ForeColor="White"></asp:Label>
         
  
      <asp:Image ID="imgLogo" runat="server" ImageUrl="~/OnTheRocksLogoV4.png" style="z-index: 1; left: 76px; top: 35px; position: absolute; width: 217px; height: 107px" />
         
  
  <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 1069px; top: 271px; position: absolute; height: 29px;" ForeColor="White"></asp:Label>
       
  
 
  <asp:Label ID="lblUser" runat="server" ForeColor="White" style="z-index: 1; left: 303px; top: 42px; position: absolute; width: 250px"></asp:Label>
           <asp:Label ID="lblArtistName" runat="server" ForeColor="White" style="z-index: 1; left: 366px; top: 368px; position: absolute" Text="Name:"></asp:Label>
  <asp:Label ID="lblPageTitle" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="XX-Large" ForeColor="White" style="z-index: 1; left: 559px; top: 155px; position: absolute; width: 558px; right: 361px" Text="Staff dedicated artist editor "></asp:Label>
       
        
    </form>
</body>
</html>