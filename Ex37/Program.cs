// See https://aka.ms/new-console-template for more information
string nome;
float idade,soma, total;
Console.WriteLine("Digite a sua idade em anos");
idade = float.Parse(Console.ReadLine());

soma = idade * 365;
total = soma * 30;
Console.WriteLine("A sua idade em dias e:" + total + "Dias vividos");
