using System;
using programa34.Entities;

namespace programa34 {
    class Program {
        /* Sobreposição, palavras [virtual, override e base] */
        // virtual - Para que um método comum (não abstrato) possa ser sobreposto, deve ser incluído nele o prefixo "virtual"
        // override - Ao sobrescrever um método, devemos incluir nele o prefixo "override"
        // base - Chama a implementação da superclasse

        static void Main(string[] args) {
            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}
