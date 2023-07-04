// See https://aka.ms/new-console-template for more information
/*Conversão implicita: Só funciona do menor para o maior*/
int a = 2;
float b = a;
Console.WriteLine($"a variável a é do tipo {a.GetType()} e b é {b.GetType()}");
/*Conversões do tipo casting ou explícita serve para você atribuir a maior para a menor, porém não há arredondamento, só truncagem.*/
double c = 5.82;
a = (int)c;
Console.WriteLine($"O novo valor de a é {a}, e de C é {c}\nElas são do tipo {a.GetType()} e {c.GetType()} ");
/*A conversão por classe auxiliar não sóconverte, como arredonda*/
double g = 5.89845;
a = Convert.ToInt32(g);
Console.WriteLine($"O valor de g é {g}. O valor de a é {a}.");


