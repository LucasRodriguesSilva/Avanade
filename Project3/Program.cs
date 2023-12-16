string[] listas = File.ReadAllLines("Arquivos/texto.txt");

foreach(string lista in listas)
{
    Console.WriteLine(lista);
}