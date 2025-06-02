<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockNew.aspx.cs" Inherits="_1_Nouveau" %>

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
   <form id="StockDetails" runat="server" style="background-color:#00051F; height:100%">
        
        <asp:Image ID="imgLogo" runat="server" ImageUrl="~/OnTheRocksLogoV4.png" style="z-index: 1; left: 76px; top: 35px; position: absolute; width: 217px; height: 107px" />
        <asp:Image ID="imgCover" runat="server" style="z-index: 1; left: 264px; top: 207px; position: absolute; height: 328px; width: 391px" />
        <asp:Label ID="lblTitle" runat="server" style="z-index: 1; left: 900px; top: 182px; position: absolute; height: 49px; width: 388px" Text="Titre" Font-Bold="True" Font-Overline="False" Font-Size="XX-Large" Font-Strikeout="False" ForeColor="White"></asp:Label>
        
        <asp:Label ID="lblArtistName" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="Medium" style="z-index: 1; left: 1069px; top: 242px; position: absolute; width: 210px; height: 25px" Text="ArtistName" ForeColor="White"></asp:Label>
        <asp:Label ID="lblGenre" runat="server" style="z-index: 1; left: 1096px; top: 287px; position: absolute; width: 128px" Text="Genre" ForeColor="White"></asp:Label>
        <asp:Panel ID="pnlAbout" runat="server" BorderStyle="Solid" style="z-index: 1; left: 790px; top: 165px; position: absolute; height: 380px; width: 630px" ForeColor="White">
            <asp:Label ID="lblArtist" runat="server" style="z-index: 1; left: 82px; top: 74px; position: absolute" Text="Artist :"></asp:Label>
            <asp:Label ID="lblGenr" runat="server" style="z-index: 1; left: 74px; top: 117px; position: absolute; height: 25px" Text="Musical genre: "></asp:Label>
            <asp:Button ID="btnBuy" runat="server" Font-Bold="True" Font-Size="Large" Height="60px" style="z-index: 1; left: 219px; top: 275px; position: absolute; bottom: 45px; width: 216px" Text="Purchase" BackColor="#48A388" BorderColor="#48A388" BorderStyle="Double" ForeColor="White" />
            <asp:DropDownList ID="ddlEdition" runat="server" AutoPostBack= "true" OnSelectedIndexChanged="ddlEdition_SelectedIndexChanged" style="z-index: 1; left: 243px; top: 161px; position: absolute; width: 166px">
            </asp:DropDownList>
            <asp:Label ID="lblPric" runat="server" style="z-index: 1; left: 76px; top: 212px; position: absolute; height: 25px; right: 506px" Text="Price: "></asp:Label>
            <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 305px; top: 213px; position: absolute; width: 94px" Text="Price"></asp:Label>
        </asp:Panel>
        <asp:Label ID="lblReleaseDate0" runat="server" style="z-index: 1; left: 1285px; top: 192px; position: absolute; width: 120px" Text="ReleaseDate" ForeColor="White"></asp:Label>
        <asp:Label ID="lblEdition" runat="server" style="z-index: 1; left: 867px; top: 327px; position: absolute; height: 25px" Text="Edition:" ForeColor="White"></asp:Label>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; left: 122px; top: 587px; position: absolute; width: 146px" Text="Description" ForeColor="White"></asp:Label>
        <asp:Label ID="lblDescription" runat="server" style="z-index: 1; left: 123px; top: 631px; position: absolute; height: 361px; width: 1241px" Text="Description Here.." ForeColor="White"></asp:Label>
        
       
        
        <asp:Button ID="btnDisplayToMain" runat="server" OnClick="btnEntryToMain_Click" style="z-index: 1; left: 1214px; position: absolute; width: 185px; top: 65px; height: 54px;" Text="Return to main menu" BackColor="#48A388" BorderColor="#48A388" BorderStyle="Double" ForeColor="White" />
        
        <asp:Button ID="btnLogin" runat="server" BackColor="#48A388" BorderColor="#48A388" BorderStyle="Double" ForeColor="White" height="54px" OnClick="btnLogin_Click" style="z-index: 1; left: 979px; top: 65px; position: absolute" Text="Login" width="94px" />
        <asp:Button ID="btnStaffGateway" runat="server" BackColor="#48A388" BorderColor="#48A388" BorderStyle="Double" ForeColor="White" height="54px" OnClick="btnStaffGateway_Click" style="z-index: 1; left: 785px; top: 65px; position: absolute; width: 160px" Text="Staff Gateway" />
        <asp:Button ID="btnRegister" runat="server" BackColor="#48A388" BorderColor="#48A388" BorderStyle="Double" ForeColor="White" OnClick="btnRegister_Click" style="z-index: 1; left: 1097px; top: 65px; position: absolute; height: 54px; width: 94px; right: 287px" Text="Register" />
        <asp:Label ID="lblUser" runat="server" ForeColor="White" style="z-index: 1; left: 310px; top: 43px; position: absolute; width: 366px"></asp:Label>
        <asp:Button ID="btnLogOut" runat="server" BackColor="#48A388" BorderColor="#48A388" BorderStyle="Double" ForeColor="White" OnClick="btnLogOut_Click" style="z-index: 1; left: 446px; top: 99px; position: absolute; height: 54px" Text="Log Out" Visible="False" width="94px" />
        
    </form>
</body>
</html>
