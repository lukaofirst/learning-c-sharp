using System;
using System.Globalization;

namespace programa14 {
    class Program {
        static void Main(string[] args) {
            /*** Construtores ***/
            // Operação especial da classe, onde é executado no momento da instanciação do objeto
            // É utilizado para iniciar os atributos ou permitir que o objeto receba dados/dependências na instanciação
            // Por exemplo: Produto p = new Produto(); => O construtor padrão é o que se encontra dentro dos parênteses

            /*** Sobrecarga ***/
            // Recurso das classes que oferece mais de uma operação com o mesmo nome, porém com os argumentos são diferentes
            // É possível incluir um construtor padrão (sem parâmetros), porém deve ser feito na "mão"
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);
            // Repare que aqui, não foi necessário usar o atributo diretamente da Classe, em vez usar: p.Nome
            // Foi feita o uso de uma variável auxiliar passando ela como parâmetro na instanciação do objeto.

            // Construtor que possui apenas dois argumentos
            Produto p2 = new Produto(nome, preco);

            // Construtor padrão que não possui nenhum argumento
            Produto p3 = new Produto();

            /*** Sintaxe Alternativa Para Iniciar Valores ***/
            // Essa sintaxe funciona mesmo se a classse não possuir construtores próprios
            Produto p4 = new Produto {
                Nome = "TV",
                Preco = 500.00,
                Quantidade = 20
            };

            Produto p5 = new Produto() {
                Nome = "TV",
                Preco = 500.00,
                Quantidade = 20
            };

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}