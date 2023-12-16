using Project2.Models;

using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

Pessoa pessoa1 = new Pessoa(nome: "Lucas", sobrenome: "Rodrigues", idade: 25);

Pessoa pessoa2 = new Pessoa(nome: "Bruno", sobrenome: "Rodrigues", idade: 28);

Curso cursoDeIngles = new Curso(nome: "inglês");

cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAlunos(pessoa1);
cursoDeIngles.AdicionarAlunos(pessoa2);
cursoDeIngles.ListarAlunos();

// Manipulação de valores
decimal valorEmDinheiro = 10.00M;

Console.WriteLine($"{valorEmDinheiro:C}");
Console.WriteLine($"{valorEmDinheiro:N}");
Console.WriteLine($"{valorEmDinheiro:C5}");

double porcentagem = .25;

Console.WriteLine(porcentagem.ToString("P1"));

int numeroComoData = 12122023;
Console.WriteLine(numeroComoData.ToString("##-##-####"));

DateTime data = DateTime.Now;

Console.WriteLine(data.ToString("dd-MM-yy HH:mm tt"));

// Exemplo se caso a data for inválida

string dataIncorreta = "10-13-2023 25:00";

bool validarData = DateTime.TryParseExact(dataIncorreta, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataCorreta);

if(validarData)
{
    Console.WriteLine($"Data correta: {dataCorreta}");
}
else
{
    Console.WriteLine($"Data incorreta: {dataIncorreta}");
}