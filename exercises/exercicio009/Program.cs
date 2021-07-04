using System;
using System.Globalization;

namespace exercicio9 {
    class Program {
        // Exercício de Fixação - Vetores
        static void Main(string[] args) {
            Estudante[] vect = new Estudante[10];

            Console.Write("Quantos quartos serão alugados? ");
            // Como [quartosAlugados] não possui nenhuma restrição,
            // Então, os últimos valores irão, pra um mesmo valor de quarto, serão sobrepostos
            int quartosAlugados = int.Parse(Console.ReadLine());

            for(int i = 1; i <= quartosAlugados; i++) {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int numeroQuarto = int.Parse(Console.ReadLine());

                vect[numeroQuarto] = new Estudante(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Listagem dos Quartos Ocupados:");
            
            for(int i = 0; i < quartosAlugados; i++) {
                if(vect[i] != null) {
                    Console.WriteLine($"{i}: {vect[i]}");
                }
            }

        }
    }
}
