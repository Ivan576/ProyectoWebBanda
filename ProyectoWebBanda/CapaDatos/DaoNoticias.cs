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
                String strSql = "Select idNoticia, titulo, resumen, contenido, DATE_FORMAT(fecha, \"%Y-%m-%d\"), imagenPortada, imagenesContenido from Noticia";
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


        //METODO PARA OBTENER LOS DATOS DE UN EVENTO
        public List<Noticia> cargarDatos(ref int id)
        {
            //SE LLAMA LA CONEXION A LA BASE DE DATOS
            conexion();
            try
            {
                //SE HACE LA CONSULTA A LA BASE DE DATOS
                String strSql = "Select idNoticia, titulo, resumen, contenido, DATE_FORMAT(fecha, \"%Y-%m-%d\"), imagenPortada, imagenesContenido from Noticia where idNoticia = " + id;
                MySqlCommand cm = new MySqlCommand(strSql, conex);
                MySqlDataReader dr = cm.ExecuteReader();

                //SE CREA UNA LISTA DE TIPO EVENTO
                List<Noticia> lista = new List<Noticia>();

                //SE LEEN LOS DATOS Y SE LLENA LA LISTA CON LOS DATOS LEIDOS
                while (dr.Read())
                {
                    Noticia us = new Noticia(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6));
                    lista.Add(us);

                }
                conex.Close();
                return lista;

            }
            catch (Exception)
            {

                throw;
            }
        }



        //METODO PARA MODIFICAR UN EVENTO EN LA BASE DE DATOS
        public bool modificar(int idNoticia, string titulo, string resumen, string contenido, string fecha, string imagenPortada, string imagenesContenido)
        {
            //SE LLAMA LA CONEXION A LA BASE DE DATOS
            conexion();
            //SE CREA UN OBJETO DE TIPO COMANDO
            MySqlCommand comando = new MySqlCommand();

            try
            {


                /// AGREGAR LA ACTUALIZACION A LA BASE DE DATOS
                string strSQL = "Update Noticia Set titulo='" + titulo + "' , resumen='" + resumen + "' , contenido='" + contenido + "' , fecha='" + fecha + "', imagenPortada='"+ imagenPortada + "', imagenesContenido='" + imagenesContenido+ "' Where idNoticia=" + idNoticia;
                comando = new MySqlCommand(strSQL, conex);
                comando.ExecuteNonQuery();



                return true;
            }
            catch (Exception e)
            {
                throw;
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                //SIEMPRE SE CIERRA LA CONEXION AUNQUE ARROJE ERROR 
                comando.Dispose();
                conex.Close();
                conex.Dispose();
            }
            /// FINALIZAMOS LA CONEXION CERRAMOS TODO
        }



    }
}