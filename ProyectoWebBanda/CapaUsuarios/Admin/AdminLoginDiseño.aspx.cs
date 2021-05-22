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
    public partial class AdminLogin_Diseño : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            AdminObjeto obj = new AdminObjeto();
            obj.usuario = txtUser.Text;
            obj.contrasenia = txtPassword.Text;
            // ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('{****************')", true);
            
            DaoConexion conexion = new DaoConexion();

            Boolean can = conexion.login(obj);
            if (can)
            {
                Response.Redirect("AdminMainMenu.aspx", true);
            }
            else
            {

                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('usuario no valido')", true);

            }
        }

        protected void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}