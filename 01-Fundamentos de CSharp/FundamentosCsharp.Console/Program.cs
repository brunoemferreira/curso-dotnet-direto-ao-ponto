﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


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