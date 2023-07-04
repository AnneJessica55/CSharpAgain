
using M06A05;

Console.WriteLine("Digite abaixo a quantidade de produtos a ser adicionada.");
int n;
int.TryParse(Console.ReadLine(), out n);

Product[] vect = new Product[n];

for (int i =0; i< n; i++)
{
    Console.WriteLine($"Digite o nome do {i+1}° produto.");
    string nome = Console.ReadLine();
    Console.WriteLine("Digite o preço desse produto.");
    double preco;
    double.TryParse(Console.ReadLine(), out preco);
    vect[i] = new Product { Nome = nome, Preco = preco };

}
double sum = 0.0;
for( int i = 0; i < n; i++)
{
    sum += vect[i].Preco;
}
double med = sum / n;
Console.WriteLine($"A média dos preços é R$ {med.ToString("F2")}.");