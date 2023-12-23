using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project4_POO.Models
{
    public class Professor : Pessoa
    {
        public Professor(double salario)
        {
            Salario = salario;
        }
        public Professor()
        {
            
        }
        public double Salario { get; set; }
    }
}