using ProyectoWebBanda.CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoWebBanda.CapaUsuarios
{
    public partial class CatalogoVinculos : System.Web.UI.Page
    {
        DaoVinculo objVinculo = new DaoVinculo();
        protected void Page_Load(object sender, EventArgs e)
        {
            actualizaTAbla();
        }

        
        protected void actualizaTAbla()
        {
            gvVinculo.DataSource = objVinculo.mostrarVinculos();
            gvVinculo.DataBind();

        }
    }
}