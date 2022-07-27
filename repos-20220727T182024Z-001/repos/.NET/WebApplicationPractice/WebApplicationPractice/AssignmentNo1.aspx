<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AssignmentNo1.aspx.cs" Inherits="WebApplicationPractice.AssignmentNo1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Select1 {
            height: 14px;
            width: 133px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="productimg" ImageUrl = "" runat="server" Height="92px" Width="171px" />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="132px" AutoPostBack="True">
     <asp:ListItem>Select Product</asp:ListItem>            
    <asp:ListItem Value="s22">Samsung S22 Ultra</asp:ListItem>
                <asp:ListItem Value="13 Pro">Iphone 13 Pro</asp:ListItem>
                <asp:ListItem Value="N1">Nothing 1</asp:ListItem>
            </asp:DropDownList>
&nbsp;<br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="CheckBtn" runat="server" Text="Show Price" OnClick="CheckBtn_Click" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
