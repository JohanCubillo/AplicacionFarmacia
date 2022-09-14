using Sistema_de_Requisiciones.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_de_Requisiciones
{
    public class UsuarioSinglenton
    {
        private UsuarioSinglenton() { }

        private static UsuarioSinglenton _instance;
        public string[] rutas = { 
            "Administrador.aspx"
            ,"Comprador_Hacer_Pedidos.aspx"
            ,"Aprobadpr_Jefe.aspx"
            ,"Aprobador_Financiero1.aspx"
            ,"Aprobador_Financiero1.aspx"
            ,"Aprobador_Financiero1.aspx"};
        public Usuario usuario;
        public static UsuarioSinglenton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new UsuarioSinglenton();
            }
            return _instance;
        }

        
    }
}