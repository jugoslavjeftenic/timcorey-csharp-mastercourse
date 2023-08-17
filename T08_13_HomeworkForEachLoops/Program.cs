

// Ask the user for their first name.
// Continue asking for first names until there are no more.
// Then loop through each name using foreach and tell each person hello on the Console.

List<string> firstNames = new();

do
{
    Console.Write("Enter your first name (type \"exit\" to exit): ");
    string? readLine = Console.ReadLine();

    if (readLine?.ToLower() == "exit")
    {
        Console.WriteLine("End of program.");
        break;
    }

    if (readLine == null || readLine.Length < 2)
    {
        Console.WriteLine("Please enter name with min two characters.");
        continue;
    }

    firstNames.Add(readLine);
} while (true);

foreach (var firstName in firstNames)
{
    Console.WriteLine($"Hello {firstName}.");
}
