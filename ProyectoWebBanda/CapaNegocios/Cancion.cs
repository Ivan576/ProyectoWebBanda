using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoWebBanda.CapaNegocios
{
    public class Cancion
    {
        public long idCancion { get; set; }
        public string Nombre { get; set; }
        public string Duracion { get; set; }
        public string Genero { get; set; }
        public long idAlbum { get; set; }
        public string srcSpotify { get; set; }

        public Cancion() { }

        public Cancion(long idCancion, string Nombre, string Duracion, string Genero, long idAlbum, string srcSpotify) {
            this.idCancion = idCancion;
            this.Nombre = Nombre;
            this.Duracion = Duracion;
            this.Genero = Genero;
            this.idAlbum = idAlbum;
            this.srcSpotify = srcSpotify;
        }

        public Cancion(string Nombre, string Duracion, string Genero, long idAlbum, string srcSpotify)
        {
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