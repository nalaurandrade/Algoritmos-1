/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class Comparação
{
    static void Main()
    {
        Console.Write("Digite o valor numérico de x: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Digite o valor numérico de y: ");
        int y = int.Parse(Console.ReadLine());
        Console.WriteLine(x == y ? "x e y são iguais " : "x e y não são iguais ");
        Console.WriteLine(x < y ? $"{x} < {y}" : $"{x} > {y}");
        
        if (x <= y)
        {
            Console.WriteLine($"{x} <= {y}");
        }
        if (x >= y)
        {
            Console.WriteLine($"{x} >= {y}");
        }
    }
}

