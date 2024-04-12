using System;

class Program
{
    // Função para calcular o fatorial de um número
    static long Fatorial(int n)
    {
        if (n == 0)
            return 1;
        else
            return n * Fatorial(n - 1);
    }

    // Função para calcular as permutações de subconjuntos
    static long PermSub(int n, int r)
    {
        if (n < r)
        {
            // Caso inválido, pois não podemos ter mais elementos no subconjunto do que no conjunto original.
            return 0;
        }

        // Calcula o fatorial de n e (n - r)
        long fatorialN = Fatorial(n);
        long fatorialNR = Fatorial(n - r);

        // Calcula as permutações de subconjuntos
        long permSub = fatorialN / fatorialNR;

        return permSub;
    }

    static void Main()
    {
        Console.WriteLine("Informe o valor de n:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe o valor de r:");
        int r = int.Parse(Console.ReadLine());

        long permSub = PermSub(n, r);
        Console.WriteLine($"PermSub({n}, {r}) = {permSub}");
    }
}
