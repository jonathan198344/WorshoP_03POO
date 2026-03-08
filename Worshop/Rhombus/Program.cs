class Program
{
    static void Main()
    {
        Console.Write("Ingrese el tamaño del rombo: ");
        int n = int.Parse(Console.ReadLine()!);

        int mitad = n / 2;

        for (int i = 0; i < n; i++)
        {
            int espacios = Math.Abs(mitad - i);
            int ancho = n - 2 * espacios;

            // Espacios antes del rombo
            for (int j = 0; j < espacios; j++)
            {
                Console.Write(" ");
            }

            // Imprimir los #
            if (ancho == 1)
            {
                Console.Write("#");
            }
            else
            {
                Console.Write("#");

                for (int j = 0; j < ancho - 2; j++)
                {
                    Console.Write(" ");
                }

                Console.Write("#");
            }

            Console.WriteLine();
        }
    }
}
