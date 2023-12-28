using Calculadora.Services;

CalculadoraImp calculadora = new CalculadoraImp();

int numero1 = 10;
int numero2 = 15;

Console.WriteLine($"{numero1} + {numero2} = {calculadora.Somar(numero1, numero2)}");