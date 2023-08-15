

// Create a Console Application that ask the user for their name.
// Welcome me (Tim) as professor or anyone else as student.
// Make sure that "TIM" also gets called professor.

Console.Write("Thell us your name? ");
string? name = Console.ReadLine();

if (name?.ToLower() == "tim" || name?.ToLower() == "timothy")
{
    Console.WriteLine("Resistance is futile Professor.");
}
else
{
    Console.WriteLine("Resistance is futile student.");
}

switch (name?.ToLower())
{
    case "tim" or "timothy":
        Console.WriteLine("Resistance is futile Professor.");
        break;
    default:
        Console.WriteLine("Resistance is futile student.");
        break;
}
