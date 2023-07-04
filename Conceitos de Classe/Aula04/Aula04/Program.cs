using System.Globalization;
namespace Course {
    
}

namespace Course
{
    class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {

            Console.Write("Digite o valor do raio.  ");
            double raio;
            double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out raio);

            double circ = Circunferencia(raio);
            double vol = Volume(raio);

            Console.WriteLine($"A circunferência do círculo é: {circ.ToString("F2")}cm, e o volume é {vol.ToString("F2")}cm³.\nO valor de Pi é\nPi = {Pi.ToString("F2")}");


            static double Circunferencia(double r)
            {
                return 2 * Pi * r;
            }
            static double Volume (double r)
            {
                return 4 * Math.Pow(r, 3) * Pi / 3;
            }
        }
    }
}