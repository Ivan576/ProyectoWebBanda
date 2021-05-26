using ProyectoWebBanda.CapaDatos;
using ProyectoWebBanda.CapaNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace ProyectoWebBanda.CapaUsuarios.Admin
{
	public partial class CatalogoCanciones : System.Web.UI.Page
	{
		DaoAlbum daoAlbum;
		DaoCancion daoCancion;
		List<Album> albums;
		List<Cancion> canciones;
		protected void Page_Load(object sender, EventArgs e)
		{
			daoAlbum = new DaoAlbum();
			daoCancion = new DaoCancion();
			albums = new List<Album>();
			canciones = new List<Cancion>();
			for(int i = 0; i < 100; i++)
            {
				//ddlHoras.Items.Add(i+"");
			}
			for (int i = 0; i < 60; i++)
			{
				//ddlMinutos.Items.Add(i + "");
				//ddlSegundos.Items.Add(i + "");
			}
			chargeData();
		}

		private void chargeData()
        {
			albums = daoAlbum.obtenerTodos();
			HtmlGenericControl div;
			HtmlImage image;
			HtmlGenericControl h4;
			HtmlGenericControl span;
			HtmlAnchor buttonEdit;
			HtmlAnchor buttonDelete;
			HtmlGenericControl iControl;
			for (int i = 0; i < albums.Count; i++)
            {
				div = new HtmlGenericControl("DIV");
				div.ID = "card" + albums[i].idAlbum;
				div.Attributes["class"] = "card";
				
				image = new HtmlImage();
				image.Src = "../../Recursos/Imagenes/Portadas/" + albums[i].Portada;
				div.Controls.Add(image);

				h4 = new HtmlGenericControl("H4");
				h4.InnerText = albums[i].Titulo;
				div.Controls.Add(h4);

				canciones = daoCancion.MostrarCancionesPorAlbum(albums[i].idAlbum);

                for (int j =0; j<canciones.Count; j++)
                {
					span = new HtmlGenericControl("SPAN");
					span.InnerText = canciones[j].Nombre;
					div.Controls.Add(span);
                }

				buttonEdit = new HtmlAnchor();
				buttonEdit.ID = "btnEdit" + albums[i].idAlbum;
				buttonEdit.ServerClick += new System.EventHandler(this.buttonsCard_click);
				buttonEdit.Attributes["runat"] = "server";
				buttonEdit.Attributes["onserverclick"] = "buttonsCard_click";
				buttonEdit.Attributes["class"] = "edit";

				iControl = new HtmlGenericControl("I");
				iControl.Attributes["class"] = "material-icons";
				iControl.InnerText = "create";
				buttonEdit.Controls.Add(iControl);
				div.Controls.Add(buttonEdit);

				buttonDelete = new HtmlAnchor();
				buttonDelete.ServerClick += new System.EventHandler(this.buttonsCard_click);
				buttonDelete.ID = "btnDelete" + albums[i].idAlbum;
				buttonDelete.Attributes["runat"] = "server";
				buttonDelete.Attributes["onserverclick"] = "buttonsCard_click";
				buttonDelete.Attributes["class"] = "delete";

				iControl = new HtmlGenericControl("I");
				iControl.Attributes["class"] = "material-icons";
				iControl.InnerText = "delete";
				buttonDelete.Controls.Add(iControl);
				div.Controls.Add(buttonDelete);

				albumContainer.Controls.Add(div);
			}
        }

		protected void buttonsCard_click(object sender, EventArgs e)
        {
			string algo = ((HtmlAnchor) sender).ClientID;
            if (algo.Contains("btnEdit"))
            {
				string idStr = algo.Replace("btnEdit", "");
				Session["idAlbum"] = int.Parse(idStr);
				Response.Redirect("EdicionAlbumes.aspx", true);
			}
			else
            {
				string idStr = algo.Replace("btnDelete", "");
				daoAlbum.eliminar(int.Parse(idStr));
				albumContainer.InnerHtml = "";
				chargeData();
            }
		}

        protected void addAlbum_ServerClick(object sender, EventArgs e)
        {
			Session["idAlbum"] = -1;
			Response.Redirect("EdicionAlbumes.aspx", true);
		}
    }
}