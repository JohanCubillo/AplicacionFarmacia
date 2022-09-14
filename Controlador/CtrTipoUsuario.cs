using Sistema_de_Requisiciones.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Sistema_de_Requisiciones.Controlador
{
    public class CtrTipoUsuario
    {

        public List<TipoUsuario> listarTipoUsuario()
        {
            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.CommandText = "SELECT * FROM Requisiciones.tipoUsuario;";
            cmd.CommandType = System.Data.CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();

            List<TipoUsuario> lista = new List<TipoUsuario>();
            while (dr.Read())
            {
                TipoUsuario tipoUsuario = new TipoUsuario();

                tipoUsuario.TipoUsuarioId1 = int.Parse(dr["tipoUsuarioId"].ToString());
                tipoUsuario.Rol1 = dr["rol"].ToString();
                tipoUsuario.FinancieroId1 = int.Parse(dr["financieroId"].ToString());

                lista.Add(tipoUsuario);
            }
            aux.conectar();
            return lista;
        }
        public TipoUsuario consultarTipoUsuario(int id)
        {
            SqlCommand command = new SqlCommand();
            Conexion conexion = new Conexion();
            command.Connection = conexion.conectar();
            command.CommandText = "select * from tipoUsuario where tipoUsuarioId=@id;";
            command.CommandType = System.Data.CommandType.Text;
            command.Parameters.Add(new SqlParameter("tipoUsuarioId", id));
            SqlDataReader dr = command.ExecuteReader();
            TipoUsuario tipoUsuario = new TipoUsuario();
            if (dr.Read())
            {
                tipoUsuario.TipoUsuarioId1 = int.Parse(dr["tipoUsuarioId"].ToString());
                tipoUsuario.Rol1 = dr["rol"].ToString();
                tipoUsuario.FinancieroId1 = int.Parse(dr["financieroId"].ToString());
            }
            return tipoUsuario;
        }
        public bool insertarTipoUsuario(TipoUsuario tipoUsuario)
        {
            SqlCommand command = new SqlCommand();
            Conexion conexion = new Conexion();
            command.Connection = conexion.conectar();
            command.CommandText = "insert  into tipoUsuario(rol,financieroId) values(@rol,@financieroId)";
            command.CommandType = System.Data.CommandType.Text;
            command.Parameters.Add(new SqlParameter("rol", tipoUsuario.Rol1));
            command.Parameters.Add(new SqlParameter("financieroId", tipoUsuario.FinancieroId1));

            //Para verificar la insercion correctamente
            int rs = command.ExecuteNonQuery();
            conexion.conectar();
            return rs >= 0;
        }
        public bool editarTipoUsuario(TipoUsuario tipoUsuario)
        {
            SqlCommand command = new SqlCommand();
            Conexion conexion = new Conexion();
            command.Connection = conexion.conectar();
            command.CommandText = "update tipoUsuario set rol=@rol,financieroId=@financieroId where tipoUsuarioId=@tipoUsuarioId";
            command.CommandType = System.Data.CommandType.Text;
            command.Parameters.Add(new SqlParameter("tipoUsuarioId", tipoUsuario.TipoUsuarioId1));
            command.Parameters.Add(new SqlParameter("rol", tipoUsuario.Rol1));
            command.Parameters.Add(new SqlParameter("financieroId", tipoUsuario.FinancieroId1));
          

            int rs = command.ExecuteNonQuery();
            conexion.conectar();
            return rs >= 0;
        }
    


    }
}