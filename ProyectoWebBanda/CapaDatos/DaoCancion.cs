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
        public List<Cancion> mMostrarCanciones()
        {
            //SE LLAMA LA CONEXION A LA BASE DE DATOS
            conexion();
            try
            {
                //SE HACE LA CONSULTA A LA BASE DE DATOS
                String strSql = "Select * from cancion";
                MySqlCommand cm = new MySqlCommand(strSql, conex);
                MySqlDataReader dr = cm.ExecuteReader();

                //SE CREA UNA LISTA DE TIPO EVENTO
                List<Cancion> lista = new List<Cancion>();
                //SE LEEN LOS DATOS Y SE LLENA LA LISTA CON LOS DATOS LEIDOS
                while (dr.Read())
                {
                    Cancion can = new Cancion(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetInt32(4),dr.GetInt32(5));
                    lista.Add(can);

                }
                conex.Close();
                return lista;

            }
            catch (Exception)
            {

                throw;
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
                string sql = "Insert into cancion (nombre,duracion,genero,idAlbum,idPlataforma)values('" + objcan.Nombre + "','" + objcan.Duracion + "','" + objcan.Genero + "'," + objcan.idAlbum + ","+ objcan.idPlataforma +")";
                comman = new MySqlCommand(sql, conex);
                comman.ExecuteNonQuery();
                return comman.LastInsertedId;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                //SIEMPRE SE CIERRA LA CONEXION AUNQUE ARROJE ERROR 
                comman.Dispose();
                conex.Close();
                conex.Dispose();
            }
            return -1;
        }




    }
}