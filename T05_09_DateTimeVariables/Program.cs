

using System.Globalization;

DateTime today = DateTime.Now;
DateTime todayUtc = DateTime.UtcNow;

Console.WriteLine(today);
Console.WriteLine(todayUtc);
Console.WriteLine(today.ToString(format: "d"));
Console.WriteLine(today.ToString(format: "t"));
Console.WriteLine(today.ToString(format: "MMM"));
Console.WriteLine(today.ToString(format: "MMMM"));
Console.WriteLine(today.ToString(format: "MMMM dd, yyyy hh:mm tt zzz"));

DateTime birthdayParse = DateTime.Parse(s: "15/6/1999");
Console.WriteLine(birthdayParse.ToString());

DateTime birthdayParseExact = DateTime.ParseExact(s: "1999/6/16", format: "yyyy/M/d", CultureInfo.InvariantCulture);
Console.WriteLine(birthdayParseExact.ToString());
