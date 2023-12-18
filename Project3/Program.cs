// Tratando exceção

// trantando para arquivo não encontrado
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
