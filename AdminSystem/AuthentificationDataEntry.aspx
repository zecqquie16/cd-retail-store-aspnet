<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AuthentificationDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Information Entry</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="padding: 20px; font-family: Arial, sans-serif; max-width: 500px;">
            <asp:Label ID="lblMessage" runat="server" ForeColor="Green" />

            <!-- Customer ID -->
            <asp:Label ID="Label1" runat="server" Text="Customer ID: "></asp:Label>
            <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
            <br /><br />

            <!-- Customer Name -->
            <asp:Label ID="Label2" runat="server" Text="Customer Name: "></asp:Label>
            <asp:TextBox ID="txtCustomerName" runat="server"></asp:TextBox>
            <br /><br />

            <!-- Phone -->
            <asp:Label ID="Label3" runat="server" Text="Phone: "></asp:Label>
            <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
            <br /><br />

            <!-- Email -->
            <asp:Label ID="Label4" runat="server" Text="Email: "></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br /><br />

            <!-- Billing Address -->
            <asp:Label ID="Label5" runat="server" Text="Billing Address: "></asp:Label>
            <asp:TextBox 
                ID="txtBillingAddress" 
                runat="server" 
                TextMode="MultiLine" 
                Rows="3" 
                Columns="30" 
                AutoPostBack="True"
                OnTextChanged="txtBillingAddress_TextChanged">
            </asp:TextBox>
            <br /><br />

            <!-- Password -->
            <asp:Label ID="Label6" runat="server" Text="Password: "></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <br /><br />

            <!-- Active Checkbox -->
            <asp:CheckBox ID="chkActive" runat="server" Text="Active" />
            <br /><br />

            <!-- Buttons -->
            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
            &nbsp;
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" Width="72px" />

        </div>
    </form>
</body>
</html>
