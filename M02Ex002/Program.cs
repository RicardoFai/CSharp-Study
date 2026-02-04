// See https://aka.ms/new-console-template for more information
int n1 = 0;
int n2 = 0;

Console.Write("Numerador: ");
int.TryParse(Console.ReadLine(), out n1);
Console.Write("Denominador: ");
int.TryParse(Console.ReadLine(), out n2);



Console.WriteLine($"Divisão inteira {n1} / {n2} = {(int)n1 / (int)n2:D}");
Console.WriteLine($"Divisão reL DE {n1} / {n2} = {(float)n1 / (float)n2:F2}");



