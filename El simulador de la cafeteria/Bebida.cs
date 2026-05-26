using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_simulador_de_la_cafeteria
{
    internal class bebida
    {
        protected string nombre;
        protected string tamano;
        protected float precio;
        private float descuento;
        public float Descuento
        {
            get { return descuento; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    descuento = value;
                }
                else
                {
                    descuento = -1;
                }
            }
        }
        //constructor
        public bebida(string nombre, string tamano, float precio)
        {
            this.nombre = nombre;
            this.tamano = tamano;
            this.precio = precio;
        }
        public virtual string preparar()
        {
            return "preparando un: "+ nombre+ " tamaño: "+ tamano;
        }
        // Método para aplicar descuento
        public void AplicarDescuento(float porcentaje)
        {
            // Usar la propiedad para validar
            Descuento = porcentaje;

            if (Descuento != -1)
            {
                float descuentoAplicado = precio * (Descuento / 100);
                precio = precio - descuentoAplicado;

                Console.WriteLine("Descuento aplicado correctamente.");
            }
            else
            {
                Console.WriteLine("Error: el descuento debe estar entre 0 y 100.");
            }
        }
        // Método para mostrar descripción
        public string MostrarDescripcion()
        {
            return "Esto es un " + nombre +
                              " de tamaño " + tamano +
                              " con un costo de $" + precio;
        }
    }
}
