using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project2.Models
{
    public class Pessoa
    {
        // Para poder adicionar com parametro ou sem no program
        public Pessoa()
        {

        }
        // Adicionando parametros, e refênciando nas propriedades
        public Pessoa(string nome, string sobrenome, int idade)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
        }
        private string _nome;
        private string _sobrenome;
        private int _idade;
        
        public string Nome
        {
            get => _nome;
            
            set
            {
                if(value == "")
                {
                    throw new ArgumentException("Não pode ser vazio o nome");
                }

                _nome = value;
            }
        }

        public string Sobrenome
        {
            get => _sobrenome;

            set
            {
                if(value == "")
                {
                    throw new ArgumentException("O sobrenome não pode ser vazio");
                }
            
                _sobrenome = value;
            }
        }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        public int Idade
        {
            get => _idade;

            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("O número não pode ser menor que 0");
                }

                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Oi, meu nome é {NomeCompleto} tenho {Idade} anos");
        }
    }
}