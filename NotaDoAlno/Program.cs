using System.ComponentModel.Design;

string nome;
float nota1, nota2,nota3, total;
Console.WriteLine("Digite o seu nome: ");
nome = Console.ReadLine();
Console.WriteLine("Digite a primeira nota1:");
nota1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a segunda nota2:");
nota2 = float.Parse(Console.ReadLine());
total = nota1 + nota2;

if (total >= 60) 
{
    Console.WriteLine("aluno: " + nome + "- aprovado");
}
else
{
    Console.WriteLine("aluno: " + nome + "- reprovado");
}
