using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoWebBanda.CapaNegocios
{
    public class Cancion
    {
        public int idCancion { get; set; }
        public string Nombre { get; set; }
        public string Duracion { get; set; }
        public string Genero { get; set; }
        public int idAlbum { get; set; }
        public string srcSpotify { get; set; }

        public Cancion() { }

        public Cancion(int idCancion, string Nombre, string Duracion, string Genero, int idAlbum, string srcSpotify) {
            this.idCancion = idCancion;
            this.Nombre = Nombre;
            this.Duracion = Duracion;
            this.Genero = Genero;
            this.idAlbum = idAlbum;
            this.srcSpotify = srcSpotify;
        }

        public Cancion(int idCancion)
        {
            this.idCancion = idCancion;
        }

    }
}