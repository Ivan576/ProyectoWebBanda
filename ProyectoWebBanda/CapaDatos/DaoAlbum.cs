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
                conex.Close();
                throw;
            }
        }
        public List<Album> obtenerTodos()
        {
            List<Album> datos = new List<Album>();
            try
            {
                conexion();
                MySqlCommand command = new MySqlCommand("select * from album;", conex);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read()) {
                    datos.Add(new Album(reader.GetInt32(0),reader.GetString(1),reader.GetString(2),reader.GetInt32(3), reader.GetString(4), reader.GetString(5), reader.GetString(6)));
                }
            }
            catch (Exception ex)
            {
                return datos;
                throw;
            }finally
            {
                conex.Close();
            }
            return datos;
        }

        public Album obtenerPorId(long id)
        {
            Album album = new Album();
            try
            {
                conexion();
                MySqlCommand command = new MySqlCommand("select * from album where idAlbum=@id;", conex);
                command.Parameters.AddWithValue("@id",id);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read()) {
                    album = new Album(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetString(4), reader.GetString(5), reader.GetString(6));
                }
            }
            catch (Exception ex)
            {
                return album;
                throw;
            }finally
            {
                conex.Close();
            }
            return album;
        }

        public long insertar(ref Album objAlbum)
        {
            MySqlCommand mySql = null;
            try
            {
                conexion();
                String sql = "insert into album(titulo, tipo, noCanciones, artista, srcPortada, srcSpotify) values (@titulo, @tipo, @noCanciones, @artista, @srcPortada, @srcSpotify);";
                mySql = new MySqlCommand(sql, conex);
                mySql.Parameters.AddWithValue("@titulo", objAlbum.Titulo);
                mySql.Parameters.AddWithValue("@tipo", objAlbum.Tipo);
                mySql.Parameters.AddWithValue("@noCanciones", objAlbum.NoCanciones);
                mySql.Parameters.AddWithValue("@artista", objAlbum.Artista);
                mySql.Parameters.AddWithValue("@srcPortada", objAlbum.Portada);
                mySql.Parameters.AddWithValue("@srcSpotify", objAlbum.SrcSpotify);
                mySql.ExecuteNonQuery();
                return mySql.LastInsertedId;
            }
            catch(Exception ex)
            {
                return -1;
            }
            finally
            {
                if (mySql != null)
                {
                    mySql.Dispose();
                    mySql.Clone();
                }
            }
        }

        public bool editar(Album objAlbum)
        {
            MySqlCommand mySql = null;
            try
            {
                conexion();
                String sql = "UPDATE Album SET titulo=@titulo, tipo=@tipo, noCanciones=@noCanciones, artista=@artista, srcPortada=@srcPortada, srcSpotify=@srcSpotify WHERE idAlbum=@idAlbum;";
                mySql = new MySqlCommand(sql, conex);
                mySql.Parameters.AddWithValue("@titulo", objAlbum.Titulo);
                mySql.Parameters.AddWithValue("@tipo", objAlbum.Tipo);
                mySql.Parameters.AddWithValue("@noCanciones", objAlbum.NoCanciones);
                mySql.Parameters.AddWithValue("@artista", objAlbum.Artista);
                mySql.Parameters.AddWithValue("@srcPortada", objAlbum.Portada);
                mySql.Parameters.AddWithValue("@srcSpotify", objAlbum.SrcSpotify);
                mySql.Parameters.AddWithValue("@idAlbum", objAlbum.idAlbum);
                int id = Convert.ToInt32(mySql.ExecuteNonQuery());
                if (id == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (mySql != null)
                {
                    mySql.Dispose();
                    mySql.Clone();
                }
            }
        }

        public void eliminar(long idAlbum)
        {
            MySqlCommand miCom = null;
            try
            {
                conexion();
                string sql = "DELETE FROM album WHERE idAlbum=@id;";
                miCom = new MySqlCommand(sql, conex);
                miCom.Parameters.AddWithValue("@id", idAlbum);
                miCom.ExecuteNonQuery();
            }
            catch(Exception ex)
            {

            }
            finally
            {
                if (miCom != null)
                {
                    miCom.Dispose();
                }
                conex.Close();
            }
            
        }
    }
}