<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <style>
  html, body, form 
  {
      height: 100%;
      margin: 0;
      padding: 0;
      background-color: #00051F;
  }
    </style>
</head>
<body style="height: 855px">
    <form id="StockListPage" runat="server" style="background-color:#00051F; height:100%">
        
        <asp:ListBox ID="lstAlbumList" runat="server"  BorderColor="#444" BorderStyle="Solid" BorderWidth="1px" style=" border-radius: 6px; padding: 6px; z-index: 1; left: 264px; top: 346px; position: absolute; height: 342px; width: 768px; margin-top: 0px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" BackColor="#00051F" ForeColor="White" Rows="6" Width="300px"></asp:ListBox>
        
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 389px; top: 742px; position: absolute; height: 37px; width: 87px" Text="Add" OnClick="btnAdd_Click" BackColor="#48A388" BorderColor="#48A388" BorderStyle="Double" ForeColor="White" />
        
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 283px; top: 741px; position: absolute; height: 37px; width: 87px; right: 1108px;" Text="Edit" BackColor="#48A388" BorderColor="#48A388" BorderStyle="Double" ForeColor="White" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 1047px; top: 533px; position: absolute" ForeColor="White"></asp:Label>
        
        <asp:Label ID="lblFilter" runat="server" style="z-index: 1; left: 1065px; top: 291px; position: absolute" Text="Search" ForeColor="White"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 1128px; top: 289px; position: absolute; width: 204px;" TextMode="Search" ToolTip="Enter an album title." OnTextChanged="txtFilter_TextChanged"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 1173px; top: 357px; position: absolute" Text="Apply" BackColor="#48A388" BorderColor="#48A388" BorderStyle="Double" ForeColor="White" ToolTip="Applies Filter" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 1293px; top: 358px; position: absolute" Text="Clear" ToolTip="Clears filter" />
        
        <asp:Button ID="btnDisplay" runat="server" OnClick="btnDisplay_Click" style="z-index: 1; left: 593px; top: 719px; position: absolute; height: 68px; width: 135px" Text="Display Album" BackColor="#48A388" BorderColor="#48A388" ForeColor="White" />
        
        <asp:Image ID="imgLogo" runat="server" ImageUrl="~/OnTheRocksLogoV4.png" style="z-index: 1; left: 32px; top: 10px; position: absolute; height: 190px; width: 245px" BackColor="Black" BorderStyle="None" />
        
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 152px; top: 743px; position: absolute; height: 37px; width: 87px" Text="Delete" BackColor="#48A388" BorderColor="#48A388" BorderStyle="Double" ForeColor="White" />
        
      
       
        <asp:Label ID="lblTitle" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="X-Large" ForeColor="White" style="z-index: 1; left: 60px; top: 208px; position: absolute; height: 36px; width: 478px" Text="Browse Our Collection"></asp:Label>
        <asp:Label ID="lblTitle0" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="X-Large" ForeColor="White" style="z-index: 1; left: 60px; top: 208px; position: absolute; height: 36px; width: 478px" Text="Browse Our Collection"></asp:Label>
        <asp:Label ID="lblParagraph" runat="server" Font-Names="Arial" Font-Size="Large" ForeColor="White" style="z-index: 1; left: 59px; top: 251px; position: absolute; width: 842px" Text="From legendary albums to hidden gems — use the search bar to explore and enjoy our handpicked music collection. "></asp:Label>
        
      
       
        <asp:Label ID="lblUser" runat="server" ForeColor="White" style="z-index: 1; left: 337px; top: 44px; position: absolute; width: 417px"></asp:Label>
        <asp:Button ID="btnLogOut" runat="server" BackColor="#48A388" BorderColor="#48A388" BorderStyle="Double" ForeColor="White" OnClick="btnLogOut_Click" style="z-index: 1; left: 331px; top: 77px; position: absolute; height: 35px; width: 95px" Text="Log Out" Visible="False" />
        <asp:Button ID="btnRegister" runat="server" BackColor="#48A388" BorderColor="#48A388" BorderStyle="Double" ForeColor="White" OnClick="btnRegister_Click" style="z-index: 1; left: 1078px; top: 41px; position: absolute; height: 42px; width: 94px" Text="Register" />
        
        <asp:Button ID="btnListToMain" runat="server" OnClick="btnEntryToMain_Click" style="z-index: 1; left: 1247px; position: absolute; width: 184px; top: 35px; height: 46px;" Text="Return to main menu" BackColor="#48A388" BorderColor="#48A388" ForeColor="White" BorderStyle="Double" />
        
        <asp:Button ID="btnUserLog" runat="server" BackColor="#48A388" BorderColor="#48A388" BorderStyle="Double" ForeColor="White" OnClick="btnUserLog_Click" style="z-index: 1; left: 954px; top: 44px; position: absolute; height: 37px; width: 80px; bottom: 495px" Text="Login" />
        <asp:Button ID="btnStaff" runat="server" BackColor="#48A388" BorderColor="#48A388" BorderStyle="Double" ForeColor="White" OnClick="btnStaff_Click" style="z-index: 1; left: 774px; top: 43px; position: absolute; height: 38px; width: 139px" Text="Staff Gateway" />
        
      
       
    </form>
</body>
</html>
