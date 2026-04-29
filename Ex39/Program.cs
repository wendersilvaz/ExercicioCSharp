// See https://aka.ms/new-console-template for more information
string nome;
int valor, valorpg, total;
Console.WriteLine("Digite o valor da compra:");
valor = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor pago:");
valorpg = int.Parse(Console.ReadLine());

total = valorpg - valor;

if (total < 80) ;
{
    Console.WriteLine("O troco e de :" + total);
}

if (total < 80 && total < 150) ;
{
    Console.WriteLine("O troco e com uma nota de 5 reais");
}

if(total <10)
{
    Console.WriteLine("o troco sera com a nota de 10 reais");
}

