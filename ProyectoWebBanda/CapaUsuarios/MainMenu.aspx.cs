using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SpotifyAPI.Web;


namespace ProyectoWebBanda.CapaUsuarios
{
    public partial class MainMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dateOne.InnerHtml = "22-02-2020";
        }

        protected void btnDates_Click(object sender, EventArgs e)
        {
            Response.Redirect("Evento.aspx",true);
        }

        
    }
}