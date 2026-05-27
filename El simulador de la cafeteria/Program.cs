namespace El_simulador_de_la_cafeteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lista de bebidas
            List<bebida> pedido = new List<bebida>();
            pedido.Add(new BebidaCaliente("Café Americano", "Grande", 90.5f, 89));
            pedido.Add(new BebidaFria("Frappé de Capuchino", "Mediano", 60.00f, 7));
            pedido.Add(new BebidaCaliente("Chocolate Caliente", "Grande", 55.00f, 80));
            pedido.Add(new BebidaFria("Té Helado", "Chico", 85.00f, 5));
            pedido.Add(new BebidaCaliente("Latte", "Mediano", 89.0f, 90));

            Console.WriteLine("**** TICKET ****\n");

            float total = 0;
            foreach (bebida bebida in pedido)
            {
                Console.WriteLine(bebida.preparar());

                // Pattern Matching
                if (bebida is BebidaCaliente caliente)
                {
                    if (caliente.temperatura > 88)
                    {
                        Console.WriteLine("[!] ADVERTENCIA: ¡Cuidado, bebida muy caliente!");
                    }
                }

                total += bebida.Precio;

                Console.WriteLine("-----------------------------------------------------------------------------------------");
            }
            Console.WriteLine("\nTOTAL A PAGAR: $" + total);        
        }
    }
        
}

