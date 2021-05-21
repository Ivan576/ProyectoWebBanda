using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoWebBanda.CapaNegocios
{
    public class Multimedia
    {
        public int idMultimedia { get; set; }
        public string titulo { get; set; }
        public string formato { get; set; }
        public string link { get; set; }
        public Multimedia(int id,string titulo,string formato,string link)
        {
            this.idMultimedia = id;
            this.titulo = titulo;
            this.formato = formato;
            this.link = link;
        }
        public Multimedia(int id)
        {
            this.idMultimedia = id;
        }
        public Multimedia() { }
    }
}