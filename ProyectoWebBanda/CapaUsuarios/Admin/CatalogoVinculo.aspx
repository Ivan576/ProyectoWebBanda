<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CatalogoVinculo.aspx.cs" Inherits="ProyectoWebBanda.CapaUsuarios.Admin.CatalogoVinculo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="../CSS/CommonStyles.css" />
    <link rel="stylesheet" href="../CSS/Multimedia.css" />
    <link rel="stylesheet" href="../CSS/estilos.css">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <div class="header">
        <a class="logo">
            <img src="../../Recursos/Imagenes/Logos/120millas logo.png" />
        </a>
        <input class="menu-btn" type="checkbox" id="menu-btn" />
        <label class="menu-icon" for="menu-btn"><span class="navicon"></span></label>
        <ul class="menu">
            <li><a href="CatalogoAlbum.aspx">Album</a></li>
            <li><a href="CatalogoCanciones.aspx">Canciones</a></li>
            <li><a href="CatalogoEventos.aspx">Eventos</a></li>
            <li><a href="CatalogoMultimedia.aspx">Multimedia</a></li>
            <li><a href="CatalogoNoticias.aspx">Noticias</a></li>
            <li><a href="CatalogoVinculos.aspx">Vinculos</a></li>
        </ul>
    </div>
     <div class="row">
               <div class="col s12 center-align">
                    <h1 class="titulo">CatalogoVinculos</h1>
               </div>
          </div>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Panel ID="Panel1" runat="server">
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server">
            <asp:Label ID="txt" runat="server" Text="id"></asp:Label>
            <asp:TextBox ID="txtVinculo" runat="server" Width="298px"></asp:TextBox>
            <asp:Button ID="btnSelecionar" runat="server" OnClick="btnSelecionar_Click" Text="seleciona" />
        </asp:Panel>
        <asp:Panel ID="Panel3" runat="server">
            <asp:Label ID="Label2" runat="server" Text="Nombre vinculo"></asp:Label>
            <asp:TextBox ID="txtNombreVinculo" runat="server" Width="296px"></asp:TextBox>
        </asp:Panel>
        <asp:Panel ID="Panel4" runat="server">
            <asp:Label ID="Label3" runat="server" Text="Nombre imagen"></asp:Label>
            <asp:TextBox ID="txtImagen" runat="server" Width="294px"></asp:TextBox>
        </asp:Panel>
        <asp:Panel ID="Panel5" runat="server">
            <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
            <asp:Button ID="btnEditar" runat="server" OnClick="btnEditar_Click" Text="Editar" />
            <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" />
        </asp:Panel>
        <asp:GridView ID="gvVinculo" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
