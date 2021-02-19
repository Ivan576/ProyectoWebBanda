using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoWebBanda.CapaNegocios
{
    public class Album
    {
        public int idAlbum { get; set; }
        public string Titulo { get; set; }
        public string Tipo { get; set; }
        public int NoCanciones { get; set; }
        public string Portada { get; set; }
        public string Artista { get; set; }
        public int idPlataforma { get; set; }

        public Album() { }

        
        public Album(int idAlbum, string Titulo, string Tipo, int NoCanciones, string Portada, string Artista, int idPlataforma) {
            this.idAlbum = idAlbum;
            this.Titulo = Titulo;
            this.Tipo = Tipo;
            this.NoCanciones = NoCanciones;
            this.Portada = Portada;
            this.Artista = Artista;
            this.idPlataforma = idPlataforma;
        }

        public Album(string Titulo, string Tipo, int NoCanciones, string Portada, string Artista, int idPlataforma)
        {
            this.Titulo = Titulo;
            this.Tipo = Tipo;
            this.NoCanciones = NoCanciones;
            this.Portada = Portada;
            this.Artista = Artista;
            this.idPlataforma = idPlataforma;
        }
    }
}