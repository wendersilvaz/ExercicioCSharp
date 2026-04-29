// See https://aka.ms/new-console-template for more information
string nome;
float nota1, nota2, nota3, total;
Console.WriteLine("Digite a primeira nota:");
nota1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a segunda nota:");
nota2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a tersceira nota:");
    nota3 = float.Parse(Console.ReadLine());

if (nota1 + nota2 >= nota3) ;
{
    Console.WriteLine("A soma de A + B e maior ou igual a C");
}

if (nota1 + nota3 >= nota2) ;
{
    Console.WriteLine("A soma de A + C e maior ou igual a B");
}

if (nota2 + nota3 >= nota1) ;
{
    Console.WriteLine("A soma de B + C e maior ou igual a A");
}