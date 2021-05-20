using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoWebBanda.CapaDatos;
using ProyectoWebBanda.CapaNegocios;
using SpotifyAPI.Web;


namespace ProyectoWebBanda.CapaUsuarios
{
    public partial class MainMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            updateDateTable();
        }

        /*
         * Actualiza la tabla del menu principal
         */
        private void updateDateTable() {
            DaoEventos daoEventos = new DaoEventos();
            List<Evento> eventos = daoEventos.mMostrarEventosOrdenados();
            // Cargando los datos de la base de datos
            dateOne.InnerText = eventos[0].Fecha.Split(char.Parse(" "))[0];
            nameOne.InnerText = eventos[0].Nombre;
            placeOne.InnerText = eventos[0].Ubicacion;
            linkOne.InnerText = eventos[0].LinkEvento;
            linkOne.HRef = "https://" + eventos[0].LinkEvento;

            dateTwo.InnerText = eventos[1].Fecha.Split(char.Parse(" "))[0];
            nameTwo.InnerText = eventos[1].Nombre;
            placeTwo.InnerText = eventos[1].Ubicacion;
            linkTwo.InnerText = eventos[1].LinkEvento;
            linkTwo.HRef = "https://" + eventos[1].LinkEvento;

            dateTree.InnerText = eventos[2].Fecha.Split(char.Parse(" "))[0];
            nameTree.InnerText = eventos[2].Nombre;
            placeTree.InnerText = eventos[2].Ubicacion;
            linkTree.InnerText = eventos[2].LinkEvento;
            linkTree.HRef = "https://" + eventos[2].LinkEvento;
        }

        protected void btnDates_Click(object sender, EventArgs e)
        {
            Response.Redirect("Evento.aspx",true);
        }

        protected void aMusic_Click(object sender, EventArgs e)
        {
            Response.Redirect("Musica.aspx", true);
        }
    }
}