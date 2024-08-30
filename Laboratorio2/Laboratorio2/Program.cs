using System;

namespace Laboraorio2
{
    public class MyClass
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public void MyMethod()
        {
            int valor1 = 21;
            int valor2;

            valor2 = valor1;
            valor2 = 22;

            Console.WriteLine(valor1);
            Console.WriteLine(valor2);
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int ID { get; set; }

        public string GetFullname()
        {
            return $"{FirstName} {LastName}";
        }
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

            // Tipos de datos alfanumericos
            char caracter = 'A';
            string cadena = "Cadena de caracteres";

            // Tipo de datos Logicos booleanos
            bool condicion = true;

            // Variable Instancia
            MyClass client = new MyClass
            {
                FirstName = "su_nombre",
                LastName = "su_apellido",
                Age = 15,
                ID = 1
            };

            Console.WriteLine(client.GetFullname());

            // Llamada al método MyMethod
            object1.MyMethod();
        }
    }
}
