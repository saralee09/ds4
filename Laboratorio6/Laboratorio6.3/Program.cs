class Program
{
    static void Main(string[] args)
    {
        try
        {
            int[] MyNumbers = { 1, 2, 3 };
            Console.WriteLine(MyNumbers[10]);
        }
        catch (Exception e)
        {
            Console.WriteLine("algo salio mal, valide el indice del arreglo");
        }
        finally
        {
            Console.WriteLine("Continuacion de la aplicacion lueo del bloque try/catch");
        }
    }
}