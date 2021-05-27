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
        DaoCancion daoCancion;
        Cancion cancion;
        long id;
        protected void Page_Load()
        {
            daoAlbum = new DaoAlbum();
            daoCancion = new DaoCancion();
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
                    chargeSongInfo();
                }
            }
        }

        private void chargeSongInfo()
        {
            gvCanciones.DataSource = daoCancion.MostrarCancionesPorAlbum(id);
            gvCanciones.DataBind();
        }

        protected void BtnChargeSong_onClick(object sender, EventArgs e)
        {
            if (id == -1)
            {
                string script = "alert(\"Favor de registrar un album.\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
            else if (idSong.Value == "" || idSong.Value == null)
            {
                string script = "alert(\"Favor de seleccionar un id de la tabla\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
            else
            {
                cancion = daoCancion.MostrarCancionesPorID(long.Parse(idSong.Value));
                if (cancion == null)
                {
                    string script = "alert(\"Selecciona un ID válido\");";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else
                {
                    songName.Value = cancion.Nombre;
                    songDuration.Value = cancion.Duracion;
                    songGenere.Value = cancion.Genero;
                    srcSongSpotify.Value = cancion.srcSpotify;
                }
            }
        }

        protected void BtnSaveSong_onClick(object sender, EventArgs e)
        {
            if (id == -1)
            {
                string script = "alert(\"Favor de registrar un album antes de ingresar las canciones.\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
            else
            {
                string nombre = songName.Value;
                string duracion = songDuration.Value;
                string genero = songGenere.Value;
                string songSpotify = srcSongSpotify.Value;
                if (nombre == "" || duracion == "" || genero == "" || songSpotify == "")
                {
                    string script = "alert(\"Favor de llenar todos los datos.\");";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else
                {
                    Cancion songInsert = new Cancion(nombre, duracion, genero, id, songSpotify);
                    try
                    {
                        daoCancion.insertar(ref songInsert);
                        gvCanciones.DataSource = daoCancion.MostrarCancionesPorAlbum(id);
                        gvCanciones.DataBind();
                    }
                    catch (Exception)
                    {
                        string script = "alert(\"Algunos valores son incorrectos, favor de revisarlos.\");";
                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                }
            }
        }

        protected void BtnEditSong_onClick(object sender, EventArgs e)
        {
            if (id == -1)
            {
                string script = "alert(\"Favor de registrar un album antes de ingresar las canciones.\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
            else if (idSong.Value == "" || idSong.Value == null)
            {
                string script = "alert(\"Favor de seleccionar un id.\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
            else
            {
                long idCancion = long.Parse(idSong.Value);
                string nombre = songName.Value;
                string duracion = songDuration.Value;
                string genero = songGenere.Value;
                string songSpotify = srcSongSpotify.Value;
                if (nombre == "" || duracion == "" || genero == "" || songSpotify == "")
                {
                    string script = "alert(\"Favor de llenar todos los datos.\");";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else
                {
                    Cancion songInsert = new Cancion(idCancion, nombre, duracion, genero, id, songSpotify);
                    try
                    {
                        daoCancion.actualizar(ref songInsert);
                        gvCanciones.DataSource = daoCancion.MostrarCancionesPorAlbum(id);
                        gvCanciones.DataBind();
                    }
                    catch (Exception)
                    {
                        string script = "alert(\"Algunos valores son incorrectos, favor de revisarlos.\");";
                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                }
            }
        }

        protected void BtnDeleteSong_onClick(object sender, EventArgs e)
        {
            if (id == -1)
            {
                string script = "alert(\"Favor de registrar un album antes de ingresar las canciones.\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
            else if (idSong.Value == "" || idSong.Value == null)
            {
                string script = "alert(\"Favor de seleccionar un id.\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
            else
            {
                long idCancion = long.Parse(idSong.Value);
                daoCancion.eliminar(idCancion);
                gvCanciones.DataSource = daoCancion.MostrarCancionesPorAlbum(id);
                gvCanciones.DataBind();
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

            if (title == null || title == "" || type == null || type == "" || artists == null || artists == "" || cover == "" || spotifyUrl == null || spotifyUrl == "")
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
                }
                else
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