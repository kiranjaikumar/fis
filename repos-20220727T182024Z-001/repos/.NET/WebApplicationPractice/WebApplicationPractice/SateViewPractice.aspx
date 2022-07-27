<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SateViewPractice.aspx.cs" Inherits="WebApplicationPractice.SateViewPractice" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Example Of ViewState<br />
        <br />
        <asp:Label ID="usernameLabel" runat="server" Text="Username"></asp:Label>
        &nbsp;&nbsp;
        <asp:TextBox ID="Username" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="passwordLabel" runat="server" Text="Password"></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Password" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="StoreBtn" runat="server" Text="Store" OnClick="StoreBtn_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="LoadBtn" runat="server" Text="Load" OnClick="LoadBtn_Click" />
        <br />
        <br />
        <asp:Label ID="MsgLabel" runat="server" Text=""></asp:Label>
    </form>


    
</body>
</html>
