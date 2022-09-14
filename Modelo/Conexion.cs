using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Sistema_de_Requisiciones.Modelo
{
    public class Conexion
    {
        public SqlConnection conectar()
        {
            //Cadena
            //CArlos
            //string strConn = @"Data Source=LAPTOP-16D0D786\SQLEXPRESS;Initial Catalog=Requisiciones;Integrated Security=True"; 
            //string strConn = @"Data Source=LAPTOP-16D0D786\SQLEXPRESS;Initial Catalog=Requisiciones;Integrated Security=True"; KAt
            string strConn = @"Data Source=RC02;Initial Catalog=Requisiciones;Integrated Security=True";// Pablo
            //string strConn = @"Data Source=LAPTOP-16D0D786\SQLEXPRESS;Initial Catalog=Requisiciones;Integrated Security=True"; Mile
            //string strConn = @"Data Source=LAPTOP-1V90MKP\SQLEXPRESS;Initial Catalog=Requisiciones;Integrated Security=True";
            //string strConn = "data source = LAPTOP - 56Q87DQN\SQLEXPRESS;initial catalog = hoteles; integrated security = false; user id = web6; password = 123456";
            //string strConn= @"user=DESKTOP-1V90MKP\lenovo 1597; password=validpassword; server=192.168.1.9:1433; Trusted_Connection=yes; Database=Requisiciones; connection timeout=30";

            SqlConnection conn = new SqlConnection(strConn);
            try
            {
                if (conn.State.Equals(ConnectionState.Closed))
                {
                    conn.Open();
                }
                else
                {
                    conn.Close();
                }
            }
            catch (Exception)
            {
                return null;
            }

            return conn;

        }
    }
}