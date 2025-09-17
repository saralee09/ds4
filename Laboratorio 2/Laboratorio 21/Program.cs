using System;

namespace Laboraorio21
{
    public class Program
    {
        public static void MAIN()
        {
            MyClass.Valor = 1;
            Console.WriteLine(MyClass.Valor);
        }
    }

    public class MyClass
    {
        public static int Valor;
    }

}