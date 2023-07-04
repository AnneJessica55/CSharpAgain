using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    internal class Empregados
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; protected set; }

        public Empregados(string id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void Aumento( double x)
        {
            Salario = Salario*(1 + x / 100);
        }

        public override string ToString()
        {
            return $"\n{Id} - {Nome} R${Salario.ToString("F2")}.";
        }
    }
}
