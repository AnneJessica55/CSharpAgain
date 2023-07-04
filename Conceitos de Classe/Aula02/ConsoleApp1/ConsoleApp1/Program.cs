namespace Course
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double Area()
        {
            double p = (A + B + C) / 2;
            double area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return area;
        }
    }
}
   

namespace Course
{
    class Program
    {

        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Cálculo de área de 2 triangulos");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Digite abaixo os lados, em centímetros, do triângulo X:");

            double.TryParse(Console.ReadLine(), out x.A);
            double.TryParse(Console.ReadLine(), out x.B);
            double.TryParse(Console.ReadLine(), out x.C);
            Console.WriteLine("Digite abaixo os lados, em centímetros, do triângulo Y:");

            double.TryParse(Console.ReadLine(), out y.A);
            double.TryParse(Console.ReadLine(), out y.B);
            double.TryParse(Console.ReadLine(), out y.C);

            double areaX = x.Area();
            double areaY = y.Area();

            if (areaX > areaY)
            {
                Console.WriteLine($"A maior área é do triângulo X, que mede {areaX.ToString("F2")} cm².");
            }
            else
            {
                Console.WriteLine($"A maior área é do triângulo Y, que mede {areaY.ToString("F2")} cm².");
            }
        }
    }
}