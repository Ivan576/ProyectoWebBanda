using MySql.Data.MySqlClient;
using ProyectoWebBanda.CapaNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoWebBanda.CapaDatos
{
    public class DaoMultimedia
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

        public List<Multimedia> mostrarMultimedia()
        {
            //SE LLAMA LA CONEXION A LA BASE DE DATOS
            conexion();
            try
            {
                //SE HACE LA CONSULTA A LA BASE DE DATOS
                String strSql = "select * from Multimedia;";
                MySqlCommand cm = new MySqlCommand(strSql, conex);
                MySqlDataReader dr = cm.ExecuteReader();

                //SE CREA UNA LISTA DE TIPO EVENTO
                List<Multimedia> lista = new List<Multimedia>();
                //SE LEEN LOS DATOS Y SE LLENA LA LISTA CON LOS DATOS LEIDOS
                while (dr.Read())
                {
                    Multimedia obj = new Multimedia();
                    obj.idMultimedia = dr.GetInt32(0);
                    obj.titulo = dr.GetString(1);
                    obj.formato = dr.GetString(2);
                    obj.link = dr.GetString(3);
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
        public Multimedia selecionar(int id)
        {
            //SE LLAMA LA CONEXION A LA BASE DE DATOS
            conexion();
            try
            {
                //SE HACE LA CONSULTA A LA BASE DE DATOS
                String strSql = "select * from multimedia where idMultimedia=@idMultimedia;";
                MySqlCommand cm = new MySqlCommand(strSql, conex);
                cm.Parameters.AddWithValue("@idMultimedia", id);
                MySqlDataReader dr = cm.ExecuteReader();
                //SE CREA UNA LISTA DE TIPO EVENTO
                Multimedia obj = new Multimedia();
                //SE LEEN LOS DATOS Y SE LLENA LA LISTA CON LOS DATOS LEIDOS 
                while (dr.Read())
                {
                    obj.idMultimedia = dr.GetInt32(0);
                    obj.titulo = dr.GetString(1);
                    obj.formato = dr.GetString(2);
                    obj.link = dr.GetString(3);
                }

                conex.Close();
                return obj;

            }
            catch (Exception)
            {

                throw;
            }

        }
        public bool insertarMultimedia(Multimedia obj)
        {
            //bandera que nos dira si se pudo insertar
            bool flag = true;

            try
            {
                MySqlConnection conexxion = new MySqlConnection();
                conexion();
                //SE LLAMA LA CONEXION A LA BASE DE DATOS
                string strSQL = "insert into multimedia(idMultimedia,titulo,formato,link) values(@idMultimedia,@titulo,@formato,@link);";
                MySqlCommand comman = new MySqlCommand();
                comman = new MySqlCommand(strSQL, conex);
                comman.Parameters.AddWithValue("@idMultimedia",obj.idMultimedia);
                comman.Parameters.AddWithValue("@titulo", obj.titulo);
                comman.Parameters.AddWithValue("@formato", obj.formato);
                comman.Parameters.AddWithValue("@link", obj.link);
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
        public bool eliminarMultimedia(int id)
        {
            //bandera que nos dira si se pudo insertar
            bool flag = true;

            try
            {
                MySqlConnection conexxion = new MySqlConnection();
                conexion();
                //SE LLAMA LA CONEXION A LA BASE DE DATOS
                string strSQL = "DELETE FROM  multimedia WHERE idMultimedia=@idMultimedia;";
                MySqlCommand comman = new MySqlCommand();
                comman = new MySqlCommand(strSQL, conex);
                comman.Parameters.AddWithValue("@idMultimedia", id);
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
        public String actualizarMultimedia(Multimedia obj)
        {
            //bandera que nos dira si se pudo insertar
            bool flag = true;

            try
            {

                MySqlConnection conexxion = new MySqlConnection();
                conexion();
                //SE LLAMA LA CONEXION A LA BASE DE DATOS
                string strSQL = "UPDATE multimedia SET titulo = @titulo, formato = @formato,link =@link WHERE idMultimedia = @idMultimedia;";
                MySqlCommand comman = new MySqlCommand();
                comman = new MySqlCommand(strSQL, conex);
                comman.Parameters.AddWithValue("@titulo", obj.titulo);
                comman.Parameters.AddWithValue("@formato", obj.formato);
                comman.Parameters.AddWithValue("@link", obj.link);
                comman.Parameters.AddWithValue("@idMultimedia", obj.idMultimedia);
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