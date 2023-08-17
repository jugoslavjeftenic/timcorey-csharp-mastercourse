

using T09_02_Methods;

string? name = ConsoleMessages.GetUsersName();

if (name == null)
{
    ConsoleMessages.SayHi();
}
else
{
    ConsoleMessages.SayHi(name);
}

int x = 5, y = 3;
Console.WriteLine($"The value of {x} + {y} = {MathShortcuts.Add(x, y)}.");

double[] vals = new double[] { 2, 5, 6, 21, 52, 98 };
MathShortcuts.AddAll(vals);

ConsoleMessages.SayGoodbye();

// Tuples
(string? firstName, string? lastName) fullName = ConsoleMessages.GetFullName();
Console.WriteLine($"First name: {fullName.firstName}.");
Console.WriteLine($"Last name: {fullName.lastName}.");

(string? firstName, string? lastName) = ConsoleMessages.GetFullName();
Console.WriteLine($"First name: {firstName}.");
Console.WriteLine($"Last name: {lastName}.");

var (firstNameVar, lastNameVar) = ConsoleMessages.GetFullName();
Console.WriteLine($"First name: {firstNameVar}.");
Console.WriteLine($"Last name: {lastNameVar}.");

(string? firstNameOnly, _) = ConsoleMessages.GetFullName();
Console.WriteLine($"First name: {firstNameOnly}.");
