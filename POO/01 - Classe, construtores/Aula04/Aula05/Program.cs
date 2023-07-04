using System.Globalization;

namespace Course
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;
        //Tornou os atributos privados.
        public Produto() { }
        //Construtor de 3 atributos
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
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
        public double Preco
        {
            get { return _preco; }
        }


      public int Quantidade
        {
            get { return _quantidade; }
            
         }





       

        public double Total()
        {
            return _preco * _quantidade;
        }
        public void Adicionar(int ad)
        {
            _quantidade += ad;
        }
        public void Remover(int rem)
        {
            _quantidade -= rem;
        }
        public override string ToString()
        {
            return $"Produto: {_nome}\nPreço: R${_preco.ToString("F2")}\nQuantidade: {_quantidade}\nValor Total: {Total().ToString("F2")} ";
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
