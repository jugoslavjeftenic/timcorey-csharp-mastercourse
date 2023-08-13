

Console.Write("What is your age: ");
string? ageText = Console.ReadLine();

Console.WriteLine(ageText + 10);

//int age = int.Parse(ageText);
//bool isValidInt = int.TryParse(ageText, out int age);
int age;
bool isValidInt = int.TryParse(ageText, out age);

Console.WriteLine($"This is valid: {isValidInt}. The number was {age}.");

Console.WriteLine(age + 10);


double testDouble = age;
decimal testDecimal = (decimal)testDouble;

Console.WriteLine(testDecimal);
