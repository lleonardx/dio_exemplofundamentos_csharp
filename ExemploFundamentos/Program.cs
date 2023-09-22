using System.Runtime.CompilerServices;
using ExemploFundamentos.Common.Models;

//LISTA
List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");
listaString.Add("RJ");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("SC");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Remove("MG");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");


Console.WriteLine("Percorrendo List com FOR");
for(int i=0; i < listaString.Count; i++)
{
     Console.WriteLine($"Posicao N: {i} - {listaString[i]}");
}

Console.WriteLine("\nPercorrendo List com FOREACH");
int iForeach = 0;
foreach(string item in listaString)
{
    Console.WriteLine($"Posicao N: {iForeach} - {item}");

}



int[] arrayInteiros = new int [4];
arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
arrayInteiros[3] = 1;

int [] arrayInteirosDobrado = new int [arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);


Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);  //redimensionar o array, e dobrar ele de tamanho

Console.WriteLine("Percorrendo array com FOR");
for(int i=0; i < arrayInteiros.Length; i++)
{
    Console.WriteLine($"Posicao {i} - {arrayInteiros[i]} ");
}


Console.WriteLine("\nPercorrendo array com FOREACH");
int iForeach1 = 0;
foreach(int valor in arrayInteiros)
{
    Console.WriteLine($"Posicao {iForeach1} - {valor} ");
    iForeach++;
}



string? opcao;
bool exibirMenu = true;

while(exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Insira sua opcao: ?");
    Console.WriteLine("1 - Cadastrar Cliente");
    Console.WriteLine("2 - Buscar Cliente");
    Console.WriteLine("3 - Apagar Cliente");
    Console.WriteLine("4 - Encerrar"  );

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
        Console.WriteLine("Cadastro de Cliente");
        break;

        case "2":
        Console.WriteLine("Busca de Cliente");
        break;

        case "3":
        Console.WriteLine("Apagar Cliente");
        break;

        case "4":
        Console.WriteLine("Encerrar");
        exibirMenu = false;
        break;

        default:
        Console.WriteLine("Opcao Invalida");
        break;
    }
   
}

 Console.WriteLine();




 //DO WHILE

int soma = 0;
int numero = 0;

do
{
    Console.WriteLine("Digite um Numero (0 para parar) ");
    numero = Convert.ToInt32(Console.ReadLine());

    soma += numero;


} while (numero != 0);

Console.WriteLine($"Total da soma dos numeros digitados e: {soma}");



 //WHILE
int numero2 = 5;
int contador = 1;

while(contador <= 10)
{
    Console.WriteLine($"{contador} Execucao: {numero2} x {contador} = {numero * contador}");
    contador++;

    if (contador == 6)
    { 
        break;
    }
}

 //FOR
int numero1 = 10;
for (int contador1 =0; contador1 <= 10; contador1++)
{
    Console.WriteLine($"{numero1} x {contador1} = {numero1 * contador1}");
}

//MAth
Calculadora calc = new Calculadora();

calc.Somar(10,20);
calc.Subtrair(10,50);
calc.Multiplicar(15,45);
calc.Dividir(2,2);
calc.Potencia(3,3);

calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);

calc.RaizQuadrada(25);




//SWITCH CASE
Console.WriteLine("Digite uma letra: ");
string? letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;

    default:
        Console.WriteLine("Nao e uma Vogal");
        break;

}


if (letra == "a" )
{
    Console.WriteLine("Vogal");
}
 else if (letra == "e")
{
    Console.WriteLine("Vogal");
}
 else if (letra == "i")
{
    Console.WriteLine("Vogal");
}
 else if (letra == "o")
{
    Console.WriteLine("Vogal");
}
else if (letra == "u")
{
    Console.WriteLine("Vogal");
}
else
{
    Console.WriteLine("Nao e uma vogal");
}



//CONDICAO IF ELSE
int quantidadeEmEstoque = 3;
int quantidadeCompra = 0;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade de compra: {quantidadeCompra}");
Console.WriteLine($"E possivel realizar venda ?: {possivelVenda}");
if (quantidadeCompra == 0)
{
    Console.WriteLine("Venda Invalida");
}
else if (possivelVenda)
{
     Console.WriteLine("Venda Realizada");
}
else
{
    Console.WriteLine("Nao temos quantidade no estoque");
}


string a = "15-";
int b = 0;

int.TryParse(a, out b);

Console.WriteLine(b);
Console.WriteLine("Conversao realizada");


//TIPOS
int a2 = 10;
int b2 = 20;

int c = a2 + b2;
c += 5;

 Console.WriteLine(c);

//DATE TIME
DateTime dataAtual = DateTime.Now.AddDays(5);
Console.WriteLine(dataAtual);

//VARIAVEIS
string apresentacao = "Ola, seja bem vindo";
int quantidade = 1;
Console.WriteLine("Valor da Variavel quantidade: " + quantidade);
quantidade = 10;
Console.WriteLine("Valor da Variavel quantidade: " + quantidade);


double altura = 1.80;
decimal preco = 1.80M;
bool condicao = true;
Console.WriteLine(apresentacao);
Console.WriteLine("Valor da Variavel quantidade: " + quantidade);
Console.WriteLine("Valor da Variavel altura: " + altura.ToString("0.00"));
Console.WriteLine("Valor da Variavel preco: " + preco);
Console.WriteLine("Valor da Variavel condicao: " + condicao);

Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "Leonardo";
pessoa1.Idade = 26;
pessoa1.Apresentar();

