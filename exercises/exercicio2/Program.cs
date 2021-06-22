using System;
using System.Globalization;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercício de Fixação 002
            Console.WriteLine("Entre com seu nome completo:");
            string nomeCompleto = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int qtdQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha):");
            string[] info = Console.ReadLine().Split(" ");

            string lastName = info[0];
            int idade = int.Parse(info[1]);
            double altura = double.Parse(info[2], CultureInfo.InvariantCulture);

            Console.WriteLine("----------------");

            Console.WriteLine(nomeCompleto);
            Console.WriteLine(qtdQuartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(lastName);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
