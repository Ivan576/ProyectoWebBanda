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
        ServiceReference2.CalculatorSoapClient calculatorSoap;
        protected void Page_Load(object sender, EventArgs e)
        {
            dateOne.InnerHtml = "22-02-2020";
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

        protected void btnLike_Click1(object sender, EventArgs e)
        {
            int cant = int.Parse(likes.InnerText);
            cant = calculatorSoap.Add(cant, 1);
            likes.InnerText = cant + "";
        }
    }
}