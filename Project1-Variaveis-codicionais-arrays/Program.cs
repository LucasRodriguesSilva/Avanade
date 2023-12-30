// esse código é somente das aulas que estou aprendendo na DIO.

using Project1.Models;

People pessoa1 = new People();

pessoa1.Name = "Lucas";
pessoa1.Age = 25;

pessoa1.Apresentar();

int transformandoLetraEmNumero = Convert.ToInt32("10");

string transformandoNumeroEmLetra = transformandoLetraEmNumero.ToString();

// resultado tem que ser 105
Console.WriteLine(transformandoNumeroEmLetra + 5);

string letra10 = "10";
int transfomarndoLetra10EmInteiro = int.Parse(letra10);

// tem que ser 20
Console.WriteLine(transfomarndoLetra10EmInteiro + 10);

string letraComInteiroErrado  = "10-";

int numeroParaSubstituirOErrado = 0;

int.TryParse(letraComInteiroErrado, out numeroParaSubstituirOErrado);

// Se o letra estiver errado, vai ser exibido o número 0
Console.WriteLine(numeroParaSubstituirOErrado);

// Compra de produto, verificando a quantidade no estoque
int quantidadeNoEstoque = 10;
int quantidadeDeCompra = 10;
bool quantidadeDeCompraInvalida = quantidadeDeCompra == 0;
bool quantidadeETemEstoqueValido = quantidadeNoEstoque >= quantidadeDeCompra;
if(quantidadeDeCompraInvalida)
{
    Console.WriteLine("Quantidade de compra incorreta");
}
else if(quantidadeETemEstoqueValido)
{
    Console.WriteLine("Obrigado pela compra!");
}
else
{
    Console.WriteLine("Não temos em estoque");
}

// Aqui é escolhido uma vogal

Console.WriteLine("Escolha uma vogal");
// string vogal = Console.ReadLine();
// Conmentei o código ReadLine, para ter um código contínuo
string vogal = "A";

// coloquei um ToLower para que a letra maiúscula se transoforme em minúscula e possa ser feita a verificação
switch (vogal.ToLower())
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Isso é uma vogal!");
        break;

    default:
        Console.WriteLine("Isso não é uma vogal");
        break;
}

// Operadores

bool maiorDeIdade = true;
bool possuiAutorizacaoDeUmResponsavel = false;

if(maiorDeIdade || possuiAutorizacaoDeUmResponsavel)
{
    Console.WriteLine("Entrada autorizada!");
}
else
{
    Console.WriteLine("Não possui autorização para entrar");
}

bool estavaPresenteNasAulas = false;
double qualFoiAMedia = 7.5;

if(estavaPresenteNasAulas && qualFoiAMedia == 7)
{
    Console.WriteLine("Aprovado!");
}
else
{
    Console.WriteLine("Reprovado!");
}


bool taChovendo = false;
bool taTarde = false;

if(!taChovendo && !taTarde)
{
    Console.WriteLine("Uhul, vamos pedalar de bicicleta!");
}
else
{
    Console.WriteLine("Hoje não tem como sair de bicicleta");
}

// Calculadora
Calculadora calcular = new Calculadora();

calcular.Somar(5, 7);
calcular.Subtrair(1, 10);
calcular.Multiplicar(-1, 10);
calcular.Dividir(10, 3);
calcular.Potenciacao(3, 3);
calcular.Seno(30);
calcular.Conseno(30);
calcular.Tangente(30);
calcular.RaizQuadrada(10);

// Incremento e decremento
int numeroIncrementar = 5;
int numeroDecrementar = 5;
numeroIncrementar++;
numeroDecrementar--;

Console.WriteLine($"O número {numeroIncrementar} será adicionado mais 1 e o resultado vai ficar {numeroIncrementar}");
Console.WriteLine($"O número {numeroDecrementar} será subtraído menos 1 e o resultado vai ficar {numeroDecrementar}");

// Laço de repetição for

int valorParaMultiplicar = 6;

for(int contadorMultiplicar = 0; contadorMultiplicar <= 10; contadorMultiplicar++)
{
    Console.WriteLine($"{valorParaMultiplicar} x {contadorMultiplicar} = {valorParaMultiplicar * contadorMultiplicar}");
}

int valorParaSomar = 10;
int contadorSomar = 0;

// Laço de repetição while

while(contadorSomar <= valorParaSomar)
{
    Console.WriteLine($"{valorParaSomar} + {contadorSomar} = {valorParaSomar + contadorSomar}");
    contadorSomar++;

    if(contadorSomar == 6)
    {
        break;
    }
}

int quantidadeDaSomaDoNumeroInserido = 0, numeroInserido = 0;

do
{
    Console.WriteLine("Digite o número 0 para parar:");
    // inseri o número para o sistema continuar
    numeroInserido = 0;
    //numeroInserido = Convert.ToInt32(Console.ReadLine());
    quantidadeDaSomaDoNumeroInserido += numeroInserido;

} while(numeroInserido != 0);

Console.WriteLine($"A soma dos números inseridos é {quantidadeDaSomaDoNumeroInserido}");

// Aqui é um menu interativo

// coloquei uma opção para ser contínuo
string opcao = "3";

while(opcao != "3")
{
    Console.WriteLine("1 - Entrar");
    Console.WriteLine("2 - Cadastrar");
    Console.WriteLine("3 - Sair");

     opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.WriteLine("Entrando");
            break;

        case "2":
            Console.WriteLine("Cadastrando");
            break;

        case "3":
            Console.WriteLine("Saindo");
            break;
        
        default:
            Console.WriteLine("Você escolheu uma opção inexistente");
            break;
    }
}

Console.WriteLine("Você saiu do menu interativo");

// Trabalhando com array

int[] numero = new int[] {10,20,30};

// Usando o for
for(int i = 0; i < numero.Length; i++ )
{
    Console.WriteLine($"O numero {i} é {numero[i]}");
}

// Usando o foreach

foreach(int caixaDeNumeros in numero)
{
    Console.WriteLine(caixaDeNumeros);
}

// aumentando array

Array.Resize(ref numero, numero.Length * 2);

Console.WriteLine($"Quantida atual do array é = {numero.Length}");

int[] copiaNumero = new int[numero.Length * 2];

Array.Copy(numero, copiaNumero, numero.Length);

Console.WriteLine($"Essa quantidade da copia do array é {copiaNumero.Length}");

// trabalhando com lista

List<int> lista = new List<int>();

lista.Add(1);
lista.Add(2);
lista.Add(3);
lista.Remove(3);

for(int i = 0; i < lista.Count; i++)
{
    Console.WriteLine($"lista número {i} é {lista[i]} no for");
}

int numeroParaContagemDeLista = 0;
foreach(int caixaDeLista in lista)
{
    Console.WriteLine($"lista número {numeroParaContagemDeLista} é {caixaDeLista} no foreach");
}