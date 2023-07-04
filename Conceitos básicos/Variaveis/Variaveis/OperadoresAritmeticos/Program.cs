// See https://aka.ms/new-console-template for more information
/*
 soma +
subtração -
multiplicação *
Divisão /
mod %
Potência Math.Pow(base, expoente)
Raiz quadrada Math.Sqrt(variavel)
 
 */
double a = 1, b = 3, c = 2;
double delta = Math.Pow(b, 2.0) - 4 * a * c;
double x1 = (- b + Math.Sqrt(delta)) / 2 * a;
double x2 =(-b - Math.Sqrt(delta))/2 * a;

Console.WriteLine($" Os valores de x1 e x2 sãoo respectivamente: {x1}, {x2}.");
