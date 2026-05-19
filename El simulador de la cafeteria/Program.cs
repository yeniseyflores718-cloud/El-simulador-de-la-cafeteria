namespace El_simulador_de_la_cafeteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string nombre, tamaño;
            float precio;
            // Primera bebida
            
            Console.WriteLine("Ingrese el nombre de la bebida 1:");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el tamaño:");
            tamaño = Console.ReadLine();

            Console.WriteLine("Ingrese el precio:");
            precio = float.Parse(Console.ReadLine());

            bebida bebida1 = new bebida(nombre, tamaño, precio);
            // Segunda bebida
            Console.WriteLine("\nIngrese el nombre de la bebida 2:");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el tamaño:");
            tamaño = Console.ReadLine();

            Console.WriteLine("Ingrese el precio:");
            precio = float.Parse(Console.ReadLine());

            bebida bebida2 = new bebida(nombre, tamaño, precio);
            // Tercera bebida
            Console.WriteLine("\nIngrese el nombre de la bebida 3:");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el tamaño:");
            tamaño = Console.ReadLine();

            Console.WriteLine("Ingrese el precio:");
            precio = float.Parse(Console.ReadLine());

            bebida bebida3 = new bebida(nombre, tamaño, precio);
            bebida1.AplicarDescuento(20);
            bebida2.AplicarDescuento(10);
            bebida3.AplicarDescuento(0);

            Console.WriteLine("Preparando....");
            Console.WriteLine("\n" + bebida1.preparar());
            Console.WriteLine("\n" + bebida2.preparar());
            Console.WriteLine("\n" + bebida3.preparar());


            Console.WriteLine("\n Descripcion del pedido....");
            Console.WriteLine("\n" + bebida1.MostrarDescripcion ());
            Console.WriteLine("\n" + bebida2.MostrarDescripcion());
            Console.WriteLine("\n" + bebida3.MostrarDescripcion());

            Console.ReadKey();
        }
    }
        
    }

