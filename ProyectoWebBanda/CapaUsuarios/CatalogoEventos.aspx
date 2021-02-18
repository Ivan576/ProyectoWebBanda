<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CatalogoEventos.aspx.cs" Inherits="ProyectoWebBanda.CapaUsuarios.CatalogoEventos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Catalogo de Eventos<p>
            <asp:Label ID="Label1" runat="server" Text="Nombre del Evento"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server" style="margin-left: 8px" Width="219px"></asp:TextBox>
        </p>
        <asp:Label ID="Label2" runat="server" Text="Fecha"></asp:Label>
        <asp:TextBox ID="txtFecha" runat="server" style="margin-left: 10px" Width="249px"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" Text="Formato: AAAA-MM-DD HH: MM: SS"></asp:Label>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Ubicacion"></asp:Label>
            <asp:TextBox ID="txtUbicacion" runat="server" style="margin-left: 12px" Width="229px"></asp:TextBox>
        </p>
        <asp:Label ID="Label4" runat="server" Text="Link"></asp:Label>
        <asp:TextBox ID="txtLink" runat="server" style="margin-left: 7px" Width="276px"></asp:TextBox>
    </form>
</body>
</html>
