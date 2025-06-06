<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AuthentificationViewer.aspx.cs" Inherits="_1Viewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <a href='AuthentificationViewer.aspx?CostumerID=<%# Eval("CostumerID") %>'>View</a>
    <form id="form1" runat="server">
        <h2>View Costumer Details</h2>
        <asp:Label ID="lblMessage" runat="server" ForeColor="Red" /><br /><br />

        <asp:Label runat="server" Text="Costumer ID: " />
        <asp:Label ID="lblCostumerID" runat="server" /><br /><br />

        <asp:Label runat="server" Text="Name: " />
        <asp:Label ID="lblCostumerName" runat="server" /><br /><br />

        <asp:Label runat="server" Text="Email: " />
        <asp:Label ID="lblEmail" runat="server" /><br /><br />

        <asp:Label runat="server" Text="Billing Address: " />
        <asp:Label ID="lblBilling" runat="server" /><br /><br />

        <asp:Label runat="server" Text="Phone Number: " />
        <asp:Label ID="lblPhone" runat="server" /><br /><br />

        <asp:Label runat="server" Text="Gender: " />
        <asp:Label ID="lblGender" runat="server" /><br /><br />

        <asp:Label runat="server" Text="Password: " />
        <asp:Label ID="lblPassword" runat="server" /><br /><br />

        <asp:Label runat="server" Text="Active: " />
        <asp:Label ID="lblActive" runat="server" /><br /><br />

        <asp:Button ID="btnBack" runat="server" Text="Back to List" PostBackUrl="AuthentificationList.aspx" />
    </form>
</body>
</html>
