using System;

namespace FiguraGeometrica2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;

            Console.WriteLine("FIGURA GEOMETRICA #2 - ROMBO");
            Console.WriteLine();

            // parte superior .
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            // parte inferior .
            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Presione una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}