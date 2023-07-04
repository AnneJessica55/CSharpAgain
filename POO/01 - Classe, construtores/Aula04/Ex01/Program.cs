using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;

namespace Ex01
{
    class Conta
    {
        public string Nome { get; set; }
        public int Numero  { get; private set; }
        public float Saldo { get; private set; }

        public Conta(int numero, string nome)
        {

            Numero = numero;
            Nome = nome;
            //No primeiro acesso o saldo será 0
        }
        public Conta( int numero, string nome, float depInicial) : this(numero, nome) 
        {
            Deposito(depInicial);
        }
        //Desenvolvendo os métodos
       public void Deposito(float dep) {
            Saldo += dep;
        }

        public void Saque (float saq) 
        {
            Saldo -= saq;
        }
    


        public override string ToString()
        {
            return $"Conta: {Numero}\nTitular:{Nome}\nSaldo:R${Saldo.ToString("F2")}";
        }
    }

}
namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta ct;
            Console.Write("Digite o número da conta: ");
            int num;
            int.TryParse(Console.ReadLine(), out num);
            Console.Write("Digite o nome do titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá um depósito inicial? Responda S para sim e  N para não ");
            char resp = Convert.ToChar(Console.ReadLine());
            if (resp == 's'|| resp == 'S')
            {
                Console.Write("Digite o valor do depósito: R$");
                float saldo;
                float.TryParse(Console.ReadLine(), out saldo);
                ct = new Conta(num, nome, saldo);
                
            }
            else 
            {
                ct = new Conta(num, nome);
                
            }
            Console.WriteLine($"Atualização de dados cadastrados:\n{ct}");
            //realização do depósito
            Console.WriteLine("Aperte ENTER para fazer um depósito.");
            Console.ReadKey();
            Console.Write("Digite o valor do deposito: R$");
            float dep;
            float.TryParse(Console.ReadLine(), out dep);
            ct.Deposito(dep);
            Console.WriteLine($"Atualização de dados cadastrados:\n{ct}");
            //Realização do saque
            Console.WriteLine("Aperte ENTER para fazer um saque.");
            Console.ReadKey();
            Console.Write("Digite o valor do saque: R$");
            float.TryParse(Console.ReadLine(), out dep);
            ct.Saque(dep);
            Console.WriteLine($"Atualização de dados cadastrados:\n{ct}");
        }
    }
}