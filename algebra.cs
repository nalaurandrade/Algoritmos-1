using System;

class HelloWorld
{
    static void Main()
    {
        int x, y;
        
        Console.Write("Enter the value of x: ");
        x = int.Parse(Console.ReadLine());

        Console.Write("Enter the value of y: ");
        y = int.Parse(Console.ReadLine());

        Console.WriteLine(x > 5 && y > 5 ? "x e y são maiores que 5" : "pelo menos um dos valores é menor ou igual a 5");

        int notaDoAluno; // You didn't define notaDoAluno, so I assume it's an integer variable.
        Console.Write("Enter the student's grade: ");
        notaDoAluno = int.Parse(Console.ReadLine());

        if (notaDoAluno >= 90)
        {
            Console.WriteLine("A");
        }
        else if (notaDoAluno >= 80)
        {
            Console.WriteLine("B");
        }
        else if (notaDoAluno >= 70)
        {
            Console.WriteLine("C");
        }
        else if (notaDoAluno >= 60)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }
    }
}