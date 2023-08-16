

string[] firstNames = new string[5];

firstNames[0] = "Tim";
firstNames[1] = "Sue";
firstNames[2] = "Bob";
firstNames[4] = "Jane";

Console.WriteLine($"First names of first and second person are {firstNames[0]} and {firstNames[1]}.");

firstNames[0] = "Timothy";

Console.WriteLine(firstNames[0]);

string csvData = "Tim,Sue,Bob,Jane,Frank";
string[] namesFromCsv = csvData.Split(',');

Console.WriteLine(namesFromCsv[namesFromCsv.Length - 1]);

string[] lastNames = new string[] { "Corey", "Smith", "Jones" };

int[] ages = new int[] { 42, 52, 62 };
