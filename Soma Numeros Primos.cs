using System;

class Program
{
    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;
        
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }
        
        return true;
    }

    static void Main()
    {
        int start = 1; // Início do intervalo
        int end = 20; // Fim do intervalo

        int sum = 0;

        for (int i = start; i <= end; i++)
        {
            if (IsPrime(i))
            {
                sum += i;
                Console.WriteLine(i); // Exibir os números primos encontrados
            }
        }

        Console.WriteLine($"A soma dos números primos no intervalo de {start} a {end} é: {sum}");
    }
}