using System;

public class Program
{
    public static void Main(string[] args)
    {
        Aleatorios aleatorios = new Aleatorios();

        Console.WriteLine("Número aleatorio entre 5 y 10: " + aleatorios.GenerarNumeroEntre(5, 10));

        Console.WriteLine("Arreglo de números aleatorios entre 1 y 50:");
        int[] arreglo = aleatorios.GenerarArregloNumerosEntre(1, 50, 5);
        foreach (int numero in arreglo)
        {
            Console.WriteLine(numero);
        }
    }
}
