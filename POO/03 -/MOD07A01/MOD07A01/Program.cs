
//Switch 
Console.WriteLine("Digite um número inteiro, de 1 a 7, para um dia da semana:");
int num;
int.TryParse(Console.ReadLine(), out num);
string dia;
switch(num)
{
    case 1:
        dia = "Domingo";
        break;
    case 2:
        dia = "Segunda-Feira";
        break;
    case 3:
        dia = "Terça-Feira";
        break;
    case 4:
        dia = "Quarta-Feira";
        break;
    case 5:
        dia = "Quinta-Feira";
        break;
    case 6:
        dia = "Sexta-Feira";
        break;
    case 7:
        dia = "Sábado";
        break;
    default:
        dia = "Dia inválido";
        break;
}
Console.WriteLine($"Do dia da semana é {dia}");

//Expressão condicionl ternária
string cond;
cond = (2 > 4) ?"Maior" :"Menor";

Console.WriteLine(cond);

