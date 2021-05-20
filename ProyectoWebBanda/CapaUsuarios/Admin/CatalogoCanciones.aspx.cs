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
	public partial class CatalogoCanciones : System.Web.UI.Page
	{
		DaoCancion objConectar = new DaoCancion();
		Cancion objCancion;
		protected void Page_Load(object sender, EventArgs e)
		{
			gvCanciones.DataSource = objConectar.mMostrarCanciones();
			gvCanciones.DataBind();

		}

		protected void btnAgregar_Click(object sender, EventArgs e)
		{
			//DataBase
			string Nombre = txtNombre.Text.ToString();
			string Duracion = txtDuracion.Text.ToString();
			string Genero = txtGenero.Text.ToString();
			int idAlbum = Convert.ToInt32(txtidAlbum.Text);
			int idPlataforma = Convert.ToInt32(txtidPlataforma.Text);
			objCancion = new Cancion (0, Nombre, Duracion, Genero, idAlbum, idPlataforma);
			long idInsertado = objConectar.insertar(ref objCancion);

			//Servicio para cargar los datos de la DB

			ServiceReference1.ServiceDBSoapClient miWebService = new ServiceReference1.ServiceDBSoapClient();
			gvCanciones.DataSource = miWebService.ObtenerCanciones();
			gvCanciones.DataBind();

		}

        protected void gvCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}