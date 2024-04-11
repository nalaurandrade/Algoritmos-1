using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Digite um CPF para ser validado >>> ");
        string cpfInput = Console.ReadLine();
        ValidarCPF(cpfInput);
    }

    static void ValidarCPF(string cpf)
    {
        // Transforma a string do CPF em uma lista de inteiros contendo apenas os dígitos
        List<int> cpfNumeros = cpf.Where(char.IsDigit).Select(digito => int.Parse(digito.ToString())).ToList();

        // Verifica se a quantidade de dígitos do CPF é diferente de 11 e exibe uma mensagem de erro se for
        if (cpfNumeros.Count != 11)
        {
            Console.WriteLine($"O CPF número {cpf} é inválido, tente novamente.");
            return;
        }

        // Calcula o primeiro dígito verificador do CPF
        int soma1 = Enumerable.Range(0, 9).Sum(i => (i + 1) * cpfNumeros[i]);
        int digitoVerif1 = (soma1 * 10) % 11;
        if (digitoVerif1 == 10)
        {
            digitoVerif1 = 0;
        }

        // Verifica se o primeiro dígito verificador é igual ao fornecido no CPF
        if (digitoVerif1 == cpfNumeros[9])
        {
            // Calcula o segundo dígito verificador do CPF
            int soma2 = Enumerable.Range(0, 10).Sum(i => (i + 1) * cpfNumeros[i]);
            int digitoVerif2 = (soma2 * 10) % 11;
            if (digitoVerif2 == 10)
            {
                digitoVerif2 = 0;
            }

            // Verifica se o segundo dígito verificador é igual ao fornecido no CPF
            if (digitoVerif2 == cpfNumeros[10])
            {
                Console.WriteLine($"O CPF número {cpf} é válido!");

                // Cria um dicionário associando números de estados aos seus nomes correspondentes
                Dictionary<int, string> estados = new Dictionary<int, string>
                {
                    { 0, "Rio Grande do Sul" },
                    { 1, "Distrito Federal, Goiás, Mato Grosso do Sul, Tocantins" },
                    // ... (os outros estados estão definidos da mesma forma)
                };

                // Verifica se o número do estado existe no dicionário e exibe o estado correspondente
                string estadoOrigem = estados.ContainsKey(cpfNumeros[8]) ? estados[cpfNumeros[8]] : "Desconhecido";
                Console.WriteLine($"Seu CPF é originário do estado do {estadoOrigem}");
                return;
            }
        }

        // Exibe uma mensagem de CPF inválido caso as verificações falhem
        Console.WriteLine($"O CPF número {cpf} é inválido, tente novamente.");
    }
}

