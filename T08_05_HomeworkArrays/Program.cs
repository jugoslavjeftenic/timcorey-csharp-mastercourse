

// Create an array of 3 names.
// Ask user which number to select.
// When user gives you a number, return that name.
// Make sure to check for walid numbers.

string[] names = new string[] { "Hinata", "Yuki", "Akira" };

do
{
    Console.Write("Please select a number to show name (type 0 to exit)? ");
    bool isNumber = int.TryParse(Console.ReadLine(), out int number);

    if (isNumber && number == 0)
    {
        return;
    }

    if (isNumber && number > 0)
    {
        number--;
        if (number < names.Length)
        {
            Console.WriteLine(names[number]);
        }
        else
        {
            Console.WriteLine("There is no name associated to typed number.");
        }
    }
    else
    {
        Console.WriteLine("Incorect number.");
    }
} while (true);
