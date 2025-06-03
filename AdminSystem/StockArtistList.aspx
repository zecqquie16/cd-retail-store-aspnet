<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockArtistList.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
            <style>
html, body, form 
{
    height: 5px;
    margin: 0;
    padding: 0;
    background-color: #00051F;
}
  </style>
</head>
<body>
     <form id="StockDetails" runat="server" style="background-color:#00051F; height:20%">
      
      <asp:Image ID="imgLogo" runat="server" ImageUrl="~/OnTheRocksLogoV4.png" style="z-index: 1; left: 76px; top: 35px; position: absolute; width: 217px; height: 107px" />
         <asp:Button ID="btnDisplayToMain" runat="server" OnClick="btnEntryToMain_Click" style="z-index: 1; left: 1214px; position: absolute; width: 185px; top: 65px; height: 54px;" Text="Return to main menu" BackColor="#48A388" BorderColor="#48A388" BorderStyle="Double" ForeColor="White" />

<asp:Button ID="btnLogin" runat="server" BackColor="#48A388" BorderColor="#48A388" BorderStyle="Double" ForeColor="White" height="54px" OnClick="btnLogin_Click" style="z-index: 1; left: 979px; top: 65px; position: absolute" Text="Login" width="94px" />
<asp:Button ID="btnStaffGateway" runat="server" BackColor="#48A388" BorderColor="#48A388" BorderStyle="Double" ForeColor="White" height="54px" OnClick="btnStaffGateway_Click" style="z-index: 1; left: 785px; top: 65px; position: absolute; width: 160px" Text="Staff Gateway" />
<asp:Button ID="btnRegister" runat="server" BackColor="#48A388" BorderColor="#48A388" BorderStyle="Double" ForeColor="White" OnClick="btnRegister_Click" style="z-index: 1; left: 1097px; top: 65px; position: absolute; height: 54px; width: 94px; right: 287px" Text="Register" />
<asp:Label ID="lblUser" runat="server" ForeColor="White" style="z-index: 1; left: 310px; top: 43px; position: absolute; width: 366px"></asp:Label>
<asp:Button ID="btnLogOut" runat="server" BackColor="#48A388" BorderColor="#48A388" BorderStyle="Double" ForeColor="White" OnClick="btnLogOut_Click" style="z-index: 1; left: 446px; top: 99px; position: absolute; height: 54px" Text="Log Out" Visible="False" width="94px" />
    
     
         <asp:Image ID="Image1" runat="server" style="z-index: 1; left: 206px; top: 253px; position: absolute; height: 255px; width: 340px" />
         <asp:Label ID="lblArtistName" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="White" style="z-index: 1; left: 263px; top: 199px; position: absolute; height: 24px; width: 270px; margin-bottom: 1px"></asp:Label>
         <asp:Label ID="lblAbout" runat="server" Font-Size="X-Large" ForeColor="White" style="z-index: 1; left: 814px; top: 215px; position: absolute; width: 109px" Text="About"></asp:Label>
         <asp:Panel ID="pnlAbout" runat="server" style="z-index: 1; left: 774px; top: 257px; position: absolute; height: 299px; width: 680px; margin-top: 0px;" BorderColor="White" BorderStyle="Solid" ForeColor="White">
             <asp:Label ID="lblGenre" runat="server" style="z-index: 1; left: 300px; top: 18px; position: absolute" Text="Main genre:"></asp:Label>
             <asp:Label ID="LblNationality" runat="server" style="z-index: 1; left: 21px; top: 18px; position: absolute" Text="Nationality:"></asp:Label>
             <asp:Label ID="lblNationalityy" runat="server" style="z-index: 1; left: 130px; top: 18px; position: absolute"></asp:Label>
             <asp:Label ID="lblGenree" runat="server" style="z-index: 1; left: 408px; top: 18px; position: absolute"></asp:Label>
             <asp:Label ID="lblIsSolo" runat="server" style="z-index: 1; left: 23px; top: 52px; position: absolute" Text="Is Solo ?:"></asp:Label>
             <asp:Label ID="lblIsSoloo" runat="server" style="z-index: 1; left: 112px; top: 52px; position: absolute"></asp:Label>
             <asp:ListBox ID="lstArtistAlbum" runat="server"  BorderColor="#444" BorderStyle="Solid" BorderWidth="1px" BackColor="#00051F" Font-Italic="True" ForeColor="White" OnSelectedIndexChanged="lstArtistAlbum_SelectedIndexChanged" Rows="5" style=  " border-radius: 6px; padding: 6px; z-index: 1; left: 156px; top: 121px; position: absolute; width: 351px; height: 161px" Width="300px"></asp:ListBox>
             <asp:Label ID="lblList" runat="server" style="z-index: 1; left: 24px; top: 86px; position: absolute" Text="Artist's available albums:"></asp:Label>
         </asp:Panel>
    
     
         <asp:Label ID="lblBiographyTitle" runat="server" Font-Size="Larger" ForeColor="White" style="z-index: 1; left: 79px; top: 534px; position: absolute; height: 62px; width: 329px" Text="More about "></asp:Label>
         <asp:Label ID="lblBiography" runat="server" Font-Size="Medium" ForeColor="White" style="z-index: 1; left: 77px; top: 587px; position: absolute; height: 234px; width: 493px"></asp:Label>
         <asp:Button ID="btnDisplay" runat="server" BackColor="#48A388" BorderColor="#48A388" BorderStyle="Double" ForeColor="White" OnClick="btnDisplay_Click" style="z-index: 1; left: 1325px; top: 423px; position: absolute; height: 41px; width: 95px" Text="Display" />
    
     
     </form>
</body>
</html>
