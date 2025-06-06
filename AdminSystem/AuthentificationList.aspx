<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AuthentificationList.aspx.cs" Inherits="AuthentificationList" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Costumer List</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Costumer List</h2>
        <asp:GridView ID="gvCostumers" runat="server" AutoGenerateColumns="False" DataKeyNames="CostumerID">
            <Columns>
                <asp:BoundField DataField="CostumerID" HeaderText="ID" />
                <asp:BoundField DataField="CostumerName" HeaderText="Name" />
                <asp:BoundField DataField="EmailAddress" HeaderText="Email" />
                <asp:BoundField DataField="PhoneNumber" HeaderText="Phone" />
                <asp:TemplateField HeaderText="Actions">
                    <ItemTemplate>
                        <a href='AuthentificationDataEntry.aspx?CostumerID=<%# Eval("CostumerID") %>'>Edit</a> |
                        <a href='AuthentificationConfirmDelete.aspx?CostumerID=<%# Eval("CostumerID") %>'>Delete</a>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <br />
        <asp:Button ID="btnAddNew" runat="server" Text="Add New Costumer" OnClick="btnAddNew_Click" />
    </form>
</body>
</html>