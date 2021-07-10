using System;

namespace programa39 {
    class Program {
        static void Main(string[] args) {
            /* Estrutura try-catch-finally */
            // Bloco try - Ele possui um trecho de código que pode acarretar em uma exceção
            // Bloco catch - Ele captura esse try e executa no seu escopo como essa exceção será lidada
            // Bloco finally - Ele executa um código mesmo que tenha ocorrido ou não uma exceção
            try {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            } catch (DivideByZeroException) {
                Console.WriteLine($"Division by zero is not allowed");
            } catch (FormatException e) {
                Console.WriteLine($"Format error! {e.Message}");
            }
        }
    }
}
