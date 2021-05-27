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
    public partial class CatalogoNoticias : System.Web.UI.Page
    {
        DaoNoticias objConectar = new DaoNoticias();
        Noticia objNoticia;
        protected void Page_Load(object sender, EventArgs e)
        {
            gvNoticias.DataSource = objConectar.mMostrarNoticia();
            gvNoticias.DataBind();
        }

        protected void btnAgregarNoticia_Click(object sender, EventArgs e)
        {
            //DataBase
            string titulo = txtTitulo.Text.ToString();
            string resumen = txtResumen.Text.ToString();
            string contenido = txtContenido.Text.ToString();
            string fecha = txtFecha.Text.ToString();
            String imgPortada = imagenPortada.FileName;
            String imgContent = imagenesContenido.FileName;
            

            objNoticia = new Noticia(0, titulo, resumen, contenido, fecha, imgPortada, imgContent);
            long idInsertado = objConectar.insertar(ref objNoticia);
            gvNoticias.DataSource = objConectar.mMostrarNoticia();
            gvNoticias.DataBind();


            txtTitulo.Text = "";
            txtResumen.Text = "";
            txtContenido.Text = "";
            txtFecha.Text = "";
            

        }

        protected void btnEditarN_Click(object sender, EventArgs e)
        {
            int Id = Int32.Parse(txtId.Text);
            string titulo = txtTitulo.Text.ToString();
            string resumen = txtResumen.Text.ToString();
            string contenido = txtContenido.Text.ToString();
            string fecha = txtFecha.Text.ToString();
            String imgPortada = imagenPortada.FileName;
            String imgContent = imagenesContenido.FileName;


            Noticia Registro = new Noticia(Id, titulo, resumen, contenido, fecha, imgPortada, imgContent);



            DaoNoticias objmodifica = new DaoNoticias();
            //if (
            objmodifica.modificar(Id, titulo, resumen, contenido, fecha, imgPortada, imgContent);
            //)
            //{
            //lblNotifu.Text = "Modificado correctamente";
            gvNoticias.DataSource = objConectar.mMostrarNoticia();
            gvNoticias.DataBind();
            //}
            //else
            //{

            //    lblNotifu.Text = "Algo salio mal";
            //}
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow row in gvNoticias.Rows)
            {
                if (txtId.Text == row.Cells[0].Text)
                {
                    objNoticia = new Noticia(Int32.Parse(txtId.Text));
                    objConectar.eliminar(ref objNoticia);
                    gvNoticias.DataSource = objConectar.mMostrarNoticia();
                    gvNoticias.DataBind();
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
            DaoNoticias noticia = new DaoNoticias();

            int Id = Int32.Parse(txtId.Text);
            noticia.cargarDatos(ref Id);
            List<Noticia> lista = noticia.cargarDatos(ref Id);


            txtTitulo.Text = lista[0].titulo;
            txtResumen.Text = lista[0].resumen;
            txtContenido.Text = lista[0].contenido;
            txtFecha.Text = lista[0].fecha;
           
        }
    }
}