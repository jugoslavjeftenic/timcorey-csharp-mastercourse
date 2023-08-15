

string firstName = "Tim";
int age = 52;

switch (firstName.ToLower())
{
    case "tim" or "sue":
        Console.WriteLine("Hello Professor");
        break;
    case "tom":
        Console.WriteLine("Hello Tom");
        break;
    default:
        Console.WriteLine("I don't know you.");
        break;
}

switch (age)
{
    case >= 0 and < 18:
        Console.WriteLine("You are a child");
        break;
    case >= 18 and < 66:
        Console.WriteLine("You should have a job.");
        break;
    case >= 66:
        Console.WriteLine("Hopefully you are retiered or retiting soon.");
        break;
    default:
        Console.WriteLine("Age was not in expected range.");
        break;
}