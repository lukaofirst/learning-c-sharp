using System;
using System.Globalization;

namespace programa21 {
    class Program {
        static void Main(string[] args) {
            /* Vetores */

            // Vetores - Parte 1
            // Vetor que armazena dados tipo struct
            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];
            double sum = 0.0;

            for (int i = 0; i < n; i++) {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                sum += vect[i];
            }

            double avg = sum / n;
            Console.WriteLine("Average Height = {0}", avg.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("------------");
            Console.WriteLine();

            // Vetores - Parte 2
            // Vetor que armazena dados tipo classe
            int j = int.Parse(Console.ReadLine());
            Product[] vector = new Product[j];
            double soma = 0.0;

            for (int i = 0; i < j; i++) {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vector[i] = new Product { Name = name, Price = price };
            }

            for (int i = 0; i < j; i++) {
                soma += vector[i].Price;
            }

            double media = soma / j;
            Console.WriteLine("Preço Médio: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
