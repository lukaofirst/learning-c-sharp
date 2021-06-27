using System;
using System.Globalization;

namespace programa17 {
    class Program {
        /* Properties (Encapsulamento) */
        static void Main(string[] args) {
            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "T";   // Apenas a string "T" não será exibido por conta da condição imposta
            // p.Preco = 300; => A propriedade de preço não permite setar um outro preço, apenas permite a leitura

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);

        }
    }
}