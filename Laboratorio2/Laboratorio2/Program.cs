namespace Laboraorio2
{
    internal class Program
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
    }
}
