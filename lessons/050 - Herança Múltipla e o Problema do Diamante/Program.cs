using System;
using programa50.Devices;

namespace programa50 {
    class Program {
        static void Main(string[] args) {
            /* Herança Múltipla e o Problema do Diamante */
            // A herança múltipla pode gerar o problema do diamante:
            // uma ambiguidade causada pela existência do mesmo método em mais de uma superclasse.
            // Esse problema pode ser resolvido com a implementação de mais de uma interface pois as classes permitem isso
            // Ou seja, em vez de fazer uma herança múltipla, se faz uma classe com mais de uma interface

            Printer p = new Printer() { SerialNumber = 1080 };
            p.ProcessDoc("My letter");
            p.Print("My letter");

            Scanner s = new Scanner() { SerialNumber = 2003 };
            s.ProcessDoc("My Email");
            Console.WriteLine(s.Scan());

            ComboDevice c = new ComboDevice() { SerialNumber = 3921 };
            c.ProcessDoc("My dissertation");
            c.Print("My dissertation");
            Console.WriteLine(c.Scan());
        }
    }
}
