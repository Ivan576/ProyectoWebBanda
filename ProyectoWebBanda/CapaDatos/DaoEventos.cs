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



        public void insertar(ref Evento objeven)
        {
            conexion();
            MySqlCommand comman = new MySqlCommand();
            try
            {
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
                comman.Dispose();
                conex.Close();
                conex.Dispose();
            }
        }

        public List<Evento> mMostrarEventos()
        {
            conexion();
            try
            {
                String strSql = "Select * from Evento";
                MySqlCommand cm = new MySqlCommand(strSql, conex);
                MySqlDataReader dr = cm.ExecuteReader();


                List<Evento> lista = new List<Evento>();

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

        public List<Evento> cargarDatos(ref int id)
        {

            conexion();
            try
            {
                String strSql = "Select * from Evento where idEvento = " + id;
                MySqlCommand cm = new MySqlCommand(strSql, conex);
                MySqlDataReader dr = cm.ExecuteReader();


                List<Evento> lista = new List<Evento>();

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



        public bool modificar(int Id, string Nombre, string Fecha, string Ubicacion, string Link)
        {
            MySqlCommand comando = new MySqlCommand();

            try
            {
                conexion();

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
                comando.Dispose();
                conex.Close();
                conex.Dispose();
            }
            /// FINALIZAMOS LA CONEXION CERRAMOS TODO
        }



        public void eliminar(ref Evento objEvent)
        {
            conexion();
            MySqlCommand comman = new MySqlCommand();
            try
            {
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
             comman.Dispose();
            conex.Close();
            }
            
            
            
        }

    }
}