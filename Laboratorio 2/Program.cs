namespace Laboraorio2
{
    private static void Main(string[] args)
    {
        Client client = new Client
        {
            FirstName = "su_nombre",
            LastName = "su_apellido",
            Age = 15,
            ID = 1
        };

        Console.WriteLine(client.GetFullname());
    }

    public class MyClass
    {
        public void MyMethod()
        {
            int valor1 = 28;
            int valor2 = valor1;
            valor2 = 30;

            Console.WriteLine(valor1);
            Console.WriteLine(valor2);

            Console.WriteLine(valor1);
            Console.WriteLine(valor2);
        }
}