using System;

public class Aleatorios
{
    private Random random;

    public Aleatorios()
    {
        random = new Random();
    }

    public int GenerarNumeroEntre(int min, int max)
    {
        return random.Next(min, max + 1);
    }

    public int[] GenerarArregloNumerosEntre(int min, int max, int tamaño)
    {
        int[] arreglo = new int[tamaño];
        for (int i = 0; i < tamaño; i++)
        {
            arreglo[i] = GenerarNumeroEntre(min, max);
        }
        return arreglo;
    }
}
