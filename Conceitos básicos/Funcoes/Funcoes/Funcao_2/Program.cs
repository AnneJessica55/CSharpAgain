using System.ComponentModel;

Console.WriteLine("Digite abaixo 3 números, dando enter em cada");
int num1;
int num2;
int num3;
int.TryParse(Console.ReadLine(), out num1);
int.TryParse(Console.ReadLine(), out num2);
int.TryParse(Console.ReadLine(), out num3);
int max = Maior(num1, num2, num3);
Console.WriteLine($"O maior valor entre o {num1}, {num2}, e {num3} é: {max}.");
static int Maior(int a, int b, int c)
{
    int m;
    if (a > b && a > c)
    {
        m = a;
    }
    else if( b > c)
    {
        m = b;
    }
    else
    {
        m = c;
    }
    return m;
}
