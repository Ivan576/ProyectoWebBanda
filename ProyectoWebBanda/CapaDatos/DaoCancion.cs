using MySql.Data.MySqlClient;
using ProyectoWebBanda.CapaNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoWebBanda.CapaDatos
{
    public class DaoCancion
    {
        //SE CREA LA CONEXION A LA BASE DE DATOS, SE INSERTAN LAS CREDENCIALES DEL SERVIDOR
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


        //METODO PARA OBTENER TODOS LOS EVENTOS DE LA BASE DE DATOS
        public List<Cancion> MostrarCanciones()
        {
            //SE LLAMA LA CONEXION A LA BASE DE DATOS
            conexion();
            try
            {
                //SE HACE LA CONSULTA A LA BASE DE DATOS
                String strSql = "Select * from cancion;";
                MySqlCommand cm = new MySqlCommand(strSql, conex);
                MySqlDataReader dr = cm.ExecuteReader();

                //SE CREA UNA LISTA DE TIPO EVENTO
                List<Cancion> lista = new List<Cancion>();
                //SE LEEN LOS DATOS Y SE LLENA LA LISTA CON LOS DATOS LEIDOS
                while (dr.Read())
                {
                    Cancion can = new Cancion(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetInt32(4),dr.GetString(5));
                    lista.Add(can);

                }
                return lista;

            }
            catch (Exception)
            {

                throw;
            } finally {
                conex.Close();
            }

        }

        public List<Cancion> MostrarCancionesPorAlbum(long idAlbum)
        {
            //SE LLAMA LA CONEXION A LA BASE DE DATOS
            conexion();
            try
            {
                //SE HACE LA CONSULTA A LA BASE DE DATOS
                String strSql = "Select * from cancion where idAlbum = @id;";
                MySqlCommand cm = new MySqlCommand(strSql, conex);
                cm.Parameters.AddWithValue("@id",idAlbum);
                MySqlDataReader dr = cm.ExecuteReader();

                //SE CREA UNA LISTA DE TIPO EVENTO
                List<Cancion> lista = new List<Cancion>();
                //SE LEEN LOS DATOS Y SE LLENA LA LISTA CON LOS DATOS LEIDOS
                while (dr.Read())
                {
                    Cancion can = new Cancion(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetInt32(4), dr.GetString(5));
                    lista.Add(can);

                }
                conex.Close();
                return lista;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conex.Close();
            }

        }

        public Cancion MostrarCancionesPorID(long id)
        {
            //SE LLAMA LA CONEXION A LA BASE DE DATOS
            conexion();
            try
            {
                //SE HACE LA CONSULTA A LA BASE DE DATOS
                String strSql = "Select * from cancion where idCancion = @id;";
                MySqlCommand cm = new MySqlCommand(strSql, conex);
                cm.Parameters.AddWithValue("@id", id);
                MySqlDataReader dr = cm.ExecuteReader();

                //SE CREA UNA LISTA DE TIPO EVENTO
                Cancion cancion = null;
                //SE LEEN LOS DATOS Y SE LLENA LA LISTA CON LOS DATOS LEIDOS
                while (dr.Read())
                {
                    cancion = new Cancion(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetInt32(4), dr.GetString(5));

                }
                conex.Close();
                return cancion;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conex.Close();
            }

        }


        //METODO PARA INSERTAR UN NUEVO EVENTO A LA BASE DE DATOS
        //METODO PARA INSERTAR UN NUEVO EVENTO A LA BASE DE DATOS
        public long insertar(ref Cancion objcan)
        {
            //SE LLAMA LA CONEXION
            conexion();
            MySqlCommand comman = new MySqlCommand();
            try
            {
                //CONSULTA PARA INSERTAR EN LA BASE DE DATOS 
                string sql = "Insert into cancion (nombre,duracion,genero,idAlbum,srcSpotify)values('" + objcan.Nombre + "','" + objcan.Duracion + "','" + objcan.Genero + "'," + objcan.idAlbum + ",'"+ objcan.srcSpotify +"')";
                comman = new MySqlCommand(sql, conex);
                comman.ExecuteNonQuery();
                return comman.LastInsertedId;
            }
            catch (Exception ex)
            {
                return -1;
                throw;
            }
            finally
            {
                //SIEMPRE SE CIERRA LA CONEXION AUNQUE ARROJE ERROR 
                comman.Dispose();
                conex.Close();
                conex.Dispose();
            }
        }

        public long actualizar(ref Cancion objcan)
        {
            //SE LLAMA LA CONEXION
            conexion();
            MySqlCommand comman = new MySqlCommand();
            try
            {
                //CONSULTA PARA INSERTAR EN LA BASE DE DATOS 
                string sql = "update cancion set nombre=@nombre, duracion=@duracion, genero=@genero, idAlbum=@idAlbum, srcSpotify=@srcSpotify where idCancion=@idCancion";
                comman = new MySqlCommand(sql, conex);
                comman.Parameters.AddWithValue("@nombre", objcan.Nombre);
                comman.Parameters.AddWithValue("@duracion", objcan.Duracion);
                comman.Parameters.AddWithValue("@genero", objcan.Genero);
                comman.Parameters.AddWithValue("@idAlbum", objcan.idAlbum);
                comman.Parameters.AddWithValue("@srcSpotify", objcan.srcSpotify);
                comman.Parameters.AddWithValue("@idCancion", objcan.idCancion);
                comman.ExecuteNonQuery();
                return comman.LastInsertedId;
            }
            catch (Exception ex)
            {
                return -1;
                throw;
            }
            finally
            {
                //SIEMPRE SE CIERRA LA CONEXION AUNQUE ARROJE ERROR 
                comman.Dispose();
                conex.Close();
                conex.Dispose();
            }
        }

        public void eliminar(long idSong)
        {
            MySqlCommand miCom = null;
            try
            {
                conexion();
                string sql = "DELETE FROM cancion WHERE idCancion=@id;";
                miCom = new MySqlCommand(sql, conex);
                miCom.Parameters.AddWithValue("@id", idSong);
                miCom.ExecuteNonQuery();
            }
            catch (Exception ex)
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