using System;
using programa33.Entities;

namespace programa33 {
    class Program {
        /* Upcasting e Downcasting */
        static void Main(string[] args) {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            // UPCASTING
            // É o casting da subclasse para superclasse
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            // DOWNCASTING
            // É o casting da superclasse para subclasse
            // É uma operação insegura, use apenas quando necessário

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);
            // Por mais que no "acc2" tenha feito a declaração para o tipo BusinessAccount
            // O compilador não sabe disso, o que interessa pra ele é o que vem antes da atribuição que é o Account

            // Essa operação dará erro
            // BusinessAccount acc5 = (SavingsAccount)acc3;

            // Palavra "is" - Ele verifica se o tipo de uma variável é instância de outro 
            // Palavra "as" - Uma outra forma de se fazer o casting
            if(acc3 is BusinessAccount) {
                // BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if(acc3 is SavingsAccount) {
                // SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
            
        }
    }
}
