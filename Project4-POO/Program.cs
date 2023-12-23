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
