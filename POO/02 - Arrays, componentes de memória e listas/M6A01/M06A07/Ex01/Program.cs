using Ex01;

Console.WriteLine("Digite a quantidade de funcionários que deseja inserir:");
int n;
List<Empregados> lista = new List<Empregados>();
int.TryParse(Console.ReadLine(), out n);
for (int i = 1; i<= n; i++)
{
    string id ="2023 - " + i;
    Console.WriteLine($"Digite o nome {i}°do(a) Empregado(a):");
    string nome = Console.ReadLine();
    Console.WriteLine($"Digite o salário {i}° do(a) funcionário(a):");
    double salario;
    double.TryParse(Console.ReadLine(), out salario);
    lista.Add(new Empregados(id, nome, salario));
    Console.WriteLine();
}
Console.WriteLine("Lista atualizada de funcionários:\nID - NOME R$ SALÁRIO");
foreach (Empregados obj in lista)
{
    
    Console.WriteLine(obj);
}

Console.WriteLine("Digite o id do funcionário que terá seu salário aumentado");
string locaemp = Console.ReadLine();
Empregados lista2 = lista.Find(x => x.Id == locaemp);

if (lista2 != null)
{
    Console.WriteLine("Digite a porcentagem do aumento:");
    double por;
    double.TryParse(Console.ReadLine(), out por);
    lista2.Aumento(por);
}
else
{
    Console.WriteLine("Funcionário inexistente.");
}
Console.WriteLine("Lista atualizada de funcionários:\nID - NOME R$ SALÁRIO");

foreach (Empregados obj in lista)
{
    
    Console.WriteLine(obj);
}
