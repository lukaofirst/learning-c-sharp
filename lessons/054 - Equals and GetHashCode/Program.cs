using System;
using programa54.Entities;

namespace programa54 {
    class Program {
        static void Main(string[] args) {
            /* Equals and GetHashCode */
            // São operações da classe Object utilizadas para comparar se um objeto é igual a outro

            // Os tipos pré-definidos já possuem implementação para essas operações.
            // Classes e structs personalizados precisam sobrepô-las
            // Verifique a classe [Client]

            // Equals tende a ser mais lento, porém com uma resposta de 100%
            // string a = "Maria";
            // string b = "Maria";
            // Console.WriteLine(a.Equals(b));

            // GetHashCode tende a ser mais rápido, porém a resposta positiva não é 100%
            // Console.WriteLine(a.GetHashCode());
            // Console.WriteLine(b.GetHashCode());

            // Regra de ouro do GetHashCode
            // Se o código de dois objetos for diferente, então os dois objetos são diferentes
            // Se o código de dois objetos for igual, muito provavelmente os objetos são iguais (pode haver colisão)

            Client a = new Client() { Name = "Maria", Email = "maria@gmail.com"};
            Client b = new Client() { Name = "Alex", Email = "alex@gmail.com"};

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b);
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());


        }
    }
}
