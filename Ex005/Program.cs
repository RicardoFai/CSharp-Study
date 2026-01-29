// See https://aka.ms/new-console-template for more information
Console.WriteLine("Em que ano você nasceu?");
int anoNascimento;
int.TryParse(Console.ReadLine(), out anoNascimento);
int idade = 2026 - anoNascimento;
Console.WriteLine("-------------------------------------------------------------------");
Console.WriteLine($"Quem nasceu em {anoNascimento} vai completar {idade} anos em 2026.");
