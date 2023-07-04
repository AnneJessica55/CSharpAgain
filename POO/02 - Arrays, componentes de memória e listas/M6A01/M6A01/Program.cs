using System.Drawing;
using System;

namespace M6A01
{
    struct Point
    {
        public double X;
        public double Y;

        public override string ToString()
        {
            return $"({X}, {Y}).";
        }
    }
}



namespace M6A01
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p;

            p.X = 10;
            p.Y = 5;

            Console.WriteLine(p);
        }
    }
}

