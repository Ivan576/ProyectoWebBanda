<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CatalogoCanciones.aspx.cs" Inherits="ProyectoWebBanda.CapaUsuarios.Admin.CatalogoCanciones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-eOJMYsd53ii+scO/bJGFsiCZc+5NDVN2yr8+0RDqr0Ql0h+rP48ckxlpbzKgwra6" crossorigin="anonymous">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Catálogo de Música</h1>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server" style="margin-left: 8px" Width="223px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Duración"></asp:Label>
            <asp:TextBox ID="txtDuracion" runat="server" style="margin-left: 8px"></asp:TextBox>
            <asp:Label ID="Label6" runat="server" Text="Formato: HH:MM:SS"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Género"></asp:Label>
            <asp:TextBox ID="txtGenero" runat="server" style="margin-left: 8px" Width="182px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="ID de Albun"></asp:Label>
            <asp:TextBox ID="txtidAlbum" runat="server" style="margin-left: 8px" Width="60px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="ID de Plataforma"></asp:Label>
            <asp:TextBox ID="txtidPlataforma" runat="server" style="margin-left: 8px" Width="71px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnAgregar" Class="btn btn-outline-primary" runat="server" Style="margin-left: 17px" Text="Agregar" OnClick="btnAgregar_Click" />
            <asp:Button ID="btnEditar" Class="btn btn-outline-primary" runat="server" style="margin-left: 24px" Text="Editar" />
            <asp:Button ID="btnEliminar" Class="btn btn-outline-danger" runat="server" style="margin-left: 24px" Text="Eliminar" />
            <br />
            <br />
            <asp:Label ID="lblNotify" runat="server"></asp:Label>
            <br />
            <asp:GridView ID="gvCanciones" runat="server">
            </asp:GridView>
            <br />
                <asp:Label ID="Label7" runat="server" Text="Escribe el id de la cancion para eliminar o editar"></asp:Label>
                <br />
            <br />
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <asp:Button ID="btnCargar" Class="btn btn-outline-info" runat="server" style="margin-left: 16px" Text="Cargar datos para editar" />
        </div>
    </form>
</body>
</html>
