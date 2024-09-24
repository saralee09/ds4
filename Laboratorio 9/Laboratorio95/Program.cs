using System;
using Lab94;

public class Program
{
    public static void Main(string[] args)
    {
        Aleatorios aleatorios = new Aleatorios();

        Console.WriteLine("Arreglo de números no repetidos entre 1 y 50:");
        int[] arregloNoRepetidos = aleatorios.GenerarArregloNumerosNoRepetidos(1, 50, 10);
        foreach (int numero in arregloNoRepetidos)
        {
            Console.WriteLine(numero);
        }
    }
}
