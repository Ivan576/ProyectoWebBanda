<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Evento.aspx.cs" Inherits="ProyectoWebBanda.CapaUsuarios.Eventos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="CSS/Eventos.css"/>
    <link rel="stylesheet" href="CSS/CommonStyles.css"/>
    <link rel="stylesheet" href="CSS/CommonHeader.css"/>
    
    <!-- End CSS classes -->
    <!-- End CSS classes -->

    <!-- Bootstrap -->
    <!-- CSS only Bootstrap -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-eOJMYsd53ii+scO/bJGFsiCZc+5NDVN2yr8+0RDqr0Ql0h+rP48ckxlpbzKgwra6" crossorigin="anonymous">
    <!-- JavaScript Bundle with Popper Bootstrap -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/js/bootstrap.bundle.min.js" integrity="sha384-JEW9xMcG8R+pH31jmWH6WWP0WintQrMb4s7ZOdauHnUtxwoG2vI5DkLtS3qm9Ekf" crossorigin="anonymous"></script>
    <!-- End Bootstrap -->

    <!-- Font Nunito from Google fonts -->
    <link rel="preconnect" href="https://fonts.gstatic.com">
    <link href="https://fonts.googleapis.com/css2?family=Nunito:ital,wght@0,400;0,600;1,400&display=swap" rel="stylesheet">
    <!-- End Font Nunito from Google fonts -->
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


    <div id="carouselExampleFade" class="carousel slide carousel-fade" data-bs-ride="carousel">
        <div class="carousel-inner">
            <div class="carousel-item active">
                        <img src="../Recursos/Imagenes/Eventos/Evento1.PNG" class="d-block w-100" alt="...">
            </div>
            <div class="carousel-item">
                        <img src="../Recursos/Imagenes/Fotos/carousel2.jpg" class="d-block w-100" alt="...">
            </div>
            <div class="carousel-item">
                        <img src="../Recursos/Imagenes/Fotos/carousel3.jpg" class="d-block w-100" alt="...">
            </div>
        </div>
    </div>


    <div class="eventSection parentCenter">
                <div class="childCenter">
                   
                    <h1>Eventos</h1>
                    <table class="eventTable">
                         
                        <tr>
                            <th>Fecha</th>
                            <th>Nombre</th>
                            <th>Ubicación</th>
                            <th>Link</th>
                        </tr>


                        <tr>
                            <td>
                                <span id="fecha0" runat="server"></span>
                            </td>

                            <td class="rowName">
                                <span id="nombre0" runat="server"></span>
                            </td>

                            <td>
                                <span id="ubicacion0" runat="server"></span>
                            </td>

                            <td>
                                <a id="link0" href="#" runat="server"></a>
                            </td>
                        </tr>


                        <tr>
                            <td>
                                <span id="fecha1" runat="server"></span>
                            </td>

                            <td class="rowName">
                                <span id="nombre1" runat="server"></span>
                            </td>

                            <td>
                                <span id="ubicacion1" runat="server"></span>
                            </td>

                            <td>
                                <a id="link1" href="#" runat="server"></a>
                            </td>
                        </tr>
                        

                        <tr>
                            <td>
                                <span id="fecha2" runat="server"></span>
                            </td>

                            <td class="rowName">
                                <span id="nombre2" runat="server"></span>
                            </td>

                            <td>
                                <span id="ubicacion2" runat="server"></span>
                            </td>

                            <td>
                                <a id="link2" href="#" runat="server"></a>
                            </td>
                        </tr>
                        

                        <tr>
                            <td>
                                <span id="fecha3" runat="server"></span>
                            </td>

                            <td class="rowName">
                                <span id="nombre3" runat="server"></span>
                            </td>

                            <td>
                                <span id="ubicacion3" runat="server"></span>
                            </td>

                            <td>
                                <a id="link3" href="#" runat="server"></a>
                            </td>
                        </tr>
                        

                        <tr>
                            <td>
                                <span id="fecha4" runat="server"></span>
                            </td>

                            <td class="rowName">
                                <span id="nombre4" runat="server"></span>
                            </td>

                            <td>
                                <span id="ubicacion4" runat="server"></span>
                            </td>

                            <td>
                                <a id="link4" href="#" runat="server"></a>
                            </td>
                        </tr>
                        

                        <tr>
                            <td>
                                <span id="fecha5" runat="server"></span>
                            </td>

                            <td class="rowName">
                                <span id="nombre5" runat="server"></span>
                            </td>

                            <td>
                                <span id="ubicacion5" runat="server"></span>
                            </td>

                            <td>
                                <a id="link5" href="#" runat="server"></a>
                            </td>
                        </tr>
                        

                        <tr>
                            <td>
                                <span id="fecha6" runat="server"></span>
                            </td>

                            <td class="rowName">
                                <span id="nombre6" runat="server"></span>
                            </td>

                            <td>
                                <span id="ubicacion6" runat="server"></span>
                            </td>

                            <td>
                                <a id="link6" href="#" runat="server"></a>
                            </td>
                        </tr>

                    </table>
                   
                </div>
            </div>

             <%--<footer class="footerMain parentCenter">
                <div class="childCenter">
                    <img class="footerLogo" src="../Recursos/Imagenes/Logos/120millas logo.png" />
                    <div class="socialMediaFooter">
                        <a href="https://www.instagram.com/120_millas/" target="_blank"><img class="instagramFooter" src="../Recursos/Imagenes/Logos/instagram.png" /></a>
                        <a href="https://www.facebook.com/120millasoficial" target="_blank"><img class="facebookFooter" src="../Recursos/Imagenes/Logos/Facebook.png" /></a>
                        <a href="https://www.youtube.com/channel/UCp69-Fpky33cpcQC7ufcU_g" target="_blank"><img class="youtubeFooter" src="../Recursos/Imagenes/Logos/Youtube.png" /></a>
                    </div>
                    <p>
                        120 millas®, todos los derechos reservados.
                    </p>
                </div>
            </footer>--%>

            </div>
    </form>
</body>
</html>
