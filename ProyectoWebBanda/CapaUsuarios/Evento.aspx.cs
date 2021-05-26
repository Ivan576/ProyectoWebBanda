using ProyectoWebBanda.CapaDatos;
using ProyectoWebBanda.CapaNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace ProyectoWebBanda.CapaUsuarios
{
    public partial class Eventos : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarEventos();
        }

        public void cargarEventos()
        {
           DaoEventos objeven = new DaoEventos();
            List<Evento> evento = objeven.mMostrarEventosOrdenados();

            // Cargando los datos de la base de datos
            fecha0.InnerText = evento[0].Fecha.Split(char.Parse(" "))[0];
            nombre0.InnerText = evento[0].Nombre;
            ubicacion0.InnerText = evento[0].Ubicacion;
            link0.InnerText = evento[0].LinkEvento;
            link0.HRef = "https://" + evento[0].LinkEvento;

            fecha1.InnerText = evento[1].Fecha.Split(char.Parse(" "))[0];
            nombre1.InnerText = evento[1].Nombre;
            ubicacion1.InnerText = evento[1].Ubicacion;
            link1.InnerText = evento[1].LinkEvento;
            link1.HRef = "https://" + evento[1].LinkEvento;

            fecha2.InnerText = evento[2].Fecha.Split(char.Parse(" "))[0];
            nombre2.InnerText = evento[2].Nombre;
            ubicacion2.InnerText = evento[2].Ubicacion;
            link2.InnerText = evento[2].LinkEvento;
            link2.HRef = "https://" + evento[2].LinkEvento;

            fecha3.InnerText = evento[3].Fecha.Split(char.Parse(" "))[0];
            nombre3.InnerText = evento[3].Nombre;
            ubicacion3.InnerText = evento[3].Ubicacion;
            link3.InnerText = evento[3].LinkEvento;
            link3.HRef = "https://" + evento[3].LinkEvento;

            fecha4.InnerText = evento[4].Fecha.Split(char.Parse(" "))[0];
            nombre4.InnerText = evento[4].Nombre;
            ubicacion4.InnerText = evento[4].Ubicacion;
            link4.InnerText = evento[4].LinkEvento;
            link4.HRef = "https://" + evento[4].LinkEvento;

            fecha5.InnerText = evento[5].Fecha.Split(char.Parse(" "))[0];
            nombre5.InnerText = evento[5].Nombre;
            ubicacion5.InnerText = evento[5].Ubicacion;
            link5.InnerText = evento[5].LinkEvento;
            link5.HRef = "https://" + evento[5].LinkEvento;

            //fecha6.InnerText = evento[6].Fecha.Split(char.Parse(" "))[0];
            //nombre6.InnerText = evento[6].Nombre;
            //ubicacion6.InnerText = evento[6].Ubicacion;
            //link6.InnerText = evento[6].LinkEvento;
            //link6.HRef = "https://" + evento[6].LinkEvento;




            //for (int i = 0; i > evento.Count; i++)
            //{

            //    Tevents.InnerHtml += addNewFila(evento[i].Fecha, evento[i].Nombre, evento[i].Ubicacion, evento[i].LinkEvento);
            //    //Tevents.Controls.Add(new LiteralControl("<b>my html</b>"));
            //    //Tevents.Controls.Add(new LiteralControl(addNewFila(evento[i].Fecha, evento[i].Nombre, evento[i].Ubicacion, evento[i].LinkEvento)));
            //}
            //HtmlTableRow tRow;
            //HtmlTableCell tb;
            //HtmlAnchor anchor;
            //for (int i = 0; i > evento.Count; i++)
            //    {
            //        tRow = new HtmlTableRow();

            //        tb = new HtmlTableCell();
            //        tb.InnerText = evento[i].Fecha;
            //        tRow.Controls.Add(tb);

            //        tb = new HtmlTableCell();
            //        tb.InnerText = evento[i].Nombre;
            //        tRow.Controls.Add(tb);

            //        tb = new HtmlTableCell();
            //        tb.InnerText = evento[i].Ubicacion;
            //        tRow.Controls.Add(tb);

            //        tb = new HtmlTableCell();
            //        anchor = new HtmlAnchor();
            //        anchor.HRef = "https://" + evento[i].LinkEvento;
            //        anchor.InnerHtml = evento[i].LinkEvento;
            //        tb.Controls.Add(anchor);
            //        tRow.Controls.Add(tb);
            //        Tevents.Rows.Add(tRow);
            //}
        }

        //public string addNewFila(string fecha, string nombre, string ubicacion, string link)
        //{

        //    String algo = "<tr>";

        //      algo += "<td>";
        //      algo += fecha;
        //      algo +="</td>";

        //      algo +="<td class=\"rowName\">";
        //      algo += nombre;
        //      algo +="</td>";

        //      algo +="<td>";
        //      algo += ubicacion;
        //      algo +="</td>";

        //      algo += "<td>";
        //      algo += link;
        //      algo += "</td>";

        //      algo += "<td>";
        //      algo += "<a id = \"linkOne\" href="+link+ "runat = \"server\">" + link + "</a>";
        //      algo += "</td>";

        //      algo +="</tr>";

        //      return algo;
        //}

    }
}