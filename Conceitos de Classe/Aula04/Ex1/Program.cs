namespace Course
{
    class Dolar
    {
        public static double cotacao;
        public static double Total(double money)
        {
            return money * cotacao + money * cotacao * 0.06;
        }

        
    }
}
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar: ");
            double.TryParse(Console.ReadLine(), out Dolar.cotacao);

            Console.Write("Quantos dólares você vai comprar? ");
            double dol;
            double.TryParse(Console.ReadLine(), out dol);

            Console.WriteLine($"Valor a ser pago em reais é de R${Dolar.Total(dol).ToString("F2")}");
        }
    }
}
