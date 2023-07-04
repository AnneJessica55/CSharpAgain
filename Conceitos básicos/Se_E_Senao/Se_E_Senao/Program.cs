// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite sua cidade:");
String cidade = Console.ReadLine();

if (cidade == "São Paulo" || cidade == "SP")
{
    Console.WriteLine("A bolacha nojeenta está em cima da meisa");
}
else if( cidade == "Rio de Janeiro" || cidade == "RJ")
{
    Console.WriteLine("Ih, mané! Roubaram meuoh bixcoituoh!");
} else {
    Console.WriteLine("O biscoito está em cima da mesa");
}
Console.WriteLine("-------------------------------------------------\n \n");
Console.WriteLine("Digite um número inteiro");
int numero = 0;
int.TryParse(Console.ReadLine(), out numero);//Para converter um tipo de variavel coloca-se Convert.ToTipo(variavel a ser convertida) 
if (numero % 2 == 0 && numero!=0)
{
    Console.WriteLine($"O número {numero} é par!");
}
else if (numero % 2 != 0 && numero != 0)
{
    Console.WriteLine($"O número {numero} é ímpar");
}
else if (numero == 0)
{
    Console.WriteLine("O número 0 não é nem par nem ímpar.");
}
else
{
    Console.WriteLine("Erro! A entrada precisa ser um número inteiro!");
}