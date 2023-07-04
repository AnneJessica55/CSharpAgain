// See https://aka.ms/new-console-template for more information
int a = 12;
Console.WriteLine("a é igual a {0}", a);
a += 20;
Console.WriteLine($"a + 20 é igual a {a}.");
string f = "ABC";
Console.WriteLine($"As três primeiras letras do alfabeto são {f}");
f += "DEF";
Console.WriteLine($"As 6 primeiras letras do alfabeto são {f}");
//o += também funciona para string
Console.WriteLine($"O antecessor de a é {--a}.");