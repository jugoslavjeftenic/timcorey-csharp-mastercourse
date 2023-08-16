

// Create a Console Application that asks the user for their name.
// Welcome me (Tim) as professor or anyone else as student.
// Do this until the user types "exit".

do
{
    Console.Write("What is your first name (type \"exit\" to exit)? ");
    string? firstName = Console.ReadLine();

    if (firstName?.ToLower() == "exit")
    {
        return;
    }

    if (firstName == null || firstName.Length < 2)
    {
        Console.WriteLine("Please enter name with at least two characters.");
    }
    else
    {
        if (firstName.ToLower() == "tim")
        {
            Console.WriteLine("Welcome Professor.");
        }
        else
        {
            Console.WriteLine("Welcome student.");
        }
    }
} while (true);