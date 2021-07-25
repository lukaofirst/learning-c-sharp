using System;

namespace programa59 {
    class Program {
        static void Main(string[] args) {
            /* Extension Methods */
            // São métodos que estendem a funcionalidade de um tipo,
            // sem precisar alterar o código onte deste tipo, nem herdar desse tipo.

            // Passo a passo para criar um extension method
            // 1) Criar uma classe estática
            // 2) Na classe, criar um método estático
            // 3) O primeiro parâmetro do método deverá ter o prefixo this, seguida da declaração
            //    de um parâmetro do tipo que se deseja estender. Esta é uma referência para o próprio objeto.
            DateTime dt = new DateTime(2021, 7, 19, 9, 30, 45);
            Console.WriteLine(dt.ElapsedTime());

            string s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));
        }
    }
}
