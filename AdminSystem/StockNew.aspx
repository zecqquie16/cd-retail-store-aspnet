<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockNew.aspx.cs" Inherits="_1_Nouveau" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 1328px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        
        <asp:Image ID="imgLogo" runat="server" ImageUrl="~/StockOnTheRacksLogo.png" style="z-index: 1; left: 76px; top: 35px; position: absolute; width: 217px; height: 107px" />
        <asp:Image ID="imgCover" runat="server" style="z-index: 1; left: 270px; top: 170px; position: absolute; height: 328px; width: 391px" />
        <asp:Label ID="lblTitle" runat="server" style="z-index: 1; left: 849px; top: 150px; position: absolute; height: 30px; width: 362px" Text="Titre"></asp:Label>
        
    </form>
</body>
</html>
