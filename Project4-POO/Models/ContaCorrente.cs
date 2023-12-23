using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project4_POO.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numerodaConta, decimal saldo)
        {
            NumerodaConta = numerodaConta;
            _saldo = saldo;
        }
        public int NumerodaConta { get; set; }
        private decimal _saldo;

        public void Sacar(decimal saque)
        {
            if (_saldo >= saque)
            {
                _saldo -= saque;
                Console.WriteLine($"Saque de {saque.ToString("C")} realizado com sucesso!");
            }
            else
            {
                Console.WriteLine($"Saldo insuficiente! Saldo disponível é: {_saldo.ToString("C")}");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"seu saldo é: {_saldo.ToString("C")}!");
        }

    }
}