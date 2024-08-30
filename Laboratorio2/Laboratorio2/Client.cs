namespace Laboraorio2
{
    public class Client
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int ID { get; set; }

        public string GetFullname()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
