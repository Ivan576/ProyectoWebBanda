<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CatalogoAlbum.aspx.cs" Inherits="ProyectoWebBanda.CapaUsuarios.Admin.CatalogoAlbum" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 144px;
        }
        .auto-style2 {
            width: 143px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Albums</h1>
            <asp:GridView ID="gvAlbums" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
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
            <table style="width: 100%;">
                <tr>
                    <td class="auto-style2">ID:</td>
                    <td>
                        <asp:TextBox ID="txtID" runat="server" Width="216px"></asp:TextBox>
                        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
                    </td>
                </tr>
            </table>
            <table id="tbAgregar" style="width: 100%;">
                <tr>
                    <td class="auto-style1">Título:</td>
                    <td>
                        <asp:TextBox ID="txtTitle" runat="server" Width="216px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Tipo:</td>
                    <td>
                        <asp:DropDownList ID="ddlTipo" runat="server">
                            <asp:ListItem>EP</asp:ListItem>
                            <asp:ListItem>Single</asp:ListItem>
                            <asp:ListItem>Album</asp:ListItem>
                            <asp:ListItem>Otro</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Cantidad canciones:</td>
                    <td>
                        <asp:TextBox ID="txtCantSongs" runat="server" Width="218px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Portada:</td>
                    <td>
                        <asp:Image ID="imgPortada" runat="server" Height="396px" ImageUrl="~/Recursos/Imagenes/Portadas/AmorEnDesamor.PNG" Width="389px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Artista:</td>
                    <td>
                        <asp:TextBox ID="txtArtista" runat="server" Width="220px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Plataforma:</td>
                    <td>
                        <asp:DropDownList ID="DropDownList2" runat="server">
                            <asp:ListItem>Spotify</asp:ListItem>
                            <asp:ListItem>SoundCloud</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click1" />
                    </td>
                    <td>
                        <asp:Button ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
