// See https://aka.ms/new-console-template for more information
Console.Write("\nProduto 1:");
string n1 = Console.ReadLine().Trim();
Console.Write("Preço 1: R$");
float p1;
float.TryParse(Console.ReadLine(), out p1);

Console.Write("Produto 2: R$");
string n2 = Console.ReadLine().Trim();
Console.Write("Preço 2:");
float p2;
float.TryParse(Console.ReadLine(), out p2);


Console.SetCursorPosition(0, 10);
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine($"{" Produto", -20}{"Preço ", 13}");
Console.ResetColor();
Console.BackgroundColor = ConsoleColor.DarkGray;
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine($" {n1, -20}{p1, 13:C2}");
Console.WriteLine($" {n2, -20}{p2, 13:C2}");
Console.ResetColor();
