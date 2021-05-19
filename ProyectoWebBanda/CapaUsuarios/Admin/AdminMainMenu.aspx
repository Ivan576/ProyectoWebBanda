<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminMainMenu.aspx.cs" Inherits="ProyectoWebBanda.CapaUsuarios.Admin.AdminMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" href="CSS/CommonHeader.css" />
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
        <div>
        </div>
    </form>

</body>
</html>
