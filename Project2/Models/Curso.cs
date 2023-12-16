using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project2.Models
{
    public class Curso
    {
        public Curso()
        {

        }
        public Curso(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAlunos(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }
        public int ObterQuantidadeAlunoosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }
        public void RemoverAluno(Pessoa aluno)
        {
            Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de {Nome}");

            for (int i = 0; i < Alunos.Count; i++)
            {
                string textoDeAlunos = $"N {i + 1} {Alunos[i].NomeCompleto}";
                Console.WriteLine(textoDeAlunos);
            }
        }
    }
}