using System;

namespace programa35 {
    class Program {
        /* Classes e Métodos Selados */
        // Palavra-chave: [sealed]

        // Classe: Evita que a classe seja herdada
        // Exemplo:
        // namespace programa {
        //      sealed class SomeClasseName {

        // Métodos: Evita que um método sobreposto posta ser sobreposto novamente
        // Obs.: Só pode ser aplicado a métodos sobrespostos 
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
        }
    }
}
