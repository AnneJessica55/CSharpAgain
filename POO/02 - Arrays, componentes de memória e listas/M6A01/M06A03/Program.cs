//Não é possível uma variavel de valor receber um null

//double x = null; - isso não é permitido porque double não é um valor null

//para atribuir um null ao double:
//Nullable<double> x = null;
//essa é a forma mais difícil. A forma mais fácil está abaixo.

double? x = null;
double? y = 20;
Console.WriteLine(x.GetValueOrDefault()+"\n"+y.GetValueOrDefault());

//esse método retorna o valor da variável ou, caso nulo, retorna o valor padrão do tipo da variável. No caso de double é 0

// O atributo .HasValue() retorna verdadeiro ou falso para a pergunta se tem ou não algum valor na variável.
Console.WriteLine("------------------------------------------");
Console.WriteLine(x.HasValue);
Console.WriteLine(y.HasValue);

//Operador de coalescência
Console.WriteLine("-------------------------------------------");
double? z = null;
double? a = 10;

double b =  z ?? 5;
double c = a ?? 5;

Console.WriteLine($"{b} + {c} = {b+c}");
