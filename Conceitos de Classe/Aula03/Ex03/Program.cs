/*Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
(primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no
ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam
para o aluno obter o mínimo para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver
este problema*/
using System.Runtime.CompilerServices;

namespace Course
{
    class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double Media()
        {
            return (Nota1 + Nota2 + Nota3) / 3;
        }
        public string Situacao()
        {
            string situation;
            if (Media() >= 6)
            {
                situation = "APROVADO";
            }
            else
            {
                situation = "REPROVADO";
            }
            return situation;
        }
            public override string ToString()
        {
            return $"Aluno(a) {Nome} conseguiu uma média de {Media().ToString("F2")}. Sua situação é {Situacao()}";
        }
    }
}

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno al = new Aluno();
            Console.WriteLine("Digite o nome do aluno:");
            al.Nome = Console.ReadLine();
            Console.WriteLine("Digite a primeira nota:");
            double.TryParse(Console.ReadLine(), out al.Nota1);
            Console.WriteLine("Digite a segunda nota:");
            double.TryParse(Console.ReadLine(), out al.Nota2);
            Console.WriteLine("Digite a terceira nota:");
            double.TryParse(Console.ReadLine(), out al.Nota3);
            Console.WriteLine(al);
        }
    }
}

