<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CatalogoVinculos.aspx.cs" Inherits="ProyectoWebBanda.CapaUsuarios.CatalogoVinculos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <link rel="stylesheet" href="../CSS/CommonStyles.css" />
    <link rel="stylesheet" href="../CSS/CatalogoVinculos.css" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
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
                    <h1 class="titulo">Catalogo vinculos</h1>
               </div>
          </div>
  
         <asp:Panel ID="Panel1" runat="server">
             <asp:Label ID="Label1" runat="server" Text="idVinculo"></asp:Label>
             <asp:TextBox ID="txtVinculo" runat="server" Width="329px"></asp:TextBox>
         </asp:Panel>
         <asp:Panel ID="Panel2" runat="server">
             <asp:Label ID="Label2" runat="server" Text="nombreVinculo"></asp:Label>
             <asp:TextBox ID="txtNombreVinculo" runat="server" Width="281px"></asp:TextBox>
         </asp:Panel>
         <asp:Panel ID="Panel3" runat="server">
             <asp:Label ID="Label3" runat="server" Text="imagen"></asp:Label>
             <asp:TextBox ID="txtImagen" runat="server" Width="345px"></asp:TextBox>
             <asp:Panel ID="Panel5" runat="server">
                 <asp:Button ID="brnAgregar" runat="server" Text="Agregar" />
                 <asp:Button ID="btnEditar" runat="server" Text="Editar" />
                 <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" />
             </asp:Panel>
         </asp:Panel>
         <asp:Panel ID="Panel4" runat="server">
             <asp:GridView ID="gvVinculo" runat="server">
             </asp:GridView>
         </asp:Panel>
     </form>
  
</body>
</html>
