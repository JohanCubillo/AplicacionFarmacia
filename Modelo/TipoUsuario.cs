using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_de_Requisiciones.Modelo
{
    public class TipoUsuario
    {
        private int TipoUsuarioId;
        private string Rol;
        private int FinancieroId;

        public int TipoUsuarioId1 { get => TipoUsuarioId; set => TipoUsuarioId = value; }
        public string Rol1 { get => Rol; set => Rol = value; }
        public int FinancieroId1 { get => FinancieroId; set => FinancieroId = value; }
    }
}