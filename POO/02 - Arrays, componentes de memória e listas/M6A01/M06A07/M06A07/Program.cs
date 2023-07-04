using M06A07;
//Modificador ref
//variavel já iniciada
Console.WriteLine("Digite o número que deseja triplicar");
int a;
int.TryParse(Console.ReadLine(), out a);
Calculadora.Triplo(ref a);
Console.WriteLine($"\n* 3 \n________\n{a}");

//modificador out
//variável que recebe não iniciada
Console.WriteLine("Digite outro número");
int b;
int.TryParse(Console.ReadLine(), out b);
int resultado;
Calculator.Triplo(b, out resultado);
Console.WriteLine($"{b}\n* 3\n________\n{resultado}");
