using System.Globalization;

namespace Course
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }
        //Tornou os atributos privados.
        public Produto() { }
        //Construtor de 3 atributos
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //Método proprieties
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
                else
                {
                    _nome = "Nome inválido";
                }
            }
        }
        
        public double Total()
        {
            return Preco * Quantidade;
        }
        public void Adicionar(int ad)
        {
            Quantidade += ad;
        }
        public void Remover(int rem)
        {
            Quantidade -= rem;
        }
        public override string ToString()
        {
            return $"Produto: {_nome}\nPreço: R${Preco.ToString("F2")}\nQuantidade: {Quantidade}\nValor Total: {Total().ToString("F2")} ";
        }


    }
}
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);
            Console.WriteLine("Digite o nome do produto.");
            p.Nome = Console.ReadLine();

            Console.WriteLine($"{p.Nome} R${p.Preco.ToString("F2")} - {p.Quantidade} unidades.");

        }
    }
}

