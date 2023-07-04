namespace Course
{
    class Funcionario
    {
        public string Nome;
        public double Salario;
        public double Imposto;

        public double SlarioLiquido()
        {
            return Salario -= Imposto;
        }
        public void Aumentado(double por)
        {
            Salario = Salario * (1 + por / 100);
        }
        public override string ToString()
        {
            return $"{Nome} passará a receber R${SlarioLiquido().ToString("F2")}.";
        }
    }
}
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();
            Console.WriteLine("Digite o nome do fucionário:");
            func.Nome = Console.ReadLine();
            Console.WriteLine("Digite o valor do salário bruto:");
            double.TryParse(Console.ReadLine(), out func.Salario);
            Console.WriteLine("Digite o valor do imposto:");
            double.TryParse(Console.ReadLine(), out func.Imposto);
            Console.WriteLine("Digite o percentual do aumento:");
            double add;
            double.TryParse(Console.ReadLine(), out add);
            func.Aumentado(add);
            Console.WriteLine($"Dados Atualizados:\n{func}");
        }
    }
}
