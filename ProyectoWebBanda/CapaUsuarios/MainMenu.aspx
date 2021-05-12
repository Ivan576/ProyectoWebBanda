<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainMenu.aspx.cs" Inherits="ProyectoWebBanda.CapaUsuarios.MainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <!-- CSS classes -->
    <link rel="stylesheet" href="CSS/MainMenu.css" />
    <link rel="stylesheet" href="CSS/CommonStyles.css" />
    <link rel="stylesheet" href="CSS/CommonHeader.css" />
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
                    <li><a href="#work">Música</a></li>
                    <li><a href="#about">Eventos</a></li>
                    <li><a href="#careers">Noticias</a></li>
                    <li><a href="#contact">Multimedia</a></li>
                </ul>
            </div>
            <div id="carouselExampleFade" class="carousel slide carousel-fade" data-bs-ride="carousel">
                <div class="carousel-inner">
                    <div class="carousel-item active">
                        <img src="../Recursos/Imagenes/Fotos/carousel1.jpg" class="d-block w-100" alt="...">
                    </div>
                    <div class="carousel-item">
                        <img src="../Recursos/Imagenes/Fotos/carousel2.jpg" class="d-block w-100" alt="...">
                    </div>
                    <div class="carousel-item">
                        <img src="../Recursos/Imagenes/Fotos/carousel3.jpg" class="d-block w-100" alt="...">
                    </div>
                    <div class="carousel-item">
                        <img src="../Recursos/Imagenes/Fotos/carousel4.jpg" class="d-block w-100" alt="...">
                    </div>
                    <div class="carousel-item">
                        <img src="../Recursos/Imagenes/Fotos/carousel5.jpg" class="d-block w-100" alt="...">
                    </div>
                </div>
            </div>
            <div class="discSection parentCenter">
                <div class="discInfoContainer childCenter">
                    <a href="#">
                        <div class="imageDisc"></div>
                    </a>
                    <h2>Amor en desamor</h2>
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
                                <span id="dateOne" runat="server"></span>
                            </td>
                            <td class="rowName">
                                <span id="nameOne" runat="server"></span>
                            </td>
                            <td>
                                <span id="placeOne" runat="server"></span>
                            </td>
                            <td><a id="linkOne" href="#" runat="server">www.cupuato.com</a></td>
                        </tr>
                        <tr>
                            <td>05/05/2021</td>
                            <td class="rowName">Cupuato Fest</td>
                            <td>Cupuato</td>
                            <td><a href="#">www.cupuato.com</a></td>
                        </tr>
                        <tr>
                            <td>05/05/2021</td>
                            <td class="rowName">Cupuato Fest</td>
                            <td>Cupuato</td>
                            <td><a href="#">www.cupuato.com</a></td>
                        </tr>
                    </table>
                    <button id="btnDates" class="brownButton" type="button" runat="server" onserverclick="btnDates_Click">Más fechas</button>
                </div>
            </div>
            <div class="socialMedia row align-items-center">
                <div class="col-4 col-md-4 col-sm-12 parentCenter">
                    <div class="facebookImg childCenter"></div>
                </div>
                <div class="col-4 col-md-4 col-sm-12 parentCenter">
                    <div class="instagramImg childCenter"></div>
                </div>
                <div class="col-4 col-md-4 col-sm-12  parentCenter">
                    <div class="youtubeImg childCenter"></div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
