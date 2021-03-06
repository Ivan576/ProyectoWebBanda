﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EdicionAlbumes.aspx.cs" Inherits="ProyectoWebBanda.CapaUsuarios.Admin.EdicionAlbumes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>

    <link rel="stylesheet" href="../CSS/CommonStyles.css" />
    <link rel="stylesheet" href="../CSS/EdicionAlbumes.css" />
    <link rel="stylesheet" href="../CSS/CommonColumns.css" />

    <!-- Bootstrap -->
    <!-- CSS only Bootstrap -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-eOJMYsd53ii+scO/bJGFsiCZc+5NDVN2yr8+0RDqr0Ql0h+rP48ckxlpbzKgwra6" crossorigin="anonymous">
    <!-- JavaScript Bundle with Popper Bootstrap -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/js/bootstrap.bundle.min.js" integrity="sha384-JEW9xMcG8R+pH31jmWH6WWP0WintQrMb4s7ZOdauHnUtxwoG2vI5DkLtS3qm9Ekf" crossorigin="anonymous"></script>
    <!-- End Bootstrap -->
</head>
<body>
    <form id="form1" runat="server" enctype="multipart/form-data">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div>
                    <div class="lrow lcol-1 lcol-md-1 lcol-sm-1">
                        <div class="mainContainer">
                            <h2>Album</h2>

                            <div class="form-group">
                                <label for="albumTitle">Título:</label>
                                <input class="form-control" type="text" id="albumTitle" runat="server" />
                            </div>
                            <div class="form-group">
                                <label for="albumType">Tpo:</label><br />
                                <asp:DropDownList ID="albumType" CssClass="form-control" runat="server">
                                    <asp:ListItem>Sencillo</asp:ListItem>
                                    <asp:ListItem>Maxi-single</asp:ListItem>
                                    <asp:ListItem>EP</asp:ListItem>
                                    <asp:ListItem>Disco</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <!-- <div class="form-group">
                                <label for="noSongs">No. canciones:</label>
                                <input type="text" class="form-control" id="noSongs" name="noSongs" runat="server" />
                            </div> -->
                            <div class="form-group">
                                <label for="otherArtist">Otros artistas:</label>
                                <input type="text" class="form-control" id="otherArtist" runat="server" />
                            </div>
                            <div class="form-group">
                                <label for="albumCover">Portada:</label><br />
                                <input type="file" class="form-control" id="albumCover" name="albumCoverName" />
                            </div>
                            <div class="form-group">
                                <label for="srcAlbumSpotify">Dirección a Spotify:</label>
                                <input type="text" class="form-control" id="srcAlbumSpotify" runat="server" />
                            </div>

                            <button type="button" class="btn btn-primary buttonAdd" id="BtnSaveAlbum" runat="server" onserverclick="BtnSaveAlbum_onClick">Guardar</button>
                            <button type="button" class="btn btn-primary buttonAdd" id="btnChargeAlbum" runat="server" onserverclick="BtnChargeAlbum_onClick">Cargar información</button>
                        </div>
                        <div class="mainContainer">
                            <h2>Canciones</h2>
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
                                    <asp:GridView ID="gvCanciones" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
                                        <FooterStyle BackColor="White" ForeColor="#000066" />
                                        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                                        <RowStyle ForeColor="#000066" />
                                        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                        <SortedAscendingHeaderStyle BackColor="#007DBB" />
                                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                        <SortedDescendingHeaderStyle BackColor="#00547E" />
                                    </asp:GridView>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                            <div class="form-group">
                                <label for="songName">Id (solamente para editar y eliminar):</label>
                                <input type="text" id="idSong" name="idSong" class="form-control" runat="server" />
                            </div>
                            <button class="btn btn-primary buttonAdd" id="btnCargar" runat="server" onserverclick="BtnChargeSong_onClick">Cargar datos</button>
                            <div class="form-group">
                                <label for="songName">Nombre:</label>
                                <input type="text" id="songName" name="songName" class="form-control" runat="server" />
                            </div>
                            <div class="form-group">
                                <label>Duración (HH:MM:SS):</label>
                                <input type="text" id="songDuration" name="songDuration" class="form-control" runat="server" />
                            </div>
                            <div class="form-group">
                                <label for="songGenere">Género:</label>
                                <input type="text" id="songGenere" name="songGenere" class="form-control" runat="server" />
                            </div>
                            <div class="form-group">
                                <label for="srcSongSpotify">Link Spotify:</label>
                                <input type="text" id="srcSongSpotify" name="srcSongSpotify" class="form-control" runat="server" />
                            </div>

                            <button class="btn btn-primary buttonAdd" id="btnAddSong" runat="server" onserverclick="BtnSaveSong_onClick">Agregar</button>
                            <button class="btn btn-light buttonAdd" id="btnEditSong" runat="server" onserverclick="BtnEditSong_onClick">Editar</button>
                            <button class="btn btn-danger buttonAdd" id="btnEreaseSong" runat="server" onserverclick="BtnDeleteSong_onClick">Eliminar</button><br />
                        </div>
                    </div>
        </div>
    </form>
</body>
</html>
