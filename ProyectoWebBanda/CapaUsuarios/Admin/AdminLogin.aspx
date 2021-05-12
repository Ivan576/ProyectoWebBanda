<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="ProyectoWebBanda.CapaUsuarios.Admin.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server">
                <asp:Label ID="lblUserLogin" runat="server" Text="UserLogin"></asp:Label>
            </asp:Panel>
        </div>
        <asp:Panel ID="Panel2" runat="server">
            <asp:Label ID="lbluser" runat="server" Text="User"></asp:Label>
            <asp:TextBox ID="txtUser" runat="server">User</asp:TextBox>
        </asp:Panel>
        <asp:Label ID="lblPasword" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" OnTextChanged="txtPassword_TextChanged" TextMode="Password">password</asp:TextBox>
        <p>
            <asp:Button ID="btnLog" runat="server" Text="Log" OnClick="btnLog_Click" style="height: 26px" />
        </p>
    </form>
</body>
</html>
