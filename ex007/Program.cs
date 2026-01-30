// See https://aka.ms/new-console-template for more information
int ini, fim;
Console.WriteLine("\nSORTEADOR DE NÚMEROS");
Console.WriteLine("-----------------------------");
Console.Write("Início: ");
int.TryParse(Console.ReadLine(), out ini);
Console.Write("Fim: ");
int.TryParse(Console.ReadLine(), out fim);

Console.WriteLine("-----------------------------");
Console.SetCursorPosition(0, 6);
Console.Write("Sorteando...");
Thread.Sleep(2000);
Random gerador = new Random();
int num = gerador.Next(ini, fim + 1);
Console.SetCursorPosition(0, 6);
Console.Write($"Entre {ini} e {fim} sorteei o valor {num}");



