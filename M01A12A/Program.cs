// See https://aka.ms/new-console-template for more information
Console.WriteLine("Qual é o sue nome? ");
string nome = Console.ReadLine()!;
Console.WriteLine($"Olá, {nome}! Tudo bem?");

int dia = DateTime.Now.Day;
int mes = DateTime.Now.Month;
int ano = DateTime.Now.Year;
Console.WriteLine($"Hoje é {dia} do mês {mes} e do ano de  {ano}!  ");
