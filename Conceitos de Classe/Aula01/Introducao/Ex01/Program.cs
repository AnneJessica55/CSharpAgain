/*Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais
velha.*/
class Cadastro
{
    public string nome;
    public int idade;
}
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // agora começa a declaração e instanciamento de variáveis
            Cadastro Pessoa1, Pessoa2;
            Pessoa1 = new Cadastro();
            Pessoa2 = new Cadastro();

            Console.WriteLine("Informe seu nome:");
            Pessoa1.nome = Console.ReadLine();
            Console.WriteLine("Informe sua Idade:");
            int.TryParse(Console.ReadLine(), out Pessoa1.idade);

            Console.WriteLine("Informe o segundo nome:");
            Pessoa2.nome = Console.ReadLine();
            Console.WriteLine("Informe sua idade:");
            int.TryParse(Console.ReadLine(), out Pessoa2.idade);

            if (Pessoa1.idade > Pessoa2.idade){
                Console.WriteLine($"A pessoa mais velha é {Pessoa1.nome}, que tem {Pessoa1.idade} anos.");
            }
            else
            {
                Console.WriteLine($"A pessoa mais velha é {Pessoa2.nome}, que tem {Pessoa2.idade} anos.");
            }
        }
    }
}
