<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Multimedia.aspx.cs" Inherits="ProyectoWebBanda.CapaUsuarios.Multimedia" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/css/materialize.min.css">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="CSS/Multimedia.css" />
    <link rel="stylesheet" href="CSS/estilos.css">

    <style>
        
    </style>
    <!-- CSS only -->
<%--    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-eOJMYsd53ii+scO/bJGFsiCZc+5NDVN2yr8+0RDqr0Ql0h+rP48ckxlpbzKgwra6" crossorigin="anonymous">--%>
    <!-- JavaScript Bundle with Popper -->
<%--    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/js/bootstrap.bundle.min.js" integrity="sha384-JEW9xMcG8R+pH31jmWH6WWP0WintQrMb4s7ZOdauHnUtxwoG2vI5DkLtS3qm9Ekf" crossorigin="anonymous"></script>--%>
    
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
          <div class="row">
               <div class="col s12 center-align">
                    <h1 class="titulo">Imagenes</h1>
               </div>
          </div>

          <div class="row galeria">
               <div class="col s12 m4 l3">
                    <div class="material-placeholder">
                         <img src="../Recursos/Imagenes/ImagenesMultimedia/img-1.jpg" alt="" class="responsive-img materialboxed" data-caption="Lorem ipsum dolor sit amet, consectetur adipisicing elit.">
<%--                         <a href="../Recursos/Imagenes/ImagenesMultimedia/">../Recursos/Imagenes/ImagenesMultimedia/</a>   --%>
                    </div>
               </div>
               
       
             
              <div class="col s12 m4 l3">
                    <div class="material-placeholder">
                         <img src="../Recursos/Imagenes/ImagenesMultimedia/img-6.jpg" alt="" class="responsive-img materialboxed" data-caption="Lorem ipsum dolor sit amet, consectetur adipisicing elit.">
                    </div>
               </div>
              <div class="col s12 m4 l3">
                    <div class="material-placeholder">
                         <img src="../Recursos/Imagenes/ImagenesMultimedia/img-9.jpg" alt="" class="responsive-img materialboxed" data-caption="Lorem ipsum dolor sit amet, consectetur adipisicing elit.">
                    </div>
               </div>
              <div class="col s12 m4 l3">
                    <div class="material-placeholder">
                         <img src="../Recursos/Imagenes/ImagenesMultimedia/img-10.jpg" alt="" class="responsive-img materialboxed" data-caption="Lorem ipsum dolor sit amet, consectetur adipisicing elit.">
                    </div>
               </div>
              <div class="col s12 m4 l3">
                    <div class="material-placeholder">
                         <img src="../Recursos/Imagenes/ImagenesMultimedia/img-11.jpg" alt="" class="responsive-img materialboxed" data-caption="Lorem ipsum dolor sit amet, consectetur adipisicing elit.">
                    </div>
               </div>
              <div class="col s12 m4 l3">
                    <div class="material-placeholder">
                         <img src="../Recursos/Imagenes/ImagenesMultimedia/img-12.jpg" alt="" class="responsive-img materialboxed" data-caption="Lorem ipsum dolor sit amet, consectetur adipisicing elit.">
                    </div>
               </div>
              <div class="col s12 m4 l3">
                    <div class="material-placeholder">
                         <img src="../Recursos/Imagenes/ImagenesMultimedia/img-13.jpg" alt="" class="responsive-img materialboxed" data-caption="Lorem ipsum dolor sit amet, consectetur adipisicing elit.">
                    </div>
               </div>
              <div class="col s12 m4 l3">
                    <div class="material-placeholder">
                         <img src="../Recursos/Imagenes/ImagenesMultimedia/img-14.jpg" alt="" class="responsive-img materialboxed" data-caption="Lorem ipsum dolor sit amet, consectetur adipisicing elit.">
                    </div>
               </div>
              
           
          </div>
     </main>
     <main class="container">
          <div class="row">
               <div class="col s12 center-align">
                    <h1 class="titulo">Videos</h1>
               </div>
          </div>

          <div class="row galeria">
               <div class="col s12 m4 l3">
                    <div class="material-placeholder">
                        <iframe src="https://www.facebook.com/plugins/video.php?height=308&href=https%3A%2F%2Fwww.facebook.com%2F120millasoficial%2Fvideos%2F338230613691062%2F&show_text=false&width=560" alt=""  class="responsive-video  materialboxed" ></iframe>
                    </div>
               </div>
               
               <div class="col s12 m4 l3">
                    <div class="material-placeholder">
                        <iframe src="https://www.facebook.com/plugins/video.php?height=476&href=https%3A%2F%2Fwww.facebook.com%2F120millasoficial%2Fvideos%2F2199799673619312%2F&show_text=false&width=560"alt=""  class="responsive-video  materialboxed" ></iframe>
                    </div>
               </div>
               
               <div class="col s12 m4 l3">
                        <iframe src="https://www.facebook.com/plugins/video.php?height=308&href=https%3A%2F%2Fwww.facebook.com%2F120millasoficial%2Fvideos%2F2173525402870232%2F&show_text=false&width=560" alt=""  class="responsive-video  materialboxed" ></iframe>
               </div>
               
               <div class="col s12 m4 l3">
                        <iframe src="https://www.facebook.com/plugins/video.php?height=314&href=https%3A%2F%2Fwww.facebook.com%2F120millasoficial%2Fvideos%2F2151461115076661%2F&show_text=false&width=560" alt=""  class="responsive-video  materialboxed" ></iframe>
               </div>
               
               <div class="col s12 m4 l3">
                        <iframe src="https://www.facebook.com/plugins/video.php?height=308&href=https%3A%2F%2Fwww.facebook.com%2F120millasoficial%2Fvideos%2F1947777068778401%2F&show_text=false&width=560" alt=""  class="responsive-video  materialboxed" ></iframe>
               </div>
               
               <div class="col s12 m4 l3">
                        <iframe src="https://www.facebook.com/plugins/video.php?height=476&href=https%3A%2F%2Fwww.facebook.com%2F120millasoficial%2Fvideos%2F1946115152277926%2F&show_text=false&width=560" alt=""  class="responsive-video  materialboxed" ></iframe>
               </div>
               
               <div class="col s12 m4 l3">
                        <iframe src="https://www.facebook.com/plugins/video.php?height=311&href=https%3A%2F%2Fwww.facebook.com%2F120millasoficial%2Fvideos%2F1865434953679280%2F&show_text=false&width=560" alt=""  class="responsive-video  materialboxed" ></iframe>
               </div>
               
               <div class="col s12 m4 l3">
                        <iframe src="https://www.facebook.com/plugins/video.php?height=476&href=https%3A%2F%2Fwww.facebook.com%2F120millasoficial%2Fvideos%2F2199799673619312%2F&show_text=false&width=560" alt=""  class="responsive-video  materialboxed" ></iframe>
               </div>
               
          </div>
     </main>
     <script src="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/js/materialize.min.js"></script>
     <script src="JavaScript/main.js"></script>
</body>

    
</html>
