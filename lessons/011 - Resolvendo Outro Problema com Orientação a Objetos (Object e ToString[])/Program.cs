using System;
using System.Globalization;

namespace programa11 {
    class Program {
        static void Main(string[] args) {
            /* Aplicação que ler os dados de um produto, atualiza adicionando ou removendo a sua quantidade */

            // Instancinando uma nova classe;
            Produto p = new Produto();

            // Aqui faz a leitura dos dados iniciais do produto e exibe-os
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Dados do produto: {p}");

            // Aqui faz a adição da quantidade de produtos e atualiza a exibição
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {p}");

            // Aqui faz a redução da quantidade de produtos e atualiza a exibição
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine($"Dados do produto: {p}");
        }
    }
}
