using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SpotifyAPI.Web;


namespace ProyectoWebBanda.CapaUsuarios
{
    public partial class MainMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dateOne.InnerHtml = "El Juaco";
            calculatorSoap = new ServiceReference2.CalculatorSoapClient();
        }

        protected void btnDates_Click(object sender, EventArgs e)
        {
            Response.Redirect("Evento.aspx",true);
        }

        protected void btnLike_Click(object sender, EventArgs e)
        {
            int cant = int.Parse(likes.InnerText);
            cant = calculatorSoap.Add(cant,1);
            likes.InnerText = cant + "";
        }

        // Se crea una instancia del cliente SOAP
        ServiceReference2.CalculatorSoapClient calculatorSoap;
        /*
         * Obtiene el número de likes del span "Likes", posterior a esto le suma 1 y finalmente actualiza el valor en el Span.
         * Esto sucede cuando se da clic en el botón "Like"
         */
        protected void btnLike_Click1(object sender, EventArgs e)
        {
            int cant = int.Parse(likes.InnerText);
            cant = calculatorSoap.Add(cant, 1);
            likes.InnerText = cant + "";
        }
    }
}