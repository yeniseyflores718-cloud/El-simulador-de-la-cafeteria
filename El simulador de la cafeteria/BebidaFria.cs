using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace El_simulador_de_la_cafeteria
{
    internal class BebidaFria: bebida
    {
        private int CantidadHielo;

        public int cantidadHielo
        {
            get { return CantidadHielo; }
            set { CantidadHielo = value; }
        }

        public BebidaFria(string _nombre, string _tamaño, float _precio, int _cantidadHielo) : base(_nombre, _tamaño, _precio)
        {
            CantidadHielo = _cantidadHielo;
        }

        //metodo sobreescrito(Polimorfismo)
        public override string preparar()
        {
            return "Preparando un : " + nombre + " Fria  de tamaño : " + tamano;
        }
    }
}
