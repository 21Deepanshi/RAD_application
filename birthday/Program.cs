namespace birthday
{
    public class User
    {
        public string Name { get; private set; }
        public int Age
        {
            get
            {
                return (DateTime.Now - Birthday).Days / 365;
            }
        }

        public DateTime Birthday { get; private set; }
        public User(string name, DateTime birthday)
        {
            Name = name;
            Birthday = birthday;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = new User("Deepanshi", new DateTime(1990,10,3));
            Console.WriteLine(user.Age);
        }
    }
}
