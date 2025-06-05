<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

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
<body>
        <form id="StockDetails" runat="server" style="background-color:#00051F; height:100%">
      
        <asp:Label ID="lblConfirm" runat="server" style="z-index: 1; left: 607px; top: 250px; position: absolute; width: 360px; height: 24px" Text="Are you sure you want to delete this record ? " ForeColor="White"></asp:Label>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 655px; top: 310px; position: absolute" Text="Yes" BackColor="#48A388" BorderColor="#48A388" BorderStyle="Double" ForeColor="White" />
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 818px; top: 310px; position: absolute; width: 45px" Text="No" BackColor="#48A388" BorderColor="#48A388" BorderStyle="Double" ForeColor="White" />
         <asp:Image ID="imgLogo" runat="server" ImageUrl="~/OnTheRocksLogoV4.png" style="z-index: 1; left: 76px; top: 35px; position: absolute; width: 217px; height: 107px" />
              <asp:Label ID="lblUser2" runat="server" ForeColor="White" style="z-index: 1; left: 310px; top: 43px; position: absolute; width: 366px"></asp:Label>
  <asp:Button ID="btnLogOut2" runat="server" BackColor="#48A388" BorderColor="#48A388" BorderStyle="Double" ForeColor="White" OnClick="btnLogOut_Click" style="z-index: 1; left: 446px; top: 99px; position: absolute; height: 54px" Text="Log Out" Visible="False" width="94px" />
       
      
        
      
    </form>
</body>
</html>
