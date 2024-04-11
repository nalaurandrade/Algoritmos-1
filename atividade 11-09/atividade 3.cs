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

    // Definição da função Comb
    static ulong Comb(int n, int r)
    {
        if (n < r)
        {
            Console.WriteLine("Erro: n deve ser maior ou igual a r.");
            return 0; // Retorne 0 em caso de erro.
        }

        ulong numerador = Fatorial(n);
        ulong denominador = Fatorial(r) * Fatorial(n - r);
        return numerador / denominador;
    }

    static void Main(string[] args)
    {
        int n;

        Console.WriteLine("Insira o valor de n:");
        n = Convert.ToInt32(Console.ReadLine());

        // Cálculo de Prn
        for (int r = 0; r <= n; r++)
        {
            ulong permutacoes_subconjunto = PermSub(n, r);
            Console.WriteLine("Pr" + n + r + " = " + permutacoes_subconjunto);
        }

        // Cálculo de Crn
        for (int r = 0; r <= n; r++)
        {
            ulong combinacoes = Comb(n, r);
            Console.WriteLine("Cr" + n + r + " = " + combinacoes);
        }

        // Verificação da relação n = n1 + n2 + ... + nr
        ulong soma_fatoriais = 0;
        for (int r = 0; r <= n; r++)
        {
            soma_fatoriais += Fatorial(n) / Fatorial(r);
        }

        Console.WriteLine("n = " + soma_fatoriais);
    }
}
