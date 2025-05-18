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
        
        <asp:ListBox ID="lstAlbumList" runat="server" style="z-index: 1; left: 319px; top: 43px; position: absolute; height: 342px; width: 768px; margin-top: 0px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"></asp:ListBox>
        
    </form>
</body>
</html>
