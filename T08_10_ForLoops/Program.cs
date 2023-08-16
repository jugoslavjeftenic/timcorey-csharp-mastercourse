

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

string csvData = "Tim,Sue,Bob,Jane,Frank";
List<string> names = csvData.Split(',').ToList();

for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine(names[i]);
}


List<decimal> charges = new() { 23.78M, 15.89M, 125M };
decimal total = 0;

for (int i = 0; i < charges.Count; i++)
{
    total += charges[i];
}

Console.WriteLine($"Our total charges is {total}.");