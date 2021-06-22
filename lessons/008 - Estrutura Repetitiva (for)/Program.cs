using System;

namespace programa8 {
    class Program {
        static void Main(string[] args) {
            // Estrutura repetitiva (for)

            Console.Write("Quantos números inteiros você vai digitar? ");
            int n = int.Parse(Console.ReadLine());

            int soma = 0;
            // O contador da soma é declarada antes porque, ele será exibido após o loop for
            // Quando tiver a soma com o valor acumulado

            for (int i = 1; i <= n; i++) {

                Console.Write($"Valor #{1}: ");
                int valor = int.Parse(Console.ReadLine());

                soma += valor;
            }

            Console.WriteLine($"Resultado da soma será: {soma}");
        }
    }
}
