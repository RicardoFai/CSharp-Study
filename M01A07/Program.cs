// See https://aka.ms/new-console-template for more information

// Conversão implícita int para float
/*int a = 8;
float b = a;

Console.WriteLine("O valor de a é " + a + "do tipo " + a.GetType());
Console.WriteLine("O valor de b é " + b + "do tipo " + b.GetType());*/


// Conversão Explícita float para int
/*
float a = 8.75f;
int b = (int)a;

Console.WriteLine("O valor de a é " + a + "do tipo " + a.GetType());
Console.WriteLine("O valor de b é " + b + "do tipo " + b.GetType());*/

// Conversão por classes auxiliares
float a = 8.25f;
int   b = Convert.ToInt16(a);


Console.WriteLine("O valor de a é " + a + " do tipo " + a.GetType());
Console.WriteLine("O valor de b é " + b + " do tipo " + b.GetType());



