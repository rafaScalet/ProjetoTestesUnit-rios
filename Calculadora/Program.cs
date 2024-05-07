using Calculadora.Services;

CalculadoraImp c = new();
ValidarString v = new();

int num1 = 4;
int num2 = 2;
string texto = "olá";

Console.WriteLine(c.Somar(num1, num2));
Console.WriteLine(v.ContarString(texto));