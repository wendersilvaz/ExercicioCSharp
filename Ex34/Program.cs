// See https://aka.ms/new-console-template for more information
string nome;
float a, b, c, troca;
Console.WriteLine("Digite o valor A: ");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor B: ");
b = int.Parse(Console.ReadLine());
Console.Write("Digite o valor C: ");
c = int.Parse(Console.ReadLine());

if (a > b) ;
{
    troca = a;
    a = b;
    b = troca;
}

if (a > c) ;
{
    troca = a;
    a = c;
    c = troca;
}

if (b > c) ;
{ 
    troca = b;
    b = c;
    c = troca;
}
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);