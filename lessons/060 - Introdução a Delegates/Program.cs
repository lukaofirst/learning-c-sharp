using System;
using programa60.Services;

namespace programa60 {
    class Program {
        delegate double BinaryNumericOperation(double n1, double n2);

        static void Main(string[] args) {
            /* Introdução a Delegates */
            // É uma referência (com type safety) para um ou mais métodos
            // É um tipo referência

            double a = 10;
            double b = 12;

            // 1ª Forma: Sem usar [delegate]
            double result1 = CalculationServices.Max(a, b);
            Console.WriteLine(result1);

            // 2ª Forma: Usando [delegate], forma verbosa
            BinaryNumericOperation op = new BinaryNumericOperation(CalculationServices.Sum);
            double result2 = op(a, b);
            Console.WriteLine(result2);

            // 3ª Forma: Usando [delegate], menos verboso
            BinaryNumericOperation op2 = CalculationServices.Sum;
            double result3 = op2(a, b);
            Console.WriteLine(result3);

            // 3.1: Usando [delegate], sintaxe alternativa;
            double result4 = op2.Invoke(a, b);
            Console.WriteLine(result4);
        }
    }
}
