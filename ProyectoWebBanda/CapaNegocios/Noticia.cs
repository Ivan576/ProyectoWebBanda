using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoWebBanda.CapaNegocios
{
    public class Noticia
    {
        public int idNoticia { get; set; }
        public string titulo {get;set;}
        public string resumen {get;set;}
        public string contenido {get;set;} 
        public string fecha {get;set;}
        public string imagenPortada {get;set;}
        public string imagenesContenido {get;set;}

        public Noticia(int idNoticia, string titulo, string resumen, string contenido, string fecha, string imagenPortada, string imagenesContenido){

            this.idNoticia = idNoticia;
            this.titulo=titulo;
            this.resumen=resumen;
            this.contenido=contenido;
            this.fecha=fecha;
            this.imagenPortada=imagenPortada;
            this.imagenesContenido=imagenesContenido;
 
        }
        public Noticia(int idNoticia){
            this.idNoticia=idNoticia;
        }
    }
}