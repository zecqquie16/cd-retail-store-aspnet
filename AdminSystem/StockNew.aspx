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
        <asp:Image ID="imgCover" runat="server" style="z-index: 1; left: 264px; top: 207px; position: absolute; height: 328px; width: 391px" />
        <asp:Label ID="lblTitle" runat="server" style="z-index: 1; left: 899px; top: 182px; position: absolute; height: 49px; width: 388px" Text="Titre" Font-Bold="True" Font-Overline="False" Font-Size="XX-Large" Font-Strikeout="False"></asp:Label>
        
        <asp:Label ID="lblArtistName" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="Medium" style="z-index: 1; left: 1069px; top: 242px; position: absolute; width: 210px; height: 25px" Text="ArtistName"></asp:Label>
        <asp:Label ID="lblGenre" runat="server" style="z-index: 1; left: 1096px; top: 287px; position: absolute; width: 128px" Text="Genre"></asp:Label>
        <asp:Panel ID="pnlAbout" runat="server" BorderStyle="Solid" style="z-index: 1; left: 790px; top: 165px; position: absolute; height: 380px; width: 630px">
            <asp:Label ID="lbl1" runat="server" style="z-index: 1; left: 82px; top: 74px; position: absolute" Text="Artist :"></asp:Label>
            <asp:Label ID="lbl2" runat="server" style="z-index: 1; left: 74px; top: 117px; position: absolute; height: 25px" Text="Musical genre: "></asp:Label>
            <asp:Button ID="btnBuy" runat="server" Font-Bold="True" Font-Size="Large" Height="60px" style="z-index: 1; left: 219px; top: 275px; position: absolute; bottom: 45px; width: 216px" Text="Buy/Add to cart" />
            <asp:DropDownList ID="ddlEdition" runat="server" AutoPostBack= "true" OnSelectedIndexChanged="ddlEdition_SelectedIndexChanged" style="z-index: 1; left: 243px; top: 161px; position: absolute; width: 166px">
            </asp:DropDownList>
            <asp:Label ID="lbl4" runat="server" style="z-index: 1; left: 76px; top: 212px; position: absolute; height: 25px; right: 506px" Text="Price: "></asp:Label>
            <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 305px; top: 213px; position: absolute; width: 94px" Text="Price"></asp:Label>
        </asp:Panel>
        <asp:Label ID="lblReleaseDate0" runat="server" style="z-index: 1; left: 1285px; top: 192px; position: absolute; width: 120px" Text="ReleaseDate"></asp:Label>
        <asp:Label ID="lbl3" runat="server" style="z-index: 1; left: 867px; top: 327px; position: absolute; height: 25px" Text="Edition:"></asp:Label>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; left: 122px; top: 587px; position: absolute; width: 146px" Text="Description"></asp:Label>
        <asp:Label ID="lblDescription" runat="server" style="z-index: 1; left: 123px; top: 631px; position: absolute; height: 361px; width: 1241px" Text="Description Here.."></asp:Label>
        
        <asp:Button ID="btnDisplayToMain" runat="server" OnClick="btnEntryToMain_Click" style="z-index: 1; left: 931px; position: absolute; width: 177px; top: 587px" Text="Return to main menu" />
        
    </form>
</body>
</html>
