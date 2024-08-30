using System;

namespace Laboraorio2
{
    public class MyClass
    {
        public void MyMethod()
        {
            int valor1 = 21;
            int valor2;

            valor2 = valor1;
            valor2 = 22;

            Console.WriteLine(valor1);
            Console.WriteLine(valor2);
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.MyMethod();
        }
    }
}
