using MySql.Data.MySqlClient;
using ProyectoWebBanda.CapaNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoWebBanda.CapaDatos
{
    public class DaoVinculo
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

        public List<Vinculo> mostrarVinculos()
        {
            //SE LLAMA LA CONEXION A LA BASE DE DATOS
            conexion();
            try
            {
                //SE HACE LA CONSULTA A LA BASE DE DATOS
                String strSql = "select * from Vinculo;";
                MySqlCommand cm = new MySqlCommand(strSql, conex);
                MySqlDataReader dr = cm.ExecuteReader();

                //SE CREA UNA LISTA DE TIPO EVENTO
                List<Vinculo> lista = new List<Vinculo>();
                //SE LEEN LOS DATOS Y SE LLENA LA LISTA CON LOS DATOS LEIDOS
                while (dr.Read())
                {
                    Vinculo obj = new Vinculo();
                    obj.idVinculo = dr.GetInt32(0);
                    obj.nombreVinculo = dr.GetString(1);
                    obj.imagen = dr.GetString(2);
                    lista.Add(obj);

                }
                conex.Close();
                return lista;

            }
            catch (Exception)
            {

                throw;
            }

        }
        public Vinculo selecionar(int id)
        {
            //SE LLAMA LA CONEXION A LA BASE DE DATOS
            conexion();
            try
            {
                //SE HACE LA CONSULTA A LA BASE DE DATOS
                String strSql = "select * from vinculo where idVinculo=@idVinculo;";
                MySqlCommand cm = new MySqlCommand(strSql, conex);
                cm.Parameters.AddWithValue("@idVinculo", id);
                MySqlDataReader dr = cm.ExecuteReader();
                //SE CREA UNA LISTA DE TIPO EVENTO
                Vinculo obj = new Vinculo();
                //SE LEEN LOS DATOS Y SE LLENA LA LISTA CON LOS DATOS LEIDOS 
                while (dr.Read())
                {
                    obj.idVinculo = dr.GetInt32(0);
                    obj.nombreVinculo = dr.GetString(1);
                    obj.imagen = dr.GetString(2);
                }
                               
                conex.Close();
                return obj;

            }
            catch (Exception)
            {

                throw;
            }

        }
        public bool insertarVinculos(Vinculo obj)
        {
            //bandera que nos dira si se pudo insertar
            bool flag = true;
           
            try
            {
                MySqlConnection conexxion = new MySqlConnection();
                conexion();
                //SE LLAMA LA CONEXION A LA BASE DE DATOS
                string strSQL = "insert into vinculo(idVinculo,nombreVinculo,imagen) values(@idVinculo,@nombreVinculo,@imagen);";
                MySqlCommand comman = new MySqlCommand();
                comman = new MySqlCommand(strSQL, conex);
                comman.Parameters.AddWithValue("@idVinculo",obj.idVinculo);
                comman.Parameters.AddWithValue("@nombreVinculo", obj.nombreVinculo);
                comman.Parameters.AddWithValue("@imagen", obj.imagen);
                comman.ExecuteNonQuery();
                comman.Dispose();
            }
            catch (Exception)
            {

                flag = false;
                throw;
            }
            finally
            {
                conex.Close();
                conex.Close();
                
            }
            return flag;
        }
        public bool eliminarVinculos(int id)
        {
            //bandera que nos dira si se pudo insertar
            bool flag = true;

            try
            {
                MySqlConnection conexxion = new MySqlConnection();
                conexion();
                //SE LLAMA LA CONEXION A LA BASE DE DATOS
                string strSQL = "DELETE FROM  vinculo WHERE idVinculo=@idVinculo;";
                MySqlCommand comman = new MySqlCommand();
                comman = new MySqlCommand(strSQL, conex);
                comman.Parameters.AddWithValue("@idVinculo",id);
                comman.ExecuteNonQuery();
                comman.Dispose();
            }
            catch (Exception)
            {

                flag = false;
                throw;
            }
            finally
            {
                conex.Close();
                conex.Close();

            }
            return flag;
        }
        public String actualizarVinculos(Vinculo obj)
        {
            //bandera que nos dira si se pudo insertar
            bool flag = true;

            try
            {

                MySqlConnection conexxion = new MySqlConnection();
                conexion();
                //SE LLAMA LA CONEXION A LA BASE DE DATOS
                string strSQL = "UPDATE vinculo SET nombreVinculo = @nombreVinculo, imagen = @imagen WHERE idVinculo= @idVinculo; ";
                MySqlCommand comman = new MySqlCommand();
                comman = new MySqlCommand(strSQL, conex);
                comman.Parameters.AddWithValue("@nombreVinculo", obj.nombreVinculo);
                comman.Parameters.AddWithValue("@imagen", obj.imagen);
                comman.Parameters.AddWithValue("@idVinculo", obj.idVinculo);

                comman.ExecuteNonQuery();
                comman.Dispose();
            }
            catch (Exception ex)
            {

                return ex.Message;
                throw;
            }
            finally
            {
                conex.Close();
                conex.Close();

            }
            return "si";
        }
    }
}