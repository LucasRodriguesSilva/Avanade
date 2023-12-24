using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project4_POO.Models
{
    public sealed class Professor : Pessoa
    {
        public Professor()
        {
            
        }
        public Professor(string nome) : base(nome)
        {
            
        }
        public double Salario { get; set; }

        public sealed override void Apresentar()
        {
            Console.WriteLine($"O professor {Nome}, de {Idade} anos, ganha {Salario.ToString("C")}");
        }
    }
}