// See https://aka.ms/new-console-template for more information

//Exemplo de operadores aritméticos

int op1 = 0;
int op2 = 0;


//Entrada de dados
Console.Write("Digite o primeiro operando: ");
int.TryParse(Console.ReadLine(), out op1);
Console.Write("Digite o segundo operando: ");
int.TryParse(Console.ReadLine(), out op2);


//Processamento e saída de dados
Console.WriteLine($"Calculando +{op1} = {+op1}"); // identidade
Console.WriteLine($"Calculando -{op1} = {-op1}"); // negação
Console.WriteLine($"Calculando {op1} + {op2} = {op1 + op2} "); // adição
Console.WriteLine($"Calculando {op1} - {op2} = {op1 - op2} ");// subtração
Console.WriteLine($"Calculando {op1} * {op2} = {op1 * op2} ");// multiplicação
Console.WriteLine($"Calculando {op1} / {op2} = {op1 / op2} **ERRO** ");// divisão inteira
Console.WriteLine($"Calculando {op1} / {op2} = {(float)op1 / (float)op2:F2} ");// divisão real
Console.WriteLine($"Calculando {op1} % {op2} = {op1 % op2} ");// resto da divisão



