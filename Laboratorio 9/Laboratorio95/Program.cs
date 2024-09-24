using System;
public class Program
{
    public static void Main(string[] args)
    {
        Aleatorio2 aleatorios = new Aleatorio2();

        Console.WriteLine("Arreglo de números no repetidos entre 1 y 50:");
        int[] arregloNoRepetidos = aleatorios.GenerarArregloNumerosNoRepetidos(1, 50, 10);
        foreach (int numero in arregloNoRepetidos)
        {
            Console.WriteLine(numero);
        }
    }
}
