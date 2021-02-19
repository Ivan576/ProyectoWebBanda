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
    public partial class CatalogoEventos : System.Web.UI.Page
    {

        DaoEventos objConectar = new DaoEventos();
        Evento objEven;
        protected void Page_Load(object sender, EventArgs e)
        {
            gvEventos.DataSource = objConectar.mMostrarEventos();
            gvEventos.DataBind();
        }

        protected void btnAgregarEvento_Click(object sender, EventArgs e)
        {
            string Nombre = txtNombre.Text.ToString();
            string Fecha = txtFecha.Text.ToString();
            string Ubicacion = txtUbicacion.Text.ToString();
            string Link = txtLink.Text.ToString();
            objEven = new Evento(0, Nombre, Fecha, Ubicacion, Link);
            objConectar.insertar(ref objEven);
            gvEventos.DataSource = objConectar.mMostrarEventos();
            gvEventos.DataBind();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow row in gvEventos.Rows)
            {
                if (txtId.Text == row.Cells[0].Text)
                {
                    objEven = new Evento(Int32.Parse(txtId.Text));
                    objConectar.eliminar(ref objEven);
                    gvEventos.DataSource = objConectar.mMostrarEventos();
                    gvEventos.DataBind();
                    lblNotifu.Text = "Se elimino correctamente";
                }
                else
                {
                    lblNotifu.Text = "Algo Salio Mal";
                }
            }
        }

        protected void btnCargar_Click(object sender, EventArgs e)
        {
            DaoEventos evento = new DaoEventos();

            int Id = Int32.Parse(txtId.Text);
            evento.cargarDatos(ref Id);
            List<Evento> lista = evento.cargarDatos(ref Id);


            txtNombre.Text = lista[0].Nombre;
            txtFecha.Text = lista[0].Fecha;
            txtUbicacion.Text = lista[0].Ubicacion;
            txtLink.Text = lista[0].LinkEvento;
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            int Id = Int32.Parse(txtId.Text);
            string Nombre = txtNombre.Text.ToString();
            String Fecha = txtFecha.Text.ToString();
            string Ubicacion = txtUbicacion.Text.ToString();
            string Link = txtLink.Text.ToString();


            Evento Registro = new Evento(Id, Nombre, Fecha, Ubicacion, Link);



            DaoEventos modifica = new DaoEventos();
            //if (
            modifica.modificar(Id, Nombre, Fecha, Ubicacion, Link);
                //)
            //{
                //lblNotifu.Text = "Modificado correctamente";
                gvEventos.DataSource = objConectar.mMostrarEventos();
                gvEventos.DataBind();
            //}
            //else
            //{

            //    lblNotifu.Text = "Algo salio mal";
            //}
        }
    }
}