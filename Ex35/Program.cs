// See https://aka.ms/new-console-template for more information
string nome;
float nota1, nota2, nota3;
Console.WriteLine("Digite o seu nome: ");
nome = Console.ReadLine();
Console.WriteLine("Digite a primeira nota");
nota1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a segunda nota :");
nota2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a terceira nota: ");
nota3 = float.Parse(Console.ReadLine());

if (nota1 >= 7 && nota2 >= 7 && nota3 >= 7) ;
{ Console.WriteLine("Aprovado"); }
if (nota1 < 7 || nota2 < 7 || nota3 < 7) ;
{ Console.WriteLine("Reprovado"); }