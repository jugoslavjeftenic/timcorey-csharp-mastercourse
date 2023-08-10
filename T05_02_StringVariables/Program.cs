

string firstName = string.Empty;
string lastName = string.Empty;

firstName = "Jugoslav";
// firstName = "123";
lastName = "Jeftenic";

Console.WriteLine(firstName + " " + lastName);

// String interpolation
Console.WriteLine($"Hello {firstName} {lastName}");

string filePath1 = "C:\\Temp\\Demo";
// String literal - Verbatim text
string filePath2 = @"C:\Temp\Demo";

Console.WriteLine(filePath1);
Console.WriteLine(filePath2);

string testString = $@"The file for {firstName} is at C:\SampleFiles";

Console.WriteLine(testString);
