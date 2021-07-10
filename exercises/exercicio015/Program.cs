using System;
using System.Globalization;
using exercicio015.Entities;
using exercicio015.Entities.Exceptions;

namespace exercicio015 {
    class Program {
        static void Main(string[] args) {
            /* Tratamento de Exceções - Exercício de Fixação */
            try {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: $");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: $");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account acc = new Account(number, holder, balance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: $");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                acc.Withdraw(amount);

                Console.WriteLine($"New balance: {acc.Balance}");
            } catch (DomainException e) {
                Console.WriteLine($"Withdraw error: {e.Message}");
            }
        }
    }
}
