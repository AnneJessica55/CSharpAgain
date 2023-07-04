using System.ComponentModel.DataAnnotations;

TimeSpan t1 = new TimeSpan(0, 1, 30);
Console.WriteLine(t1);
TimeSpan t2 = new TimeSpan(900000000L);
Console.WriteLine(t2);
TimeSpan t3 = new TimeSpan(1, 2, 1, 30);
Console.WriteLine(t3);
TimeSpan t4 = TimeSpan.FromDays(1.5);
Console.WriteLine(t4);
TimeSpan t5 = TimeSpan.FromHours(1.5);
Console.WriteLine(t5);
TimeSpan t6 = TimeSpan.MaxValue;
TimeSpan t7 = TimeSpan.MinValue;
TimeSpan t8 = TimeSpan.Zero;
Console.WriteLine(t6);
Console.WriteLine(t7);
Console.WriteLine(t8);
//Operações

TimeSpan t9 =new TimeSpan(1, 30, 10);
TimeSpan t10 = new TimeSpan(0, 10, 30);
//Adição
TimeSpan soma = t9.Add(t10);
Console.WriteLine(soma);
//Subtração
TimeSpan dif = t9.Subtract(t10);
Console.WriteLine(dif);
//Multiplicação e Divisão
TimeSpan mult = t10.Multiply(2.0);
TimeSpan div = mult.Divide(2.0);
Console.WriteLine(mult);
Console.WriteLine(div);

