using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o valor do café: ");
        int numero = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numero; i++)
        {
            Console.WriteLine($"Você recebeu 1 café ({i})!");
        }
    }
}
