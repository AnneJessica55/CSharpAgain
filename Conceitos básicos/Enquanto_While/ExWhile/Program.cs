/*Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.*/
/*Console.WriteLine($"Digite a sua senha de 4 dígitos");
int senha;
int.TryParse(Console.ReadLine(), out senha);
    while (senha != 2002)
{
    Console.WriteLine("Senha incorreta. Por favor, tente novamente.");
    int.TryParse(Console.ReadLine(), out senha);
}
Console.WriteLine("Prosseguindo...");
Console.ReadKey();*/

/*Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).*/
Console.WriteLine($"Digite duas coordenadas para saber seu quadrante.");
double x;
double y;
double.TryParse(Console.ReadLine(), out x);
double.TryParse(Console.ReadLine(), out y);
while (x!=0 && y != 0)
{
    string quadrante = BuscaQuad(x, y);
    Console.WriteLine($"O quadrante é o {quadrante}.");
    Console.WriteLine($"Digite outras duas coordenadas para saber seu quadrante.");
    double.TryParse(Console.ReadLine(), out x);
    double.TryParse(Console.ReadLine(), out y);
}
Console.WriteLine("Coordenada errada. Até a próxima.");
static string BuscaQuad(double a, double b)
{
    string qd;
    if( a > 0 && b > 0)
    {
        qd = "PRIMEIRO";
    }
    else if (a < 0 && b > 0)
    {
        qd = "SEGUNDO";
    }
    else if(a < 0 && b < 0){
        qd = "TERCEIRO";
    }
    else
    {
        qd = "QUARTO";
    }
    return qd;
}

