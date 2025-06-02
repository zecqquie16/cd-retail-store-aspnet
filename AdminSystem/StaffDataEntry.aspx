<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

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
    <form id="pageLoginStaff" runat="server" aria-hidden="False" style ="background-color: #00051F; height:100%; " draggable="false">
        
        
            <asp:Label ID="lblStaffTitle" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="White" style="z-index: 1; left: 170px; top: 101px; position: absolute; width: 247px" Text="Staff Login"></asp:Label>
        
        <asp:Label ID="lblPassword" runat="server" Font-Names="Arial" Font-Size="Large" ForeColor="White" style="z-index: 1; left: 150px; top: 217px; position: absolute; width: 63px" Text="Password:"></asp:Label>
            <asp:Panel ID="Panel1" runat="server" style="z-index: 1; left: 88px; top: 75px; position: absolute; height: 347px; width: 677px">
                <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 353px; top: 246px; position: absolute" Text="Cancel" />
                <asp:Label ID="lblError" runat="server" Font-Size="Medium" ForeColor="Red" style="z-index: 1; left: 474px; top: 88px; position: absolute; width: 130px"></asp:Label>
            </asp:Panel>
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 250px; top: 321px; position: absolute" Text="Login" />
        <asp:TextBox ID="txtPassword" runat="server" BorderStyle="Double" style="z-index: 1; left: 264px; top: 213px; position: absolute; height: 26px; width: 229px" TextMode="Password"></asp:TextBox>
        <asp:Label ID="lblEmail" runat="server" Font-Names="Arial" Font-Size="Large" ForeColor="White" style="z-index: 1; left: 171px; top: 155px; position: absolute; width: 63px" Text="Email:"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" BorderStyle="Double" style="z-index: 1; left: 264px; top: 150px; position: absolute; height: 26px; width: 229px"></asp:TextBox>
        
    </form>
</body>
</html>
