using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project4_POO.Interfaces;

namespace Project4_POO.Models
{
    public class Calculadora : ICalculadora
    {
        public int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}