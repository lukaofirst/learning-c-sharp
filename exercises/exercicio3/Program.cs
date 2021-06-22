using System;
using System.Globalization;

namespace exercicio3 {
    class Program {
        static void Main(string[] args) {
            /* Ler dados de duas pessoas, a partir de uma classe criada */
            
            // Definindo o tipo das variáveis e instanciando-as
            Pessoa p1, p2;
            p1 = new Pessoa();
            p2 = new Pessoa();

            // Usando os dados da pessoa p1
            Console.WriteLine("Dados da primeira pessoa:");

            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            // Usando os dados da pessoa p2
            Console.WriteLine("Dados da segunda pessoa:");

            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            // Verificando qual das duas pessoas é a mais velha
            if (p1.Idade > p2.Idade) {
                Console.WriteLine($"Pessoa mais velha: {p1.Nome}");
            } else {
                Console.WriteLine($"Pessoa mais velha: {p2.Nome}");
            }

            Console.WriteLine("---------------------------");

            /* Ler dados de dois funcionários, a partir de uma classse */
            
            // Definindo o tipo das variáveis e instaciando-as
            Funcionario f1, f2;
            f1 = new Funcionario();
            f2 = new Funcionario();
            
            // Usando os dados do funcionário 1
            Console.WriteLine("Dados do primeiro funcionário");

            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Usando os dados do funcionário 2
            Console.WriteLine("Dados do segundo funcionário");

            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Calculando a média de salário
            double mediaSalario = (f1.Salario + f2.Salario) / 2;
            Console.WriteLine($"Salário médio: {mediaSalario.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
