using System;
using System.Globalization;

namespace programa13 {
    /* MEMBROS ESTÁTICOS - PARTE 2 */
    // São membros que fazem sentido independentemente de objetos. 
    // Não precisam de objeto para serem chamados. 
    // Essa classe não poderá ser instanciada, caso ela possua apenas membros estáticos.
    // São chamados a partir do próprio nome da classe.
    class Program {
        static void Main(string[] args) {

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine($"Circunferência: {circ.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de PI: {Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture)}");
        }

    }
}
