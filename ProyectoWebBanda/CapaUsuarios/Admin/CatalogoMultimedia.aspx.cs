using ProyectoWebBanda.CapaDatos;
using ProyectoWebBanda.CapaNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoWebBanda.CapaUsuarios
{
    public partial class CatalogoMultimedia : System.Web.UI.Page
    {
        DaoMultimedia objDaoMul = new DaoMultimedia();
        protected void actualizarpagina()
        {
            gvVinvulos.DataSource = objDaoMul.mostrarMultimedia();
            gvVinvulos.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            actualizarpagina();

        }

        protected void btnVinvuloEditar_Click(object sender, EventArgs e)
        {
            //String cad = "";
            try
            {
                CapaNegocios.Multimedia obj = new CapaNegocios.Multimedia();
                obj.idMultimedia = int.Parse(txtIdMultimedia.Text);
                obj.titulo = txtitulo.Text;
                obj.formato = txtFormato.Text;
                obj.link = txtlink.Text;
                objDaoMul.actualizarMultimedia(obj);
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert(Datos no validos)", true);

            }
            finally
            {
                // ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert(" + cad + ")", true);
                actualizarpagina();

            }
        }

        protected void btnVinculoEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtIdMultimedia.Text);
                objDaoMul.eliminarMultimedia(id);

            }
            catch (Exception ex)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('usuario no valido')", true);
            }
            finally
            {
                actualizarpagina();
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtIdMultimedia.Text);
                CapaNegocios.Multimedia obj = objDaoMul.selecionar(id);
                txtitulo.Text=obj.titulo;
                txtFormato.Text=obj.formato;
                txtlink.Text=obj.link;
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('usuario no valido')", true);
            }
        }

        protected void btnMultimediaAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                CapaNegocios.Multimedia obj = new CapaNegocios.Multimedia();
                obj.idMultimedia = int.Parse(txtIdMultimedia.Text);
                obj.titulo = txtitulo.Text;
                obj.formato = txtFormato.Text;
                obj.link = txtlink.Text;
                objDaoMul.insertarMultimedia(obj);
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert(Datos no validos)", true);

            }
            finally
            {
                // ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert(" + cad + ")", true);
                actualizarpagina();

            }
        }
    }
}