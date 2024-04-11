using System;

class Program
{
    // Definição da função Fatorial
    static ulong Fatorial(int n)
    {
        if (n <= 1)
        {
            return 1;
        }
        ulong resultado = 1;
        for (int i = 2; i <= n; i++)
        {
            resultado *= (ulong)i;
        }
        return resultado;
    }

    // Definição da função PermSub
    static ulong PermSub(int n, int r)
    {
        if (n < r)
        {
            Console.WriteLine("Erro: n deve ser maior ou igual a r.");
            return 0; // Retorne 0 em caso de erro.
        }

        ulong numerador = Fatorial(n);
        ulong denominador = Fatorial(n - r);
        return numerador / denominador;
    }

    static void Main(string[] args)
    {
        int n, r;

        Console.WriteLine("Insira os valores de n e r para calcular Prn:");
        n = Convert.ToInt32(Console.ReadLine());
        r = Convert.ToInt32(Console.ReadLine());

        ulong permutacoes_subconjunto = PermSub(n, r);

        Console.WriteLine("Prn = " + permutacoes_subconjunto);
    }
}
