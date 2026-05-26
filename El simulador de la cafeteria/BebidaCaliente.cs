using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace El_simulador_de_la_cafeteria
{
    internal class BebidaCaliente : bebida
    {
        private int Temperatura;

        public int temperatura
        {
            get { return Temperatura; }
            set { Temperatura = value; }
        }

        //constructor en cuando heredamos 
        public BebidaCaliente(string nombre, string tamano, float precio, int _temperatura) : base(nombre, tamano, precio)
        {
            Temperatura = _temperatura;
        }

        //metodo sobreescrito(Polimorfismo)
        public override string preparar()
        {
            return "Preparando un : " + nombre + " Caliente  de tamaño : " + tamano + " a una temperatura de : " + Temperatura + "°C";
        }
    }
}
