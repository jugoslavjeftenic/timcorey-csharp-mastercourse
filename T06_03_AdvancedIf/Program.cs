

Console.Write("What is your first name? ");
string? firstName = Console.ReadLine();

Console.Write("What is your last name? ");
string? lastName = Console.ReadLine();

if (firstName?.ToLower() == "tim" &&
    lastName?.ToLower() == "corey")
{
    Console.WriteLine("Hello Mr. Corey.");
}
else if (firstName?.ToLower() == "tim")
{
    Console.WriteLine("Hello, you have a cool first name.");
}
else if (lastName?.ToLower() == "corey")
{
    Console.WriteLine("Hello, you have a great last name.");
}
else if (firstName?.ToLower() == "tim" ||
    lastName?.ToLower() == "corey")
{
    Console.WriteLine("Hello, you have a great part in your name.");
}
else
{
    Console.WriteLine("Sorry, you don't have cooler name!");
}

int age = 100;
if (age >= 100)
{
    Console.WriteLine("You are up there in years.");
}
if (age != 52)
{
    Console.WriteLine("Sorry, you aren't in great age.");
}

age = 52;
if ((age >= 40 && age <= 50) ||
    (age >= 70 && age <= 80))
{
    Console.WriteLine("You are in your 40's or 70's.");
}
