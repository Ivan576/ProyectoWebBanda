using ProyectoWebBanda.CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoWebBanda.CapaUsuarios
{
    public partial class Eventos : System.Web.UI.Page
    {
        DaoEventos objeven;
        protected void Page_Load(object sender, EventArgs e)
        {
            fecha.InnerHtml = "";
        }
    }
}