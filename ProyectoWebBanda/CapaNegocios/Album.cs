using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoWebBanda.CapaNegocios
{
    public class Album
    {
        public long idAlbum { get; set; }
        public string Titulo { get; set; }
        public string Tipo { get; set; }
        public int NoCanciones { get; set; }

        public string Artista { get; set; }
        public string Portada { get; set; }
        public string SrcSpotify { get; set; }

        public Album() { }

        
        public Album(long idAlbum, string Titulo, string Tipo, int NoCanciones, string Artista, string Portada, string SrcSpotify) {
            this.idAlbum = idAlbum;
            this.Titulo = Titulo;
            this.Tipo = Tipo;
            this.NoCanciones = NoCanciones;
            this.Artista = Artista;
            this.Portada = Portada;
            this.SrcSpotify = SrcSpotify;
        }

        public Album(string Titulo, string Tipo, int NoCanciones, string Artista, string Portada, string SrcSpotify)
            {
            this.Titulo = Titulo;
            this.Tipo = Tipo;
            this.NoCanciones = NoCanciones;
            this.Artista = Artista;
            this.Portada = Portada;
            this.SrcSpotify = SrcSpotify;
        }
    }
}