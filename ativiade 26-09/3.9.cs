using System;

class Program
{
    static void Main()
    {
        // Solicitar ao usuário o raio do círculo
        Console.Write("Digite o raio do círculo: ");
        double raio = Convert.ToDouble(Console.ReadLine());

        // Calcular o diâmetro, a circunferência e a área
        double diametro = 2 * Math.PI * raio;
        double circunferencia = 2 * Math.PI * raio;
        double area = Math.PI * Math.Pow(raio, 2);

        // Imprimir os resultados
        Console.WriteLine($"Diâmetro: {diametro}");
        Console.WriteLine($"Circunferência: {circunferencia}");
        Console.WriteLine($"Área: {area}");
    }
}
