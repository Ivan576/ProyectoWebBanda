using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoWebBanda.CapaNegocios
{
    public class Evento
    {
        public int idEvento { get; set; }
        public string Nombre { get; set; }
        public String Fecha { get; set; }
        public string Ubicacion { get; set; }
        public string LinkEvento { get; set; }

        public Evento(int idEvento, string Nombre, string Fecha, string Ubicacion, string LinkEvento)
        {
            this.idEvento = idEvento;
            this.Nombre = Nombre;
            this.Fecha = Fecha;
            this.Ubicacion = Ubicacion;
            this.LinkEvento = LinkEvento;
        }

        public Evento(int idEvento)
        {
            this.idEvento = idEvento;
        }
    }
}