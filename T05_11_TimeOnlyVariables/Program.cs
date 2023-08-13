

TimeOnly opensAt = TimeOnly.Parse("8:00");

TimeOnly rightNow = TimeOnly.FromDateTime(DateTime.Now);

Console.WriteLine(opensAt);
Console.WriteLine(rightNow);

Console.WriteLine(TimeOnly.MinValue);
Console.WriteLine(TimeOnly.MaxValue);
