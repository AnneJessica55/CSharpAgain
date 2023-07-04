using System.Globalization;
Console.WriteLine($"Raíz quadrada!!\n------------------------------\nDigite um número para saber sua raiz quadrada.\nObs:Não pode ser um número negativo.");
double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    while (num >= 0)
    {

        double ra = Math.Sqrt(num);
        Console.WriteLine($"A raíz quadrada de {num} é {ra.ToString("F3", CultureInfo.InvariantCulture)}.");
        Console.WriteLine($"Digite outro número, com as  mesmas regras do primeiro.");
        num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    }

Console.WriteLine("O número não pode ser negativo.\nAté a próxima.");
