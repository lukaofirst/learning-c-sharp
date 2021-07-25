using System;
using System.Collections.Generic;
using programa64.Entities;
using System.Linq;

namespace programa64 {
    class Program {
        static void Main(string[] args) {
            /* Delegate - Func (exemplo com Select) */
            // Representa um método que recebe zero ou mais argumentos, e retorna um valor
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            // 1ª Forma: Referência para método
            // List<string> result = list.Select(NameUpper).ToList();

            // 2ª Forma: Variável para Expressão Lambda
            // Func<Product, string> func = p => p.Name.ToUpper();
            // List<string> result = list.Select(func).ToList();

            // 3ª Forma: Expressão Lambda Inline
            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();

            foreach (string s in result) {
                Console.WriteLine(s);
            }
        }

        // 1ª Forma: Referência para método
        /*
        static string NameUpper(Product p) {
            return p.Name.ToUpper();
        }
        */
    }
}
