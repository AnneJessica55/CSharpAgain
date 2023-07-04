// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite um número abaixo:");
int n1 = 0;
int.TryParse(Console.ReadLine(), out n1);
Console.WriteLine($"O número digitado foi: {n1} e seu dobro é {n1 * 2}");

Console.WriteLine("Digite seu nome, sua idade e seu sexo:");
String[] vetor = Console.ReadLine().Split(", ");
int idade = 0;
int.TryParse(vetor[1], out idade);/*O Try parse ignora o erro de entrada e retorna 0, em caso de erro.*/
char sexo = '0';
char.TryParse(vetor[2], out sexo);
Console.WriteLine($"Seu nome é {vetor[0]}, sua idade é {idade} e seu sexo é {sexo}.:");