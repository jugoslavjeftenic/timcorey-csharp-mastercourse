

// Plan and build a Console application that asks a user for their name and their age.
// If their name is Bob or Sue, address them as Professor.
// If the person is under 21, recommend they wait X years to start this class.

Console.Write("What is your first name? ");
string? firstName = Console.ReadLine();

if (firstName == null || firstName.Length < 2)
{
    Console.WriteLine("Name has to have at least two characters!");
    return;
}

Console.Write("How old are you? ");
bool isAge = int.TryParse(Console.ReadLine(), out int age);

if (!isAge || age < 0 || age > 130)
{
    Console.WriteLine("Stop lolygaging and enter a valid age.");
    return;
}

if (firstName.ToLower() == "bob" || firstName.ToLower() == "sue")
{
    Console.WriteLine("Hello Professor.");
    if (age < 21)
    {
        Console.WriteLine("You are feeling fresh and young today.");
        Console.WriteLine($"Maybe you should come back in {21 - age} years to teach this class.");
    }
}
else
{
    Console.WriteLine($"Hello {firstName}.");
    if (age < 21)
    {
        Console.WriteLine($"Maybe you should come back in {21 - age} years to start this class.");
    }
}

