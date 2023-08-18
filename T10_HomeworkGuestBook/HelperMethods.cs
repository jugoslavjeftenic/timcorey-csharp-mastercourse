
namespace T10_HomeworkGuestBook
{
    public static class HelperMethods
    {
        public static (string guestName, int numberOfPartyMembers) GetGuestNameAndNumberOfPartyMembers()
        {
            string? guestName;
            int numberOfPartyMembers;

            do
            {
                Console.Write("Please, tell us your name? ");
                guestName = Console.ReadLine();

                if (guestName == null || guestName.Length < 2)
                {
                    Console.WriteLine("Your name has to have at least two characters.");
                }
                else
                {
                    break;
                }
            } while (true);

            do
            {
                Console.Write("Please, tell us how many guests do you have? ");

                if (int.TryParse(Console.ReadLine(), out numberOfPartyMembers) == false ||
                    numberOfPartyMembers < 0)
                {
                    Console.WriteLine("Please enter valid number of guests.");
                }
                else
                {
                    break;
                }
            } while (true);

            return (guestName, numberOfPartyMembers);
        }

        public static bool AddAnotherGuest()
        {
            do
            {
                Console.Write("Add another guest (y/n)?");
                string? addAnother = Console.ReadLine();

                if (addAnother?.ToLower() == "y" || addAnother?.ToLower() == "yes")
                {
                    return true;
                }

                if (addAnother?.ToLower() == "n" || addAnother?.ToLower() == "no")
                {
                    return false;
                }

                Console.WriteLine("Please type (Y) or (N).");
            } while (true);
        }

        public static void PrintGuestList(Dictionary<string, int> guestList)
        {
            Console.WriteLine("Guest list:");

            foreach (var guest in guestList)
            {
                Console.WriteLine($"guest: {guest.Key}, number of people in their party {guest.Value}.");
            }
        }

        public static int TotalNumberOfGuests(Dictionary<string, int> guestList)
        {
            return guestList.Sum(x => x.Value);
        }
    }
}
