<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 744px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
      
        <asp:Label ID="lblConfirm" runat="server" style="z-index: 1; left: 407px; top: 101px; position: absolute; width: 369px; height: 24px" Text="Are you sure you want to delete this record ? "></asp:Label>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 499px; top: 156px; position: absolute" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 626px; top: 156px; position: absolute; width: 45px" Text="No" />
        
        </asp:Panel>
      
    </form>
</body>
</html>
