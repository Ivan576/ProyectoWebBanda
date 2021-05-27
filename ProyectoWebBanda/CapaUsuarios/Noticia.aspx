<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Noticia.aspx.cs" Inherits="ProyectoWebBanda.CapaUsuarios.Noticias" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="CSS/Noticia.css"/>
    <link rel="stylesheet" href="CSS/CommonHeader.css"/>
    <link rel="stylesheet" href="CSS/CommonColumns.css"/>
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
                    <li><a href="Musica.aspx">Música</a></li>
                    <li><a href="Evento.aspx">Eventos</a></li>
                    <li><a href="Noticia.aspx">Noticias</a></li>
                    <li><a href="Multimedia.aspx">Multimedia</a></li>
        </ul>
    </div>


    <main class="container">
        
        
        <div class="lrow lcol-2 lcol-md-1 lcol-sm-1">
              
            <article class="art">
              
                <header>
               <h2><span id="title1" runat="server"></span></h2>
                    <p><span id="fecha1" runat="server"></span></p> 
               </header> 
                    <div class="material-placeholder">
                         <img src="../Recursos/Imagenes/ImagenesMultimedia/img-6.jpg" alt="" class="responsive-img materialboxed" data-caption="Lorem ipsum dolor sit amet, consectetur adipisicing elit.">
                    </div>
                   <main>
                     <h4><span id="resumen1" runat="server"></span></h4>
                     <p><span id="contenido1" runat="server"></span></p> 
                  </main>           
                
             </article>

             <article class="art">
              
                <header>
               <h2><span id="title2" runat="server"></span></h2>
                    <p><span id="fecha2" runat="server"></span></p>
               </header> 
                    <div class="material-placeholder">
                         <img src="../Recursos/Imagenes/ImagenesMultimedia/img-9.jpg" alt="" class="responsive-img materialboxed" data-caption="Lorem ipsum dolor sit amet, consectetur adipisicing elit.">
                    </div>
                   <main>
                     <h4><span id="resumen2" runat="server"></span></h4>
                     <p><span id="contenido2" runat="server"></span></p> 
                  </main>           
                
             </article>

            <article class="art">
              
                <header>
               <h2><span id="title3" runat="server"></span></h2>
                    <p><span id="fecha3" runat="server"></span></p> 
               </header> 
                    <div class="material-placeholder">
                         <img src="../Recursos/Imagenes/ImagenesMultimedia/img-1.jpg" alt="" class="responsive-img materialboxed" data-caption="Lorem ipsum dolor sit amet, consectetur adipisicing elit.">
                    </div>
                   <main>
                     <h4><span id="resumen3" runat="server"></span></h4>
                     <p><span id="contenido3" runat="server"></span></p> 
                  </main>           
                
             </article>

            <article class="art">
              
                <header>
               <h2><span id="title4" runat="server"></span></h2>
                    <p><span id="fecha4" runat="server"></span></p> 
               </header> 
                    <div class="material-placeholder">
                         <img src="../Recursos/Imagenes/ImagenesMultimedia/img-10.jpg" alt="" class="responsive-img materialboxed" data-caption="Lorem ipsum dolor sit amet, consectetur adipisicing elit.">
                    </div>
                   <main>
                     <h4><span id="resumen4" runat="server"></span></h4>
                     <p><span id="contenido4" runat="server"></span></p>  
                  </main>           
                
             </article>







        </div>

    </main>

</body>
</html>
