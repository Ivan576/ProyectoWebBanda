﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Evento.aspx.cs" Inherits="ProyectoWebBanda.CapaUsuarios.Eventos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="CSS/CommonStyles.css" />
    <link rel="stylesheet" href="CSS/CommonHeader.css" />
    <link rel="stylesheet" href="CSS/Eventos.css" />
    <style>
        
    </style>
    <!-- CSS only -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-eOJMYsd53ii+scO/bJGFsiCZc+5NDVN2yr8+0RDqr0Ql0h+rP48ckxlpbzKgwra6" crossorigin="anonymous">
    <!-- JavaScript Bundle with Popper -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/js/bootstrap.bundle.min.js" integrity="sha384-JEW9xMcG8R+pH31jmWH6WWP0WintQrMb4s7ZOdauHnUtxwoG2vI5DkLtS3qm9Ekf" crossorigin="anonymous"></script>
    <title></title>
</head>
<body>
    <div class="header">
        <a href="" class="logo">
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
                                <span id="fecha" runat="server"></span>
                            </td>

                            <td class="rowName">
                                <span id="nombre" runat="server"></span>
                            </td>

                            <td>
                                <span id="ubicacion" runat="server"></span>
                            </td>

                            <td>
                                <a id="link" href="#" runat="server"></a>
                            </td>

                        </tr>
                        
                    </table>
                   
                </div>
            </div>

</body>
</html>
