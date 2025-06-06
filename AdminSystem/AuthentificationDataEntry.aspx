<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AuthentificationDataEntry.aspx.cs" Inherits="AuthentificationDataEntry" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Customer Entry</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtCustomerID" runat="server" Placeholder="Customer ID"></asp:TextBox><br />
            <asp:TextBox ID="txtCustomerName" runat="server" Placeholder="Customer Name"></asp:TextBox><br />
            <asp:TextBox ID="txtEmailAddress" runat="server" Placeholder="Email"></asp:TextBox><br />
            <asp:TextBox ID="txtBillingAddress" runat="server" Placeholder="Billing Address"></asp:TextBox><br />
            <asp:TextBox ID="txtPhoneNumber" runat="server" Placeholder="Phone Number"></asp:TextBox><br />
            <asp:TextBox ID="txtGender" runat="server" Placeholder="Gender"></asp:TextBox><br />
            <asp:Button ID="btnOK" runat="server" Text="Save" OnClick="btnOK_Click" />
        </div>
    </form>
</body>
</html>