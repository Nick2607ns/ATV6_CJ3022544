// See https://aka.ms/new-console-template for more information
using System.Runtime.Serialization;

Console.WriteLine("Hello, World!");

//exercicio 1
/*
int num, i=0;

Console.WriteLine("digite um num inteiro");
num = int.Parse(Console.ReadLine());


while ( i <= num)
{
    Console.WriteLine(i);
    i++;

}
*/

// exercicio 2

/*
int num, i = 0;

Console.WriteLine("digite um num inteiro");
num = int.Parse(Console.ReadLine());


while (i <= num)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
        
    }
    i++;
}

*/

//exercicio 3
/*
int i, num = 1000;

Console.WriteLine("digite um numero inteiro");
i= int.Parse(Console.ReadLine());

while ( i <= num)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
    i++;
}

*/

// exercicio 4

int n1, a1 = 1;
int soma = 200;
Console.WriteLine("Digite um número");
n1 = int.Parse(Console.ReadLine());
    while (a1 < soma)
{
    if (n1 < 0)
    {
        Console.WriteLine("número inválido");
    }
    else
    {
        Console.WriteLine(a1);
    }
    a1++;
}



// exercicio 5

    int v, p1 = 0;
    Console.WriteLine("Digite um número:");
    v = int.Parse(Console.ReadLine());

    while (p1 <= v)
    {
        if (v % p1 == 0)
        {
            Console.WriteLine(p1);
        }
        p1++;
    };

    

// exercicio 6

    int j1 = 0, v2;
    while (j1 < 11)
    {
        Console.WriteLine("Digite um valor");
        v2 = int.Parse(Console.ReadLine());
        if (v2 < v2)
        {
            Console.WriteLine("o número maior é = {0}", v2);
        }
        if (v2 > v2)
        {
            Console.WriteLine("o número menor é = {0}", v2);
        }
        j1++;
    };



// exercicio 7


                        int t = 0, l3;
    int r1 = 0, p3 = 0;
    while (t < 10)
    {
        Console.WriteLine("Digite um valor");
        l3 = int.Parse(Console.ReadLine());
        if (l3 <= 0)
            break;
        if (t % 2 != 0)
        {
            r1 = r1 + t;
        }
        if (t % 2 == 0)
        {
            p3 = p3 + t;
        }
        Console.WriteLine("soma dos números ímpares = {0}", r1);
        Console.WriteLine("soma dos números pares = {0}", p3);
        t++;
    }




