using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace MMC.Auth
{
    public class Db
    {
        // Prepara la conexión
        private MySqlConnection conexion = new MySqlConnection();

        public Db()
        {
            Initialize();
        }
        //Initialize values
        private void Initialize()
        {
            conexion = new MySqlConnection(ConfigurationManager.ConnectionStrings["SQL_AUT"].ToString());
        }
        public MySqlConnection ObtenerConexion()
        {
            try
            {
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {

                return conexion;
            }
        }
        public bool DescargarConexion()
        {
            conexion.Close();
            return true;
        }


    }
}