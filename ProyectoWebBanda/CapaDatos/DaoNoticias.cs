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
                conex.ConnectionString = "server=localhost;database=prograweb2;user id =root;password=root1;";
                conex.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}