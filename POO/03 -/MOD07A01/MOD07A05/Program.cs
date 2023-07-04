DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

Console.WriteLine(d1);
Console.WriteLine(d2);
Console.WriteLine(d3);
//COnversões
Console.WriteLine($"Tipo de d1: {d1.Kind}");
Console.WriteLine($"Convertendo para horário UTC: {d1.ToUniversalTime()}");
Console.WriteLine($"Tipo de d1: {d2.Kind}");
Console.WriteLine($"Convertendo para horário Local: {d2.ToLocalTime()}");

