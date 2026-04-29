// See https://aka.ms/new-console-template for more information
string nome;
float v1;
Console.WriteLine("digite o seu nome:");
nome =(Console.ReadLine());
Console.WriteLine("Digite o valor da venda: ");
v1 = float.Parse(Console.ReadLine());

if  (v1 >= 70.000);
{
    Console.WriteLine(nome + "A sua comissao e de : 10% do valor vendido que foi: " + v1);
}

if (v1 >= 20.000 &&  v1 <= 15.000) ;
{
    Console.WriteLine(nome + "A sua comissao e de : 18% do valor vendido que foi:" + v1);
}
if (v1 < 20.000) ;
{
    Console.WriteLine(nome + "A sua comissao e de : 20% do valor vendido que foi:" + v1);
}

