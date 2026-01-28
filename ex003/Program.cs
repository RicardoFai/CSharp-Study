// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite um número: ");
float num;
float.TryParse(Console.ReadLine(), out num);

int n1 = (int)num;
int n2 = Convert.ToInt16(num);

Console.Clear();
Console.WriteLine($"Você digitou o valor {num:N1}");
Console.WriteLine($"A parte inteira do número é {n1:D}");
Console.WriteLine($"Arrendodando, temos o número {n2}");

