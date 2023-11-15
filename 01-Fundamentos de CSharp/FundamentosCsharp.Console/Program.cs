// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

#region Tipos e Variáveis
/*
var nome = Console.ReadLine();

Console.WriteLine(nome);

double valorDouble = 3.14;
float valorFloat = 3.14F;
decimal valorDecimal = 3.14M;
int valorInteiro = 100;
bool valorBooleano = true;
char valorChar = 'A';
string valorString = "Bruno Eduardo";

const double PI = 3.1416;

Console.WriteLine($"Double: {valorDouble}, Float: {valorFloat}, Decimal: {valorDecimal}, Inteiro: {valorInteiro}, PI: {PI}");
Console.WriteLine($"Boolean: {valorBooleano}");
Console.WriteLine($"Char: {valorChar}, String: {valorString}");
*/
#endregion

#region Operadores Aritméticos
/*int a = 10;
int b = 20;

int soma = a + b;
int subtracao = a - b;
int multiplicacao = a * b;
int divisao = b / a;
int modulo = a % b;

Console.WriteLine($"Soma: {soma}, Subtração: {subtracao}, Multiplicação: {multiplicacao}, Divisão: {divisao}, Módulo: {modulo}");
*/
#endregion 

#region Operadores Lógicos
/*bool x = true;
bool y = false;

var and =  x && y; // AND
var or = x || y;   // OR
var notX = !x;     // NOT
var notY = !y;     // NOT

Console.WriteLine("x = true, y = false");
Console.WriteLine($"AND: {and}, OR: {or}, NOT X:{notX}, NOT Y: {notY}");
*/
#endregion 

#region Operadores de Comparação

/*var p = 5;
var q = 10;

bool maior = p > q;
bool maiorOuIgual = p >= q;
bool menor = p < q;
bool menorOuIgual = p <= q;
bool igual = p == q;
bool diferente = p != q;

Console.WriteLine($"P = {p}, Q = {q}");
Console.WriteLine($"Maior: {maior}, Maior ou Igual:{maiorOuIgual}");
Console.WriteLine($"Menor: {menor}, Menor ou Igual:{menorOuIgual}");
Console.WriteLine($"Igual: {igual}, Diferente:{diferente}");
*/
#endregion 

#region Operadores de Igualdade e Atribuição
using System.ComponentModel;

int k = 5;
k = 10;

k += 5; // k = k + 5 = 10 + 5 = 15
Console.WriteLine(k);
k -= 3; // k = k - 3 = 15 - 3 = 12
Console.WriteLine(k);
k *= 2; // k = k * 2 = 12 * 2 = 24
Console.WriteLine(k);
k /= 4; // k = k / 4 = 24 / 4 = 6
Console.WriteLine(k);
k %= 5; // k = k % 5 = 6 % 5 = 1
Console.WriteLine(k);


#endregion