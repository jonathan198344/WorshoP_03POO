class Program
{
    static void Main()
    {
        int m, n, p;

        Console.Write("Ingrese el valor de m: ");
        m = int.Parse(Console.ReadLine()!);

        Console.Write("Ingrese el valor de n: ");
        n = int.Parse(Console.ReadLine()!);

        Console.Write("Ingrese el valor de p: ");
        p = int.Parse(Console.ReadLine()!);

        int[,] A = new int[m, n];
        int[,] B = new int[n, p];
        int[,] C = new int[m, p];

        // Llenar matriz A
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                A[i, j] = (i + 1) * j;
            }
        }

        // Llenar matriz B
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < p; j++)
            {
                B[i, j] = (j + 1) * i;
            }
        }

        // Multiplicación de matrices A x B
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < p; j++)
            {
                C[i, j] = 0;

                for (int k = 0; k < n; k++)
                {
                    C[i, j] += A[i, k] * B[k, j];
                }
            }
        }

        // Mostrar matriz A
        Console.WriteLine("\n*** A ***");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Mostrar matriz B
        Console.WriteLine("\n*** B ***");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < p; j++)
            {
                Console.Write(B[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Mostrar matriz C
        Console.WriteLine("\n*** C ***");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < p; j++)
            {
                Console.Write(C[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
