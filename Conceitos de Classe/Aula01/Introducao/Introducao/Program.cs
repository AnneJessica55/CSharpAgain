using System.Globalization;
/*Console.WriteLine("Cálculo da área de dois triangulos");
Console.WriteLine("---------------------------------");
Console.ReadKey();
double Xa, Xb, Xc, Ya, Yb, Yc;

Console.WriteLine("Entre com os lados do triângulo X");
double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out Xa);
double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out Xb);
double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out Xc);

Console.WriteLine("Entre com os lados do triângulo Y");
double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out Ya);
double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out Yb);
double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out Yc);
double pX, pY, areaX, areaY, maior;
string triangulo;
pX = (Xa + Xb + Xc) / 2;
pY = (Ya + Yb + Yc) / 2;
areaX = Math.Sqrt(pX * (pX - Xa) * (pX - Xb) * (pX - Xc));
areaY = Math.Sqrt(pY * (pY - Ya) * (pY - Yb) * (pY - Yc));

if (areaX > areaY)
{
    maior = areaX;
    triangulo = "tirangulo X";
}
else
{
    maior = areaY;
    triangulo = "triangulo Y";
}

Console.WriteLine($"As áreas dos triangulos X e Y são respectivamente: \nAréa do Triangulo X: {areaX.ToString("F2")}m².\nÁrea do triângulo Y: {areaY.ToString("F2")}m²\n o maior triangulo é o {triangulo}, de área {maior.ToString("F2")}m²");
*/
class Triangulo//A declaração da classe tem de estar em uma instância superior ao namespace
{
    public double A;
    public double B;
    public double C;
}
namespace Course { class Program
    {
        static void Main(String[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();
            Console.WriteLine("Descobrindo a área de dois triângulos");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Digite os lados, em metros, do triângulo X:");
                double.TryParse(Console.ReadLine(), out x.A);
                double.TryParse(Console.ReadLine(), out x.B);
                double.TryParse(Console.ReadLine(), out x.C);
            Console.WriteLine("Digite os lados, em metros, do triângulo Y");
                double.TryParse(Console.ReadLine(), out y.A);
                double.TryParse(Console.ReadLine(), out y.B);
                double.TryParse(Console.ReadLine(), out y.C);

            double pX, pY, areaX, areaY, maior;
            string triangulo;
            pX = (x.A + x.B + x.C) / 2;
            pY = (y.A + y.B + y.C) / 2;
            areaX = Math.Sqrt(pX * (pX - x.A) * (pX - x.B) * (pX - x.C));
            areaY = Math.Sqrt(pY * (pY - y.A) * (pY - y.B) * (pY - y.C));

            if (areaX > areaY)
            {
                maior = areaX;
                triangulo = "tirangulo X";
            }
            else
            {
                maior = areaY;
                triangulo = "triangulo Y";
            }

            Console.WriteLine($"As áreas dos triangulos X e Y são respectivamente: \nAréa do Triangulo X: {areaX.ToString("F2")}m².\nÁrea do triângulo Y: {areaY.ToString("F2")}m²\n o maior triangulo é o {triangulo}, de área {maior.ToString("F2")}m²");

        }
}   }
    
   
