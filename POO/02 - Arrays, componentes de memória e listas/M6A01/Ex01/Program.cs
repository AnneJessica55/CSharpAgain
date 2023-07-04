using Ex01;

Aluguel[] al = new Aluguel[10];
Console.WriteLine("Digite o número de quartos que serão alugados.");
int n;
int.TryParse(Console.ReadLine(), out n);

if (n <= 10)
{
for (int i = 0; i < n; i++ )
    {
        Console.WriteLine($"Digite o nome do {i+1}° locatário:");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite o e-mail do locatário:");
        string email = Console.ReadLine();
        Console.WriteLine("Digite o número do quarto:");
        int quar;
        int.TryParse(Console.ReadLine(), out quar);

        al[quar - 1] = new Aluguel(nome, email);
    }

    Console.WriteLine("--------------------------------------");
    Console.WriteLine("Relatório de Quartos alugados");
    for (int i =0; i < 10; i++)
    {
        if (al[i] != null)
        {
            Console.WriteLine($"{i + 1}: {al[i]}");
        }
    }
}
else
{
    Console.WriteLine("O número solicitado excede a quantidade existente.");
}