using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número inteiro positivo: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        long resultado = CalcularFatorial(numero);

        Console.WriteLine("O fatorial de " + numero + " é " + resultado);
    }

    static long CalcularFatorial(int n)
    {
        if (n == 0)
            return 1;
        else
            return n * CalcularFatorial(n - 1);
    }
}
