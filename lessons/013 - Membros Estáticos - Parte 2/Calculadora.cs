using System;

namespace programa13 {
    class Calculadora {
        // Por mais se instancie, por exemplo, [calc1] e [calc2]
        // Ambos vão para usar um mesmo método, sem alterar o valor do resultado

        static public double Pi = 3.14;

        static public double Circunferencia(double r) {
            return 2.0 * Pi * r;
        }
        static public double Volume(double r) {
            return (4.0 / 3.0) * Pi * Math.Pow(r, 3);
        }
    }
}
