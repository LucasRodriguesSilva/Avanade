using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }
        public void Dividir(double x, double y)
        {
            double numeroDividido = Math.Round((x / y), 2);
            Console.WriteLine($"{x} / {y} = {numeroDividido}");
        }

        public void Potenciacao(int x, int y)
        {
            double potencia = Math.Pow(x, y);
            Console.WriteLine($"{x} ^ {y} = {potencia}");
        }
        public void Seno(double angulo)
        {
            double radiano = angulo * (Math.PI / 180);
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}° = {Math.Round(seno, 4)}");
        }
        public void Conseno(double angulo)
        {
            double radiano = angulo * (Math.PI / 180);
            double conseno = Math.Cos(radiano);
            Console.WriteLine($"Conseno de {angulo}° = {Math.Round(conseno, 4)}");
        }
        public void Tangente(double angulo)
        {
            double radiano = angulo * (Math.PI / 180);
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo}° = {Math.Round(tangente, 4)}");
        }
        public void RaizQuadrada(double x)
        {
            double y = Math.Round(Math.Sqrt(x), 1);
            Console.WriteLine($"A raiz quadrada de {x} é {y}");
        }
    }
}