using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace El_simulador_de_la_cafeteria
{
    internal class bebida
    {
        protected string nombre;
        protected string tamaño;
        protected float precio;
        private float descuento;
        //propiedades
        public string  Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Tamaño
        {
            get { return tamaño; }
            set { tamaño = value; }
        }

        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        //constructor parametrizado
        public bebida(string nombre, string tamano, float precio)
        {
            this.nombre = nombre;
            this.tamaño = tamano;
            this.precio = precio;
        }
        // contructor vacio
        public bebida()
        {
            Nombre = "";
            Tamaño = "";
            Precio = 0.0F;
        }
        //metodos 
        public virtual string preparar()
        {
            return "Preparando un : " + Nombre + " de tamaño : " + Tamaño;
        }

        public void Descuento(float descuento)
        {
            Precio = Precio * (1 - (descuento / 100));
        }
        public string MostrarDescripcion()
        {
            return "Esto es un " + nombre + " de tamaño " + tamaño + " con un costo de $" + precio;
        }

    }
}
