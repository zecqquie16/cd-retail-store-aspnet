<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 739px;
        }
    </style>
</head>
<body style="height: 631px">
    <form id="form1" runat="server">
        
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 266px; top: 437px; position: absolute; height: 33px; width: 82px" Text="Delete" />
        
        <asp:ListBox ID="lstAlbumList" runat="server" style="z-index: 1; left: 246px; top: 57px; position: absolute; height: 342px; width: 768px; margin-top: 0px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"></asp:ListBox>
        
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 633px; top: 434px; position: absolute; height: 37px; width: 87px" Text="Add" OnClick="btnAdd_Click" />
        
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 461px; top: 434px; position: absolute; height: 37px; width: 87px" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 876px; top: 436px; position: absolute"></asp:Label>
        
        <asp:Label ID="lblFilter" runat="server" style="z-index: 1; left: 1039px; top: 85px; position: absolute" Text="Enter an album Title:"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 1219px; top: 85px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 1149px; top: 155px; position: absolute" Text="Apply" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 1294px; top: 154px; position: absolute" Text="Clear" />
        
    </form>
</body>
</html>
