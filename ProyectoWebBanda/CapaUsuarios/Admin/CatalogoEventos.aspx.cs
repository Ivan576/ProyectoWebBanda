using ProyectoWebBanda.CapaDatos;
using ProyectoWebBanda.CapaNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;

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
            long idInsertado = objConectar.insertar(ref objEven);
            gvEventos.DataSource = objConectar.mMostrarEventos();
            gvEventos.DataBind();


            //Cargamos el archivo en el que se agrego el codigo xml con el comando "Load"
            XDocument file = XDocument.Load(@"C:\Users\zaval\Documents\1 - OCTAVO SEMESTRE\PRO.WEB 2\U 1\ProyectoWebBanda\ProyectoWebBanda\XMLs\Eventos.xml");
            XElement nodoRaiz = new XElement("evento");
           //Se agrega un nuevo elemento al nodo raiz
            file.Element("eventos").Add(nodoRaiz);

            //generamos un nuevo elemento llamado "datos" y agregamos los datos ingresados a las cajas de texto
            XElement datos = new XElement("datos");
            datos.Add(new XElement("IdEvento", idInsertado));
            datos.Add(new XElement("Nombre", txtNombre.Text));
            datos.Add(new XElement("Fecha", txtFecha.Text));
            datos.Add(new XElement("Ubicacion", txtUbicacion.Text));
            datos.Add(new XElement("Link", txtLink.Text));
            //Agregamos los datos al nodo raiz
            nodoRaiz.Add(datos);

            //Se guardan los datos en el archivo xml y se ingresa un mensaje en la etiqueta diciendo que el xml se generó
            file.Save(@"C:\Users\zaval\Documents\1 - OCTAVO SEMESTRE\PRO.WEB 2\U 1\ProyectoWebBanda\ProyectoWebBanda\XMLs\Eventos.xml");
            lblNotifu.Text = "Xml Generado";
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


            XmlDocument file = new XmlDocument();
            file.Load(@"C:\Users\zaval\Documents\1 - OCTAVO SEMESTRE\PRO.WEB 2\U 1\ProyectoWebBanda\ProyectoWebBanda\XMLs\Eventos.xml");

            XmlNode eventos = file.DocumentElement;
            XmlNodeList IdsEvents = file.SelectNodes("eventos/evento");


            foreach (XmlNode obj in IdsEvents)
            {
                if (obj.SelectSingleNode("datos").SelectSingleNode("IdEvento").InnerText == txtId.Text)
                {
                    XmlNode IDnodo = obj;
                    eventos.RemoveChild(IDnodo);
                }
            }


            file.Save(@"C:\Users\zaval\Documents\1 - OCTAVO SEMESTRE\PRO.WEB 2\U 1\ProyectoWebBanda\ProyectoWebBanda\XMLs\Eventos.xml");
            lblNotifu.Text = "Se elimino correctamente";


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
            //int Id = Int32.Parse(txtId.Text);
            //string Nombre = txtNombre.Text.ToString();
            //String Fecha = txtFecha.Text.ToString();
            //string Ubicacion = txtUbicacion.Text.ToString();
            //string Link = txtLink.Text.ToString();


            //Evento Registro = new Evento(Id, Nombre, Fecha, Ubicacion, Link);



            //DaoEventos modifica = new DaoEventos();
            ////if (
            //modifica.modificar(Id, Nombre, Fecha, Ubicacion, Link);
            //    //)
            ////{
            //    //lblNotifu.Text = "Modificado correctamente";
            //    gvEventos.DataSource = objConectar.mMostrarEventos();
            //    gvEventos.DataBind();
            ////}
            ////else
            ////{

            ////    lblNotifu.Text = "Algo salio mal";
            ////}



            //XML
            XmlDocument document = new XmlDocument();
            document.Load(@"C:\Users\zaval\Documents\1 - OCTAVO SEMESTRE\PRO.WEB 2\U 1\ProyectoWebBanda\ProyectoWebBanda\XMLs\Eventos.xml");

            XmlNode node;
            node = document.DocumentElement;

            XmlNodeList IdsEvent = document.SelectNodes("eventos/evento");
            foreach (XmlNode item in IdsEvent)
            {
                if (item.SelectSingleNode("datos").SelectSingleNode("IdEvento").InnerText == txtId.Text)
                {
                    item.ChildNodes[0].ChildNodes[1].InnerText = txtNombre.Text;
                    item.ChildNodes[0].ChildNodes[2].InnerText = txtFecha.Text;
                    item.ChildNodes[0].ChildNodes[3].InnerText = txtUbicacion.Text;
                    item.ChildNodes[0].ChildNodes[4].InnerText = txtLink.Text;
                    
                    document.Save(@"C:\Users\zaval\Documents\1 - OCTAVO SEMESTRE\PRO.WEB 2\U 1\ProyectoWebBanda\ProyectoWebBanda\XMLs\Eventos.xml");
                    lblNotifu.Text = "evento modificada";
                    break;
                }
            }
        }
    }
}