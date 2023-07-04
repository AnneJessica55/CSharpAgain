Console.Write($"Informe a quantidade de números que você deseja somar: ");
int qt;
int.TryParse(Console.ReadLine(), out qt);
int soma = 0;
if (qt > 0)
{
    for (int i = 1; i <= qt; i++)
    {
        Console.Write($"Informe o {i}° número.");
        int num;
        int.TryParse(Console.ReadLine(), out num);
        soma += num;
    }
    Console.WriteLine($"A soma dos {qt} números é {soma}.");
}
else
{
    Console.WriteLine("Quantidade inválida. Precisa ser um número maior que 0. \nAté a próxima.");
}
