namespace El_simulador_de_la_cafeteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lista de bebidas
            List<bebida> pedido = new List<bebida>();
            pedido.Add(new BebidaCaliente("Café", "Grande", 97.5f, 89));
            pedido.Add(new BebidaFria("cold briew", "chico", 35.00f, 7));
            pedido.Add(new BebidaCaliente("Espresso", "Grande", 70.00f, 80));
            pedido.Add(new BebidaFria("Limonada", "Chico", 45.00f, 5));
            pedido.Add(new BebidaCaliente("Moka", "Mediano", 79.0f, 90));

            float total = 0;

            // Recorrido con FOR
            Console.WriteLine("****Ticket***:\n");
            for (int i = 0; i < pedido.Count; i++)
            {
                Console.WriteLine(pedido[i].preparar());
                if (pedido[i] is BebidaCaliente caliente)
                {
                    if (caliente.temperatura > 88)
                    {
                        Console.WriteLine("***!ADVERTENCIA!*** ¡Cuidado, bebida muy caliente!");
                    }
                }

                total += pedido[i].Precio;

                Console.WriteLine("-----------------------------------------------------------------------------");
            }

            Console.WriteLine("\nTOTAL: $" + total);

            Console.ReadKey();
        }
    }
        
}

