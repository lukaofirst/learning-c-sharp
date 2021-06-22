using System;
using System.Globalization;

namespace programa7 {
    class Program {
        static void Main(string[] args) {
            // Estrutura repetitiva (while)

            Console.WriteLine("Digite um número");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // No while, se a condição for [V] ela executa e volta, se for [F] ele pula fora
            while (x > 0) {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite outro número:");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Não existe raiz quadrada de número negativo");
        }
    }
}
