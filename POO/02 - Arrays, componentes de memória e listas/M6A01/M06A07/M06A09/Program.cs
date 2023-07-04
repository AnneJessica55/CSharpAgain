using System.Collections.Generic;

//intanciando a lista
List<string> lista = new List<string>();
Console.WriteLine("Digite a quantidade de nomes que deseja adicionar");
int n;
int.TryParse(Console.ReadLine(), out n);
Console.WriteLine("Informe os nomes que deseja adicionar a lista separando-os por virgulas");

string nomes = Console.ReadLine();
string[] vetor = nomes.Split(", ");
Console.WriteLine("_________________________");

for (int i = 0; i<n; i++)
{
    lista.Add(vetor[i]);
}

foreach (string objeto in lista)
{
    Console.WriteLine(objeto);
}
Console.WriteLine("__________________________");
Console.WriteLine("Deseja Inserir outro nome? Digite S para sim e N para não.");
string resp = Console.ReadLine();
while ( resp == "s"|| resp == "S")
{
    Console.WriteLine("Insira a posição que você deseja inserir o nome");
    int pos;
    int.TryParse(Console.ReadLine(), out pos);
    Console.WriteLine("Digite o nome que deseja inserir:");
    string onome = Console.ReadLine();
    lista.Insert(pos - 1, onome);

    Console.WriteLine("Deseja Inserir outro nome? Digite S para sim e N para não.");
    resp = Console.ReadLine();

}
Console.WriteLine("______________________");
foreach(string obj in lista)
{
    Console.WriteLine(obj);
}
Console.WriteLine($"Essa lista contém {lista.Count} nomes.");
Console.WriteLine("__________________________");

string s1 = lista.Find(x => x[0] == 'A');
int pos1 = lista.FindIndex(x => x[0] == 'A');
Console.WriteLine($"O primeiro nome qua inicia com A é {s1}, na posição {pos1 + 1}.");

Console.WriteLine("________________________");
string s2 = lista.FindLast(x => x[0] == 'A');
int pos2 = lista.FindLastIndex(x => x[0] == 'A');
Console.WriteLine($"O ultimo nome que começa com A é {s2}, na posição {pos2 + 1}.");
Console.WriteLine("_____________________________");
List<string> lista2 = lista.FindAll(x => x.Length <= 5);
foreach(string obj in lista2)
{
    Console.WriteLine(obj);
}
Console.WriteLine("_________________________");
Console.WriteLine("Deseja remover alguém da lista?");
string ans = Console.ReadLine();
while( ans == "s" || ans =="S")
{
    Console.WriteLine("Digite o nome que deseja remover:");
    string nome = Console.ReadLine();
    lista.Remove(nome);
    Console.WriteLine("Deseja remover alguém da lista?");
    ans = Console.ReadLine();

}
Console.WriteLine("_________________________");
foreach ( string obj in lista)
{
    Console.WriteLine(obj);
}