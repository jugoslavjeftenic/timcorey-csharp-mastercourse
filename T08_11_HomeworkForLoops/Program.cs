

// Ask the user for a comma-separated list of first names (no spaces).
// Split the string into a string array.
// Print through the array and print "Hello <name>" to the console for each person.

Console.WriteLine("Enter comsa-separated list of first names with no spaces: ");
string? nameString = Console.ReadLine();

if (nameString == null || nameString.Length < 2)
{
    Console.WriteLine("No valid names.");
    return;
}

string[] namesArray = nameString.Split(',');

for (int i = 0; i < namesArray.Length; i++)
{
    Console.WriteLine($"Hello {namesArray[i]}.");
}
