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
        <p>
            <asp:Button ID="btnAgregarEvento" runat="server" OnClick="btnAgregarEvento_Click" style="margin-left: 17px" Text="Agregar" Width="65px" />
            <asp:Button ID="btnEditar" runat="server" OnClick="btnEditar_Click" style="margin-left: 23px" Text="Editar" />
            <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" style="margin-left: 25px" Text="Eliminar" />
        </p>
        <asp:Label ID="lblNotifu" runat="server"></asp:Label>
        <asp:GridView ID="gvEventos" runat="server">
        </asp:GridView>
        <p>
            <asp:Label ID="Label6" runat="server" Text="Escribe el id del evento para eliminar o editar"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtId" runat="server" style="margin-top: 0px"></asp:TextBox>
            <asp:Button ID="btnCargar" runat="server" OnClick="btnCargar_Click" style="margin-left: 16px" Text="Cargar datos para editar" />
        </p>
    </form>
</body>
</html>
