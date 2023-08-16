

// Add students to a class roster List until there are no more students.
// Then print out the count of the students to the Console.

List<string> students = new();

do
{
    Console.Write("Please add students first name to he list (type \"exit\" to exit): ");
    string? student = Console.ReadLine();

    if (student?.ToLower() == "exit")
    {
        break;
    }

    if (student == null || student.Length < 2)
    {
        Console.WriteLine("Please enter name with at least two characters.");
    }
    else
    {
        students.Add(student);
    }

} while (true);

Console.WriteLine($"Total number of sutdents: {students.Count}");