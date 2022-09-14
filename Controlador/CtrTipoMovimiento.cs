using Sistema_de_Requisiciones.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Sistema_de_Requisiciones.Controlador
{
    public class CtrTipoMovimiento
    {
        public List<TipoMovimiento> listarTipoMovimiento()
        {
            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.CommandText = "SELECT * FROM Requisiciones.tipoMovimiento;";
            cmd.CommandType = System.Data.CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();


            List<TipoMovimiento> lista = new List<TipoMovimiento>();

            while (dr.Read())
            {


                TipoMovimiento tipoMovimiento = new TipoMovimiento();

                tipoMovimiento.Tipomovimientoid = int.Parse(dr["tipoMovimientoId"].ToString());

                tipoMovimiento.Estado= bool.Parse(dr["estado"].ToString());

                lista.Add(tipoMovimiento);
            }

            aux.conectar();
            return lista;
        }

        public TipoMovimiento consultarTipoMovimiento(int id)
        {
            SqlCommand command = new SqlCommand();
            Conexion conexion = new Conexion();
            command.Connection = conexion.conectar();
            command.CommandText = "select * from tipoMovimiento where tipoMovimientoId=@id;";
            command.CommandType = System.Data.CommandType.Text;
            command.Parameters.Add(new SqlParameter("tipoMovimientoId", id));
            SqlDataReader dr = command.ExecuteReader();

            TipoMovimiento tipoMovimiento = new TipoMovimiento();
            if (dr.Read())
            {

                tipoMovimiento.Tipomovimientoid = int.Parse(dr["tipoMovimientoId"].ToString());

                tipoMovimiento.Estado = bool.Parse(dr["estado"].ToString());

            }
            return tipoMovimiento;
        }
        public bool insertarTipoMovimiento(TipoMovimiento tipoMovimiento)
        {
            SqlCommand command = new SqlCommand();
            Conexion conexion = new Conexion();
            command.Connection = conexion.conectar();
            command.CommandText = "insert  into tipoMovimiento(tipoMovimientoId,estado) values(@tipoMovimientoId,@estado)";

            command.CommandType = System.Data.CommandType.Text;
            command.Parameters.Add(new SqlParameter("tipoMovimientoId", tipoMovimiento.Tipomovimientoid));
            command.Parameters.Add(new SqlParameter("estado", tipoMovimiento.Estado));
 
            //Para verificar la insercion correctamente
            int rs = command.ExecuteNonQuery();
            conexion.conectar();
            return rs >= 0;
        }
        public bool editarTipoMovimiento(TipoMovimiento tipoMovimiento)
        {
            SqlCommand command = new SqlCommand();
            Conexion conexion = new Conexion();
            command.Connection = conexion.conectar();
            command.CommandText = "update  set tipoMovimientoId=@tipoMovimiento,estado=@estado  where tipoMovimientoId=@id";
            command.CommandType = System.Data.CommandType.Text;
            command.Parameters.Add(new SqlParameter("tipoMovimientoId", tipoMovimiento.Tipomovimientoid));
            command.Parameters.Add(new SqlParameter("estado", tipoMovimiento.Estado));
            int rs = command.ExecuteNonQuery();
            conexion.conectar();
            return rs >= 0;
        }
    }
}