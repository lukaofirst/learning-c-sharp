using System;
using programa49.Model.Entities;
using programa49.Model.Enums;

namespace programa49 {
    class Program {
        static void Main(string[] args) {
            /* Semelhanças e Diferenças entre Herdar e Cumprir Contrato (interface) */
            //	Aspectos em comum entre herança e interfaces
            //       * Relação é - um
            //       * Generalização / especialização
            //       * Polimorfismo

            //  Diferença fundamental
            //      Herança envolve o resuso
            //      Interface envolve um contrato a ser cumprido

            IShape s1 = new Circle() { Radius = 2.0, Color = Color.White };
            IShape s2 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.Black };

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
