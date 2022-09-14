using Sistema_de_Requisiciones.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Sistema_de_Requisiciones.Controlador
{
    public class CtrRango
    {
        public List<Rango> listarRango()
        {
            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.CommandText = "SELECT * FROM Requisiciones.rango;";
            cmd.CommandType = System.Data.CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();


            List<Rango> lista = new List<Rango>();

            while (dr.Read())
            {
               
       
                Rango rango = new Rango();

                rango.Financieroid = int.Parse(dr["financieroId"].ToString());

                rango.Limitealto = double.Parse(dr["limiteAlto"].ToString());

                rango.Limitebajo = double.Parse(dr["limiteBajo"].ToString());

                lista.Add(rango);
            }

            aux.conectar();
            return lista;
        }

        public Rango consultarRango(int id)
        {
            SqlCommand command = new SqlCommand();
            Conexion conexion = new Conexion();
            command.Connection = conexion.conectar();
            command.CommandText = "select * from rango where financieroId=@id;";
            command.CommandType = System.Data.CommandType.Text;
            command.Parameters.Add(new SqlParameter("financieroId", id));
            SqlDataReader dr = command.ExecuteReader();

            Rango rango = new Rango();
            if (dr.Read())
            {

                rango.Financieroid = int.Parse(dr["financieroId"].ToString());

                rango.Limitealto = double.Parse(dr["limiteAlto"].ToString());

                rango.Limitebajo = double.Parse(dr["limiteBajo"].ToString());




            }
            return rango;
        }
        public bool insertarRango(Rango rango)
        {
            SqlCommand command = new SqlCommand();
            Conexion conexion = new Conexion();
            command.Connection = conexion.conectar();
            command.CommandText = "insert  into rango(financieroId,limiteAlto,limiteBajo) values(@financieroId,@limiteAlto,@limiteBajo)";

            command.CommandType = System.Data.CommandType.Text;
            command.Parameters.Add(new SqlParameter("financieroId", rango.Financieroid));
            command.Parameters.Add(new SqlParameter("limiteAlto", rango.Limitealto));
            command.Parameters.Add(new SqlParameter("limiteBajo", rango.Limitebajo));

            //Para verificar la insercion correctamente
            int rs = command.ExecuteNonQuery();
            conexion.conectar();
            return rs >= 0;
        }
        public bool editarRango(Rango rango)
        {
            SqlCommand command = new SqlCommand();
            Conexion conexion = new Conexion();
            command.Connection = conexion.conectar();
            command.CommandText = "update Rango set financieroId=@financieroId,limitealto=@limitealto,limitebajo=@limitebajo  where financieroId=@id";
            command.CommandType = System.Data.CommandType.Text;
            command.Parameters.Add(new SqlParameter("financieroId", rango.Financieroid));
            command.Parameters.Add(new SqlParameter("limitealto", rango.Limitealto));
            command.Parameters.Add(new SqlParameter("limitebajo", rango.Limitebajo));
           

            int rs = command.ExecuteNonQuery();
            conexion.conectar();
            return rs >= 0;
        }
    }
}
