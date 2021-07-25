using System;
using programa61.Services;

namespace programa61 {
    class Program {
        delegate void BinaryNumericOperation(double n1, double n2);
        static void Main(string[] args) {
            /* Multicast Delegates */
            // São delegates que guardam a referência para mais de um método
            // Seu uso faz sentido para métodos void

            double a = 5;
            double b = 14;

            BinaryNumericOperation op = CalculationServices.ShowMax;
            op += CalculationServices.ShowSum;

            // op.Invoke(a, b);
            op(a, b);
        }
    }
}
