namespace Laboraorio2
{
    internal class Program
    {
        private static void Main()
        {
            //Variable de clase

            MyClass.Valor = 1;

            Console.WriteLine(MyClass.Valor);
        }
    }

    public class MyClass
    {
        public static int Valor;
    }
}
