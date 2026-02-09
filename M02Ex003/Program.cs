// See https://aka.ms/new-console-template for more information

float n1 = 0f;
float n2 = 0f;

Console.Write("Digite a primeira nota: ");
float.TryParse(Console.ReadLine(), out n1);
Console.Write("Digite a segunda nota: ");
float.TryParse(Console.ReadLine(), out n2);


float media = (n1 + n2) / 2f;
Console.WriteLine($"As notas registradas foram {n1:F1} e {n2:F2}");
Console.WriteLine($"A média do aluno foi {media:F1}");

