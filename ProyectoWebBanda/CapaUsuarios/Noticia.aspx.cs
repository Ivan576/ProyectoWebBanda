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
    public partial class Noticias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarNoticias();
        }

        public void cargarNoticias()
        {
            DaoNoticias objNoti = new DaoNoticias();
            List<Noticia> noticia = objNoti.mMostrarNoticia();

            title1.InnerText = noticia[0].titulo;
            fecha1.InnerText = noticia[0].fecha;
            resumen1.InnerText = noticia[0].resumen;
            contenido1.InnerText = noticia[0].contenido;

            title2.InnerText = noticia[1].titulo;
            fecha2.InnerText = noticia[1].fecha;
            resumen2.InnerText = noticia[1].resumen;
            contenido2.InnerText = noticia[1].contenido;

            title3.InnerText = noticia[2].titulo;
            fecha3.InnerText = noticia[2].fecha;
            resumen3.InnerText = noticia[2].resumen;
            contenido3.InnerText = noticia[2].contenido;

            title4.InnerText = noticia[3].titulo;
            fecha4.InnerText = noticia[3].fecha;
            resumen4.InnerText = noticia[3].resumen;
            contenido4.InnerText = noticia[3].contenido;

        }
    }
}