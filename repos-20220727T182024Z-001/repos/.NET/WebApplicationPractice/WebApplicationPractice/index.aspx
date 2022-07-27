<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebApplicationPractice.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:40%;">
                <tr>
                    <td>Username</td>
                    <td><asp:TextBox ID="username" runat="server" /></td>
                    
                </tr>
                <tr>
                    <td>Password</td>
                    <td><asp:TextBox ID="password" runat="server" /></td>
                    
                </tr>
                <tr>
                    <td colspan="2">&nbsp;<asp:Button ID="loginbtn" Text="Login" runat="server" PostBackUrl="~/Home.aspx" OnClick="loginbtn_Click"/></td>
                   
                   
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
