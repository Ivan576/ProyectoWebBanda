using ProyectoWebBanda.CapaDatos;
using ProyectoWebBanda.CapaNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoWebBanda.CapaUsuarios.Admin
{
    public partial class CatalogoAlbum : System.Web.UI.Page
    {

        DaoAlbum daoAlbum;

        protected void Page_Load(object sender, EventArgs e)
        {
            daoAlbum = new DaoAlbum();
            gvAlbums.DataSource = daoAlbum.obtenerTodos();
            gvAlbums.DataBind();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow row in gvAlbums.Rows)
            {
                if (txtID.Text == row.Cells[0].Text)
                {
                    daoAlbum.eliminar(Int32.Parse(txtID.Text));
                    gvAlbums.DataSource = daoAlbum.obtenerTodos();
                    gvAlbums.DataBind();
                }
            }
        }

        protected void btnAgregar_Click1(object sender, EventArgs e)
        {
            //Album album = new Album(txtTitle.Text.ToString(),ddlTipo.SelectedValue.ToString(),Int32.Parse(txtCantSongs.Text.ToString()),"aaa",txtArtista.Text.ToString(),1);
            //daoAlbum.insertar(ref album);
            //gvAlbums.DataSource = daoAlbum.obtenerTodos();
            //gvAlbums.DataBind();
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            //int idAlbum = Int32.Parse(txtID.Text.ToString());
            //string titulo = txtTitle.Text.ToString();
            //string tipo = ddlTipo.SelectedValue.ToString();
            //int noCanciones = Int32.Parse(txtCantSongs.Text.ToString());
            //string portada = "IUnaportada";
            //string artista = txtArtista.Text.ToString();
            //int idPlataforma = 1;
            //Album album = new Album(idAlbum,titulo,tipo,noCanciones,portada,artista,idPlataforma);
            //daoAlbum.editar(album);
            //gvAlbums.DataSource = daoAlbum.obtenerTodos();
            //gvAlbums.DataBind();
        }
    }
}