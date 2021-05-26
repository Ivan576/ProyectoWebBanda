<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CatalogoCanciones.aspx.cs" Inherits="ProyectoWebBanda.CapaUsuarios.Admin.CatalogoCanciones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-eOJMYsd53ii+scO/bJGFsiCZc+5NDVN2yr8+0RDqr0Ql0h+rP48ckxlpbzKgwra6" crossorigin="anonymous">
    <link rel="stylesheet" href="../CSS/CommonStyles.css" />
    <link rel="stylesheet" href="../CSS/CatalogoCanciones.css" />
    <link rel="stylesheet" href="../CSS/CommonColumns.css" />
    <link rel="stylesheet" href="https://fonts.googleapis.com/icon?family=Material+Icons">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div>
                    <header>
                        <h1 id="h1a" runat="server">Catálogo de Música</h1>
                    </header>
                    <div id="albumContainer" class="mainContainer lrow lcol-3 lcol-md-2 lcol-sm-1" runat="server">
                    </div>
                    <a href="#" class="add-button" runat="server" onserverclick="addAlbum_ServerClick">
                        <i class="material-icons">add_circle_outline</i>
                    </a>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
