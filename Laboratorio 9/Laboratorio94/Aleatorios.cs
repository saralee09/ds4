using System;

namespace Lab94
{
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

        public int[] GenerarArregloNumerosNoRepetidos(int min, int max, int tamaño)
        {
            if (tamaño > (max - min + 1))
            {
                throw new ArgumentException("El rango no puede contener suficientes números únicos para el tamaño solicitado.");
            }

            int[] arreglo = new int[tamaño];
            HashSet<int> numerosGenerados = new HashSet<int>();

            int contador = 0;
            while (contador < tamaño)
            {
                int numero = GenerarNumeroEntre(min, max);
                if (!numerosGenerados.Contains(numero))
                {
                    numerosGenerados.Add(numero);
                    arreglo[contador] = numero;
                    contador++;
                }
            }
            return arreglo;
        }
    }
}
