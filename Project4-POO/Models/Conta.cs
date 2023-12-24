using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project4_POO.Models
{
    public abstract class Conta
    {
        protected decimal _saldo;

        public abstract void Creditar(decimal valor);

        public void ExibirSaldo()
        {
            Console.WriteLine("O seu saldo é: " + _saldo.ToString("C"));
        }

    }
}