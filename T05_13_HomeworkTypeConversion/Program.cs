

// Capture user's age from th Console ant then identify how old they will be i 25 years,
// as well as how old they were 25 years ago. Print that information to the Console in natural language.

Console.Write("How old are you? ");
string? ageTxt = Console.ReadLine();

bool isAgeValid = int.TryParse(ageTxt, out int age);

Console.WriteLine();
Console.WriteLine($"Entered age is valid? {isAgeValid}.");
Console.WriteLine($"In 25 years you will be {age + 25} years old.");
Console.WriteLine($"25 years ago you were {age - 25} years old.");
