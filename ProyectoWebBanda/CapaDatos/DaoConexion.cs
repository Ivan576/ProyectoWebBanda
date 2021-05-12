using MySql.Data.MySqlClient;
using ProyectoWebBanda.CapaNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace ProyectoWebBanda.CapaDatos
{
    public class DaoConexion
    {
        public  bool login(AdminObjeto obj)
        {
            MySqlConnection conexxion = new MySqlConnection();
            MySqlCommand comando = new MySqlCommand();
            int cont =0;
           // ScriptManager.RegisterClientScriptBlock(CapaUsuarios.Admin, this.GetType(), "alertMessage", "alert('Record Inserted Successfully')", true);
            try
            {
                conexxion.ConnectionString = "server=localhost; database=web120M; user=root; pwd=root";
                conexxion.Open();
                string strSQL = "select * from Admin where usuario=@usuario and contrasenia=@contrasenia";
                comando = new MySqlCommand(strSQL, conexxion);
                comando.Parameters.AddWithValue("@usuario", obj.usuario);
                comando.Parameters.AddWithValue("@contrasenia", obj.contrasenia);
                MySqlDataReader DaR = comando.ExecuteReader();
                while (DaR.Read())
                {
                    Console.WriteLine(DaR.GetString("usuario"));
                    Console.WriteLine(DaR.GetString("contrasenia"));
                    cont++;
                }
                Console.WriteLine(" funca");


            }
            catch (Exception e) {
                Console.WriteLine("No funca");
                return true;
            }
            finally
            {
                comando.Dispose();
                conexxion.Close();
                conexxion.Dispose();
                Console.WriteLine("finaly");

            }
            Console.WriteLine("cont");
            return cont ==1;
        }
    }
}