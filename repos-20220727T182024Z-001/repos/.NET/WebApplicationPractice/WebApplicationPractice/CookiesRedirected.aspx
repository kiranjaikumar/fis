<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CookiesRedirected.aspx.cs" Inherits="WebApplicationPractice.CookiesRedirected" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="cookieMsg" runat="server" Text=""></asp:Label>
            <br />
        </div>
        <asp:Button ID="LoadFromCookie" runat="server" Text="Retrive" OnClick="LoadFromCookie_Click" />
    </form>
</body>
</html>
