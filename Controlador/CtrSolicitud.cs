using Sistema_de_Requisiciones.Modelo;
using System.Collections.Generic;
using System.Data.SqlClient;

using System;
using System.Linq;
using System.Web;
using System.Data.SqlTypes;
using System.Data;


namespace Sistema_de_Requisiciones.Controlador
{
    public class CtrSolicitud
    {
        public List<Solicitud> listarSolicitud()
        {
            Conexion aux = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            cmd.CommandText = "SELECT * FROM Requisiciones.solicitud;";
            cmd.CommandType = System.Data.CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();

            List<Solicitud> lista = new List<Solicitud>();
            while (dr.Read())
            {
                Solicitud solicitud = new Solicitud();

                solicitud.Solicitudid = int.Parse(dr["solicitudId"].ToString());
                solicitud.Nombreproducto = (dr["nombreProducto"].ToString());
                solicitud.Descripcion = dr["descripcion"].ToString();
                solicitud.Precio = int.Parse(dr["precio"].ToString());
                solicitud.Cantidad = int.Parse(dr["cantidad"].ToString());
                solicitud.Comentarios = (dr["comentarios"].ToString());
                solicitud.TipoMovimiento = int.Parse(dr["tipoMovimiento"].ToString());
                solicitud.UsuarioId = int.Parse(dr["usuarioId"].ToString());



                lista.Add(solicitud);
            }
            aux.conectar();
            return lista;
        }
        public Solicitud consultarSolicitud(int id)
        {
            SqlCommand command = new SqlCommand();
            Conexion conexion = new Conexion();
            command.Connection = conexion.conectar();
            command.CommandText = "select * from solicitud where solicitudId=@solicitudId";
            command.CommandType = System.Data.CommandType.Text;
            command.Parameters.Add(new SqlParameter("solicitudId", id));

            SqlDataReader dr = command.ExecuteReader();
            Solicitud solicitud = new Solicitud();
            if (dr.Read())
            {
                solicitud.Solicitudid = int.Parse(dr["solicitudId"].ToString());
                solicitud.Nombreproducto = (dr["nombreProducto"].ToString());
                solicitud.Descripcion = dr["descripcion"].ToString();
                solicitud.Precio = Decimal.Parse(dr["precio"].ToString());
                solicitud.Cantidad = int.Parse(dr["cantidad"].ToString());
                solicitud.Comentarios = (dr["comentarios"].ToString());
                solicitud.TipoMovimiento = int.Parse(dr["tipoMovimiento"].ToString());
                solicitud.UsuarioId = int.Parse(dr["usuarioId"].ToString());
            }
            conexion.conectar();
            return solicitud;
        }

        public DataTable obtenerTablaSolicitud(string consultar)
        {
            string condiciones = "";
            if (consultar == "nueva")
                condiciones = " where usuario.usuarioId = solicitud.usuarioId AND solicitud.tipoMovimiento = 1";

            if (consultar == "aprobada")
                condiciones = " where usuario.usuarioId = solicitud.usuarioId AND solicitud.tipoMovimiento = 2";

            if (consultar == "rechazada")
                condiciones = " where usuario.usuarioId = solicitud.usuarioId AND solicitud.tipoMovimiento = 3";
           
            DataTable dtbl = new DataTable();
            SqlCommand command = new SqlCommand();
            Conexion conexion = new Conexion();
            SqlDataAdapter sqlDa = new SqlDataAdapter("select solicitud.*, concat(nombre, apellido) as nombre, precio from solicitud, usuario"+ condiciones, conexion.conectar());
           sqlDa.Fill(dtbl);
           conexion.conectar();
           return dtbl;
        }

        public DataTable obtenerTablaSolicitudFinanciero(string consultar, int tipoFinanciero)
        {

            string maxLim, minLim, condicionRango;
            if (tipoFinanciero == 4)
            {
                minLim = "1";
                maxLim = "100000";
            }
            else 
            if (tipoFinanciero == 5)
            {
                minLim = "100000";
                maxLim = "1000000";
            }
            else 
            if (tipoFinanciero == 6)
            {
                minLim = "1000000";
                maxLim = "100000000";
            }
            else
            {
                minLim = "1000000";
                maxLim = "10000000000";
            }

            condicionRango = "AND solicitud.precio > " + minLim + " AND solicitud.precio < " + maxLim;

                string condiciones = "";
            if (consultar == "nueva")
                condiciones = " where usuario.usuarioId = solicitud.usuarioId AND solicitud.tipoMovimiento = 2 " + condicionRango;

            if (consultar == "aprobada")
                condiciones = " where usuario.usuarioId = solicitud.usuarioId AND solicitud.tipoMovimiento = 4 " + condicionRango;

            if (consultar == "rechazada")
                condiciones = " where usuario.usuarioId = solicitud.usuarioId AND solicitud.tipoMovimiento = 5 " + condicionRango;

            DataTable dtbl = new DataTable();
            SqlCommand command = new SqlCommand();
            Conexion conexion = new Conexion();
            SqlDataAdapter sqlDa = new SqlDataAdapter("select solicitud.*, concat(nombre, apellido) as nombre, precio from solicitud, usuario" + condiciones, conexion.conectar());
            sqlDa.Fill(dtbl);
            conexion.conectar();
            return dtbl;
        }
        ///falta-->
        public static bool insertarSolicitud(Solicitud solicitud)
        {
            SqlCommand command = new SqlCommand();
            Conexion conexion = new Conexion();
            command.Connection = conexion.conectar();
            command.CommandText = "insert  into solicitud(nombreProducto,precio,cantidad,descripcion,comentarios,tipoMovimiento,usuarioId) values(@nombreProducto,@precio,@cantidad, @descripcion,@comentarios,@tipoMovimiento,@usuarioId)";
            command.CommandType = System.Data.CommandType.Text;
            //solicitudId --> into
            //@solicitudId,--> Identity

            //command.Parameters.Add(new SqlParameter("solicitudId", solicitud.Solicitudid));
            command.Parameters.Add(new SqlParameter("nombreProducto", solicitud.Nombreproducto));
            command.Parameters.Add(new SqlParameter("descripcion", solicitud.Descripcion));
            command.Parameters.Add(new SqlParameter("precio", solicitud.Precio));
            command.Parameters.Add(new SqlParameter("cantidad", solicitud.Cantidad));
            command.Parameters.Add(new SqlParameter("comentarios", solicitud.Comentarios));
            command.Parameters.Add(new SqlParameter("tipoMovimiento", solicitud.TipoMovimiento));
            command.Parameters.Add(new SqlParameter("usuarioId", solicitud.UsuarioId));

            //Para verificar la insercion correctamente
            int rs = command.ExecuteNonQuery();
            conexion.conectar();
            return rs >= 0;
        }
        public bool editarSolicitud(Solicitud solicitud)
        {
            SqlCommand command = new SqlCommand();
            Conexion conexion = new Conexion();
            command.Connection = conexion.conectar();
            command.CommandText = "update solicitud set nombreProducto=@nombreProducto,precio=@precio,cantidad=@cantidad,comentarios=@comentarios,tipoMovimiento=@tipoMovimiento, usuarioId=@usuarioId where solicitudId=@solicitudId";
            command.CommandType = System.Data.CommandType.Text;

            command.Parameters.Add(new SqlParameter("solicitudId", solicitud.Solicitudid));
            command.Parameters.Add(new SqlParameter("nombreProducto", solicitud.Nombreproducto));
            command.Parameters.Add(new SqlParameter("precio", solicitud.Precio));
            command.Parameters.Add(new SqlParameter("cantidad", solicitud.Cantidad));
            command.Parameters.Add(new SqlParameter("comentarios", solicitud.Comentarios));
            command.Parameters.Add(new SqlParameter("tipoMovimiento", solicitud.TipoMovimiento));
            command.Parameters.Add(new SqlParameter("usuarioId", solicitud.UsuarioId));


            int rs = command.ExecuteNonQuery();
            conexion.conectar();
            return rs >= 0;
        }

        public bool editarSolicitudByField(Solicitud solicitud)
        {
            string comandoArmado = "";
            SqlCommand command = new SqlCommand();
            Conexion conexion = new Conexion();
            command.Connection = conexion.conectar();
            command.CommandText = "update solicitud set solicitudId=@solicitudId,nombreProducto=@nombreProducto,precio=@precio,cantidad=@cantidad,comentarios=@comentarios,tipoMovimiento=@tipoMovimiento, usuarioId=usuarioId@   where solicitudId=@id";
            command.CommandType = System.Data.CommandType.Text;

            command.Parameters.Add(new SqlParameter("solicitudId", solicitud.Solicitudid));
            command.Parameters.Add(new SqlParameter("nombreProducto", solicitud.Nombreproducto));
            command.Parameters.Add(new SqlParameter("precio", solicitud.Precio));
            command.Parameters.Add(new SqlParameter("cantidad", solicitud.Cantidad));
            command.Parameters.Add(new SqlParameter("comentarios", solicitud.Comentarios));
            command.Parameters.Add(new SqlParameter("tipoMovimiento", solicitud.TipoMovimiento));
            command.Parameters.Add(new SqlParameter("usuarioId", solicitud.UsuarioId));


            int rs = command.ExecuteNonQuery();
            conexion.conectar();
            return rs >= 0;
        }
    }
}