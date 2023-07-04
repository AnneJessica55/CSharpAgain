using System.Globalization;

namespace Course
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;
        //Aqui você criou um construtor, que sempre leva o nome da classe.
        public Produto(string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double Total()
        {
            return Preco * Quantidade;
        }
        public void Adicionar(int ad)
        {
            Quantidade += ad;
        }
        public void Remover( int rem)
        {
            Quantidade -= rem;
        }
        public override string ToString()
        {
            return $"Produto: {Nome}\nPreço: R${Preco.ToString("F2")}\nQuantidade: {Quantidade}\nValor Total: {Total().ToString("F2")} ";
        }
            
        
    }
}
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //Agora você criou variaveis auxiliares
            Console.WriteLine("Entre com os dados do produto\nNome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço:");
            double preco;
            double.TryParse(Console.ReadLine(), out preco);
            Console.WriteLine("Quantidade:");
            int quantidade;
            int.TryParse(Console.ReadLine(), out quantidade);
            Produto prod = new Produto(nome, preco, quantidade); //Instanciou já com as variáveis auxiliares para o construtor
            Console.WriteLine($"Atualização de dados:\n{prod}");

            Console.WriteLine("Aperte ENTER caso queira adicionar do mesmo produto ao estoque.");
            Console.ReadKey();
            Console.WriteLine("Digite a quantidade a ser adicionada:");
            int qtd;
            int.TryParse(Console.ReadLine(), out qtd);
            prod.Adicionar(qtd);
            Console.WriteLine($"Atualização de dados:\n{prod}");

            Console.WriteLine("Aperte ENTER caso queira remover do mesmo produto do estoque.");
            Console.ReadKey();
            Console.WriteLine("Digite a quantidade a ser removida:");
            int.TryParse(Console.ReadLine(), out qtd);
            prod.Remover(qtd);
            Console.WriteLine($"Atualização de dados:\n{prod}");
        }
    }
}