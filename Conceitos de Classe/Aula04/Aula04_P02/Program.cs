using System.Globalization;

namespace Course {
    class Calculadora
    {
        public static double Pi = 3.14;
        public static double Circunferencia(double r)
        {
            return 2 * Pi * r;
        }
        public static double Volume(double r)
        {
            return 4 * Math.Pow(r, 3) * Pi / 3;
        }
    }
}

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o valor do raio.  ");
            double raio;
            double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out raio);

            double circ = Calculadora.Circunferencia(raio);
            double vol = Calculadora.Volume(raio);

            Console.WriteLine($"A circunferência do círculo é: {circ.ToString("F2")}cm, e o volume é {vol.ToString("F2")}cm³.\nO valor de Pi é\nPi = {Calculadora.Pi.ToString("F2")}");



        }
    }
}
