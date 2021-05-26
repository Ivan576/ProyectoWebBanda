<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CatalogoNoticias.aspx.cs" Inherits="ProyectoWebBanda.CapaUsuarios.CatalogoNoticias" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <!-- CSS only -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-eOJMYsd53ii+scO/bJGFsiCZc+5NDVN2yr8+0RDqr0Ql0h+rP48ckxlpbzKgwra6" crossorigin="anonymous">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="CSS/Noticia.css"/>
    <title></title>
     <style type="text/css">
         #TextArea1 {
             height: 68px;
         }
     </style>
</head>
<body>
    <form id="form1" runat="server" enctype="multipart/form-data">
        <div>
            <h1>Catálogo de Noticias</h1>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
       
            <ContentTemplate>
                <asp:Label ID="Label1" runat="server" Text="Titulo de la Noticia"></asp:Label>
                <asp:TextBox ID="txtTitulo" runat="server" Style="margin-left: 8px" Width="219px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label2" runat="server" Text="Resumen"></asp:Label>
                <br />
                <asp:TextBox ID="txtResumen" runat="server" Style="margin-left: 10px" Width="224px" Height="104px" TextMode="MultiLine"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label3" runat="server" Text="Contenido"></asp:Label>
                <br />
                <asp:TextBox ID="txtContenido" runat="server" Style="margin-left: 12px" Width="257px" Height="139px" TextMode="MultiLine"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label4" runat="server" Text="Fecha"></asp:Label>
                <asp:TextBox ID="txtFecha" runat="server" Style="margin-left: 7px" Width="219px"></asp:TextBox>
                &nbsp;
                <asp:Label ID="Label7" runat="server" Text="Formato: AAAA-MM-DD"></asp:Label>
                <br />
                <br />
                       <div id="imgP">
                           
                           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                           
                           <asp:FileUpload ID="imagenPortada" runat="server" />
                           
                       </div>

                <br />
                <br />
                       <div>

                           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                           <asp:FileUpload ID="imagenesContenido" runat="server" />

                       </div>
                <br />
                <asp:Button ID="btnAgregarNoticia" Class="btn btn-outline-primary" runat="server" style="margin-left: 17px" Text="Agregar Noticia" OnClick="btnAgregarNoticia_Click" />
                <asp:Button ID="btnEditarN" Class="btn btn-outline-primary" runat="server" style="margin-left: 24px" Text="Editar" OnClick="btnEditarN_Click" />
                <asp:Button ID="btnEliminar" Class="btn btn-outline-danger" runat="server" style="margin-left: 24px" Text="Eliminar" OnClick="btnEliminar_Click" />
                <br />
                <br />
                <asp:Label ID="lblNotifu" runat="server"></asp:Label>
                <br />
                <asp:GridView ID="gvNoticias" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" style="margin-left: 19px">
                    <AlternatingRowStyle BackColor="White" />
                    <EditRowStyle BackColor="#7C6F57" />
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#E3EAEB" />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F8FAFA" />
                    <SortedAscendingHeaderStyle BackColor="#246B61" />
                    <SortedDescendingCellStyle BackColor="#D4DFE1" />
                    <SortedDescendingHeaderStyle BackColor="#15524A" />
                </asp:GridView>
                <br />
                <asp:Label ID="Label6" runat="server" Text="Escribe el id de la noticia para eliminar o editar"></asp:Label>
                <br />
                <br />
                <asp:TextBox ID="txtId" runat="server" Style="margin-top: 0px"></asp:TextBox>
                <asp:Button ID="btnCargar" Class="btn btn-outline-info" runat="server" Style="margin-left: 16px" Text="Cargar datos para editar" />
            </ContentTemplate>
        
        </div>
    </form>
</body>
</html>
