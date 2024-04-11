using System;

public class Program
{
    public static void Main()
    {
        // Este programa é um exemplo de cálculo de folha de pagamento.
        // Ele demonstra como calcular o salário de um funcionário com base em horas trabalhadas e taxa de pagamento.
        
        // Variáveis para armazenar informações do funcionário
        string nome = "João";
        int horasTrabalhadas = 40;
        double taxaDePagamentoPorHora = 15.5;

        // Calcular o salário bruto
        double salarioBruto = horasTrabalhadas * taxaDePagamentoPorHora;

        // Exibir o resultado
        Console.WriteLine("Nome do funcionário: " + nome);
        Console.WriteLine("Horas trabalhadas: " + horasTrabalhadas + " horas");
        Console.WriteLine("Taxa de pagamento por hora: R$" + taxaDePagamentoPorHora);
        Console.WriteLine("Salário bruto: R$" + salarioBruto);
    }
}
