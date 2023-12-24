using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project4_POO.Models
{
    public class Aluno : Pessoa
    {
        public Aluno()
        {
            
        }
        public Aluno(string nome) : base(nome)
        {
            
        }
        public int Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"O aluno {Nome}, que tem {Idade} anos tem uma nota {Nota}");
        }
    }
}