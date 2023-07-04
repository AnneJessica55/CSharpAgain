//Funções são processamentos qe possuem um significado
//Suas principais vantagens são: modulação, delegação e reaproveitamento, já que é possível chamá-la em outras linhas do mesmo código
//funções podem receber dados de entrada e retornar dados para a saída
// em orientação a objeto ela se chama de método
//Fazer o programa  receber 3 número e retornar o maior deles
Console.WriteLine("Escreva três números inteiros (\"Separados por , \").");
string conjunto = Console.ReadLine();
string[] vetor = conjunto.Split(", ");
int num1 = 0;
int num2 = 0;
int num3 = 0;
int.TryParse(vetor[0], out num1);
int.TryParse(vetor[1], out num2);
int.TryParse(vetor[2], out num3);
/*int maxnum = num1;
if (maxnum > num2 && maxnum > num3){
    Console.WriteLine($"O maior número entre {num1}, {num2} e {num3} é {maxnum}.");
} else if(num2 > num3)
{
    maxnum = num2;
    Console.WriteLine($"O maior número entre {num1}, {num2} e {num3} é {maxnum}.");
}
else { 
    maxnum = num3;
    Console.WriteLine($"O maior número entre {num1}, {num2} e {num3} é {maxnum}.");
}*/
double maxnum = Maior(num1, num2, num3);
Console.WriteLine($"O maior número entre {num1}, {num2} e {num3} é {maxnum}");

static int Maior(int a, int b, int c)
{
    int maxnum;
    if (a > b && a > c)
    {
        maxnum = a;
    }
    else if (b > c)
    {
        maxnum = b;
    }
    else
    {
        maxnum = c;
    }
    return maxnum;
}



