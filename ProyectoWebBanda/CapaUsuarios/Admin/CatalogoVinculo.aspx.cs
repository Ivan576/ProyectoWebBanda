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
    public partial class CatalogoVinculo : System.Web.UI.Page
    {
        DaoVinculo objVinculo = new DaoVinculo();
        protected void actualizaTAbla()
        {
            gvVinculo.DataSource = objVinculo.mostrarVinculos();
            gvVinculo.DataBind();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            actualizaTAbla();
        }

        protected void btnSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtVinculo.Text);
                Vinculo obj = objVinculo.selecionar(id);
                txtImagen.Text = obj.imagen;
                txtNombreVinculo.Text = obj.nombreVinculo;
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('usuario no valido')", true);
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Vinculo obj = new Vinculo();
                obj.idVinculo = int.Parse(txtVinculo.Text);
                obj.nombreVinculo = txtNombreVinculo.Text;
                obj.imagen = txtImagen.Text;
                objVinculo.insertarVinculos(obj);
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('usuario no valido')", true);
            }
            finally
            {
                actualizaTAbla();
            }
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            String cad = "";
            try
            {
                Vinculo obj = new Vinculo();
                obj.idVinculo = int.Parse(txtVinculo.Text);
                obj.nombreVinculo = txtNombreVinculo.Text;
                obj.imagen = txtImagen.Text;
                cad = objVinculo.actualizarVinculos(obj);
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert(Datos no validos)", true);

            }
            finally
            {
               // ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert(" + cad + ")", true);
                actualizaTAbla();

            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtVinculo.Text);
                objVinculo.eliminarVinculos(id);

            }
            catch (Exception ex)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('usuario no valido')", true);
            }
            finally
            {
                actualizaTAbla();
            }
        }
    
    }
}