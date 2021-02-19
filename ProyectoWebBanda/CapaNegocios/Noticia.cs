using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoWebBanda.CapaNegocios
{
    public class Noticia
    {
        public int idNoticia {get;set};
        public String titulo {get;set;};
        public String resumen {get;set;}
        public String contenido{get;set;} 
        public DateTime fecha {get;set;}
        public String imagenPortada {get;set;}
        public String imagenesContenido {get;set;}

        public Noticia(String titulo,String resumen,String contenido,DateTime fecha,String imagenPortada,String imagenesContenido){
            
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