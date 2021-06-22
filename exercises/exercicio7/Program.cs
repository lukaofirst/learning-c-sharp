using System;
using System.Globalization;

namespace exercicio7 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Qual é a cotação atual do dólar? R$ ");
            double precoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você deseja comprar? $ ");
            double quantiaDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Valor a ser pago em reais: R$ " +
                $"{ConversorDeMoeda.DolarParaReal(precoDolar, quantiaDolar).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
