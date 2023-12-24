using Project4_POO.Interfaces;
using Project4_POO.Models;

Console.WriteLine("APRESENTAR PESSOA");

Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Lucas";
pessoa1.Idade = 25;

pessoa1.Apresentar();

Console.WriteLine("CONTA CORRENTE");

ContaCorrente contaPessoa1 = new ContaCorrente(123456, 3000);

contaPessoa1.ExibirSaldo();
contaPessoa1.Sacar(100);
contaPessoa1.ExibirSaldo();
contaPessoa1.Sacar(4000);

Console.WriteLine("ALUNO");
Aluno aluno1 = new Aluno();
aluno1.Nome = "Lucas";
aluno1.Idade = 25;
aluno1.Nota = 10;

aluno1.Apresentar();

Console.WriteLine("PROFESSOR");
Professor professor1 = new Professor();
professor1.Nome = "Bruno";
professor1.Idade = 25;
professor1.Salario = 2000;

professor1.Apresentar();

Console.WriteLine("CREDITANDO NA CONTA CORRENTE");
Corrente corrente1 = new Corrente();
corrente1.Creditar(100);
corrente1.ExibirSaldo();