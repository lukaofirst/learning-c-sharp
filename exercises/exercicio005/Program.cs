using System;
using System.Globalization;

namespace exercicio5 {
    class Program {        
        static void Main(string[] args) {
            Funcionario fun1 = new Funcionario();

            Console.Write($"Nome: ");
            fun1.Nome = Console.ReadLine();
            Console.Write($"Salário Bruto: R$ ");
            fun1.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write($"Imposto: R$ ");
            fun1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine($"Funcionário: {fun1}");

            Console.WriteLine();
            Console.Write($"Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine());
            fun1.AumentarSalario(porcentagem);

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {fun1}");
        }
    }
}
