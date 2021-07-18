using System;

namespace programa52 {
    class Program {
        static void Main(string[] args) {
            /* Generics */
            // Permite que classes, interfaces e métodos possam ser parametrizados por tipo.
            // Seus benefícios incluem o Reuso, Type Safety e Performance

            // Verifique a classe [PrintService.cs]
            PrintService<int> printService = new PrintService<int>();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++) {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            printService.Print();
            Console.WriteLine($"First: {printService.First()}");
        }
    }
}
