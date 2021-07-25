using System;
using System.Collections.Generic;
using programa63.Entities;

namespace programa63 {
    class Program {
        static void Main(string[] args) {
            /* Delegate - Action (Exemplo com ForEach) */
            // Representa um método void que recebe zero ou mais argumentos
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Smartphone", 759.00));
            list.Add(new Product("HD Case", 80.90));

            // 1ª Forma: Referência para Método
            // list.ForEach(UpdatePrice);

            // 2ª Forma: Variável para Expressão Lambda
            // Na declaração Lamdba desse [Action] ele deve está entre chaves
            // Para indicar que ele não retorne nada
            // Action<Product> act = p => { p.Price += p.Price * 0.1; };

            // 3ª Forma: Expressão Lambda Inline
            list.ForEach(p => p.Price += p.Price * 0.1);
            foreach (Product p in list) {
                Console.WriteLine(p);
            }
        }

        // 1ª Forma: Referência para Método
        /*static void UpdatePrice(Product p) {
            p.Price += p.Price * 0.1;
        }*/
    }
}
