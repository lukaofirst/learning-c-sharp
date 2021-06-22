using System;

namespace programa5 {
    class Program {
        static void Main(string[] args) {
            // Estrutura Condicional (if-else)
            Console.WriteLine("Qual a hora atual");

            int hora = int.Parse(Console.ReadLine());

            if (hora >= 6 && hora < 12) {
                Console.WriteLine("Bom dia");
            } else if (hora > 12 && hora <= 18) {
                Console.WriteLine("Boa tarde");
            } else {
                Console.WriteLine("Boa noite");
            }
        }
    }
}
