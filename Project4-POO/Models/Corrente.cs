using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project4_POO.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(decimal valor)
        {
            _saldo += valor;
        }
    }
}