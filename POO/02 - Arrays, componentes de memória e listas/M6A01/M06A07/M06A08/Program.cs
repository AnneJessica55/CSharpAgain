//for
string[] vetor = new string[] { "Maria", "Jurema", "José", "Astolfo", "Roraima" };
for(int i =0; i< vetor.Length; i++)
{
    Console.WriteLine(vetor[i]);
}
Console.WriteLine("_____________________");
//foreach
foreach (string elemento in vetor)
{
    Console.WriteLine(elemento);
}