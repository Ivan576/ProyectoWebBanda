﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CatalogoEventos.aspx.cs" Inherits="ProyectoWebBanda.CapaUsuarios.CatalogoEventos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!-- CSS only -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-eOJMYsd53ii+scO/bJGFsiCZc+5NDVN2yr8+0RDqr0Ql0h+rP48ckxlpbzKgwra6" crossorigin="anonymous">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Catálogo de Eventos</h1>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Label ID="Label1" runat="server" Text="Nombre del Evento"></asp:Label>
                <asp:TextBox ID="txtNombre" runat="server" Style="margin-left: 8px" Width="219px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label2" runat="server" Text="Fecha"></asp:Label>
                <asp:TextBox ID="txtFecha" runat="server" Style="margin-left: 10px" Width="249px"></asp:TextBox>
                <asp:Label ID="Label5" runat="server" Text="Formato: AAAA-MM-DD HH: MM: SS"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label3" runat="server" Text="Ubicacion"></asp:Label>
                <asp:TextBox ID="txtUbicacion" runat="server" Style="margin-left: 12px" Width="229px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label4" runat="server" Text="Link"></asp:Label>
                <asp:TextBox ID="txtLink" runat="server" Style="margin-left: 7px" Width="276px"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="btnAgregarEvento" Class="btn btn-outline-primary" runat="server" OnClick="btnAgregarEvento_Click" Style="margin-left: 17px" Text="Agregar" Width="184px" />
                <asp:Button ID="btnEditar" Class="btn btn-outline-primary" runat="server" OnClick="btnEditar_Click" Style="margin-left: 23px" Text="Editar" />
                <asp:Button ID="btnEliminar" Class="btn btn-outline-danger" runat="server" OnClick="btnEliminar_Click" Style="margin-left: 25px" Text="Eliminar" />
                <br />
                <br />
                <asp:Label ID="lblNotifu" runat="server"></asp:Label>
                <br />
                <asp:GridView ID="gvEventos" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
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
                <asp:Label ID="Label6" runat="server" Text="Escribe el id del evento para eliminar o editar"></asp:Label>
                <br />
                <br />
                <asp:TextBox ID="txtId" runat="server" Style="margin-top: 0px"></asp:TextBox>
                <asp:Button ID="btnCargar" Class="btn btn-outline-info" runat="server" OnClick="btnCargar_Click" Style="margin-left: 16px" Text="Cargar datos para editar" />
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
