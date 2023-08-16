

List<string> firstNames = new List<string>();

firstNames.Add("Tim");
firstNames.Add("Sue");
firstNames.Add("Bob");
firstNames.Add("Jane");

Console.WriteLine(firstNames[firstNames.Count - 1]);

List<int> ages = new List<int>();

ages.Add(1);
ages.Add(2);
ages.Add(3);

string csvData = "Coreyy,Smith,Jones";
List<string> lastNames = csvData.Split(',').ToList();
lastNames.Add("Frenklin");
