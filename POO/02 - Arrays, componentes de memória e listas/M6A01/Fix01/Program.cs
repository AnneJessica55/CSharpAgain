using Fix01;

Console.WriteLine("Digite a quantidade de quartos que deseja alugar.");
int n;
int.TryParse(Console.ReadLine(), out n);
Estudante[] est = new Estudante[10];
if (n <= 10)
{
    for(int i = 0; i  < n; i++)
    {
        Console.WriteLine($"Digite o nome do {i+1}° estudante.");
        string nome = Console.ReadLine();
        Console.WriteLine($"Digite o email do {i+1}° estudante.");
        string email = Console.ReadLine();
        Console.WriteLine($"Digite o número do quarto do {i + 1}° estudante.");
        int quar;
        int.TryParse(Console.ReadLine(), out quar);
        est[quar -1] = new Estudante(nome, email);

    }
    for (int i = 0; i < 10; i++)
    {
        if (est[i] != null)
        {
            Console.WriteLine($"{i+1}: {est[i]}");
        }
    }

}
else
{
    Console.WriteLine("O número de quartos solicitados excede a quantidade existente.");
}
