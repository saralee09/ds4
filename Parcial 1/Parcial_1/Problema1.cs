internal class Matriz
{
    private int[,] mat;

    public void Ingresar()
    {
        int x = 10; // fila
        int y = 10; // columna
        mat = new int[x, y];

        // Primera fila en aumento hasta el valor maximo
        for (int c = 0; c < y; c++)
        {
            mat[0, c] = c + 1;
        }

        // Última fila en retroceso hasta 1
        for (int c = 0; c < y; c++)
        {
            //lo que mas se me complico, (vertical maxima, c) es y(que seria el numero que elegimos de N - C que seria el indice actual del arreglo en horizontal
            mat[x - 1, c] = y - c;
        }

       
    }

    public void Imprimir()
    {
        for (int f = 0; f < mat.GetLength(0); f++)
        {
            for (int c = 0; c < mat.GetLength(1); c++)
            {
                Console.Write(mat[f, c] + " ");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }

    static void Main(string[] args)
    {
        Matriz ma = new Matriz();
        ma.Ingresar();
        ma.Imprimir();
    }
}