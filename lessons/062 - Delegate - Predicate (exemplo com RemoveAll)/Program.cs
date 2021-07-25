using System;
using System.Collections.Generic;
using programa62.Entities;

namespace programa62 {
    class Program {
        static void Main(string[] args) {
            /* Delegate - Predicate (exemplo com RemoveAll) */
            // Representa um método que recebe um objeto do tipo T e retorna um valor booleano
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            // 1ª Forma: Referência para Método
            // list.RemoveAll(ProductTest);

            // 2ª Forma: Expressão Lambda
            list.RemoveAll(p => p.Price >= 100.0);
            foreach (Product p in list) {
                Console.WriteLine(p);
            }
        }

        // 1ª Forma: Referência para Método
        /*
        public static bool ProductTest(Product p) {
            return p.Price >= 100.0;
        }
        */
    }
}
