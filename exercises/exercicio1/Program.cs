using System;
using System.Globalization;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercício de Fixação 001
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1.ToString("F2")}");
            Console.WriteLine($"{produto2}, cujo preço é $ {preco2.ToString("F2")}");

            Console.WriteLine($"Registro: {idade} de idade, código {codigo} e gênero: {genero}");

            Console.WriteLine("Medida com oito casas decimais: {0}", medida.ToString("F8"));
            Console.WriteLine("Arredondado (três casas decimais): {0}", medida.ToString("F3"));
            Console.WriteLine($"Separador decimal invariant culture {medida.ToString("F3",CultureInfo.InvariantCulture)}");
        }
    }
}
