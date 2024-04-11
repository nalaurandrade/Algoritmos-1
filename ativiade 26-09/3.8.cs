using System;

class Program
{
    static void Main()
    {
        // Solicitar ao usuário que forneça dois números
        Console.Write("Digite o primeiro número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        // Calcular a soma, o produto, a diferença e o quociente
        double soma = numero1 + numero2;
        double produto = numero1 * numero2;
        double diferenca = numero1 - numero2;
        double quociente = numero1 / numero2;

        // Imprimir os resultados
        Console.WriteLine($"Soma: {soma}");
        Console.WriteLine($"Produto: {produto}");
        Console.WriteLine($"Diferença: {diferenca}");
        
        // Certificar-se de que a divisão não resulte em erro (divisão por zero)
        if (numero2 != 0)
        {
            Console.WriteLine($"Quociente: {quociente}");
        }
        else
        {
            Console.WriteLine("Não é possível calcular o quociente, pois o segundo número é zero.");
        }
    }
}
