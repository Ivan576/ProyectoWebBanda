using ProyectoWebBanda.CapaDatos;
using ProyectoWebBanda.CapaNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace ProyectoWebBanda.CapaUsuarios
{
    public partial class Música : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            chargeData();
        }

        private void chargeData()
        {
            DaoAlbum daoAlbum = new DaoAlbum();
            List<Album> albums = new List<Album>();
            DaoCancion daoCancion = new DaoCancion();
            List<Cancion> canciones = new List<Cancion>();
            albums = daoAlbum.obtenerTodos();
            HtmlGenericControl eventSection;
            HtmlAnchor a;
            HtmlImage imageDisc;
            HtmlGenericControl h1;
            HtmlTable eventTable;
            HtmlTableRow tableRow;
            HtmlTableCell th;
            HtmlAnchor aSong;
            for (int i = 0; i <albums.Count; i++)
            {
                eventSection = new HtmlGenericControl("DIV");
                eventSection.Attributes["class"] = "eventSection parentCenter";

                // Inicia portada del disco
                a = new HtmlAnchor();
                a.HRef = albums[i].SrcSpotify;

                imageDisc = new HtmlImage();
                imageDisc.Src = "../Recursos/Imagenes/Portadas/"+ albums[i].Portada;
                imageDisc.Attributes["class"] = "imageDisc";

                a.Controls.Add(imageDisc);
                eventSection.Controls.Add(a);
                // Termina portada del disco

                // Inicia h1
                h1 = new HtmlGenericControl("H1");
                h1.InnerText = albums[i].Titulo;
                eventSection.Controls.Add(h1);
                // Finaliza h1

                //Inicia table
                eventTable = new HtmlTable();
                eventTable.Attributes["class"] = "eventTable";
                    //Encabezado
                tableRow = new HtmlTableRow();
                    
                th = new HtmlTableCell();
                th.InnerText = "Nombre";
                th.Attributes["class"] = "encabezado";
                tableRow.Controls.Add(th);
                th = new HtmlTableCell();
                th.InnerText = "Duración";
                th.Attributes["class"] = "encabezado";
                tableRow.Controls.Add(th);
                th = new HtmlTableCell();
                th.InnerText = "Género";
                th.Attributes["class"] = "encabezado";
                tableRow.Controls.Add(th);
                th = new HtmlTableCell();
                th.InnerText = "";
                th.Attributes["class"] = "encabezado";
                tableRow.Controls.Add(th);

                eventTable.Controls.Add(tableRow);
                //Fin Encabezado

                canciones = daoCancion.MostrarCancionesPorAlbum(albums[i].idAlbum);

                for (int j = 0; j<canciones.Count; j++)
                {
                    tableRow = new HtmlTableRow();
                    th = new HtmlTableCell();
                    th.InnerText = canciones[j].Nombre;
                    th.Attributes["class"] = "contenido";
                    tableRow.Controls.Add(th);
                    th = new HtmlTableCell();
                    th.InnerText = canciones[j].Duracion;
                    th.Attributes["class"] = "contenido";
                    tableRow.Controls.Add(th);
                    th = new HtmlTableCell();
                    th.InnerText = canciones[j].Genero;
                    th.Attributes["class"] = "contenido";
                    tableRow.Controls.Add(th);
                    th = new HtmlTableCell();
                    aSong = new HtmlAnchor();
                    aSong.Attributes["class"] = "brownButton buttonSong";
                    aSong.HRef = canciones[j].srcSpotify;
                    aSong.InnerText = "Escuchar";
                    th.Controls.Add(aSong);
                    th.Attributes["class"] = "contenido";
                    tableRow.Controls.Add(th);
                    eventTable.Controls.Add(tableRow);
                }

                eventSection.Controls.Add(eventTable);
                // Fin table
                //Agregar al div contenedor
                songsContent.Controls.Add(eventSection);
            }
        }
    }
}
