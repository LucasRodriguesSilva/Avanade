﻿// Tratando exceção

// trantando para arquivo não encontrado
using System.Runtime.Serialization;
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

Console.WriteLine("FILA");

Queue<int> fila = new Queue<int>();

fila.Enqueue(1);
fila.Enqueue(2);
fila.Enqueue(3);
fila.Enqueue(4);

foreach (int filas in fila)
{
    Console.WriteLine(filas);
}

Console.WriteLine($"Eliminando o {fila.Dequeue()} que era o primeiro da fila");

foreach(int filas in fila)
{
    Console.WriteLine(filas);
}

// Pilhas

Console.WriteLine("PILHA");

Stack<int> pilha = new Stack<int>();

pilha.Push(6);
pilha.Push(7);
pilha.Push(8);
pilha.Push(9);

foreach (int pilhas in pilha)
{
    Console.WriteLine(pilhas);
}

Console.WriteLine($"Tirando o número {pilha.Pop()} que estava no topo");


foreach (int pilhas in pilha)
{
    Console.WriteLine(pilhas);
}

// Elementos com chave de acesso

Console.WriteLine("DICTIONARY");

Dictionary<int, string> item = new Dictionary<int, string>();

item.Add(1, "Chave de acesso 1");
item.Add(2, "Chave de acesso 2");
item.Add(3, "Chave de acesso 3");
item.Add(4, "Chave de acesso 4");

// Acessando valor
Console.WriteLine(item[1]);

foreach (var itens in item)
{
    Console.WriteLine($"Chave: {itens.Key} tem o valor: {itens.Value}");
}

item.Remove(4);
item[1] = $"a chave de acesso 1 foi modificada";

Console.WriteLine(item[1]);

// saber se um valor já existe

int valorExistente = 1;
Console.WriteLine($"verificando a chave: {valorExistente}");

if(item.ContainsKey(valorExistente))
{
    Console.WriteLine($"Não pode adicionar a chave: {valorExistente}");
}
else
{
    Console.WriteLine($"Pode adicionar o {valorExistente}");
}
