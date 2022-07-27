<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CookieTest.aspx.cs" Inherits="WebApplicationPractice.CookieTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="username" runat="server" Text="Username"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="usernameText" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="password" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="passwordText" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="RedirectBtn" runat="server" Text="Redirect" OnClick="RedirectBtn_Click" />
        <br />
    </form>
</body>
</html>
