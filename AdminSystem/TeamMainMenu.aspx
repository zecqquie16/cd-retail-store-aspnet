<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 1164px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        
        <asp:Image ID="Image1" runat="server" ImageUrl="~/StockOnTheRacksLogo.png" style="z-index: 1; left: 500px; top: 64px; position: absolute; height: 117px; width: 403px" />
        <asp:Label ID="lblSystemName" runat="server" Font-Bold="True" Font-Size="XX-Large" style="z-index: 1; left: 496px; top: 204px; position: absolute" Text="OnTheRacks Main Menu"></asp:Label>
        <asp:Button ID="btnStock" runat="server" OnClick="btnStock_Click" style="z-index: 1; left: 300px; top: 335px; position: absolute; right: 1097px" Text="Albums" />
        <asp:Button ID="btnAuthentication" runat="server" OnClick="btnAuthentication_Click" style="z-index: 1; left: 623px; top: 330px; position: absolute" Text="Login/Register" />
        <asp:Button ID="btnStaff" runat="server" OnClick="btnStaff_Click" style="z-index: 1; left: 1041px; top: 329px; position: absolute" Text="Staff" />
        
    </form>
</body>
</html>
