using ProyectoWebBanda.CapaNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;

namespace ProyectoWebBanda.CapaDatos
{
    public class DaoAlbum
    {
        MySqlConnection conex = new MySqlConnection();
        public void conexion()
        {
            try
            {
                conex.ConnectionString = "server=localhost;database=web120M;user id =root;password=root;";
                conex.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable obtenerTodos()
        {
            DataTable datos = new DataTable();
            conexion();
            MySqlCommand command = new MySqlCommand("select * from album;", conex);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Album");
            datos = ds.Tables["Album"];
            conex.Close();
            return datos;
        }

        public void insertar(ref Album objAlbum)
        {
            conexion();
            String sql = "insert into album(titulo, tipo, noCanciones, portada, artista, idPlataforma) values ('"+objAlbum.Titulo+"','"+objAlbum.Tipo+"',"+objAlbum.NoCanciones+",'"+objAlbum.Portada+"','"+objAlbum.Artista+"',"+objAlbum.idPlataforma+");";
            MySqlCommand mySql = new MySqlCommand(sql, conex);
            mySql.ExecuteNonQuery();
            mySql.Dispose();
            mySql.Clone();
            conex.Close();
        }

        public void eliminar(int idAlbum)
        {
            conexion();
            string sql = "DELETE FROM album WHERE idAlbum=" + idAlbum;
            MySqlCommand miCom = new MySqlCommand(sql, conex);
            miCom.ExecuteNonQuery();
            miCom.Dispose();
            conex.Close();
        }

        public void editar(Album album)
        {
            conexion();
            String sql = "UPDATE album set titulo = '" + album.Titulo + "', tipo = '" + album.Tipo + "', noCanciones=" + album.NoCanciones + ",portada = '" + album.Portada + "', artista='"+album.Artista+"', idPlataforma="+album.idPlataforma+ " where idAlbum = '" + album.idAlbum + "';";
            MySqlCommand mySql = new MySqlCommand(sql, conex);
            mySql.ExecuteNonQuery();
            mySql.Dispose();
            mySql.Clone();
            conex.Close();
        }
    }
}