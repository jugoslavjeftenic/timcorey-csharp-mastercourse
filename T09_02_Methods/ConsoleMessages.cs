
namespace T09_02_Methods
{
    public class ConsoleMessages
    {
        public static string? GetUsersName()
        {
            Console.Write("What is your name? ");
            return Console.ReadLine();
        }

        public static void SayHi()
        {
            Console.WriteLine("Hello User");
            Console.WriteLine("I hope you are having a good day.");
        }

        public static void SayHi(string name)
        {
            Console.WriteLine($"Hello {name}");
            Console.WriteLine("I hope you are having a good day.");
        }

        public static void SayGoodbye()
        {
            Console.WriteLine("Goodbye, my user.");
            Console.WriteLine("Thank you for visiting.");
            Console.WriteLine("I cannot wait to see you again.");
        }

        // Tuples
        public static (string? firstName, string? lastName) GetFullName()
        {
            Console.Write("What is your first name? ");
            string? firstName = Console.ReadLine();

            Console.Write("What is your last name? ");
            string? lastName = Console.ReadLine();

            return (firstName, lastName);
        }
    }
}
