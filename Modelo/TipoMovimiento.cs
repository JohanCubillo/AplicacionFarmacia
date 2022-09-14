using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_de_Requisiciones.Modelo
{
    public class TipoMovimiento
    {
        private int _Tipomovimientoid;
        private bool _Estado;

        public int Tipomovimientoid { get => _Tipomovimientoid; set => _Tipomovimientoid = value; }
        public bool Estado { get => _Estado; set => _Estado = value; }
    }
}