

string csvData = "Tim,Sue,Bob,Jane";
List<string> firstNames = csvData.Split(',').ToList();

foreach (string firstName in firstNames)
{
    Console.WriteLine(firstName);
}
