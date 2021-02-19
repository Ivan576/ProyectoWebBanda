<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CatalogoMultimedia.aspx.cs" Inherits="ProyectoWebBanda.CapaUsuarios.CatalogoMultimedia" %>

<!DOCTYPE html>
<script runat="server">

    protected void Page_Load(object sender, EventArgs e)
    {

    }
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Vinculo<br />
        <asp:Label ID="lblLinkName" runat="server" Text="Nombre Del viculo"></asp:Label>
        <asp:TextBox ID="txtNombreDelVinculo" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblImagen" runat="server" Text="Imagen"></asp:Label>
            <asp:TextBox ID="txtIamgen" runat="server" Width="189px"></asp:TextBox>
        </p>
        <asp:GridView ID="gvVinvulos" runat="server">
        </asp:GridView>
        <asp:Label ID="lblVincloID" runat="server" Text="ID"></asp:Label>
        <asp:TextBox ID="txtVinculoID" runat="server" Width="212px"></asp:TextBox>
        <asp:Button ID="btnVinculoEliminar" runat="server" Text="Eliminar" />
        <p>
            <asp:Button ID="btnVinculoAgregar" runat="server" Text="Agregar" />
            <asp:Button ID="btnVinvuloEditar" runat="server" Text="Editar" />
        </p>
    </form>
</body>
</html>
