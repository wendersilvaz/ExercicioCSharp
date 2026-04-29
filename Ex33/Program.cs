// See https://aka.ms/new-console-template for more information
using System.Numerics;

string nome;
float nota1, nota2, nota3, total;
Console.WriteLine("Digite a nota da prova1 : ");
nota1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota da prova2: ");
nota2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota da prova3");
nota3 = float.Parse(Console.ReadLine());
total = (nota1 + nota2 + nota3) / 3;
Console.WriteLine("A media e: " + total);


