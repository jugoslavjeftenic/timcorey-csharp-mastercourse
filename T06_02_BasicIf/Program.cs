﻿

bool isComplete = false;

if (isComplete)
{
    Console.WriteLine("The statement was true.");
}
else
{
    Console.WriteLine("The statement was false.");
}
Console.WriteLine();

Console.Write("What is your first name? ");
string? firstName = Console.ReadLine();

if (firstName?.ToLower() == "Tim".ToLower())
{
    Console.WriteLine("Hello Mr. Corey.");
}
else
{
    Console.WriteLine($"Hello {firstName}.");
}

Console.WriteLine("End of program.");