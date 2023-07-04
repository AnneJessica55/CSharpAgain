// See https://aka.ms/new-console-template for more information
Console.Write("Digite o seu nome: ");
string nome = Console.ReadLine();
Console.Write("Digite o sua cidade: ");
string cidade = Console.ReadLine();
Console.Write("Digite o nome do destinatário: ");
string destinatario = Console.ReadLine();
Console.Write("Digite sua frase: ");
string frase = Console.ReadLine();

Console.WriteLine($"\n-------------------------------------\nOlá, {destinatario}. \n{nome} da cidade de {cidade} deseja te deixar uma mensagem.\n\"{frase}\"");
