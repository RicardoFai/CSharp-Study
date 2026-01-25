// See https://aka.ms/new-console-template for more information
float sal= 0;
Console.WriteLine("Qual é o seu salário? ");
float.TryParse(Console.ReadLine()!, out sal);
Console.WriteLine($"Você ganha {sal:C} por mês! ");
