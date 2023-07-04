/*Fazer um programa que leia os lados de um retângulo. Em seguida, motre na tela seu perímetro, área e diagonal.*/

namespace Course
{
    class Retangulo
    {
        public double B;
        public double H;

        public double Area()
        {
            return B * H;
        }

        public double Perimetro()
        {
            return 2 * B + 2 * H;
        }

        public double Diagonal()
        {
            return Math.Sqrt(B * B + H * H);
        }
    }
   

}

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo md;
            md = new Retangulo();
            Console.WriteLine("Descobrindo área, perímetro e diagonal de um triângulo.");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Informe abaixo a medida da base do retângulo:");
            double.TryParse(Console.ReadLine(), out md.B);
            Console.WriteLine("Informe abaixo a medida da altura do retângulo:");
            double.TryParse(Console.ReadLine(), out md.H);

            double area = md.Area();
            double peri = md.Perimetro();
            double diag = md.Diagonal();

            Console.WriteLine($"O perímetro do retângulo é de {peri.ToString("F2")}cm, a sua área é de {area.ToString("F2")}cm² e sua diagonal é de {diag.ToString("F2")}");



        }
    }
}