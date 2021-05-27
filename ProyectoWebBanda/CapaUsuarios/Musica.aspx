<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Musica.aspx.cs" Inherits="ProyectoWebBanda.CapaUsuarios.Música" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="CSS/Musica.css" />
    <style>
        
    </style>
    <link rel="stylesheet" href="CSS/CommonStyles.css" />
    <link rel="stylesheet" href="CSS/CommonHeader.css" />
    <!-- CSS only -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-eOJMYsd53ii+scO/bJGFsiCZc+5NDVN2yr8+0RDqr0Ql0h+rP48ckxlpbzKgwra6" crossorigin="anonymous">
    <!-- JavaScript Bundle with Popper -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/js/bootstrap.bundle.min.js" integrity="sha384-JEW9xMcG8R+pH31jmWH6WWP0WintQrMb4s7ZOdauHnUtxwoG2vI5DkLtS3qm9Ekf" crossorigin="anonymous"></script>

    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="header">
                <a class="logo">
                    <img src="../Recursos/Imagenes/Logos/120millas logo.png" />
                </a>
                <input class="menu-btn" type="checkbox" id="menu-btn" />
                <label class="menu-icon" for="menu-btn"><span class="navicon"></span></label>
                <ul class="menu">
                    <li><a href="Musica.aspx">Música</a></li>
                    <li><a href="Evento.aspx">Eventos</a></li>
                    <li><a href="Noticia.aspx">Noticias</a></li>
                    <li><a href="Multimedia.aspx">Multimedia</a></li>
                </ul>
            </div>
            <div id="songsContent" runat="server">                
            </div>
        </div>
    </form>
</body>
</html>
