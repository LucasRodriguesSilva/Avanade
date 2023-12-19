// Tratando exceção

// trantando para arquivo não encontrado
using Project3.Models;

try
{
    string[] listas = File.ReadAllLines("Arquivos/ttexto.txt");

    foreach(string lista in listas)
    {
        Console.WriteLine(lista);
    }
}
catch (FileNotFoundException)
{
    Console.WriteLine("Arquivo não foi encontrado");
}

try
{
    string[] listas = File.ReadAllLines("Arquivos/d/ttexto.txt");

    foreach(string lista in listas)
    {
        Console.WriteLine(lista);
    }
}
catch (DirectoryNotFoundException)
{
    Console.WriteLine($"Pasta não foi encontrada");
}
finally
{
    Console.WriteLine("Finalizado");
}

new ExemploExcecao().Metodo1();

// Fila

Queue<int> fila = new Queue<int>();

fila.Enqueue(1);
fila.Enqueue(2);
fila.Enqueue(3);
fila.Enqueue(4);

foreach (int filas in fila)
{
    Console.WriteLine(filas);
}

Console.WriteLine($"Eliminando o {fila.Dequeue()}");

foreach(int filas in fila)
{
    Console.WriteLine(filas);
}