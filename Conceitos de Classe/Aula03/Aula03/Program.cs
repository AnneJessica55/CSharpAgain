using System.Globalization;
namespace Course
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double Vte()
        {
            return Preco * Quantidade;
        }
        public void Adicionar(int qt)
        {
            Quantidade += qt;
        }
        public void Retirar(int sub)
        {
            Quantidade -= sub;
        }
        public override string ToString()
        {
            return $"Nome: {Nome}\nPreço: R${Preco.ToString("F2", CultureInfo.InvariantCulture)}\nQuantidade: {Quantidade} unidades\nValor em Estoque: R${Vte().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto prod = new Produto();
            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            prod.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            double.TryParse(Console.ReadLine(), out prod.Preco);
            Console.Write("Quantidade: ");
            int.TryParse(Console.ReadLine(), out prod.Quantidade);
            Console.WriteLine($"Dados do produto:\n{prod}");
            Console.WriteLine("Pressione ENTER caso queira adicionar mais produtos");
            Console.ReadKey();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Digite a quantidade adicionada:");
            int add;
            int.TryParse(Console.ReadLine(), out add);
            prod.Adicionar(add);
            Console.WriteLine($"Novos dados do produto:\n{prod}");
            Console.WriteLine("Pressione ENTER caso queira retirar mais produtos");
            Console.ReadKey();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Digite a quantidade retirada:");
            int sub;
            int.TryParse(Console.ReadLine(), out sub);
            prod.Retirar(sub);
            Console.WriteLine($"Novos dados do produto:\n{prod}");
             

        }
    }
}
