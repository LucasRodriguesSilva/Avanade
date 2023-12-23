using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project4_POO.Models
{
    public class Aluno : Pessoa
    {
        public Aluno(int nota)
        {
            Nota = nota;
        }
        public Aluno()
        {
            
        }
        public int Nota { get; set; }
    }
}