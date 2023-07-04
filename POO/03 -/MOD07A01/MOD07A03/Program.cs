using System.Globalization;
//datetime
DateTime d1 = DateTime.Now;
Console.WriteLine(d1);

DateTime d2 = new DateTime(1991, 04, 26);
Console.WriteLine(d2);
DateTime d3 = new DateTime(1991, 04, 26, 18, 06, 25);
Console.WriteLine(d3);
DateTime d4 = DateTime.Today;
Console.WriteLine(d4);
DateTime d5 = DateTime.UtcNow;
Console.WriteLine(d5);
DateTime d6 = DateTime.Parse("1991-04-26");
Console.WriteLine(d6);
DateTime d7 = DateTime.Parse("1991-04-26 18:06:25");
Console.WriteLine(d7);
Console.WriteLine("Digite sua data de nascimento");
string nasc = Console.ReadLine();
DateTime d8 = DateTime.Parse(nasc);
Console.WriteLine($"Você nasceu no dia: {d8.ToLongDateString()}.");
Console.WriteLine($"Você Nasceu no Dia: {d8.ToShortDateString()}.");
Console.WriteLine($"Numa {d8.DayOfWeek}.");
string s1 = d8.ToString("yyyy-MM-dd");
Console.WriteLine(s1);
DateTime d9 = d1.AddDays(3);

TimeSpan d10 = d9.Subtract(d1);
Console.WriteLine(d10);
