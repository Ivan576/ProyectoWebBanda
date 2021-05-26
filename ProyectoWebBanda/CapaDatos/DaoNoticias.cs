using MySql.Data.MySqlClient;
using ProyectoWebBanda.CapaNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoWebBanda.CapaDatos
{
    public class DaoNoticias
    {
        MySqlConnection conex = new MySqlConnection();
        public void conexion()
        {
            try
            {
                conex.ConnectionString = "server=localhost;database=web120M;user id =root;password=root1;";
                conex.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }

        //METODO PARA OBTENER TODOS LOS EVENTOS DE LA BASE DE DATOS
        public List<Noticia> mMostrarNoticia()
        {
            //SE LLAMA LA CONEXION A LA BASE DE DATOS
            conexion();
            try
            {
                //SE HACE LA CONSULTA A LA BASE DE DATOS
                String strSql = "Select * from Noticia";
                MySqlCommand cm = new MySqlCommand(strSql, conex);
                MySqlDataReader dr = cm.ExecuteReader();

                //SE CREA UNA LISTA DE TIPO EVENTO
                List<Noticia> lista = new List<Noticia>();
                //SE LEEN LOS DATOS Y SE LLENA LA LISTA CON LOS DATOS LEIDOS
                while (dr.Read())
                {
                    Noticia noti = new Noticia(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6));
                    lista.Add(noti);

                }
                conex.Close();
                return lista;

            }
            catch (Exception)
            {

                throw;
            }

        }

        public long insertar(ref Noticia objNoti)
        {
            //SE LLAMA LA CONEXION
            conexion();
            MySqlCommand comman = new MySqlCommand();
            try
            {
                //CONSULTA PARA INSERTAR EN LA BASE DE DATOS 
                string sql = "Insert into Noticia (titulo,resumen,contenido,fecha,imagenPortada,imagenesContenido)values('" + objNoti.titulo + "','" + objNoti.resumen + "','" + objNoti.contenido + "','" + objNoti.fecha + "','"+ objNoti.imagenPortada+"','"+ objNoti.imagenesContenido+"')";
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


        //METODO PARA ELIMINAR UN EVENTO DE LA BASE DE DATOS
        public void eliminar(ref Noticia objNoti)
        {
            //LLAMAMOS LA CONEXION A LA BASE DE DATOS
            conexion();
            MySqlCommand comman = new MySqlCommand();
            try
            {
                //SE HACE LA ELIMINACION EN LA BASE DE DATOS
                string sql = "delete from Noticia where idNoticia=" + objNoti.idNoticia;
                comman = new MySqlCommand(sql, conex);
                comman.ExecuteNonQuery();
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
            }



        }

    }
}