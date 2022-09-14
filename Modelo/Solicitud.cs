using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_de_Requisiciones.Modelo
{
    public class Solicitud
    {
        private int _Solicitudid;
        private string _Nombreproducto;
        private string _Descripcion;
        private Decimal _Precio;
        private int _Cantidad;
        private string _Comentarios;
        private int _TipoMovimiento;
        private int _UsuarioId;

        public int Solicitudid { get => _Solicitudid; set => _Solicitudid = value; }
        public string Nombreproducto { get => _Nombreproducto; set => _Nombreproducto = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public Decimal Precio { get => _Precio; set => _Precio = value; }
        public int Cantidad { get => _Cantidad; set => _Cantidad = value; }
        public string Comentarios { get => _Comentarios; set => _Comentarios = value; }
        public int TipoMovimiento { get => _TipoMovimiento; set => _TipoMovimiento = value; }
        public int UsuarioId { get => _UsuarioId; set => _UsuarioId = value; }
    }
}