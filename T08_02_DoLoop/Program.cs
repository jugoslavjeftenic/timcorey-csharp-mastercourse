

bool isValidAge;
int age;

do
{
    Console.Write("What is your age? ");
    isValidAge = int.TryParse(Console.ReadLine(), out age);

    if (isValidAge == false)
    {
        Console.WriteLine("That was an invalid age.");
    }
} while (isValidAge == false);

Console.WriteLine($"Your age is {age}.");



int testNumber = 0;

do
{
    Console.WriteLine(testNumber);
    testNumber += 3;
} while (testNumber < 10);