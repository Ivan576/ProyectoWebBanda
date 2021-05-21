<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CatalogoMultimedia.aspx.cs" Inherits="ProyectoWebBanda.CapaUsuarios.CatalogoMultimedia" %>

<!DOCTYPE html>
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
    <form id="form1" runat="server">
     <div class="row">
        <div class="col s12 center-align">
            <h1 class="titulo">Catalogo multimedia</h1>
            <asp:Panel ID="Panel1" runat="server" Height="66px">
            </asp:Panel>
        </div>
     </div>
        idMultimedia<asp:TextBox ID="txtIdMultimedia" runat="server" Width="339px"></asp:TextBox>
        <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" Width="61px" />
        <br />
        <asp:Label ID="lblLinkName" runat="server" Text="titulo"></asp:Label>
        <asp:TextBox ID="txtitulo" runat="server" Width="401px"></asp:TextBox>
        <p>
            <asp:Label ID="lblImagen" runat="server" Text="formato"></asp:Label>
            <asp:TextBox ID="txtFormato" runat="server" Width="379px"></asp:TextBox>
        </p>
        <asp:Label ID="Label1" runat="server" Text="link"></asp:Label>
        <asp:TextBox ID="txtlink" runat="server" Width="410px"></asp:TextBox>
        <asp:GridView ID="gvVinvulos" runat="server">
        </asp:GridView>
        <p>
            <asp:Button ID="btnMultimediaAgregar" runat="server" Text="Agregar" OnClick="btnMultimediaAgregar_Click" style="height: 26px" />
            <asp:Button ID="btnMultimediaEditar" runat="server" Text="Editar" OnClick="btnVinvuloEditar_Click" />
        <asp:Button ID="btnMultimediaEliminar" runat="server" Text="Eliminar" OnClick="btnVinculoEliminar_Click" />
        </p>
    </form>
</body>
</html>
