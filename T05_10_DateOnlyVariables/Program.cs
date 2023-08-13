

DateTime today = DateTime.Now;

DateOnly birthday = DateOnly.Parse("16/9/1972");

Console.WriteLine(birthday.ToString("dd MMMM yyyy"));

Console.WriteLine($"Today full format: {today}");
Console.WriteLine($"Today just date: {today.Date}");
Console.WriteLine($"Birthday full format: : {birthday}");
