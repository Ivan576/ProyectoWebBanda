using MySql.Data.MySqlClient;
using ProyectoWebBanda.CapaNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoWebBanda.CapaDatos
{
    public class DaoEventos
    {
        //SE CREA LA CONEXION A LA BASE DE DATOS, SE INSERTAN LAS CREDENCIALES DEL SERVIDOR
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


        //METODO PARA INSERTAR UN NUEVO EVENTO A LA BASE DE DATOS
        public void insertar(ref Evento objeven)
        {
            //SE LLAMA LA CONEXION
            conexion();
            MySqlCommand comman = new MySqlCommand();
            try
            {
                //CONSULTA PARA INSERTAR EN LA BASE DE DATOS 
                string sql = "Insert into Evento (nombre,fecha,ubicacion,linkEvento)values('" + objeven.Nombre + "','" + objeven.Fecha + "','" + objeven.Ubicacion + "','" + objeven.LinkEvento + "')";
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
                conex.Dispose();
            }
        }

        //METODO PARA OBTENER TODOS LOS EVENTOS DE LA BASE DE DATOS
        public List<Evento> mMostrarEventos()
        {
            //SE LLAMA LA CONEXION A LA BASE DE DATOS
            conexion();
            try
            {
                //SE HACE LA CONSULTA A LA BASE DE DATOS
                String strSql = "Select * from Evento";
                MySqlCommand cm = new MySqlCommand(strSql, conex);
                MySqlDataReader dr = cm.ExecuteReader();

                //SE CREA UNA LISTA DE TIPO EVENTO
                List<Evento> lista = new List<Evento>();
                //SE LEEN LOS DATOS Y SE LLENA LA LISTA CON LOS DATOS LEIDOS
                while (dr.Read())
                {
                    Evento eve = new Evento(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4));
                    lista.Add(eve);

                }
                conex.Close();
                return lista;

            }
            catch (Exception)
            {

                throw;
            }

        }

        //METODO PARA OBTENER LOS DATOS DE UN EVENTO
        public List<Evento> cargarDatos(ref int id)
        {
            //SE LLAMA LA CONEXION A LA BASE DE DATOS
            conexion();
            try
            {
                //SE HACE LA CONSULTA A LA BASE DE DATOS
                String strSql = "Select * from Evento where idEvento = " + id;
                MySqlCommand cm = new MySqlCommand(strSql, conex);
                MySqlDataReader dr = cm.ExecuteReader();

                //SE CREA UNA LISTA DE TIPO EVENTO
                List<Evento> lista = new List<Evento>();

                //SE LEEN LOS DATOS Y SE LLENA LA LISTA CON LOS DATOS LEIDOS
                while (dr.Read())
                {
                    Evento us = new Evento(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4));
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
        public bool modificar(int Id, string Nombre, string Fecha, string Ubicacion, string Link)
        {
            //SE LLAMA LA CONEXION A LA BASE DE DATOS
            conexion();
            //SE CREA UN OBJETO DE TIPO COMANDO
            MySqlCommand comando = new MySqlCommand();

            try
            {
                

                /// AGREGAR LA ACTUALIZACION A LA BASE DE DATOS
                string strSQL = "Update Evento Set nombre='" + Nombre + "' , fecha='" + Fecha + "' , ubicacion='" + Ubicacion + "' , linkEvento='" + Link + "' Where idEvento=" + Id;
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


        //METODO PARA ELIMINAR UN EVENTO DE LA BASE DE DATOS
        public void eliminar(ref Evento objEvent)
        {
            //LLAMAMOS LA CONEXION A LA BASE DE DATOS
            conexion();
            MySqlCommand comman = new MySqlCommand();
            try
            {
                //SE HACE LA ELIMINACION EN LA BASE DE DATOS
            string sql = "delete from Evento where idEvento=" + objEvent.idEvento;
            comman = new MySqlCommand(sql, conex);
            comman.ExecuteNonQuery();
            }
            catch(Exception)
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