using System;

namespace programa20 {
    class Program {
        static void Main(string[] args) {
            /*** Nullable ***/
            // É uma forma dos structs possam receber o valor null (Por padrão não podem)

            // Formas de declarar um nullable

            // 1ª Forma - Verbosa
            Nullable<double> x = null;

            // 2ª Forma - Simpleficada
            double? y = null;

            // Métodos Possíveis
            double? a = null;
            double? b = 10;
            double? c = 20; // Mude para null

            // .GetValueOrDefault() - Ele pega o valor, se houver, ou o valor padrão
            Console.WriteLine(a.GetValueOrDefault());   // Output 0, porque o valor padrão do double é 0;
            Console.WriteLine(b.GetValueOrDefault());   // Output 10;

            // .HasValue - Retorna o booleano do nullable
            Console.WriteLine(a.HasValue);  // Output False
            Console.WriteLine(b.HasValue);  // Output True

            // .Value - Lança uma exceção no programa se não houver valor
            if(c.HasValue) {
                Console.WriteLine(c);
            } else {
                Console.WriteLine("c is null");
            }

            // Operador de Coalescência Nula
            // Se y for null, a variável y irá mostrar o valor após o [??]
            double z = y ?? 0.0;

            Console.WriteLine(z);

        }
    }
}
