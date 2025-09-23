
class program1
{
    private static void Main(string[]args)
    {
        //Declaracion de un arreglo tipo vector
        int[] valores;
        //declarar el tamano despues de la declaracion
        valores = new int[20]; //contiene 20 elementos

        //Arreglos multidimencionales
        int[,] valores1;
        int[,] valores2 = new int[3, 7];//dos dimenciones

        //arreglo de arreglos
        int[][] matriz = new int[3][];
        for (int i =0; i<matriz.Length; i++)
        {
            matriz[i] = new int[4];
        }

    }
}