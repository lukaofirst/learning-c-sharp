using System;

namespace programa23 {
    class Program {
        static void Main(string[] args) {
            /* Modificador de Parâmetros: [ref] e [out]*/

            // [ref]
            // Sem ele o método de triplicar o valor não será feito
            // Pois, ele está sendo realizado em outro escopo
            // Obs.: Ele tem que ser adicionado tanto no método quando na sua chamada principal
            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);

            // [out]
            // Similar ao [ref], porém não é preciso iniciar a variável passada
            // Ele precisa de uma variável de origem, e uma outra variável de saída
            int b = 50;
            int triple;
            Calculator.CalcTriple(b, out triple);
            Console.WriteLine(triple);

        }
    }
}
