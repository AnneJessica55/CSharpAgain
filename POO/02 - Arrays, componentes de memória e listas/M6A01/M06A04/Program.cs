//VETOES
Console.WriteLine("Digite  a quantidade de alturas a ser calculada a média");
int n;
int.TryParse( Console.ReadLine(), out n);

double[] vect = new double[n]; 

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Digite a {i + 1}ª altura:");
    double alt;
    double.TryParse(Console.ReadLine(), out alt);
    vect[i] = alt;
}


double sum = 0.0;
for (int i = 0; i < 3; i++)
{
    sum += vect[i];
}
double media = sum / n;

Console.WriteLine($"A média de altura é {media.ToString("F2")} m.");