using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_de_Requisiciones.Modelo
{
    public class Rango
    {
        private int _Financieroid;
        private double _Limitealto;
        private double _Limitebajo;

        public int Financieroid { get => _Financieroid; set => _Financieroid = value; }
        public double Limitealto { get => _Limitealto; set => _Limitealto = value; }
        public double Limitebajo { get => _Limitebajo; set => _Limitebajo = value; }
    }
}