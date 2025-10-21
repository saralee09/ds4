using System;

namespace SucesionMatematica
{
    class Program
    {
        static void Main(string[] args)
        {
            // cuantos términos quiere el usuario
            Console.Write("Ingrese el número de términos: ");
            int n = int.Parse(Console.ReadLine());

            int sumatoria = 0;

            // Encabezado de tabla para que quede centreado
            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine($"{"Iteración",-10}{"Término",-12}{"Sumatoria",-12}");
            Console.WriteLine("-------------------------------------------");

            // Bucle principal
            for (int i = 1; i <= n; i++)
            {
                // los signoa negativo y positivo
                int signo = (i % 2 == 0) ? -1 : 1;

                // Cálculo del término: signo( 2^i)
                int termino = signo * (int)Math.Pow(2, i);

                // la sumatoria
                sumatoria += termino;

                Console.WriteLine($"{i,-10}{termino,-12}{sumatoria,-12}");
            }

        }
    }
}

