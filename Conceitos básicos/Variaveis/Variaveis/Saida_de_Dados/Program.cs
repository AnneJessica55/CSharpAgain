// See https://aka.ms/new-console-template for more information
using System.Globalization;
Console.WriteLine($"Para utilizar o metodo de saída de dados, você deve utilizar o Console.WritleLine(\"\"). \nÉ super simples! \nVamos aos Exemplos:\n---------------------------------");
string nome = ("Jurema Cleide Ohana");
byte idade = 45;
char genero = 'F';
double saldo = 1578.3574585;
double multa = 0.1 * saldo ;
double total = saldo + multa;
Console.WriteLine($"Nome: {nome}\nIdade: {idade}\nGênero: {genero}\nSaldo: {saldo.ToString("F2", CultureInfo.InvariantCulture)}\nMulta: {multa.ToString("F2", CultureInfo.InvariantCulture)}\nTotal: {total.ToString("F2", CultureInfo.InvariantCulture)}\n---------------------------------");
Console.WriteLine($"{nome} tem {idade} anos e uma dívida de R${total:F2}.");
Console.WriteLine /*Interpolaçãp*/($"-----------------------------\nOutra forma de imprimir:\n \n");
Console.WriteLine/*placeholder */("{0} tem {1} anos e uma dívida de R${2:F2}.", nome, idade, total);


