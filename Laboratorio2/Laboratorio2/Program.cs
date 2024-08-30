using System;

namespace Laboraorio2
{
    public class MyClass
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            MyClass object1 = new MyClass();
            object1.Nombre = "Yeison";
            object1.Edad = 28;

            MyClass object2 = object1;

            object2.Nombre = "Jose";

            // Al imprimir en consola vemos que ambas referencias imprimen el mismo valor "Jose".
            Console.WriteLine(object2.Nombre);
            Console.WriteLine(object1.Nombre);

            //Tipos de datos alfanumericos
            char caracter = 'A';
            string cadena = "Cadena de caracteres";

            //Tipo de datos Logicos booleanos
            bool condicion = true;

        }
    }
}
