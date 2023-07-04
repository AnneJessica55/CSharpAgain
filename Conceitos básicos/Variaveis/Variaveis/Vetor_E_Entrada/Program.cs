// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite abaixo seu nome, cidade e o nome do destinatário. (Separe por vírgula");
string r = Console.ReadLine();
string[] rv = r.Split(',');/*É possível também fazer com o Console.ReadLine().Split(',')*/
Console.WriteLine("Digite a frase que desejas transmitir ao destinatário");
string frase = Console.ReadLine();
Console.WriteLine($"-----------------------------\nOlá, {rv[2]}. {rv[0]} da cidade de {rv[1]} deseja te transmitir a seguinte mensagem:\n----------------------------\n\"{frase}\".");
