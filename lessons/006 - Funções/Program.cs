using System;   // Declaração das bibliotecas

namespace programa6 {
    // Aqui vem as classes
    class Program {
        // Aqui vem as funções
        static void Main(string[] args) {       // Esse termo significa a função padrão que indica o entry-point da aplicação
            Console.WriteLine("Digite três números:");

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);

            Console.WriteLine($"O maior número é {resultado}");
        }

        static int Maior(int a, int b, int c) {     
            // Com esse static é possível chamar o método na própria classe
            // Após o método do tipo [static] é preciso definir que tipo de valor será retornado.
            // Cada parâmetro é preciso declarar o tipo da variável
            int m;

            if (a > b && a > c) {
                m = a;
            } else if (b > c) {
                m = b;
            } else {
                m = c;
            }

            return m;       // Com esse return a variável [m] ficará disponível fora do escopo
        }
    }
}
