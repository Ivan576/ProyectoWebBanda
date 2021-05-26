using ProyectoWebBanda.CapaDatos;
using ProyectoWebBanda.CapaNegocios;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoWebBanda.CapaUsuarios.Admin
{
    public partial class EdicionAlbumes : System.Web.UI.Page
    {
        Album album;
        DaoAlbum daoAlbum;
        long id;
        protected void Page_Load()
        {
            daoAlbum = new DaoAlbum();
            string variable = "idAlbum";
            object idString = HttpContext.Current.Session[variable];
            btnChargeAlbum.Visible = false;
            if (idString != null)
            {
                string stringId = idString.ToString();
                id = long.Parse(stringId);
                if (id != -1)
                {
                    btnChargeAlbum.Visible = true;
                }
            }
        }

        protected void BtnChargeAlbum_onClick(object sender, EventArgs e)
        {
            album = daoAlbum.obtenerPorId(id);
            albumTitle.Value = album.Titulo;
            albumType.SelectedValue = album.Tipo;
            otherArtist.Value = album.Artista;
            srcAlbumSpotify.Value = album.SrcSpotify;
        }

        protected void BtnSaveAlbum_onClick(object sender, EventArgs e)
        {
            string title = albumTitle.Value;
            int numberSongs = 0;
            string type = albumType.SelectedValue;
            string artists = otherArtist.Value;
            HttpPostedFile file = Request.Files["albumCoverName"];
            string cover = "";
            //check file was submitted
            if (file != null && file.ContentLength > 0)
            {
                cover = file.FileName;
                string fname = Path.GetFileName(file.FileName);
                file.SaveAs(Server.MapPath(Path.Combine("~/Recursos/Imagenes/Portadas/", fname)));
            }
            string spotifyUrl = srcAlbumSpotify.Value;

            if (title==null || title == "" || type == null || type == "" || artists == null || artists == "" || cover == "" || spotifyUrl == null || spotifyUrl == "")
            {
                string script = "alert(\"Favor de llenar todos los campos\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
            else
            {
                if (id == -1)
                {
                    album = new Album(title, type, numberSongs, artists, cover, spotifyUrl);
                    Session["idAlbum"] = daoAlbum.insertar(ref album);
                }else
                {
                    album = new Album(id, title, type, numberSongs, artists, cover, spotifyUrl);
                    bool result = daoAlbum.editar(album);
                    if (result)
                    {
                        
                    }
                    else
                    {
                        string script = "alert(\"No se pudo actualizar\");";
                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                }
            }
        }
    }
}