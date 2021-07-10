using System;
using programa32.Entities;

namespace programa32 {
    class Program {
        static void Main(string[] args) {
            /* Herança */
            // É uma forma de associar as classes, de forma que um herde os dados da outra
            // Tem como principais vantagens o Reuso e Polimorfismo
            // Syntax: [:] estende; base (referência para superclasse)
            // Obs.: Herança é uma associação entre classes, e não entre objetos.
            // Obs2.: Verifique as outras classes desse projeto
            Console.WriteLine("Hello World!");

            BusinessAccount account = new BusinessAccount(8010, "Bob", 100.0, 500.0);
            Console.WriteLine(account.Balance);

            // Como [Balance] foi declarado com "protected", a operação abaixo não será possível
            // account.Balance = 200.0;
        }
    }
}
