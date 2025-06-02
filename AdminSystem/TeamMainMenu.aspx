<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
    html, body, form {
        height: 100%;
        margin: 0;
        padding: 0;
        background-color: #00051F;
    }
</style>

</head>
<body>
    <form id="pageMain" runat="server" aria-hidden="False" style ="background-color: #00051F; height:100%; " draggable="false">
        
        <asp:Image ID="imgLogo" runat="server" ImageUrl="~/OnTheRocksLogoV4.png" style="z-index: 1; left: 32px; top: 10px; position: absolute; height: 190px; width: 245px" BackColor="Black" BorderStyle="None" />
        <asp:Label ID="lblSystemName" runat="server" Font-Bold="True" Font-Size="XX-Large" style="z-index: 1; left: 136px; top: 267px; position: absolute" Text="Own the Music" ForeColor="White"></asp:Label>
        <asp:Button ID="btnUserLogin" runat="server" OnClick="btnAuthentication_Click" style="z-index: 1; left: 1218px; top: 61px; position: absolute; height: 45px; width: 79px;" Text="Login" BackColor="#48A388" BorderColor="#48A388" BorderStyle="Double" ForeColor="White" />
       
        <asp:Label ID="lblUser" runat="server" ForeColor="White" style="z-index: 1; left: 295px; top: 59px; position: absolute; height: 32px; width: 495px"></asp:Label>
       
        <asp:Button ID="btnStaff" runat="server" OnClick="btnStaff_Click" style="z-index: 1; left: 966px; top: 62px; position: absolute; height: 45px; width: 183px;" Text="Staff gateway" BackColor="#48A388" BorderColor="#48A388" BorderStyle="Double" ForeColor="White" />
        
        <asp:Label ID="lblSystemName0" runat="server" Font-Bold="False" Font-Size="Large" style=" font-name:Arial;  z-index: 1; left: 134px; top: 331px; position: absolute; right: 866px;" Text="Owning a real CD album gives you a real connection to the music—it turns something you’d normally just stream into a personal keepsake. The artwork, booklet, and lyrics make the experience way more immersive than just listening online. Plus, collecting CDs is a cool way to support your favourite artists and hang on to something that feels nostalgic and lasting !" ForeColor="White"></asp:Label>
        
        
        

        <asp:Button ID="btnStock" runat="server" OnClick="btnStock_Click" style="z-index: 1; left: 703px; top: 370px; position: absolute; right: 560px; height: 59px; width: 215px;" Text="Discover our collection ! " BackColor="#48A388" BorderColor="#48A388" BorderStyle="Double" Font-Bold="True" Font-Names="Arial" ForeColor="White" />
        
        
        
        <asp:Button ID="btnLogOut" runat="server" BackColor="#48A388" BorderColor="#48A388" BorderStyle="Double" ForeColor="White" OnClick="btnLogOut_Click" style="z-index: 1; left: 289px; top: 100px; position: absolute; width: 139px; height: 40px; bottom: 437px" Text="LogOut" Visible="False" />
        <asp:Button ID="btnUserRegister" runat="server" BackColor="#48A388" BorderColor="#48A388" BorderStyle="Double" ForeColor="White" OnClick="btnUserRegister_Click" style="z-index: 1; left: 1340px; top: 58px; position: absolute; height: 42px; width: 105px; bottom: 476px" Text="Register" />
        
        
        
    </form>
</body>
</html>
