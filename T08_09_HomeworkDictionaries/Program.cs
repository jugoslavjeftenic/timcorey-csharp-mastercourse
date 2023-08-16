

// Create s Dictionaries list of employee IDs and the name that goes with ID.
// Fill in a few records.
// Then ask the user for their ID and return their name.

Dictionary<int, string> employee = new()
{
    [100] = "Pera",
    [101] = "Mika",
    [102] = "Zika",
    [103] = "Cika",
    [104] = "Prika",
    [105] = "Strika",
    [106] = "Paprika"
};

Console.Write("Please enter your ID: ");
bool isInt = int.TryParse(Console.ReadLine(), out int ID);

if (isInt)
{
    Console.WriteLine($"Your name is {employee[ID]}.");
}
