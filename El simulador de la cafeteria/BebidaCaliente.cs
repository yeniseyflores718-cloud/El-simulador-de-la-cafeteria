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
        private float Temperatura;

        public float temperatura
        {
            get { return Temperatura; }
            set { Temperatura = value; }
        }
        //constructor 
        public BebidaCaliente(string nombre, string tamano, float precio, int _temperatura) : base(nombre, tamano, precio)
        {
            Temperatura = _temperatura;
        }
        //polimorfismo
        public override string preparar()
        {
            return "Estamos preparando un : " + Nombre + " Caliente (Temperatura: " + Temperatura +
                   "°C) tamaño : " + Tamaño;
        }
    }
}
