// See https://aka.ms/new-console-template for more information
int n = 0;
Console.WriteLine("Digite um número: ");
int.TryParse(Console.ReadLine(), out n);
int d = n * 2;
Console.WriteLine($"O dobro de {n} é {d}");
