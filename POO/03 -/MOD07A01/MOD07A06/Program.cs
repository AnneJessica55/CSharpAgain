Console.WriteLine("Digite o se nome:");
string nome = Console.ReadLine();
string NOME = nome.ToUpper();
Console.WriteLine($"Nome normal: -{nome}-\nNome em maíusculo: -{NOME}-");

//ToLower()
string NOME2 = nome.ToLower();
Console.WriteLine("Nome normal: -{nome}-\nNome em minúsculo: -" + NOME2 + "-");

//Trim()
string NOME3 = nome.Trim();
Console.WriteLine("Nome aparado:-" + NOME3 + "-");
//IndexOf() e LastIndexOf()
int n1 = nome.IndexOf("a");
Console.WriteLine($"IndexOf(\"a\") = {n1}");
int n2 = nome.LastIndexOf("a");
Console.WriteLine($"LastIndexOf(\"a\") = {n2}");

//substring()
string n3 = nome.Substring(7);
Console.WriteLine($"Substring(3) {n3}");
string n4 = nome.Substring(7, 6);
Console.WriteLine($"Substring(3) {n4}");
// Replace()
string n5 = nome.Replace("a", "o");
Console.WriteLine($"Seu nome masculino {n5}");

//IsNullOrEmpity()
bool b1 = String.IsNullOrEmpty(nome);
Console.WriteLine($"IsNullOrEmpity() {b1}");

bool b2 = String.IsNullOrWhiteSpace(nome);
Console.WriteLine($"IsNullOrWhite|Space() {b2}");