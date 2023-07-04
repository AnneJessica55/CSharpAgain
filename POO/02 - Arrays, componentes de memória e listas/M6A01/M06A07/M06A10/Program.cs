//Matrizes
Console.WriteLine("Digite a ordem da matriz:");
int n = int.Parse(Console.ReadLine());

int[,] matriz = new int[n, n];

for (int i = 0; i < n; i++) //linhas
{
    Console.WriteLine($"Digite os valores da {i +1}ª linha smeparando-os por ' ':");
    string[] valores = Console.ReadLine().Split(' ');
        for (int i2 = 0; i2 < n; i2++) //colunas
            {
        matriz[i, i2] = int.Parse(valores[i2]);  
            }
}

Console.WriteLine("Os valores da diagonal são:");
for (int i=0; i< n; i++)
{
    Console.WriteLine($"{matriz[i, i]} ");
}
int count = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (matriz[i, j] < 0)
        {
            count++;
        }
    }
}
Console.WriteLine($"Existem {count} número negativos.");