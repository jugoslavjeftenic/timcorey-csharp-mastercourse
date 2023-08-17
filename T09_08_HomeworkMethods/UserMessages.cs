
namespace T09_08_HomeworkMethods
{
    public static class UserMessages
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to Application.");
        }

        public static string? GetUserName()
        {
            Console.Write("Please enter your name: ");
            return Console.ReadLine();
        }

        public static string HelloUser(string? name)
        {
            return $"Hello {name}.";
        }
    }
}
